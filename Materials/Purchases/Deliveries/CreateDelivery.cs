using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Utilities;
//using Invoices;

namespace Purchases
{
    public partial class CreateDelivery : Deliveries_Template 
    {

        Delivery del;
        List<Purchases.PO_DetailItem> _details;
        List<string> _productRecords;
        List<string> _poRecord;
        List<string> _commandStrings;
        List<string> dataStrings ;
        List<string> _supplierData;
        List<Utilities.Product> _products;
       
        IdentityObject _ident;
    //    int _po_ID;
        string _poID_Str;
        int _supplierID = 0;
    //    string _productID;
        DataTable dt_PurchaseOrder;
        Purchases.PurchaseOrder _po;
        Delivery _del;
        //public CreateDelivery()
        //{
        //    InitializeComponent();
        //    _ident = new IdentityObject();
        //    textBox_Comment.Text = "new_PO";
        //    NewDelivery(_ident);
        //}
        public CreateDelivery(IdentityObject ident)
        {
            InitializeComponent();
            _ident = ident;
            base.ident = ident;
            textBox_Comment.Text = "new_PO";
            NewDelivery(_ident);
        }
        public CreateDelivery(string poID_Str, IdentityObject ident)
        {
            InitializeComponent();
            _ident = ident;
            _poID_Str = poID_Str;
            NewDelivery(ident);
        }
         public void NewDelivery(IdentityObject ident)
        {
            InitializeComponent();
            _ident = ident;
            _commandStrings = new List<string>();
            _details = new List<Purchases.PO_DetailItem >();
            LoadPO_IDs();
            LoadSuppliers();
        //    textBox_DocNumber.Text = purchaseOrderID.ToString();
            textBox_Type.Text = "14";
            comboBox_Status.SelectedIndex = 5;
            dt_PurchaseOrder = new DataTable();
            dt_PurchaseOrder.Columns.Add("ProductId", typeof(int));
            dt_PurchaseOrder.Columns.Add("Name", typeof(string));
            dt_PurchaseOrder.Columns.Add("Qty", typeof(int));
            dt_PurchaseOrder.Columns.Add("Cost", typeof(int));
           // FillSupplier(_supplierID.ToString() );
           // FillProducts(_supplierID);
        }


         private void comboBox_DocNumber_IndexChanged(object sender, EventArgs e)
         {
             textBox_DocNumber.Text = comboBox_DocNumber.SelectedItem.ToString();
             _poID_Str = textBox_DocNumber.Text.Trim();
         }
            private void button_FromPO_Click(object sender, EventArgs e)
        {
             //List<string> poStr = Utilities.DataBaseUtility.GetList("Select * from purchaseOrders where docnum = " + textBox_DocNumber.Text );
             //string[] fields = poStr[1].Split('\t');
             // _po = new PurchaseOrder(fields);
             // _del = new Delivery(fields);
             _ident = new IdentityObject();
             _poID_Str = textBox_DocNumber.Text.Trim();
             _poRecord = Utilities.DataBaseUtility.GetList("select * from PURCHASE_ORDERS where docnum = " + _poID_Str,',');
             if (_poRecord.Count != 2)
             {
                 MessageBox.Show("could not find purchase order :  " + _poID_Str);
                 return;
             }
             textBox_Details.Text = _poRecord[1] + "\r\n";
             //    _po = new PurchaseOrder(_poRecord[1]);
             _del = new Delivery(_poRecord[1]);
             textBox_Supplier.Text = _del.SupplierID.ToString();
             if (_ident == null) _ident = new IdentityObject("111", "Johnson", "clerk", 1, 2);
             textBox_Employee.Text = _ident.UserID.ToString();  // _del.EmployeeID.ToString();
             dateTimePicker1.Value  = DateTime.Now;  //.ToShortDateString();
             //  dateTimePicker1.Text = DateTime.Now.ToShortDateString();
             //   Parse(_po.PO_Date).ToShortDateString ();
             if (_del.SupplierID > 0)
             {
                 _supplierID = _del.SupplierID;
                 textBox_Supplier.Text = _supplierID.ToString();
                 FillSupplier(_supplierID.ToString());
                 FillProducts(_supplierID);
             }
             textBox_Comment.Text = "P. O. " + _poID_Str  + " delivery";
             // NewDelivery(_ident);
             // string _titles = String.Format("{0}\t{1}\t{2}\t{3}", "Del.ID", "prod.ID", "Quant.", "Cost");
             // textBox_Details.Text = _titles;
             List<string> detailRecords = Utilities.DataBaseUtility.GetList("select * from PurchaseOrderDetails where docnum = " + _poID_Str, ',');
             for (int i = 1; i < detailRecords.Count; i++)
             {
                 textBox_Details.Text += detailRecords[i] + "\r\n";

             }
         }


