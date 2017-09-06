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
            List<CheckBox> checkBoxList = new List<CheckBox>();

            List<NumericUpDown> amtList = new List<NumericUpDown>();

            List<ShoppingCar> sPCars = new List<ShoppingCar>();

            GroupBoxList(productsGroupBoxA, ref checkBoxList, ref amtList);

            ShoppingCar shoppingCarA = new ShoppingCar(checkBoxList, amtList, productsGroupBoxA.Text);

            sPCars.Add(shoppingCarA);

            GroupBoxList(productsGroupBoxB, ref checkBoxList, ref amtList);

            ShoppingCar shoppingCarB = new ShoppingCar(checkBoxList, amtList, productsGroupBoxB.Text);

            sPCars.Add(shoppingCarB);

            GroupBoxList(productsGroupBoxC, ref checkBoxList, ref amtList);

            ShoppingCar shoppingCarC = new ShoppingCar(checkBoxList, amtList, productsGroupBoxC.Text);

            sPCars.Add(shoppingCarC);

            //幫每個項目看要不要打折
            foreach(var sc in sPCars)
            {
                if(sc.ProductGroup == "甲區商品")
                {

                    OverDiscount dis = new OverDiscount(2, 1000, 0.9);

                    dis.Discount(sc);
                }
                else if(sc.ProductGroup == "乙區商品")
                {

                    OverDiscount dis = new OverDiscount(3, 5, 0.85);

                    dis.Discount(sc);
                }
                else
                {

                    GiveDiscount gDis = new GiveDiscount(3);

                    gDis.Discount(sc);

                    OverDiscount dis = new OverDiscount(1, 2, 0.95);

                    dis.Discount(sc);
                }
            }

            if (nameTextBox.Text == "" || (shoppingCarA.ReturnTotal() == 0 && shoppingCarB.ReturnTotal() == 0 && shoppingCarC.ReturnTotal() == 0))
            {
                if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter buyer name");
                }else if(shoppingCarA.ReturnTotal() == 0 && shoppingCarB.ReturnTotal() == 0 && shoppingCarC.ReturnTotal() == 0)
                {
                    MessageBox.Show("Please check any item");
                }
            }
            else
            {
                string showText = "";

                showText += nameTextBox.Text + "  ";

                showText += DateTime.Now.RocDate();

                foreach(var sc in sPCars)
                {
                    if(sc.ReturnTotalQuantity() != 0)
                    {
                        AddShowText(ref showText, sc);
                    }
                }

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

        //回傳民國年
        public string GetRocDate()
        {
            DateTime dt = DateTime.Now;

            string dty = (Int32.Parse(dt.Year.ToString()) - Int32.Parse("1911")).ToString();

            string rocDate = string.Format("民國{0}年{1}月{2}號\t 時間:{3}", dty, dt.Month, dt.Day, dt.ToString("HH:mm"));

            return rocDate;
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
