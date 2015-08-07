using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Payroll
{
    public partial class GrossList : Payroll.Payroll_Template
    {
        public GrossList(IdentityObject identObject)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
            

            //***Pooja Sharma***Changed the validation 

            
        }

        public GrossList(IdentityObject identObject, String IntRef)
        {
            InitializeComponent();
            base.SaveIdent(identObject);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();

            String Role = "Manager";
            
            if (base.ident.Role.Trim() != Role)
            {
                comboBox_L.Visible = false;
                textBox_ID.Text = IntRef;
                label1.Text = "Your username:" + base.ident.UserName;
            }
                        
        }

       
        private void ResetCommand()
        {

            //DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox_CMD.Text);
            //dataGridView1.DataSource = dtable;
            //dataGridView1.Visible = true;

            string part1 = "select *  from emp_gross_pay ";
            

            string part2 = "";
            
            
            string part3 = "";
            if (comboBox_L.Visible == true)
            {
                String Combo = comboBox_L.SelectedItem.ToString();
                String[] Split = Combo.Split();
                textBox_ID.Text = Split[0];
                if (textBox_ID.Text != "0")
                {
                    part3 = "where IntRef = " + textBox_ID.Text;
                }
            }
            else part3 = "where IntRef = " + textBox_ID.Text;
            
            textBox_CMD.Text = part1 + part2 + part3;
        }

        

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void GrossList_Load_1(object sender, EventArgs e)
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            ResetCommand();
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
                this.dataGridView1.ReadOnly = false;
            }
        }

        private void comboBox_L_SelectedIndexChanged(object sender, EventArgs e)
        {
            ResetCommand();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             int rowIndex = e.RowIndex;
            DataGridViewRow row = dataGridView1.Rows[rowIndex];
            String DocNum = row.Cells[0].Value.ToString();
            DisplayGross app = new DisplayGross(ident, "emp_gross_pay", "32", DocNum);
            app.Show();
        }

        

    }
}