        private void LoadPO_IDs()
        {
            List<string> po_Names = Utilities.DataBaseUtility.GetList("Select docnum from PURCHASE_ORDERS order by docnum"); 
            comboBox_DocNumber.Items.Clear();
            for (int i = 1; i < po_Names.Count; i++)
                comboBox_DocNumber.Items.Add(po_Names[i]);
        }
        private void LoadSuppliers()
        {
            DataTable dtSupplier = new DataTable();
            dtSupplier = DataBaseUtility.GetTable("select * from Suppliers");
   
            for (int i = 0; i < dtSupplier.Rows.Count; i++)
                comboBox_Supplier.Items.Add((i + 1).ToString() + "  :  " + dtSupplier.Rows[i][1].ToString());
        }
        private void FillProducts(int _id)
        {
            string command = "select * from products where supplier = " + _supplierID.ToString();
            if (_id > 0) command = "select * from products where supplier = " + _id.ToString();
            _productRecords = DataBaseUtility.GetList(command);
            _products = new List<Utilities.Product> { };
            for (int i = 1; i < _productRecords.Count; i++)
            {
                _products.Add(new Utilities.Product(_productRecords[i]));
                string[] fields = _productRecords[i].Split(',')
                                    .Select(s => s.Trim())
                                    .Where(s => s != String.Empty)
                                    .ToArray(); ; ;
                comboBox2.Items.Add(fields[0] + "  :  " + fields[1]);
            }

        }

        private double GetCost(string PO_IDstr)
        {
            int po_ID = Int32.Parse(PO_IDstr);
            double _cost = 0.00;
            for (int i = 0; i < _products.Count; i++)
                if (po_ID == _products[i].ProductID) _cost = _products[i].Cost;
            return _cost;
        }
        private void FillSupplier(string supplierID)
        {
             _supplierData = DataBaseUtility.GetList("select * from Suppliers where supplierID = " + supplierID);
             string[] field = _supplierData[1].Split(',')
                                    .Select(s => s.Trim())
                                    .Where(s => s != String.Empty)
                                    .ToArray(); ;
            //    DataTable dt_Supplier = new DataTable();
            //        dt_Supplier = DataBaseUtility.GetTable("select * from suppliers where supplierid=" + (comboBox1.SelectedIndex +1).ToString());
             textBox2.Text = field[1];  // Convert.ToString(dt_Supplier.Rows[0]["Name"]);
             textBox3.Text = field[2];  // Convert.ToString(dt_Supplier.Rows[0]["Address"]);
             textBox4.Text = field[3];  // Convert.ToString(dt_Supplier.Rows[0]["City"]);
             textBox5.Text = field[4];  // Convert.ToString(dt_Supplier.Rows[0]["State"]);
             textBox_ZIP.Text = field[5]; // Convert.ToString(dt_Supplier.Rows[0]["Postalcode"]);
        }

