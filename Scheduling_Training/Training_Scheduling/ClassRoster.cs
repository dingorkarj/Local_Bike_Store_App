using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class ClassRoster : Training_Scheduling.Training_Scheduling_template
    {
        DataTable dtable = new DataTable();
        DataTable dtable1 = new DataTable();
        DataTable dtable2 = new DataTable();
        string courseid = string.Empty;
        string sessid = string.Empty;

        public ClassRoster()
        {
            InitializeComponent();
        }

        public ClassRoster(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            
        }

        private void ClassRoster_Load(object sender, EventArgs e)
        {
            loaddata();
        }
        public void loaddata()
        {
            cmbsessionid.Items.Clear();
            cmbsessionid.SelectedIndex = -1;
            string sqlselect1 = "select * from Training_Schedule order by Session_Id asc";
            dtable = Utilities.DataBaseUtility.GetTable(sqlselect1);

            for (int i = 0; i < dtable.Rows.Count; i++)
            {
                cmbsessionid.Items.Add(dtable.Rows[i][0]);
            }
            cmbsessionid.Sorted = false;         
                       
        }          

        
            
        private void cmbsessionid_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        } 

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbsessionid_SelectedIndexChanged_1(object sender, EventArgs e)
        {
          
            sessid = cmbsessionid.GetItemText(cmbsessionid.Text).ToString();
          //  dtable = Utilities.DataBaseUtility.GetTable("Select * from Training_Booking where Session_Id =" + sessid);
            
            dtable = Utilities.DataBaseUtility.GetTable("Select b.Booking_Id, b.Session_Id, b.Course_Id, b.Cust_Id, c.Cust_fname, c.Cust_lname, b.Booking_Status from Training_Booking b, Training_Customer c where b.Cust_Id = c.Cust_id and Session_Id =" + sessid);


            dataGridView1.DataSource = dtable;

        }
      
    }
}
