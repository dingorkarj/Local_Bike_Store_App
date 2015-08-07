using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Update_Inventory: Inventory_New_Template
    {

        public Update_Inventory()
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }

        private void Update_Inventory_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }


        public ShippingDoc ob = new ShippingDoc();
        
      
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

          

        }

        public  void acces(int ind)
        {

         string text1_val= ind.ToString();

         textBox1.Text = text1_val;


        }

        //quantity

        public void Quantity(int quantity)
        {
            String quan = quantity.ToString();

            textBox3.Text = quan;

        }
        public void totalItems( int ind)
        {
            string text1_val1= ind.ToString();

         textBox1.Text = text1_val1;
            int ind1=int.Parse(text1_val1);
            
              String qu = "select OnHand from Inventory_List where ProductID ="+ ind1 +"";
            //string query = "select ProductName from Inventory_List where ProductID ="188";

            int Prod = 0;

            DataTable dtable1 = Utilities.DataBaseUtility.GetTable(qu);
             int rows = 0;
             rows = dtable1.Rows.Count;
             Prod = Convert.ToInt32(dtable1.Rows[0] ["OnHand"]);
            
           String Pro=Prod.ToString();
            textBox2.Text = Pro;


        }



        private void button1_Click(object sender, EventArgs e)
        {

            int prod=int.Parse(textBox1.Text);
            int totalItems = int.Parse(textBox2.Text);

            int itemssold = int.Parse(textBox3.Text);

            int CurntOnhand=(totalItems-itemssold);

            String que = "update Inventory_List set OnHand=" + CurntOnhand + " where ProductID=" + prod + "";

            Utilities.DataBaseUtility.Execute(ident, que);

            MessageBox.Show("Inventory table Updated Succesfully");
        }
    }
}
