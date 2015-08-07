using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using System.IO;
using System.Data.SqlClient;

namespace HRBenefits
{
   /* class GlobalClass
    {
        public static SqlDataAdapter adap;
        public static DataTable dt;
    }
    */
    public partial class ViewRequests : HRBenefits.HRBenefits_Template
    {
        OleDbDataAdapter sAdapter;
        //DataTable sTable;
        DataSet sDs;
        public ViewRequests()
        {
            InitializeComponent();
        }
        public ViewRequests(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void ViewRequests_Load(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable("SELECT * FROM HR_Benefits_Requests;");
            dataGridView1.DataSource = dtable;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable("SELECT * FROM HR_Benefits_Requests;");
            dataGridView1.DataSource = dtable;
/*
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= Frontend.accdb";
            string sql = "SELECT * FROM HR_Benefits_Requests";
            OleDbConnection connection = new OleDbConnection(connectionString);
            //SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            //sCommand = new SqlCommand(sql, connection);
            sAdapter = new OleDbDataAdapter(sql, connection);
            //sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "HR_Benefits_Requests");
            dataGridView1.DataSource = sDs.Tables[0];
            //sTable = sDs.Tables["HR_Benefits_Requests"];
            connection.Close();
            
            dataGridView1.ReadOnly = true;
            button4.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
 */
        }


        

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
           // button4.Enabled = true;
           // button2.Enabled = false;
            //button3.Enabled = false;

            // insert into TABLE

            string s = "Select * from HR_Benefits_Request";
            DataTable dt1 = Utilities.DataBaseUtility.GetTable(s);
            dataGridView1.DataSource = dt1;


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete this row ?", "Delete", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                //sAdapter.Update(sTable);
                sAdapter.Update(sDs, "HR_Benefits_Requests");
                MessageBox.Show("Deleted.");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            /*
            //SqlCommand cmdUpdate = new SqlCommand();
            sAdapter = new OleDbDataAdapter(updatesql, connection);
            cmdUpdate.CommandText = "UPDATE Contact SET " + "FirstName = @FirstName"+ ", " + "LastName = @LastName"+ " WHERE ContactID = @ContactID"
//.... also define "SqlParameter" objects for each parameter (IE. @FirstName)

            sqlDbDataAdapter1.UpdateCommand = cmdUpdate;
            */
            
            
            //sAdapter.Update(sTable);
            sAdapter.Update(sDs, "HR_Benefits_Requests");
            dataGridView1.ReadOnly = true;
            //button4.Enabled = false;
            //button2.Enabled = true;
           // button3.Enabled = true;
            MessageBox.Show("Update Successful.");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string reqID = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            UpdateRequests newform = new UpdateRequests(reqID);
            newform.Show();
        }

    }
}
