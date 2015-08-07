using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Utilities.Documents;

namespace Payroll
{
    public partial class TimeList : Payroll.Payroll_Template
    {

                
        public TimeList(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            InitializeComponent();
            base.SaveIdent(identObject);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
            //
           
            comboBox_L.Visible = true;
        }

        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            DisplaySelected disp = new DisplaySelected("emp_time_card","34",ident); 

            disp.Show();
        }

        public TimeList(IdentityObject identObject, String IntRef)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        
            comboBox_L.Visible = false;
            textBox_ID.Text = IntRef;
            textBox_ID.ReadOnly = true;
            label1.Text = "Your username:" + base.ident.UserName;

        }

        private void TimeList_Load(object sender, EventArgs e)
        {
            //DataTable dtable = Utilities.DataBaseUtility.GetTable("Select * from Employees");
            //dataGridView1.DataSource = dtable;
            comboBox_L.Items.Add("0 : All ");
            comboBox_L.SelectedIndex = 0;
            DataTable dtEmp = new DataTable();
            dtEmp = Utilities.DataBaseUtility.GetTable("Select * from Employees");

            
            //Items.Add("0 : All Employees");
            for (int i = 0; i < dtEmp.Rows.Count; i++)
                // show Empl_ID : Firstname Lastname from Employees table
                comboBox_L.Items.Add(dtEmp.Rows[i][0].ToString() + "  :  " + dtEmp.Rows[i][1].ToString() + "  " + dtEmp.Rows[i][2].ToString());
            //}
            comboBox_L.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            dataGridView1.DataSource = dtable;
            dataGridView1.Visible = true;
            if (comboBox_L.Visible == false)
            {
                //this.dataGridView1.Columns["Approval"].Visible = false;
                this.dataGridView1.ReadOnly = true;
                //this.dataGridView1.AllowUserToAddRows = false;
                //this.dataGridView1.AllowUserToDeleteRows = false;
            }
            else
            {
                //this.dataGridView1.Columns["Approval"].Visible = true;
                this.dataGridView1.ReadOnly = true;
            }
              
        }

        private void ResetCommand()
        {

            //DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            //dataGridView1.DataSource = dtable;
            //dataGridView1.Visible = true;

            string part1 = "select * from emp_time_card ";

            string part2 = "";
            if (radioButton1.Checked) part2 = "where Approval = YES ";
            if (radioButton2.Checked) part2 = "where Approval = NO ";

            ///Null refernce exception
            
            string part3 = "";
            if (comboBox_L.Visible == true)
            {
                String Combo = comboBox_L.SelectedItem.ToString();
                String[] Split = Combo.Split();
                textBox_ID.Text = Split[0];
                if (textBox_ID.Text != "0")
                {
                    part3 = "and IntRef = " + textBox_ID.Text;
                }
            }
            else part3 = "and IntRef = " + textBox_ID.Text;
            
            textBox_CMD.Text = part1 + part2 + part3;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ResetCommand();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ResetCommand();
        }

        private void comboBox_L_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCommand();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (comboBox_L.Visible == true)
            {
                //MessageBox.Show("Do you want to Approve this time card");
                DialogResult dr = MessageBox.Show("Are you sure to approve this time card?", "Verify Operation",
                               MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (dr == DialogResult.No)
                {
                    MessageBox.Show(" Operation Cancelled by user ");
                    return;
                }
                int rowIndex = e.RowIndex;
                DataGridViewRow row = dataGridView1.Rows[rowIndex];
                //textBox1.Text = row.Cells[0].Value.ToString();
                String CMD = "update emp_time_card set Approval = 1 where DocNum =" + row.Cells[0].Value.ToString();
                DataTable utable = Utilities.DataBaseUtility.GetTable(CMD);

                DataTable stable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
                dataGridView1.DataSource = stable;
                dataGridView1.Visible = true;
            }
            else
            {
                MessageBox.Show(" You are only allow to view ");
                return;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to set all approval to NO ?", "Verify Operation", 
                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                MessageBox.Show(" Operation Cancelled by user ");
                return;      
            }
            try
            {
                DataTable dtable = Utilities.DataBaseUtility.GetTable("update Emp_Timecard set Approval = 0 where 1");
                dataGridView1.DataSource = dtable;
                dataGridView1.Visible = true;
                //dtable. .Update(yourDataSet.tablename);
                //MessageBox.Show("Record Updated", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                //MessageBox.Show("Some Error in Update", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        // Adding code for final Gross Pay Calculation
      
       
        public void button3_Click(object sender, EventArgs e)
        {
            //Payroll.CalculateGrossPay newapp = new Payroll.CalculateGrossPay(base.ident); 
           
      

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            String DocNum = row.Cells[0].Value.ToString();
            String type;
            if (comboBox_L.Visible == true)
                type = "approve";
            else
                type = "view";

            Display disp = new Display(ident, "emp_time_card", "34", DocNum, type);
            disp.Show();
        }

        private void button_DisplaySelectedObject_Click_1(object sender, EventArgs e)
        {

        }

     

    }
}
