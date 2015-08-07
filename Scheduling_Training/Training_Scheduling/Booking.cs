using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class Booking : Training_Scheduling.Training_Scheduling_template
    {
        DataTable dtable = new DataTable();
        DataTable dtable1 = new DataTable();
        DataTable dtable2 = new DataTable();
        DataTable dtable3 = new DataTable();
        string bookid = string.Empty;
        string sessid = string.Empty;
        string custid = string.Empty;
        string bookingid = string.Empty;
        string message = string.Empty;
        public Booking()
        {
            InitializeComponent();
        }

        public Booking(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
        }
        private void Booking_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        public void loaddata()
        {
            lblbookingid.Visible = false;
            cmbbookingid.Visible = false;
            cmbcustid.Items.Clear();
            cmbcustid.SelectedIndex = -1;
            string sqlselect = "select Cust_id from Training_Customer order by Cust_id asc";
            dtable2 = Utilities.DataBaseUtility.GetTable(sqlselect);

            for (int i = 0; i < dtable2.Rows.Count; i++)
            {
                cmbcustid.Items.Add(dtable2.Rows[i][0]);
            }
            cmbcustid.Sorted = false;

            cmbsessionid.Items.Clear();
            cmbsessionid.SelectedIndex = -1;
            string sqlselect1 = "select * from Training_Schedule where Session_Status = 1 order by Session_Id asc";
            dtable = Utilities.DataBaseUtility.GetTable(sqlselect1);
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                cmbsessionid.Items.Add(dtable.Rows[i][0]);
            }
            cmbsessionid.Sorted = false;         
                        
        }
       

        private void cmbsessionid_SelectedIndexChanged(object sender, EventArgs e)
        {
            sessid = cmbsessionid.GetItemText(cmbsessionid.SelectedItem).ToString();
            dtable = Utilities.DataBaseUtility.GetTable("select * from Training_Schedule where Session_Id=" + sessid);
            txtcourseid.Text = dtable.Rows[0][2].ToString();
            //txtempid.Text = dtable.Rows[0][5].ToString();
            txtstartdate.Text = dtable.Rows[0][6].ToString();
            txtenddate.Text = dtable.Rows[0][7].ToString();
            dtable1 = Utilities.DataBaseUtility.GetTable("select * from Training_Course where Course_id=" + txtcourseid.Text);
            txtcoursename.Text = dtable1.Rows[0][6].ToString();
            txtday.Text = dtable1.Rows[0][7].ToString();
            txtfees.Text = dtable1.Rows[0][8].ToString();
        }

        private void cmbcustid_SelectedIndexChanged(object sender, EventArgs e)
        {
            custid = cmbcustid.GetItemText(cmbcustid.SelectedItem).ToString();
            dtable2 = Utilities.DataBaseUtility.GetTable("select * from Training_Customer where Cust_id=" + custid);
            txtfirstname.Text = dtable2.Rows[0][1].ToString();
            txtlastname.Text = dtable2.Rows[0][2].ToString();
            txtphone.Text = dtable2.Rows[0][7].ToString();
            txtemail.Text = dtable2.Rows[0][8].ToString();
        }

        private void btnbook_Click(object sender, EventArgs e)
        {
            if (cmbcustid.Text != String.Empty && cmbsessionid.Text != String.Empty)
            {
                string sqlinsert = "insert into Training_Booking (Session_Id, Booking_Status, Cust_Id, Course_StartDate, Course_EndDate, Course_Id, Course_Fees) values ('" + cmbsessionid.Text + "','" + "1" + "','" + cmbcustid.Text + "','" + txtstartdate.Text + "','" + txtenddate.Text + "','" + txtcourseid.Text + "','" + txtfees.Text + "')";
                message = Utilities.DataBaseUtility.Execute(sqlinsert, ident);
                if (sqlinsert != String.Empty)
                {
                    MessageBox.Show("Booked Successfully");
                    cleartext();

                }
            }
            else
            {
                 MessageBox.Show("Select Customer Id and Session Id to make booking");
            }
            
            
        }
        public void cleartext()
        {
            txtsessionid.Text = string.Empty;
            txtcustid.Text = string.Empty;
            cmbcustid.Text = string.Empty;
            txtfirstname.Text = string.Empty;
            txtlastname.Text = string.Empty;
            txtcourseid.Text = string.Empty;
            txtcoursename.Text = string.Empty;
            txtday.Text = string.Empty;
            txtemail.Text = string.Empty;
            txtenddate.Text = string.Empty;
            txtfees.Text = string.Empty;
            txtphone.Text = string.Empty;
            txtstartdate.Text = string.Empty;
            cmbcustid.Text = string.Empty;
            cmbsessionid.Text = string.Empty;
            cmbbookingid.Text = string.Empty;
            lblbookingid.Visible = false;
            cmbbookingid.Visible = false;
            txtcustid.Visible = false;
            txtsessionid.Visible = false;
            cmbcustid.Visible = true;
            cmbsessionid.Visible = true;
            lblstatus.Visible = false;
        }
       

        private void cmbbookingid_SelectedIndexChanged(object sender, EventArgs e)
        {
            bookid = cmbbookingid.GetItemText(cmbbookingid.SelectedItem).ToString();
            dtable = Utilities.DataBaseUtility.GetTable("select * from Training_Booking where Booking_Id=" + bookid);
            txtsessionid.Text = dtable.Rows[0][2].ToString();
            txtcustid.Text = dtable.Rows[0][5].ToString();
            txtcourseid.Text = dtable.Rows[0][8].ToString();
            txtstartdate.Text = dtable.Rows[0][6].ToString();
            txtenddate.Text = dtable.Rows[0][7].ToString();
            txtfees.Text = dtable.Rows[0][9].ToString();
            lblstatus1.Text = dtable.Rows[0][4].ToString();
            int value = Convert.ToInt32(lblstatus1.Text);
            lblstatus.Visible = true;

            if (value > 0)
            {
                lblstatus.Text = "Booked";

            }
            else
            {
                lblstatus.Text = "Cancelled";
            }
            dtable2 = Utilities.DataBaseUtility.GetTable("select * from Training_Customer where Cust_id=" + txtcustid.Text );
            txtfirstname.Text = dtable2.Rows[0][1].ToString();
            txtlastname.Text = dtable2.Rows[0][2].ToString();
            txtphone.Text = dtable2.Rows[0][7].ToString();
            txtemail.Text = dtable2.Rows[0][8].ToString();
            dtable1 = Utilities.DataBaseUtility.GetTable("select * from Training_Course where Course_id=" + txtcourseid.Text);
            txtcoursename.Text = dtable1.Rows[0][6].ToString();
            txtday.Text = dtable1.Rows[0][7].ToString();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartext();
        }

        private void btnview_Click(object sender, EventArgs e)
        {
            
            lblbookingid.Visible = true;
            cmbbookingid.Visible = true;
            cmbbookingid.Items.Clear();
            cmbbookingid.SelectedIndex = -1;
            string sqlselect2 = "select * from Training_Booking";
            dtable = Utilities.DataBaseUtility.GetTable(sqlselect2);
            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                cmbbookingid.Items.Add(dtable.Rows[i][0]);
            }
            cmbbookingid.Sorted = false;
            cmbcustid.Visible = false;
            cmbsessionid.Visible = false;
            txtsessionid.Visible = true;
            txtcustid.Visible = true;                 
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (cmbbookingid.Text != String.Empty)
            {
                string sqlcancel = "UPDATE Training_Booking SET Booking_Status= '0' where Booking_Id=" + int.Parse(cmbbookingid.SelectedItem.ToString());
                message = Utilities.DataBaseUtility.Execute(sqlcancel, ident);
                if (sqlcancel != String.Empty)
                {
                    MessageBox.Show("Cancelled Successfully");
                    cleartext();

                }
            }
            else
            {
                MessageBox.Show("Select Booking Id to cancel the booking");
            }
        }


        
    }
}
