using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Sales_sm
{

    public partial class CustomerInfo : Sales_sm.Sales_sm_template
    {

        OleDbDataAdapter oledbAdapter;
        OleDbCommandBuilder oledbCmdBuilder;
        DataSet ds = new DataSet();
        BindingSource tblsrc = new BindingSource();
        DataSet ds_Employee = new DataSet();
        DataSet changes1;
        DataSet changes2;
        int i;
        int userId;
        String sql1;
        public int cid;
        string sqlinsert;
        string servinsert;
        string service;
        string message = string.Empty;
        string msg2 = string.Empty;
        int latestcusID=0;
        int currentcusID;
        int initdocnum = 200;

        public CustomerInfo()
        {
            InitializeComponent();
        }

        public CustomerInfo(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            label_SubName.Text="SALES S&M > CUSTOMER INFORMATION";
            DataTable Customers = Utilities.DataBaseUtility.GetTable("Select CustomerID, (CustomerID & ': '& FirstName & ' ' & LastName  ) as custNAME from Customers");
            DataView dvCust = new DataView(Customers);
            CmbCustomer.DataSource = dvCust;
            CmbCustomer.DisplayMember = "custName";
            CmbCustomer.ValueMember = "CustomerID";
            CmbCustomer.SelectedIndex = -1;


           

              }

         private void bind_data(string tablenm, string _DocNum)
        {
            OleDbConnection connection = Utilities.DataBaseUtility.GetConnectionObject();

            sql1 = "select DocNum, Doctype, CustomerID, Service_order_id , Status, Delivery_Date , Customer_Service_Request from " + tablenm + " where CustomerID =" + _DocNum;
            try 
            {
                connection.Open();
                ds.Clear();
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                oledbAdapter = new OleDbDataAdapter(sql1, connection);
                oledbAdapter.Fill(ds);
                tblsrc.DataSource = ds.Tables[0];
                dataGridView1.DataSource = tblsrc;
                // dataGridView1.DefaultValuesNeeded += new DataGridViewRowEventHandler(dataGridView1_DefaultValuesNeeded);
                dataGridView1.Columns["DocNum"].Visible = false;
                dataGridView1.Columns["DocType"].Visible = false;
                dataGridView1.Columns["CustomerID"].Visible = false;
                DataGridViewButtonColumn dgvbtnedit = new DataGridViewButtonColumn();
                //DataGridCheckBoxColumn dgvCmb = new DataGridCheckBoxColumn();
                //dgvCmb.ValueType = typeof(bool);
                dgvbtnedit.Name = "Update";
                dgvbtnedit.HeaderText = "Update";
                dgvbtnedit.Text = "Update";
                //dgvbtnedit. = "SAVE";
                dgvbtnedit.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(dgvbtnedit);

                DataGridViewButtonColumn dgvbtnDel = new DataGridViewButtonColumn();
                //DataGridCheckBoxColumn dgvCmb = new DataGridCheckBoxColumn();
                //dgvCmb.ValueType = typeof(bool);
                dgvbtnDel.Name = "Delete";
                dgvbtnDel.HeaderText = "Delete";
                dgvbtnDel.Text = "Delete";
                //dgvbtnedit. = "SAVE";
                dgvbtnDel.UseColumnTextForButtonValue = true;
                dataGridView1.Columns.Add(dgvbtnDel); 

               // dataGridView1.Columns["ServiceProductType"].Visible = false;
                // dataGridView1.Columns["ProductID"].Visible = false;
                //dataGridView1.Columns[2].Visible = false;
               // ds.Tables[0].RowChanged += new DataRowChangeEventHandler(Row_Changed);

                //total_amt.Text = ds.Tables[0].Compute("Sum(Price)", "").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnCusID_Click(object sender, EventArgs e)
        {

            if (CmbCustomer.SelectedIndex != -1)
            {
                string Selectedcustomer = ((DataRowView)CmbCustomer.SelectedItem).Row["CustomerID"].ToString();
                if (!String.IsNullOrEmpty(Selectedcustomer))
                {

                    AddServiceOrder pds = new AddServiceOrder(ident, "", Selectedcustomer);

                    pds.ShowDialog();
                    string myString = pds.ResultString;
                    CmbCustomer.SelectedValue = myString;

                    bind_data("Service_Order", myString);

                }
            }
               
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'frontendDataSet.Customers' table. You can move, or remove it, as needed.
            //this.customersTableAdapter.Fill(this.frontendDataSet.Customers);

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void cmbServList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //DisplayServiceTypes pds = new DisplayServiceTypes(ident, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            //pds.Show();

            if (e.ColumnIndex == 7)
            {
                AddServiceOrder pds = new AddServiceOrder(ident, dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString(), dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString());
           
                pds.ShowDialog();
                string myString = pds.ResultString;
                CmbCustomer.SelectedValue = myString;
                 
                        bind_data("Service_Order", myString);
               
            }

            if (e.ColumnIndex == 8)
            {
                string Delete_order = "Delete from Service_Order where Docnum =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Delete_orderDtl = "Delete from Service_Order_Details where Docnum =" + dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                 
                string returncode = Utilities.DataBaseUtility.Execute(Delete_order, base.ident);
                 returncode = Utilities.DataBaseUtility.Execute(Delete_orderDtl, base.ident);
                 bind_data("Service_Order", dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            

            }


        }
        private void CmbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(" customerpicked");
            if (CmbCustomer.SelectedIndex != -1)
            {
                 string Selectedcustomer = ((DataRowView)CmbCustomer.SelectedItem).Row["CustomerID"].ToString();
                    if (!String.IsNullOrEmpty(Selectedcustomer))
                    {
                        bind_data("Service_Order", Selectedcustomer);
                    } }

            
        }


    

      

       
    }
}
