using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public int Quantity { get { return quantity; } }

        public int TotalAmount { get { return Amount * Quantity; } }

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
}
