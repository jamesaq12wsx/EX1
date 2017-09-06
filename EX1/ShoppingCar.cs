using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EX1
{
    class ShoppingCar
    {
        List<Product> productsList = new List<Product>();

        string productGroup = "";

        double realTotal;

        public List<Product> ProductsList
        {
            get { return productsList; }
        }

        public double RealTotal { get { return realTotal; } set { realTotal = value; } }

        public string ProductGroup { get => productGroup; set => productGroup = value; }

        public ShoppingCar(List<CheckBox> listP, List<NumericUpDown> listA, string pg)
        {
            ProductGroup = pg;

            for (int i = 0; i < listP.Count; i++)
            {
                if (listP[i].Checked)
                {
                    Product p = new Product(Product.CatchProductName(listP[i].Text), Product.CatchProductPrice(listP[i].Text), (int)listA[i].Value);

                    productsList.Add(p);
                }
                else
                {
                    Product p = new Product(Product.CatchProductName(listP[i].Text), Product.CatchProductPrice(listP[i].Text), 0);

                    productsList.Add(p);
                }
            }

            realTotal = productsList.Sum(z => z.Quantity * z.Amount);
        }

        public string ReturnProductsName()
        {
            string productsName = "";

            if (productsList.Count > 0)
            {
                int j = 0;
                for (int i = 0; i < productsList.Count; i++)
                {
                    if (j == 0)
                        if (productsList[i].Quantity != 0)
                        {
                            productsName = productsName + productsList[i].ProductName + "*" + productsList[i].Quantity.ToString();

                            j++;
                        }
                        else
                        {
                            continue;
                        }
                    else
                    {
                        if (productsList[i].Quantity != 0)
                        {
                            productsName = productsName + '，' + productsList[i].ProductName + '*' + productsList[i].Quantity.ToString();
                        }
                        else
                        {
                            continue;
                        }
                    }
                }

                return productsName;
            }
            else
            {
                return "Nothing checkout";
            }
        }

        public double ReturnTotal()
        {
            return RealTotal;
        }

        public int ReturnTotalQuantity()
        {
            int tQ = this.productsList.Sum(w => w.Quantity);

            return tQ;
        }

        public int ReturnTotalType()
        {
            int tT = this.productsList.Where(w => w.Quantity > 0).Count();

            return tT;
        }
    }
}
