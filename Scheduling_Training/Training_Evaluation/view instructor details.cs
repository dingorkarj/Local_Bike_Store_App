using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class view_instructor_details : Training_Evaluation.Training_Evaluation_Template
    {
        public view_instructor_details()
        {
            InitializeComponent();
        }
        public view_instructor_details(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(comboBox1.Text);
            DataTable dtable = Utilities.DataBaseUtility.GetTable("Select Firstname,Lastname,Role,Dept_id,Address,Phone,email from Employees where Emplid = " + x);
            dataGridView1.DataSource = dtable;
            dataGridView1.Visible = true;
        }

        private void view_instructor_details_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            DataColumn dc1 = new DataColumn();
            comboBox1.Items.Clear();
            string command = "select EmplID from Employees";

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
