using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EX1
{
    class Product
    {
        private string productName;
        private int amount;
        private int quantity;

        public string ProductName
        {
            get { return productName; }
        }

        public int Amount { get { return amount; } }

        public int Quantity { get { return quantity; }  }

        public int TotalAmount { get { return Amount * Quantity;  } }

        public Product(string p, int a, int q)
        {
            productName = p;
            amount = a;
            quantity = q;
        }

        public static string CatchProductName(string t)
        {
            return t.Substring(0, t.IndexOf('，'));
        }

        public static int CatchProductPrice(string t)
        {
            return Int32.Parse(t.Split('$')[1]);
        }
    }

    class ShoppingCar
    {
        List<Product> productsList = new List<Product>();

        private string buyerName;

        public ShoppingCar(string bn)
        {
            buyerName = bn;
        }

        public ShoppingCar()
        {
            buyerName = "";
            MessageBox.Show("Please enter buyer name");
        }

        public ShoppingCar(List<CheckBox> listP, List<NumericUpDown> listA)
        {
            for(int i=0; i<listP.Count; i++)
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
        }

        public string BuyerName
        {
            get
            {
                return buyerName;
            }
            set
            {
                buyerName = value;
            }
        }

        public void AddProduct(Product p)
        {
            productsList.Add(p);
        }

        public string ReturnProductsName()
        {
            string productsName="";

            if (productsList.Count > 0)
            {
                int j = 0;
                for( int i =0; i < productsList.Count; i++)
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

        public int ReturnTotal()
        {
            int total=0;

            if(productsList.Count > 0)
            {
                foreach (var prod in productsList)
                {
                    if(prod.Amount != 0)
                    {
                        total += prod.TotalAmount;
                    }
                }

                return total;
            }
            else
            {
                return 0;
            }

            
        }
    }
}
