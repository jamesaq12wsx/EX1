namespace EX1
{
    //超過某金額的打折
    class OverDiscount : IDiscount<ShoppingCar>
    {
        int over;

        double discount;

        enum Types {Type=1, Total, Quantity};

        Types t;

        public OverDiscount(int t, int o, double d)
        {
            this.t = (Types)t;

            over = o;

            discount = d;
        }

        public void Discount(ShoppingCar sc)
        {
            switch (t)
            {
                case Types.Type:
                    if(sc.ReturnTotalType() >= over)
                    {
                        sc.RealTotal = sc.RealTotal * discount;
                    }
                    break;
                case Types.Total:
                    if (sc.ReturnTotal() >= over)
                    {
                        sc.RealTotal = sc.RealTotal * discount;
                    }
                    break;
                case Types.Quantity:
                    if(sc.ReturnTotalQuantity() >= over)
                    {
                        sc.RealTotal = sc.RealTotal * discount;
                    }
                    break;
            }
        }
    }
}