        private void button_SubmitOrder_Click(object sender, EventArgs e)
        {

            Delivery del = new Delivery();
            int order_no = 0;
            int.TryParse(textBox_DocNumber.Text, out order_no);
            if (order_no == 0) { MessageBox.Show("Invalid Order Number"); return; }
            del.DocNumber = order_no;
            del.SupplierID = comboBox_Supplier.SelectedIndex = 1;
            del.Status = comboBox_Status.SelectedIndex;
            del.PO_Date = dateTimePicker1.Value;
            del.DeliveryDate = dateTimePicker2.Value;
            
           // textBox_Employee.Text
            //          _action = new Utilities.Action();
            //_action.DocNumber = order_no;
            //_action.ActionType = 2;
            //_action.EmployeeID = Int32.Parse(textBox_Employee.Text);
            //_action.DepartmentID = 1;    //  not textBox_Role.Text;
            //_action.ActionDate = DateTime.Now;
            //_action.Status = 2;
            //_action.Command = "";
            //_action.Comment = textBox_Comment.Text;
            Purchases.PurchaseOrder po = new Purchases.PurchaseOrder();
            po.PO_ID = order_no;
            po.SupplierID = comboBox_Supplier.SelectedIndex + 0;
            po.PO_Status = comboBox_Status.SelectedIndex;
            po.EmployeeID = Int32.Parse(textBox_Employee.Text);
            po.PO_Date = dateTimePicker1.Value;
            po.DeliveryDate = dateTimePicker2.Value;
            po.Comment = textBox_Comment.Text;
            if (po.Comment.Length < 1)
                po.Comment = "create PO " + po.PO_ID.ToString();
            if (Convert.ToDateTime(dateTimePicker1.Text) > Convert.ToDateTime(dateTimePicker2.Text))
            {
                MessageBox.Show("Start Date should not be greater than End Date"); return;
            }
            string[] cmds = textBox_Details.Text.Split(';');
            int last = cmds.Length - 1;
            for (int i = 0; i < last; i++)
            {
                //action.Command = ;
                DataBaseUtility.Execute(cmds[i].Trim(), _ident);
            }
            ////     if (po.Comment.Length < 1) 
       //         po.Comment = "create PO " + po.PO_ID.ToString();
       //     if (Convert.ToDateTime(dateTimePicker1.Text) > Convert.ToDateTime(dateTimePicker2.Text))
       //     {
       //         MessageBox.Show("Start Date should not be greater than End Date"); return; 
       //     }
            cmds = textBox_Details.Text.Split(';');
            last = cmds.Length - 1;
            for (int i = 0; i < last; i++)
            {
              //  _action.Command = cmds[i];
              //  DataBaseUtility.Execute(_action, _ident);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                _supplierID = comboBox_Supplier.SelectedIndex + 1;
                textBox_Supplier.Text = _supplierID.ToString();
                FillSupplier(_supplierID.ToString());
     
        }
        private void button_Add_Click(object sender, EventArgs e)
        {
            //Add Prodcut to purchase order
            DataTable dt_POD = new DataTable();
            Purchases.PO_DetailItem _item = new Purchases.PO_DetailItem();
            int indx = comboBox2.SelectedIndex;
            Utilities.Product _selected = new Utilities.Product(_productRecords[indx + 1]);
           // FillProductDetails(_supplierID );
            _item.PO_ID = Int32.Parse(textBox_DocNumber.Text);  // lastPO_Number + 1;
            _item.ProductID = _selected.ProductID;  // Int32.Parse(comboBox2.SelectedValue.ToString());
            _item.Quantity = Int32.Parse(textBox_Quant.Text);
            _item.Price = _selected.Cost;
            int qty = 0;
            int.TryParse(textBox_Quant.Text, out qty);
            if (qty < 1) { MessageBox.Show("Invalid Quantity"); return; }
            dataGridResults.Rows.Add();
            int i = dataGridResults.Rows.Count - 2;
            dataGridResults.Rows[i].Cells[0].Value = String.Format("{0,18:F0}", _item.PO_ID );  //Int32.Parse(_textStrings[j]));
            dataGridResults.Rows[i].Cells[1].Value = String.Format("{0,18:F0}", _item.ProductID);  //Int32.Parse(_textStrings[j]));
            dataGridResults.Rows[i].Cells[2].Value = String.Format("{0,18:F0}", _item.Quantity);  //Int32.Parse(_textStrings[j]));
            dataGridResults.Rows[i].Cells[3].Value = String.Format("{0,18:F2}", _item.Price);  // Double.Parse(_textStrings[3]));

        }

    

        //private void FillProductDetails(int _id)
        //{
        //    listBox_Products.Items.Clear();
        //    //   listBox_Quant.Items.Clear();
        //    //   listBox_Cost.Items.Clear();
        //    foreach (DataRow drProdut in dt_PurchaseOrder.Rows)
        //    {
        //        listBox_Products.Items.Add(Convert.ToString(drProdut["Name"]));
        //        //     listBox_Quant.Items.Add(Convert.ToString(drProdut["Qty"]).PadLeft(5, ' '));
        //        //     listBox_Cost.Items.Add(Convert.ToString(drProdut["Cost"]).PadLeft(5, ' '));
        //    }
        //}

  
        private void button_Preview_Click(object sender, EventArgs e)
        {
            if (radioButton_SQL.Checked) radioButton_SQL_CheckedChanged(this, null);
            del = new Delivery(textBox_Details.Text );
            //int order_no = 0;
            //int.TryParse(textBox_DocNumber.Text, out order_no);
            //if (order_no == 0) { MessageBox.Show("Invalid Order Number"); return; }
            textBox_DocNumber.Text = del.DocNumber.ToString();  // = order_no;
            textBox_Supplier.Text = del.SupplierID.ToString();  // = Int32.Parse(textBox_Supplier.Text);
          //  comboBox_Supplier.SelectedIndex = del.SupplierID;
            comboBox_Status.SelectedIndex = del.Status;
            textBox_Comment.Text = del.Comment;
            textBox_Employee.Text = del.EmployeeID.ToString();   // _ident.UserID.ToString();
            textBox_AuthLevel.Text = _ident.ActionLevel.ToString();
            textBox_Role.Text = _ident.Role;
            dateTimePicker1.Value = DateTime.Now;  // Parse(_po.PO_Date).ToShortDateString();
          //  dateTimePicker1.Text = DateTime.Parse(_po.PO_Date).ToShortDateString();
            if (_del.SupplierID > 0)
            {
                _supplierID = _del.SupplierID;
                textBox_Supplier.Text = _supplierID.ToString();
                FillSupplier(_supplierID.ToString());
            }
            for (int i = 0; i < del.DeliveryDetails.Count; i++)
            {
                dataGridResults.Rows.Add();
                Del_DetailItem det = del.DeliveryDetails[i];
                dataGridResults.Rows[i].Cells[0].Value = det.Del_ID;
                dataGridResults.Rows[i].Cells[1].Value = det.ProductID ;
                dataGridResults.Rows[i].Cells[2].Value = det.Quantity ;
                dataGridResults.Rows[i].Cells[3].Value = det.Price ;

            }
            //dateTimePicker1.Value  = (DateTime) del.PO_Date.ToOADate();
            //del.DeliveryDate = dateTimePicker2.Value ;
            //del.PO_Date = dateTimePicker1.Value;
            //del.DeliveryDate = dateTimePicker2.Value ;
            //del.Comment = textBox_Comment.Text;
            //if (Convert.ToDateTime(dateTimePicker1.Text) > Convert.ToDateTime(dateTimePicker2.Text))
            //{
            //    MessageBox.Show("Start Date should not be greater than End Date"); return;
            //}
            //    string part1 = "INSERT into Deliveries values (";
         
            
        }

        private void button_Supplier_Click(object sender, EventArgs e)
        {
            FillSupplier(textBox_Supplier.Text);
        }

        private void radioButton_SQL_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button_CollectData_Click(object sender, EventArgs e)
        {
         //   MessageBox.Show(" not connected to UHCL.MIS  server "); return;

            string basicData = String.Format("{0}  ,{1:F0}  ,{2}  ,{3}  ,{4}  ,{5:F0}  ,'{6}'",
                //  del.DocNumber, del.PO_Date.ToOADate(), del.EmployeeID, del.Status, del.SupplierID, del.DeliveryDate.ToOADate(), del.Comment);
                //        0                  1                  2              3                4               5            6
                               textBox_DocNumber.Text,  //  0
                               dateTimePicker1.Value.ToOADate(),  //  1
                               textBox_Employee.Text,             //  2
                               comboBox_Status.SelectedIndex,     //  3
                               textBox_Supplier.Text,             //  4
                               dateTimePicker2.Value.ToOADate(),  //  5
                               textBox_Comment.Text);             //  6
                            
            textBox_Details.Text = basicData + "\r\n";
            dataStrings = new List<string>();
            dataStrings.Add(basicData);
            for (int i = 0; i < dataGridResults.Rows.Count; i++)
            {
                // part1 = "INSERT into DeliveryDetails values (";
                 string detailsString = String.Format("{0}  ,{1}  ,{2}  ,{3}",
                                          textBox_DocNumber.Text,  dataGridResults.Rows[i].Cells[1].Value ,
                                           dataGridResults.Rows[i].Cells[2].Value , dataGridResults.Rows[i].Cells[3].Value );
                                      //                2                                    3          
                 if (detailsString.Length < 16) continue;
                dataStrings.Add(detailsString );
                 textBox_Details.Text += detailsString + "\r\n";
            }      
        }

        private void button_ToSQL_Click(object sender, EventArgs e)
        {
        //    MessageBox.Show(" not connected to UHCL.MIS  server "); return;
            textBox_Details.Text = "insert into Deliveries values (" + dataStrings[0] + ");  \r\n";
            for (int i = 1; i < dataStrings.Count; i++)
                textBox_Details.Text += "insert into DeliveryDetails values (" + dataStrings[i] + ");  \r\n";
        
        }

        private void button_CreateTransString_Click(object sender, EventArgs e)
        {
            int lastrow = dataGridResults.Rows.Count - 1;
            double summ = 0.00;
            textBox_Details.Text = String.Format("{0}  ,2  ,15  ,4 , 41449  ,1  ,3  ,{1} \r\n", textBox_DocNumber.Text, textBox_Comment.Text);
            for (int i = 0; i < lastrow; i++ )
            {
                int productCode = (Int32)dataGridResults.Rows[i].Cells[1].Value;
                int quantity = (Int32)dataGridResults.Rows[i].Cells[2].Value;
                double rate = (Double)dataGridResults.Rows[i].Cells[3].Value;
                double multProduct = rate * quantity;
                summ += multProduct;
                textBox_Details.Text += String.Format("{0}  ,130  ,{1}  ,0  ,3 ,{2}, 1  ,{3}  ,1  ,Finished Goods Inventory \r\n",
                                            textBox_DocNumber.Text, productCode, quantity, multProduct);
            }
             textBox_Details.Text += String.Format("{0} , 211, {1},  0,  3,  1, -1, -{2} , 2 , Accounts payable \r\n",
                                    textBox_DocNumber.Text, textBox_Supplier.Text, summ);  
        }

        private void button_CallTransCreate_Click(object sender, EventArgs e)
        {
            //Utilities.CreateTransaction crt = new CreateTransaction(ident, textBox_Details.Text);
            //crt.Show();
        }

        private void button_PendingAction_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Details.Visible = !textBox_Details.Visible;
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
      
    }
}
