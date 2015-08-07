using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class View_Trainee_Report : Training_Evaluation.Training_Evaluation_Template
    {
        public View_Trainee_Report()
        {
            InitializeComponent();
        }

        public View_Trainee_Report(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(comboBox1.Text);

            String a = "select Course_id from TRAINING_RECORD where Trainee_id = " + x;
            List<String> a1 = Utilities.DataBaseUtility.GetList(a);
            textBox2.Text = a1[1];
            String b = "select Training_Status from TRAINING_RECORD where Trainee_id = " + x;
            List<String> b1 = Utilities.DataBaseUtility.GetList(b);
            textBox1.Text = b1[1];
            String c = "select Instructor_id from TRAINING_RECORD where Trainee_id = " + x;
            List<String> c1 = Utilities.DataBaseUtility.GetList(c);
            textBox3.Text = c1[1];
            String d = "select Course_StartDate from TRAINING_RECORD where Trainee_id = " + x;
            List<String> d1 = Utilities.DataBaseUtility.GetList(d);
            textBox4.Text = d1[1];
            String f = "select Course_StartDate from TRAINING_RECORD where Trainee_id = " + x;
            List<String> f1 = Utilities.DataBaseUtility.GetList(f);
            textBox5.Text = f1[1];

        }

        private void View_Trainee_Report_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn();
            comboBox1.Items.Clear();
            string command = "select Trainee_id from Training_Record";

            List<String> CourseNameList = new List<string>();
            CourseNameList = Utilities.DataBaseUtility.GetList(command);
            for (int i = 1; i < CourseNameList.Count; i++)
            {
                //  string[] temp = CourseNameList
                comboBox1.Items.Add(CourseNameList[i]);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(comboBox1.Text);
            int a = Convert.ToInt32(textBox2.Text);
            int b = Convert.ToInt32(textBox1.Text);
            int c = Convert.ToInt32(textBox3.Text);
            String d = textBox4.Text;
            String ef= textBox5.Text;
            String z = "update Training_record set Course_id =\"" + a + "\" , Training_Status =\"" + b + "\", Instructor_id =\"" + c + "\", Course_StartDate =\"" + d + "\", Course_EndDate =\"" + ef + "\"where Trainee_id= " + x;
            //  String z = "update Training_Customer set Cust_fname = \"a\" where Cust_id = 1"; 
            String dtable = Utilities.DataBaseUtility.Execute(z, ident);
            //  textBox2.Text = dtable[1];
            if (dtable == "no errors")
                MessageBox.Show("Successful changes ");
        }
    }
}
