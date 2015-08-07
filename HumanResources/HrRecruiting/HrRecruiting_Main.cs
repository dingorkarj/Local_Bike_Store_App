using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HrRecruiting
{
    public partial class HrRecruiting_Main : HrRecruiting_Template
    {
        public HrRecruiting_Main()
        {
            InitializeComponent();
        }

        public HrRecruiting_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtboxQuery.Text = "select * from Applicant_Status;";
            DataTable dTable = Utilities.DataBaseUtility.GetTable(txtboxQuery.Text);
            dataGridView2.DataSource = dTable;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtboxQuery.Text = "select * from Job_History;";
            DataTable dTable = Utilities.DataBaseUtility.GetTable(txtboxQuery.Text);
            dataGridView2.DataSource = dTable;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtboxQuery.Text = "select * from Job;";
            DataTable dTable = Utilities.DataBaseUtility.GetTable(txtboxQuery.Text);
            dataGridView2.DataSource = dTable;
        //    label3.Text = dTable.Rows[0].ItemArray[3].ToString();
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtboxQuery.Text = "select * from Applicant_Skill_Details;";
            DataTable dTable = Utilities.DataBaseUtility.GetTable(txtboxQuery.Text);
            dataGridView2.DataSource = dTable;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            //   HrRecruiting_Template.ModifyEmployee newapp = new HrRecruiting_Template.ModifyEmployee();
            //   newapp.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ModifyEmployee newapp = new ModifyEmployee(ident);
            newapp.Show();
       //     HrRecruiting_Template.ModifyEmployee newapp = new HrRecruiting_Template.ModifyEmployee(ident);
        //    newapp.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
