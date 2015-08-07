using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class view_customer_details : Training_Evaluation.Training_Evaluation_Template
    {
        public view_customer_details()
        {
            InitializeComponent();
        }

        public view_customer_details(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
           base.DisplayIdent(ident);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public Boolean isNumber(String num)
        {
            try
            {
                Convert.ToInt32(num);
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isNumber(textBox1.Text))
            {
                int x = Convert.ToInt32(textBox1.Text);
                DataTable dtable = Utilities.DataBaseUtility.GetTable("Select * from Training_Customer where Cust_id = " + x);
                dataGridView1.DataSource = dtable;
                dataGridView1.Visible = true;
                label3.Text = "";
            }
            else
            {
                label3.Text = "Please enter only numbers in the Customer Id field";
                return;
            }
            
        }
    }
}
