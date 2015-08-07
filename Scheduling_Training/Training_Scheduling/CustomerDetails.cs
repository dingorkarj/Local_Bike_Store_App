using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class CustomerDetails : Training_Scheduling.Training_Scheduling_template
    {
        DataTable dtable = new DataTable();
        string custid = string.Empty;
        string message = string.Empty;
        string sqlselect = string.Empty;
      //  int rowCount = 0;

        public CustomerDetails()
        {
            InitializeComponent();
        }
        public CustomerDetails(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            cmbcustid.Items.Clear();
            cmbcustid.SelectedIndex = -1;
            string sqlselect = "select Cust_id from Training_Customer order by cust_id asc";
            dtable = Utilities.DataBaseUtility.GetTable(sqlselect);

           for (int i = 0; i < dtable.Rows.Count; i++)
            {
                cmbcustid.Items.Add(dtable.Rows[i][0]);
            } 
            cmbcustid.Sorted = false;
        }

        private void cmbcustid_SelectedIndexChanged(object sender, EventArgs e)
        {
            custid = cmbcustid.GetItemText(cmbcustid.SelectedItem).ToString();
            dtable = Utilities.DataBaseUtility.GetTable("select * from Training_Customer where Cust_id=" + custid );
            txtcustfname.Text = dtable.Rows[0][1].ToString();
            txtcustlname.Text = dtable.Rows[0][2].ToString();
            txtcuststreet.Text = dtable.Rows[0][3].ToString();
            txtcustcity.Text = dtable.Rows[0][4].ToString();
            txtcuststate.Text = dtable.Rows[0][5].ToString();
            txtcustzipcode.Text = dtable.Rows[0][6].ToString();
            txtcustmobile.Text = dtable.Rows[0][7].ToString();
            txtcustemail.Text = dtable.Rows[0][8].ToString();
        }
         
        private void btnedit_Click(object sender, EventArgs e)
        {
            unlocktext();
        }
        public void locktext()
        {
            txtcustfname.ReadOnly = true;
            txtcustlname.ReadOnly = true;
            txtcuststreet.ReadOnly = true;
            txtcustcity.ReadOnly = true;
            txtcuststate.ReadOnly = true;
            txtcustzipcode.ReadOnly = true;
            txtcustmobile.ReadOnly = true;
            txtcustemail.ReadOnly = true;
        }
        public void unlocktext()
        {
            txtcustfname.ReadOnly = false;
            txtcustlname.ReadOnly = false;
            txtcuststreet.ReadOnly = false;
            txtcustcity.ReadOnly = false;
            txtcuststate.ReadOnly = false;
            txtcustzipcode.ReadOnly = false;
            txtcustmobile.ReadOnly = false;
            txtcustemail.ReadOnly = false;
        }
        public void cleartext()
        {
            txtcustid.Visible = false;
            cmbcustid.Visible = true;
            cmbcustid.Text = string.Empty;
            txtcustfname.Text = string.Empty;
            txtcustlname.Text = string.Empty;
            txtcuststreet.Text = string.Empty;
            txtcustcity.Text = string.Empty;
            txtcuststate.Text = string.Empty;
            txtcustzipcode.Text = string.Empty;
            txtcustmobile.Text = string.Empty;
            txtcustemail.Text = string.Empty;
            label4.Visible = false;
            label11.Visible = false;
            label13.Visible = false;
        }
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbcustid.Text != string.Empty)
            {
                string sqlstmt = "delete from Training_Customer where Cust_id=" + custid;
                string message = Utilities.DataBaseUtility.Execute(sqlstmt, ident);
                string sqlinsert = "insert into Training_Customer values ('" + custid + "','" + txtcustfname.Text + "','" + txtcustlname.Text + "','" + txtcuststreet.Text + "','" + txtcustcity.Text + "','" + txtcuststate.Text + "','" + txtcustzipcode.Text + "','" + txtcustmobile.Text + "','" + txtcustemail.Text + "')";
                message = Utilities.DataBaseUtility.Execute(sqlinsert, ident);
                if (sqlinsert != String.Empty)
                {
                    MessageBox.Show("Updated Successfully");
                    cleartext();
                    locktext();
                }
            }
            else
            {
                MessageBox.Show("Select Customer Id to update");
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            if (cmbcustid.Text != string.Empty)
            {
                string sqlstmt = "delete from Training_Customer where Cust_id=" + custid;
                message = Utilities.DataBaseUtility.Execute(sqlstmt, ident);
                if (sqlstmt != String.Empty)
                {
                    MessageBox.Show("Deleted Successfully");
                    cleartext();
                }
                loaddata();
            }
            else
            {
                MessageBox.Show("Select Customer Id to Delete");
            }

            
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            cleartext();
            lblcustidcmb.Visible = false;
            cmbcustid.Visible = false;
            lblcustidtxt.Visible = true;
            txtcustid.Visible = true;
            txtcustid.Text = String.Empty;
            label4.Visible = true;
            label11.Visible = true;
            label13.Visible = true;
            unlocktext();
            
        }
        

        private void btnsave_Click(object sender, EventArgs e)
        {
           
            string sqlinsert = "insert into Training_Customer values ('" + txtcustid.Text + "','" + txtcustfname.Text + "','" + txtcustlname.Text + "','" + txtcuststreet.Text + "','" + txtcustcity.Text + "','" + txtcuststate.Text + "','" + txtcustzipcode.Text + "','" + txtcustmobile.Text + "','" + txtcustemail.Text + "')";
            message = Utilities.DataBaseUtility.Execute(sqlinsert, ident);
            label12.Text = message;
            if (label12.Text == "no errors")
            {

                MessageBox.Show("Customer details have been saved Successfully");
                cleartext();
                lblcustidcmb.Visible = true;
                cmbcustid.Visible = true;
                cmbcustid.Text = string.Empty;
                lblcustidtxt.Visible = false;
                txtcustid.Visible = false;
                loaddata();
                locktext();
            }
            else
            {
                MessageBox.Show("Error: Could be one of the following reasons.\n1.Customer Id you entered already exist (or)\n2.You didn't enter values in all the fields (or)\n3.Make sure you have entered the State, Zipcode and Phone number as per the example.");
          
            }
            

            
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartext();
        }

       
    }
}
