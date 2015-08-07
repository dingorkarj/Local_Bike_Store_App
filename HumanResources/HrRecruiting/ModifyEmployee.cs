using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HrRecruiting
{
    public partial class ModifyEmployee : HrRecruiting_Template
    {
        public ModifyEmployee()
        {
            InitializeComponent();
        }

        public ModifyEmployee(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void txtEmpID_TextChanged(object sender, EventArgs e)
        {

        }

        public void clear()
         {
             txtEmpID.Text = "";
             txtFirstName.Text = "";
             txtLastName.Text = "";
             txtRole.Text = "";
             txtDeptId.Text = "";
             txtAdminLevel.Text = "";
             txtAddressLine1.Text = "";
             txtAddressLine2.Text = "";
             txtCity.Text = "";
             txtState.Text = "";
             txtZipcode.Text = "";
             txtPhone.Text = "";
             txtEmail.Text = "";
         }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Enter Applicant ID");
            }
            else
            {

            int id = int.Parse(txtEmpID.Text);
            
            string query = "select * from EMPLOYEES where EmplID =" + id;
            DataTable dTable = Utilities.DataBaseUtility.GetTable(query);
            
            if (dTable.Rows.Count > 0)
            {
                clear();

                txtEmpID.Text = dTable.Rows[0].ItemArray[0].ToString();
                txtFirstName.Text = dTable.Rows[0].ItemArray[1].ToString();
                txtLastName.Text = dTable.Rows[0].ItemArray[2].ToString();
                txtRole.Text = dTable.Rows[0].ItemArray[3].ToString();
                txtDeptId.Text = dTable.Rows[0].ItemArray[4].ToString();
                txtAdminLevel.Text = dTable.Rows[0].ItemArray[5].ToString();
                txtAddressLine1.Text = dTable.Rows[0].ItemArray[6].ToString();
                txtAddressLine2.Text = dTable.Rows[0].ItemArray[7].ToString();
                txtCity.Text = dTable.Rows[0].ItemArray[8].ToString();
                txtState.Text = dTable.Rows[0].ItemArray[9].ToString();
                txtZipcode.Text = dTable.Rows[0].ItemArray[10].ToString();
                txtPhone.Text = dTable.Rows[0].ItemArray[11].ToString();
                txtEmail.Text = dTable.Rows[0].ItemArray[12].ToString();
                
            }
            else
            {

                MessageBox.Show("No Record Found");
                txtEmpID.Text = "";
                clear();
            }

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Enter Applicant ID");
            }
            if (txtDeptId.Text == "")
            {
                MessageBox.Show("Enter Applicant Details");
            }
            else
            {
                int empId = int.Parse(txtEmpID.Text);
                string FirstName = txtFirstName.Text;
                string LastName = txtLastName.Text;
                string Role = txtRole.Text;
                int deptId = int.Parse(txtDeptId.Text);
                int adminLevel = int.Parse(txtAdminLevel.Text);
                var address1 = txtAddressLine1.Text;
                var address2 = txtAddressLine2.Text;
                string city = txtCity.Text;
                string state = txtState.Text;
                int zipcode = int.Parse(txtZipcode.Text);
                double phone = double.Parse(txtPhone.Text);
                var email = txtEmail.Text;


                string tempQuery = +empId + "," + "'" + FirstName + "'" + "," + "'" + LastName + "'" + "," + "'" + Role + "'" + "," + deptId + "," + adminLevel + "," + "'" + address1 + "'"
                    + "," + "'" + address2 + "'" + "," + "'" + city + "'" + "," + "'" + state + "'" + "," + zipcode + "," + phone + "," + "'" + email + "'" + ")" + ";";
                string query = "insert into EMPLOYEES values (" + tempQuery;
                try
                {
                    DataTable dTable = Utilities.DataBaseUtility.GetTable(query);
                    MessageBox.Show("New Record Inserted Successfully");
                    clear();

                }
                catch
                {
                    MessageBox.Show("Record Insert Failed");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (txtEmpID.Text == "")
            {
                MessageBox.Show("Enter Applicant ID");
            }
            else
            {
                int empId = int.Parse(txtEmpID.Text);


                string FirstName = txtFirstName.Text;
                string LastName = txtLastName.Text;
                string Role = txtRole.Text;
                int deptId = 0;
                string temp = txtDeptId.Text;
                if (temp == "")
                {
                    MessageBox.Show("Enter all the fields");
                }
                else
                {

                    deptId = int.Parse(temp);
                    int adminLevel = int.Parse(txtAdminLevel.Text);
                    var address1 = txtAddressLine1.Text;
                    var address2 = txtAddressLine2.Text;
                    string city = txtCity.Text;
                    string state = txtState.Text;
                    int zipcode = int.Parse(txtZipcode.Text);
                    double phone = double.Parse(txtPhone.Text);
                    var email = txtEmail.Text;

                    string query = "update EMPLOYEES set EmplID = " + empId +
                        ",FirstName ='" + FirstName + " ' " +
                        ",LastName ='" + LastName + " ' " +
                        ",Role ='" + Role + " ' " +
                        ",Dept_ID =" + deptId +
                        ",AdmiLevel =" + adminLevel +
                        ",Address ='" + address1 + " ' " +
                        ",Address2 ='" + address2 + " ' " +
                        ",City ='" + city + " ' " +
                        ",State ='" + state + " ' " +
                        ",Zipcode =" + zipcode +
                        ", Phone =" + phone +
                        ",email ='" + email + " ' where EmplID =" + empId +
                        ";";

                    try
                    {
                        DataTable dTable = Utilities.DataBaseUtility.GetTable(query);
                        MessageBox.Show("Update Successful");
                        clear();

                    }
                    catch
                    {
                        MessageBox.Show("Update UnSuccessful");
                    }
                }
            }
        }
    }
}
