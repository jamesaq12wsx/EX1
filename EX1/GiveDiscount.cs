using System.Collections.Generic;
using System.Linq;

namespace EX1
{
    class GiveDiscount : IDiscount<ShoppingCar>
    {
        int buyCount;

        int giveCount;

        public GiveDiscount()
        {
            buyCount = 0;

            giveCount = 0;
        }

        //預設為買b個送1個
        public GiveDiscount(int b)
        {
            buyCount = b;

            giveCount = 1;
        }

        //買b個送g個
        public GiveDiscount(int b, int g)
        {
            buyCount = b;

            giveCount = g;
        }

        public void Discount(ShoppingCar sc)
        {
            int freeQnt = sc.ReturnTotalQuantity() / buyCount;

            var tempList = new List<int>();

            foreach (var t in sc.ProductsList)
            {
                for (int i = 0; i < t.Quantity; i++)
                {
                    tempList.Add(t.Amount);
                }
            }

            int sum = tempList.OrderByDescending(x => x).Take(tempList.Count - freeQnt).Sum();

            sc.RealTotal = sum;
        }
    }
}
