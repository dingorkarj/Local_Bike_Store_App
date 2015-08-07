using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class update_trainee_record : Training_Evaluation.Training_Evaluation_Template
    {
        public update_trainee_record()
        {
            InitializeComponent();
        }
        public update_trainee_record(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(comboBox1.Text);

            String y = "select FirstName from Customers where CustomerID = " + x;
            List<String> dtable = Utilities.DataBaseUtility.GetList(y);
            textBox2.Text = dtable[1];
            String z = "select LastName from Customers where CustomerID = " + x;
            List<String> le = Utilities.DataBaseUtility.GetList(z);
            textBox3.Text = le[1];
            String b = "select Address from Customers where CustomerID = " + x;
            List<String> l = Utilities.DataBaseUtility.GetList(b);
            textBox4.Text = l[1];
            String c = "select City from Customers where CustomerID = " + x;
            List<String> m = Utilities.DataBaseUtility.GetList(c);
            textBox5.Text = m[1];
            String d = "select State from Customers where CustomerID = " + x;
            List<String> n = Utilities.DataBaseUtility.GetList(d);
            textBox6.Text = n[1];
            String f = "select Zipcode from Customers where CustomerID= " + x;
            List<String> o = Utilities.DataBaseUtility.GetList(f);
            textBox7.Text = o[1];
            String g = "select Phone from Customers where CustomerID = " + x;
            List<String> p = Utilities.DataBaseUtility.GetList(g);
            textBox8.Text = p[1];
            String h = "select eMail from Customers where CustomerID = " + x;
            List<String> q = Utilities.DataBaseUtility.GetList(h);
            textBox9.Text = q[1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(comboBox1.Text);
            String y = textBox2.Text;
            String a = textBox3.Text;
            String b = textBox4.Text;
            String c = textBox5.Text;
            String d = textBox6.Text;
                String f = textBox7.Text;
                String g = textBox8.Text;
                String h = textBox8.Text;
                String z = "update Customers set FirstName =\"" + y + "\" , LastName =\"" + a + "\", Address =\"" + b + "\", City =\"" + c + "\", State =\"" + d + "\",Zipcode =\"" + f + "\",Phone =\"" + g + "\",eMail =\"" + h + "\"where CustomerID= " + x;
          //  String z = "update Customers set Cust_fname = \"a\" where Cust_id = 1"; 
            String dtable = Utilities.DataBaseUtility.Execute(z,ident);
          //  textBox2.Text = dtable[1];
            if (dtable == "no errors")
                MessageBox.Show("Successful changes ");

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox_RightLogo_Click(object sender, EventArgs e)
        {

        }

        private void update_trainee_record_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn();
            comboBox1.Items.Clear();
            string command = "select CustomerID from Customers";

            List<String> CourseNameList = new List<string>();
            CourseNameList = Utilities.DataBaseUtility.GetList(command);
            for (int i = 1; i < CourseNameList.Count; i++)
            {
                //  string[] temp = CourseNameList
                comboBox1.Items.Add(CourseNameList[i]);
            }
        }
    }
}
