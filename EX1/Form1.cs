using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace EX1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int allTotal = 0;

            List<CheckBox> checkBoxList = new List<CheckBox>();

            List<NumericUpDown> amtList = new List<NumericUpDown>();

            List<ShoppingCar> sPCars = new List<ShoppingCar>();

            GroupBoxList(productsGroupBoxA, ref checkBoxList, ref amtList);

            ShoppingCar sc = new ShoppingCar(checkBoxList, amtList, productsGroupBoxA.Text);

            sPCars.Add(sc);

            GroupBoxList(productsGroupBoxB, ref checkBoxList, ref amtList);

            sc = new ShoppingCar(checkBoxList, amtList, productsGroupBoxB.Text);

            sPCars.Add(sc);

            GroupBoxList(productsGroupBoxC, ref checkBoxList, ref amtList);

            sc = new ShoppingCar(checkBoxList, amtList, productsGroupBoxC.Text);

            sPCars.Add(sc);

            OverDiscount dis;

            GiveDiscount gDis;

            //幫每個項目看要不要打折
            foreach(var shop in sPCars)
            {
                allTotal += (int)shop.ReturnTotal();

                switch (sc.ProductGroup)
                {
                    case "甲商品區":
                        dis = new OverDiscount(2, 1000, 0.9);

                        dis.Discount(shop);

                        break;
                    case "乙區商品":

                        dis = new OverDiscount(3, 5, 0.85);

                        dis.Discount(shop);

                        break;
                    case "丙區商品":

                        gDis = new GiveDiscount(3);

                        gDis.Discount(shop);

                        dis = new OverDiscount(1, 2, 0.95);

                        dis.Discount(shop);

                        break;
                }

                
            }

            if (nameTextBox.Text == "" || allTotal == 0)
            {
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter buyer name");
                }else if(allTotal == 0)
                {
                    MessageBox.Show("Please check any item");
                }
            }
            else
            {
                string showText = "";

                showText += nameTextBox.Text + "  ";

                showText += DateTime.Now.RocDate();

                foreach(var shop in sPCars)
                {
                    if(sc.ReturnTotalQuantity() != 0)
                    {
                        AddShowText(ref showText, sc);
                    }
                }

                showText += string.Format("\n總金額:{0:c0}",allTotal);

                MessageBox.Show(showText);
            }

        }

        //將字串加到輸出字串
        private void AddShowText(ref string s, ShoppingCar spCar)
        {
            s = s + string.Format("\n====={0}=====\n購買商品: {1}\n總金額: {2:C0}", spCar.ProductGroup, spCar.ReturnProductsName(), spCar.ReturnTotal());
        }

        //產生shoppingCar
        public static void GroupBoxList(GroupBox gb, ref List<CheckBox> cbl, ref List<NumericUpDown> aml)
        {
            cbl.Clear();

            aml.Clear();

            foreach (var obj in gb.Controls)
            {
                if (obj.GetType() == typeof(CheckBox))
                {
                    cbl.Add((CheckBox)obj);
                }
                else if(obj.GetType() == typeof(NumericUpDown))
                {
                    aml.Add((NumericUpDown)obj);
                }
            }
        }
    }
}
