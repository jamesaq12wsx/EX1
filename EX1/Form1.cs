﻿using System;
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

            foreach(var obj in productsGroupBox.Controls)
            {
                if(obj.GetType() == typeof(CheckBox))
                {
                    checkBoxList.Add((CheckBox)obj);
                }
                else
                {
                    amtList.Add((NumericUpDown)obj);
                }
            }
            /*
            checkBoxList.Add(productACheckBox);

            amtList.Add(productAUpDown);

            checkBoxList.Add(productBCheckBox);

            amtList.Add(productBUpDown);

            checkBoxList.Add(productCCheckBox);

            amtList.Add(productCUpDown);

            checkBoxList.Add(productDCheckBox);

            amtList.Add(productDUpDown);

            checkBoxList.Add(productECheckBox);

            amtList.Add(productEUpDown);
            */

            ShoppingCar shoppingCar = new ShoppingCar(checkBoxList, amtList);

            if (nameTextBox.Text == "" || shoppingCar.ReturnTotal() == 0)
            {
                if (nameTextBox.Text == "" && shoppingCar.ReturnTotal() == 0)
                {
                    MessageBox.Show("Please enter buyer name and check any products");
                }
                else if (nameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter buyer name");
                }
                else
                {
                    MessageBox.Show("Please check any products");
                }
            }
            else
            {
                MessageBox.Show(nameTextBox.Text + Environment.NewLine + shoppingCar.ReturnProductsName() + Environment.NewLine + shoppingCar.ReturnTotal().ToString());
            }

            



            //==================================================================================
            /*
            int total=0;
            List<string> productsList = new List<string>();
            string showBuyerNameStr;
            string showTotalStr;

            if(nameTextBox.Text == "" || !CheckProductsCheckListBox())
            {
                if(nameTextBox.Text == "" && !CheckProductsCheckListBox())
                {
                    MessageBox.Show("Please enter buyer name and check any products");
                }
                else if(nameTextBox.Text == "")
                {
                    MessageBox.Show("Please enter buyer name");
                }
                else
                {
                    MessageBox.Show("Please check any products");
                }
            }
            else
            {
                showBuyerNameStr = "購買人 : " + nameTextBox.Text;

                showTotalStr = "總金額 : $" + Total().ToString();
                Console.Write(total);
                MessageBox.Show(showBuyerNameStr + Environment.NewLine + ProductsListStr() + Environment.NewLine + showTotalStr);
            }
            */
        }
        /*
        public bool CheckProductsCheckListBox()
        {
            bool check = false;

            for(int i = 0; i< productsCheckListBox.Items.Count; i++)
            {
                if (productsCheckListBox.GetItemChecked(i))
                {
                    check = true;
                    return check;
                }
            }
            return check;
        }

        public int Total( )
        {
            int total=0;
            string checkHolder;
            
            for (int i = 0; i < productsCheckListBox.Items.Count; i++)
            {
                if (productsCheckListBox.GetItemChecked(i))
                {
                    checkHolder = productsCheckListBox.GetItemText(productsCheckListBox.Items[i]);
                    int productPrice = Int32.Parse(checkHolder.Split('$')[1]);
                    total += productPrice;
                }
            }
            return total;
        }

        public string ProductsListStr()
        {
            string checkHolder="";
            string showProductsListStr = "";
            List<string> productsList = new List<string>();
            for (int i = 0; i < productsCheckListBox.Items.Count; i++)
            {
                if (productsCheckListBox.GetItemChecked(i))
                {
                    checkHolder = productsCheckListBox.GetItemText(productsCheckListBox.Items[i]);
                    string productName = checkHolder.Substring(0, checkHolder.IndexOf('，'));
                    productsList.Add(productName);
                }
            }

            int productsListCnt = 0;
            foreach (var pro in productsList)
            {
                if (productsListCnt == 0)
                {
                    showProductsListStr += pro;
                    productsListCnt++;
                }
                else
                {
                    showProductsListStr = showProductsListStr + '，' + pro;
                    productsListCnt++;
                }
            }

            return showProductsListStr;
        }
        */
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
    }
}
