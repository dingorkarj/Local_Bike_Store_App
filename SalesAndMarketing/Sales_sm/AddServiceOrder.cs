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
    public partial class AddServiceOrder : HAWK_Template_2
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
        String FormMode;
        String Customerinp;
        List<string> _NewOrder;
        IdentityObject ident_local = new IdentityObject();

        public string ResultString { get; set; } // In .NET 3.0 or newer

        public AddServiceOrder()
        {
            InitializeComponent();
        }

        public AddServiceOrder(IdentityObject ident, String _Orderid, string Customerinp)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            ident_local = ident;
            label_SubName.Text = "Sales_sm";
            Doctype.Text ="22";
            CustomerID.Text = Customerinp;
          
            if (_Orderid == "")
            {  
                _NewOrder = Utilities.DataBaseUtility.GetList("select max(Docnum)+1 from Service_Order_Details" );
            FillTextBoxes("New");
            FormMode = "New";
            }
            else {
              _NewOrder = Utilities.DataBaseUtility.GetList("select * from Service_Order where Docnum =" +_Orderid );
            FillTextBoxes("Update");
            FormMode = "Update";
            }

   
            bind_data("Service_Order_Details",  DocNum.Text );

            ResultString = Customerinp;
        }
        private void FillTextBoxes(string typeid)
        {
            string[] _items = _NewOrder[1].ToString().Split(',');
            if (typeid.Equals("New"))
            {
                DocNum.Text = _items[0];
                
                if (ident_local == null) ident_local = new IdentityObject();
                if (ident_local.UserID.Equals("user")) { EmployeeID.Text = "000"; } else { EmployeeID.Text = ident_local.UserID; }
            }

            if (typeid.Equals("Update"))
            {
                DocNum.Text = _items[0];
                Doctype.Text = _items[1];
                CustomerID.Text = _items[2];
                EmployeeID.Text = _items[3];
                Orderstatus.SelectedIndex = Int32.Parse(_items[4]);
                Service_order_id.Text = _items[5];
                DeliveryDate.Text = _items[7];
                CustomerRequest.Text = _items[10];
            
               


            }
            //textBox4.Text = _items[3];
            //textBox5.Text = _items[4];
            //textBox6.Text = _items[5];
            //textBox7.Text = _items[6];
            //textBox8.Text = _items[7];
            //textBox9.Text = _items[8];
            //textBox10.Text = _items[9];
        }


        private void bind_data(string tablenm, string _DocNum)
        {
            OleDbConnection connection = Utilities.DataBaseUtility.GetConnectionObject();

            sql1 = "select DocNum, DocType, ServiceProductType, ServiceProductDescription, Hours, Quantity, price, Status from " + tablenm + " where DocNum =" + _DocNum;
            try 
            {
                connection.Open();
                oledbAdapter = new OleDbDataAdapter(sql1, connection);
                oledbAdapter.Fill(ds);
                tblsrc.DataSource = ds.Tables[0];
                dataGridView1.DataSource = tblsrc;
                // dataGridView1.DefaultValuesNeeded += new DataGridViewRowEventHandler(dataGridView1_DefaultValuesNeeded);
                dataGridView1.Columns["DocNum"].Visible = false;
                dataGridView1.Columns["DocType"].Visible = false;
                dataGridView1.Columns["ServiceProductType"].Visible = false;
                dataGridView1.Columns["Status"].Visible = false;
               //  dataGridView1.Columns["ProductID"].Visible = false;
                //dataGridView1.Columns[2].Visible = false;
                ds.Tables[0].RowChanged += new DataRowChangeEventHandler(Row_Changed);

               // total_amt.Text = ds.Tables[0].Compute("Sum(Price)", "").ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            String _DocNUM = DocNum.Text;
            String _DocType = Doctype.Text;
            String _ProductID = "";
            String _Quantity = "1";
            String _ServiceProductType = "";
            String _comment = "This is To pass existing comments";
            AddServiceOrderItem pas = new AddServiceOrderItem(ident, _ServiceProductType, _DocNUM, _DocType, _ProductID, _Quantity, _comment);
            pas.ShowDialog();
            string myString = pas.ResultString;
            if (!String.IsNullOrEmpty(myString))
            {
                string[] fields = myString.ToString().Split(',');
             //   MessageBox.Show("debug Getting REturn String" + "PRODTYPE : " + fields[0] + " PRODTYPEdesc  : " + fields[1]);


                DataRow newServiceOrderDTLRow = ds.Tables[0].NewRow();

                newServiceOrderDTLRow["DocNum"] = Int32.Parse(DocNum.Text);
                newServiceOrderDTLRow["DocType"] = Int32.Parse(Doctype.Text);
                newServiceOrderDTLRow["Quantity"] = Int32.Parse("1");
                newServiceOrderDTLRow["ServiceProductType"] = Int32.Parse(fields[0]);
                newServiceOrderDTLRow["ServiceProductDescription"] = fields[1];
                newServiceOrderDTLRow["Hours"] = double.Parse(fields[3]);
                newServiceOrderDTLRow["Price"] = double.Parse(fields[4]);
                newServiceOrderDTLRow["Status"] = Int32.Parse("0");
               // newServiceOrderDTLRow["Comments"] = fields[5].Trim();
                ds.Tables[0].Rows.Add(newServiceOrderDTLRow);


            }
        }

        private void SaveOrderBtn_Click(object sender, EventArgs e)
        {
            try
            {
                
                string hdr_DocNum_var = DocNum.Text;
                string hdr_DocType_var = Doctype.Text;
                string hdr_EmployeeID_var = EmployeeID.Text;
                string hdr_CustomerID_var = CustomerID.Text;

                string hdr_status_var = Orderstatus.SelectedText;
                string hdr_statusCOde_var = Orderstatus.SelectedIndex.ToString();
                //string hdr_GrossPrice_var = textBox8.Text;
                string hdr_DateCreated_var = " NOW()";
                string hdr_DateDeivery_var = "'"+ DeliveryDate.Text +"'" ;
                String hdr_Customer_Service_Request_var = "'" + CustomerRequest.Text + "'";

                
                     String Uptdtset = "Status = " + hdr_statusCOde_var + " , Delivery_Date= "+  hdr_DateDeivery_var + " , Customer_Service_Request = "+ hdr_Customer_Service_Request_var ;

 

                String Sqlstmt1 = "insert into Service_Order(DocNum,DocType,EmployeeID,CustomerID , Status,Service_order_id,Date_Created, Delivery_date , numvalue1,  numvalue2, Customer_Service_Request )  values(" + hdr_DocNum_var + ", " +   hdr_DocType_var + ", " + hdr_EmployeeID_var + ", " + hdr_CustomerID_var + ", " + hdr_statusCOde_var + ", " + hdr_DocNum_var + ", " + hdr_DateCreated_var + ", " + hdr_DateDeivery_var + ", 0, 0 , " + hdr_Customer_Service_Request_var + " );";
                String UpdtString = "Update Service_Order SET " + Uptdtset + " where DocNum = " + hdr_DocNum_var;

                if (FormMode.Equals("New"))
                {
                    textBox11.Text = Sqlstmt1;
                }
                if (FormMode.Equals("Update"))
                {
                    textBox11.Text = UpdtString;
                }
                
               

                string returncode = Utilities.DataBaseUtility.Execute(textBox11.Text, base.ident);
                textBox11.Text += "REsult : " + returncode;



                tblsrc.EndEdit();
                oledbCmdBuilder = new OleDbCommandBuilder(oledbAdapter);
                changes1 = ds.GetChanges(DataRowState.Modified);
                changes2 = ds.GetChanges(DataRowState.Added);

                // || changes2 != null
                if (changes1 != null || changes2 != null)
                {
                    oledbAdapter.Update(ds.Tables[0]);
                  //  MessageBox.Show("Changes Saved");
                }
                
                ds.AcceptChanges();
                //MessageBox.Show("Save changes");
                ResultString = hdr_CustomerID_var;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String _DocNUM = dataGridView1.Rows[e.RowIndex].Cells["DocNum"].Value.ToString();
            String _DocType = dataGridView1.Rows[e.RowIndex].Cells["DocType"].Value.ToString();
            String _ProductID = "";
            String _Quantity = dataGridView1.Rows[e.RowIndex].Cells["Quantity"].Value.ToString();
            String _ServiceProductType = dataGridView1.Rows[e.RowIndex].Cells["ServiceProductType"].Value.ToString();
            String _comment = "";
            AddServiceOrderItem pas = new AddServiceOrderItem(ident, _ServiceProductType, _DocNUM, _DocType, _ProductID, _Quantity, _comment);
            pas.ShowDialog();
            string myString = pas.ResultString;
            if (!String.IsNullOrEmpty(myString))
            {
                string[] fields = myString.ToString().Split(',');
                //MessageBox.Show("debug Getting REturn String" + "PRODTYPE : " + fields[0] + " PRODTYPEdesc  : " + fields[1]);
           

                DataRow[] newServiceOrderDTLRow = ds.Tables[0].Select("DocNum = '"+ _DocNUM + "' AND DocType = '"+ _DocType + "' and ServiceProductType = '"+  _ServiceProductType + "'");

                newServiceOrderDTLRow[0]["DocNum"] = Int32.Parse(_DocNUM);
                newServiceOrderDTLRow[0]["DocType"] = Int32.Parse(_DocType);
                newServiceOrderDTLRow[0]["Quantity"] = Int32.Parse("1");
                newServiceOrderDTLRow[0]["ServiceProductType"] = Int32.Parse(fields[0]);
                newServiceOrderDTLRow[0]["ServiceProductDescription"] = fields[1];
                newServiceOrderDTLRow[0]["Hours"] = double.Parse(fields[3]);
                newServiceOrderDTLRow[0]["Price"] = double.Parse(fields[4]);
                newServiceOrderDTLRow[0]["Status"] = Int32.Parse("0");

               // newServiceOrderDTLRow[0]["Comments"] = fields[5].Trim();
              //  ds.Tables[0].Rows.Add(newServiceOrderDTLRow);
            }
        }
        private static void Row_Changed(object sender, DataRowChangeEventArgs e)
        {
          

                
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Orderstatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EmployeeID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}