using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class ScheduleClasses : Training_Scheduling.Training_Scheduling_template
    {
        DataTable dtable = new DataTable();
        string sessid = string.Empty;
        string message = string.Empty;
        public ScheduleClasses()
        {
            InitializeComponent();
        }
        public ScheduleClasses(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
        }
        
        public void loaddata()
        {
            cmbsessid.Items.Clear();
            cmbsessid.SelectedIndex = -1;
            string sqlselect = "select * from Training_Schedule";
            dtable = Utilities.DataBaseUtility.GetTable(sqlselect);
            for (int i=0; i<dtable.Rows.Count; i++)
            {
                cmbsessid.Items.Add(dtable.Rows[i][0]);
            }
            cmbsessid.Sorted = false;
        }
        public void locktext()
        {
            txtcourseid.ReadOnly = true;
            txtempid.ReadOnly = true;
            txtstartdate.ReadOnly = true;
            txtenddate.ReadOnly = true;

        }
        public void unlocktext()
        {
            txtcourseid.ReadOnly = false;
            txtempid.ReadOnly = false;
            txtstartdate.ReadOnly = false;
            txtenddate.ReadOnly = false;

        }
        public void cleartext()
        {
            txtsessionid.Visible = false;
            cmbsessid.Visible = true;
            cmbsessid.Text = string.Empty;
            txtcourseid.Text = string.Empty;
            txtempid.Text = string.Empty;
            txtstartdate.Text = string.Empty;
            txtenddate.Text = string.Empty;
        }

        private void cmbsessid_SelectedIndexChanged(object sender, EventArgs e)
        {
            sessid = cmbsessid.GetItemText(cmbsessid.SelectedItem).ToString();
            dtable = Utilities.DataBaseUtility.GetTable("select * from Training_Schedule where Session_Id=" + sessid);
            txtcourseid.Text = dtable.Rows[0][2].ToString();
            txtempid.Text = dtable.Rows[0][5].ToString();
            txtstartdate.Text = dtable.Rows[0][6].ToString();
            txtenddate.Text = dtable.Rows[0][7].ToString();           
        }

        private void ScheduleClasses_Load(object sender, EventArgs e)
        {
            loaddata();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            string sqlinsert = "insert into Training_Schedule (Session_id, Course_id, Session_Status, Emp_id, Course_StartDate, Course_EndDate) values ('" + txtsessionid.Text + "','" + txtcourseid.Text + "','" + "1" + "','" + txtempid.Text + "','" + txtstartdate.Text + "','" + txtenddate.Text + "')";
            message = Utilities.DataBaseUtility.Execute(sqlinsert, ident);
            label4.Text = message;
            if (label4.Text == "no errors")
            {
                MessageBox.Show("Schedule has been created Successfully"); 
                cleartext();
                label1.Visible = true;
                cmbsessid.Visible = true;
                cmbsessid.Text = string.Empty;
                label2.Visible = false;
                txtsessionid.Visible = false;
                loaddata();
                locktext();
            }
            else
            {
                MessageBox.Show("Error: Could be one of the following reasons.\n1.Session Id you entered already exist (or)\n2.You didn't enter values in all the fields");
            }
            
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            unlocktext();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            label1.Visible = false;
            cmbsessid.Visible = false;
            label2.Visible = true;
            txtsessionid.Visible = true;
            txtsessionid.Text = string.Empty;
            txtcourseid.Text = string.Empty;
            txtempid.Text = string.Empty;
            txtstartdate.Text = string.Empty;
            txtenddate.Text = string.Empty;
            unlocktext();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            cleartext();
            locktext();
        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            if (cmbsessid.Text != string.Empty)
            {
                string sqlstmt = "delete from Training_Schedule where Session_id=" + sessid;
                string message = Utilities.DataBaseUtility.Execute(sqlstmt, ident);
                string sqlinsert = "insert into Training_Schedule (Session_id, Course_id, Session_Status, Emp_id, Course_StartDate, Course_EndDate) values ('" + txtsessionid.Text + "','" + txtcourseid.Text + "','" + "1" + "','" + txtempid.Text + "','" + txtstartdate.Text + "','" + txtenddate.Text + "')";
                message = Utilities.DataBaseUtility.Execute(sqlinsert, ident);
                if (sqlinsert != String.Empty)
                {
                    MessageBox.Show("Schedule has been updated Successfully");
                    cleartext();
                }
                locktext();
            }
            else
            {
                MessageBox.Show("Select the Session id to update");
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if (cmbsessid.Text != string.Empty)
            {
                string sqlcancel = "UPDATE Training_Schedule SET Training_Status= '0' where Session_Id=" + int.Parse(cmbsessid.SelectedItem.ToString());
                string message = Utilities.DataBaseUtility.Execute(sqlcancel, ident);
                if (sqlcancel != String.Empty)
                {
                    MessageBox.Show("Cancelled Successfully");
                    cleartext();

                }
                locktext();
            }
            else
            {
                MessageBox.Show("Select Session id to cancel");
            }

         }
    }
}
