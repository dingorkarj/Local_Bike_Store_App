using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class view_course_details : Training_Evaluation.Training_Evaluation_Template
    {
        public view_course_details()
        {
            InitializeComponent();
        }

        public view_course_details(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            String[] tu = s.Split(',');
            

    // MessageBox.Show(s);
            string s1 = "";
            s1 = "Select Course_Name,Course_Day,Course_fees,Course_desc from Training_Course where Course_Name LIKE '" + tu[1] + "' ";
            DataTable dtable = Utilities.DataBaseUtility.GetTable(s1);
            dataGridView1.DataSource = dtable;
            dataGridView1.Visible = true;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void view_course_details_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn();
            comboBox1.Items.Clear();
            string command = "select Course_id,Course_Name from Training_Course";
            
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
