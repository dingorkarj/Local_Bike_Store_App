using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Inventory_product2 :Inventory_New_Template
    {
        public Inventory_product2()
        {
            InitializeComponent();
        }

        public Inventory_product2(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {


            int CurntItems = Convert.ToInt32(textBox3.Text);

            int prod = Convert.ToInt32(textBox4.Text);

            String FinalQuery = "update Inventory set OnHand=" + CurntItems + " where DocNum=" + prod + "";
            Utilities.DataBaseUtility.Execute(ident, FinalQuery);

            MessageBox.Show("Inventory Updated");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            

    

        }



        public void totalQuantities(IdentityObject ident, int total)
        {




            String text_val = "";
            text_val = total.ToString();
            textBox1.Text = text_val;
        
           
           // int total1 = Convert.ToInt32(textBox1.Text);


        }
        public void TotalSold(IdentityObject ident, int totalS)
        {

            String sold = totalS.ToString();
            textBox2.Text = sold;


        }

        public void CurrentTotal(IdentityObject ident, int CurntTot)
        {

            String Curnt = CurntTot.ToString();

            textBox3.Text = Curnt;
           

            
}
        public void ProductID(IdentityObject ident, int prodid)
        {


            textBox4.Text = prodid.ToString();
        }



    }
}
