using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class View_Trainee_Details : Training_Evaluation.Training_Evaluation_Template
    {
        public View_Trainee_Details()
        {
            InitializeComponent();
        }

        public View_Trainee_Details(IdentityObject ident)
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
            }catch(Exception e){
                return false;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) )
            {
                if (isNumber(textBox1.Text))
                {
                    int x = Convert.ToInt32(textBox1.Text);
                    DataTable dtable = Utilities.DataBaseUtility.GetTable("Select * from Training_Customer where Cust_id = " + x);
                    dataGridView1.DataSource = dtable;
                    dataGridView1.Visible = true;
                    label3.Text = "";
                }else{
                    label3.Text = "Please enter only numbers in the Trainee Id field";
                    return;
                }
                
            }

            else if (checkBox1.Checked == true)
            {
                DataTable dtable = Utilities.DataBaseUtility.GetTable("Select c.Cust_id,c.Cust_fname,c.Cust_lname,c.Address,c.City,c.State,c.Zipcode,c.Phone,c.Email from Training_Customer c,Training_record r where c.Cust_id=r.Trainee_id and r.Training_Status = 100");
                dataGridView1.DataSource = dtable;
                dataGridView1.Visible = true;
            }
            else if (checkBox2.Checked == true)
            {
                DataTable dtable = Utilities.DataBaseUtility.GetTable("Select c.Cust_id,c.Cust_fname,c.Cust_lname,c.Address,c.City,c.State,c.Zipcode,c.Phone,c.Email from Training_Customer c,Training_record r where c.Cust_id=r.Trainee_id and Training_Status < 100");
                dataGridView1.DataSource = dtable;
                dataGridView1.Visible = true;
            }
           
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void View_Trainee_Details_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
