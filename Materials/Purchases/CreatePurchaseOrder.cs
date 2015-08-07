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
    public partial class CreatePurchaseOrder : PurchaseOrder_Template
    {
        List<PO_DetailItem> _details;
        List<string> _productRecords;
        List<string> dataStrings;
        List<InventoryItem> _products;
        IdentityObject _ident;
        int po_ID = 0;
        //int processDoc_ID = 0;
        double totalProductCost = 0;
        PurchaseOrder po;
        string  _productID;
        //int DeliveryDoc_ID;
        bool isvalid = false;


        
        public CreatePurchaseOrder(IdentityObject in_ident)
        {
            InitializeComponent();
            _ident = in_ident;
            if (_ident == null) _ident = base.ident;
            if (_ident == null) 
            {
                MessageBox.Show(" must log in with authority level > 1  to create purchase order");
                return;
            }
            if (_ident.ActionLevel  < 2)
            {
                MessageBox.Show(" must have higher authority level to create purchase order");
                return;
            }
            FillSupplier();
            textBox_Comment.Text = "new_PO";
            textBox_Role.Text = _ident.Role;
            textBox_Employee.Text = _ident.UserID;
            textBox_AuthLevel.Text = _ident.ActionLevel.ToString();
            button_Preview.Visible = false;
            button_DataToText.Visible = false;
            button_ConvertToSql.Visible = false;
            textBox_Commands.Visible = false;
            NewPurchaseOrder(_ident);
        }
        public CreatePurchaseOrder(IdentityObject ident,Purchases.InventoryItem item)
        {
            InitializeComponent();
            label_SubName.Text = "New Purchase Order";
            _ident = ident;
            textBox_Role.Text = _ident.Role;
            if (_ident == null) _ident = new IdentityObject("111", "Johnson", "clerk", 1, 2);
            textBox_Employee.Text = _ident.UserID;
            textBox_AuthLevel.Text = _ident.ActionLevel.ToString();
            FillSupplier();
            comboBox1.SelectedIndex = item.Supplier;
            textBox_Supplier.Text = item.Supplier.ToString();
            comboBox1_SelectedIndexChanged(this, null);
            _productID = item.ProductID.ToString();
            //textBox_Comment.Text = "Product No:" + _productID + "(" + item.ProductName  +")";
            textBox_OnHand.Text = item.OnHand.ToString();
            textBox_MinQuantity.Text = item.MinQuantity.ToString();
            textBox_Quantity.Text = (item.MinQuantity - item.OnHand).ToString();
            textBox_Price.Text = item.Cost.ToString();
            textBox_ProductID.Text = item.InvID.ToString();
            textBox_PO_ID2.Text = item.ProductName.ToString();
            button_Preview.Visible = false;
            button_DataToText.Visible = false;
            button_ConvertToSql.Visible = false;

            NewPurchaseOrder(_ident);
        }
        public void NewPurchaseOrder(IdentityObject ident)
        {
            //InitializeComponent();
            _ident = ident;
            dataStrings = new List<string>();
            _details = new List<PO_DetailItem >();
            po_ID = CreatePurchaseOrdersDocNum();//Utilities.DataBaseUtility.GetNextNumber("PURCHASE_ORDERS", 0, "");
            textBox_PurchaseOrderID.Text = po_ID.ToString();
            textBox_Type.Text = "11";
            comboBox_Status.SelectedIndex = 2;
            //textBox_PO_ID2.Text = textBox_PurchaseOrderID.Text;
            if (textBox_Supplier.Text.Length == 1)
            {
                int indx = Int32.Parse(textBox_Supplier.Text);
                if ((indx > 0) && (indx < 8))
                {
                    comboBox1.SelectedIndex = indx ;
                    comboBox1_SelectedIndexChanged(this, null);
                }
            }
            FillProducts();
        }

        private int CreatePurchaseOrdersDocNum()
        {
            try
            {
                List<string> _list = DataBaseUtility.GetList("select * from " + PODConstants.PURCHASE_ORDERS_TABLE_NAME);
                if(_list ==  null || (_list != null && _list.Count == 0))
                {
                    return 101;
                }
                int lastrow = _list.Count - 1;
                string[] lastrowStr = _list[lastrow].Split(',')
                                    .Select(s => s.Trim())
                                    .Where(s => s != String.Empty)
                                    .ToArray();
                int nextNumber = Int32.Parse(lastrowStr[0]) + 1;

                return nextNumber;
            }
            catch (Exception)
            {
                MessageBox.Show("Could not generate Doc num for new purchase orders.  Please check your table PURCHASE_ORDERS");
                return -1;
            }
        }

        private void FillProducts()
        {
            _productRecords = DataBaseUtility.GetList("Select DocNum,DocType,ExtRef,Max,Min,OnHand,Category,year,Price,UnitCost,Comments from " + PODConstants.INVENTORY_LIST + " where OnHand < Min and onHand > 0 and supplierID = " + textBox_Supplier.Text);
            _products = new List<InventoryItem> { };
            for (int i = 1; i < _productRecords.Count; i++)
            {
                InventoryItem item = new InventoryItem(_productRecords[i]);
                _products.Add(item);
                //string[] fields = _productRecords[i].Split(',')
                //                    .Select(s => s.Trim())
                //                    .Where(s => s != String.Empty)
                //                    .ToArray();
                comboBox_Products.Items.Add(item.InvID + "  :  " + item.ProductName);
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
        private void FillSupplier()
        {
            DataTable dtSupplier = new DataTable();
             dtSupplier = DataBaseUtility.GetTable("select * from Suppliers");
             comboBox1 = new ComboBox();
             comboBox1.Items.Add("Suppliers");
             for (int i =0; i < dtSupplier.Rows.Count; i++)
                comboBox1.Items.Add((i+1).ToString() + "  :  " + dtSupplier.Rows[i]["Name"].ToString());
        }

        private void button_SubmitOrder_Click(object sender, EventArgs e)
        {
            isvalid = true;
            button_Preview_Click(sender, e);
            if (isvalid)
            {
                button_DataToText_Click(sender, e);
                if (isvalid)
                {
                    button_ConvertToSql_Click(sender, e);

                    string[] cmds = textBox_Commands.Text.Split(';');
                    int last = cmds.Length - 1;
                    string strreturn = "";
                    for (int i = 0; i < last; i++)
                    {
                        strreturn = DataBaseUtility.Execute(cmds[i].Trim(), _ident);
                        if (strreturn != "no errors")
                        {
                            strreturn = "";
                            MessageBox.Show("Error while creating purchase order.  Please try again!");
                            break;
                            this.Close();
                        }
                    }


                    if (strreturn == "no errors")
                    {
                        if (CreateDeliverySql() == "no errors")
                        {
                            MessageBox.Show("Purchase Order , Delivery Doc " + po.PO_ID + " Created Successfully..!!!");
                            this.Close();
                        }
                    }
                }
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt_Supplier = new DataTable();
                textBox_Supplier.Text = (comboBox1.SelectedIndex ).ToString();
                dt_Supplier = DataBaseUtility.GetTable("select * from suppliers where supplierid=" + (comboBox1.SelectedIndex ).ToString());
                textBox2.Text = Convert.ToString(dt_Supplier.Rows[0]["Name"]);
                textBox3.Text = Convert.ToString(dt_Supplier.Rows[0]["Address"]);
                textBox4.Text = Convert.ToString(dt_Supplier.Rows[0]["City"]);
                textBox6.Text = Convert.ToString(dt_Supplier.Rows[0]["State"]);
                textBox5.Text = Convert.ToString(dt_Supplier.Rows[0]["Postalcode"]);
          
        }

        private void button_Add_Click(object sender, EventArgs e)
        {
            
            //Add Prodcut to purchase order
            PO_DetailItem _item = new PO_DetailItem();
            _item.Name = textBox_PO_ID2.Text;
            _item.PO_ID = po_ID; // lastPO_Number + 1;
            _item.ProductID = Int32.Parse(textBox_ProductID.Text); 
            _item.Quantity = Int32.Parse(textBox_Quantity.Text); 
            _item.Price = Double.Parse(textBox_Price.Text);
            int Onhand = Int32.Parse(textBox_OnHand.Text);
            if (_item.Quantity == 0)
            {
                MessageBox.Show("Please enter quanity > 0");
                return;
            }

            else if (_item.Quantity > Onhand)
            {
                MessageBox.Show("Please enter quanity less than on hand");
                return;
            }


            else
            {
                //_item.Comment = "Product No:" + _item.ProductID;// +"(" + +")";

                var duplicate = _details.FirstOrDefault(x => x.ProductID == _item.ProductID);

                if (duplicate == null)
                {
                    _details.Add(_item);
                    dataGridResults.Rows.Add();
                    int lastrow = dataGridResults.Rows.Count - 2;
                    dataGridResults.Rows[lastrow].Cells[1].Value = textBox_PO_ID2.Text;
                    dataGridResults.Rows[lastrow].Cells[0].Value = textBox_ProductID.Text;
                    dataGridResults.Rows[lastrow].Cells[2].Value = textBox_Quantity.Text;
                    dataGridResults.Rows[lastrow].Cells[3].Value = textBox_Price.Text;
                    if (textBox_Comment.Text == "")
                    {
                        textBox_Comment.Text = "Product No:" + textBox_ProductID.Text + "(" + textBox_PO_ID2.Text + ")";
                    }
                    else
                    {
                        textBox_Comment.Text += ",Product No:" + textBox_ProductID.Text + "(" + textBox_PO_ID2.Text + ")";
                    }
                }
                else
                {
                    MessageBox.Show("Product is already added");
                }
            }
         }

        private void FillProductDetails()
        {
            //listBox_Products.Items.Clear();
            //listBox_Quant.Items.Clear();
            //foreach(DataRow drProdut in dt_PurchaseOrder.Rows)
            //{
            //    listBox_Products.Items.Add(Convert.ToString(drProdut["Name"]));
            //    listBox_Quant.Items.Add(Convert.ToString(drProdut["Qty"]).PadLeft(5, ' '));
            //    listBox_Cost.Items.Add(Convert.ToString(drProdut["Cost"]).PadLeft(5, ' '));
            //}
        }

  
        private void button_Preview_Click(object sender, EventArgs e)
        {
            if (_ident == null) { isvalid = false; MessageBox.Show("you must be logged in with authoity level > 1"); return; }
            if (textBox_Employee.Text == "") { isvalid = false; MessageBox.Show("you must be logged in with a valid employee ID and authoity level > 1"); return; }
            int order_no = 0;
            int.TryParse(textBox_PurchaseOrderID.Text, out order_no);
            if (order_no == 0) { isvalid = false;  MessageBox.Show("Invalid Order Number"); return; }

            po = new PurchaseOrder();
            po.PO_ID = order_no;
            po.SupplierID = comboBox1.SelectedIndex + 0;
            po.PO_Status = comboBox_Status.SelectedIndex;
            int val = 111;
            if (Int32.TryParse(textBox_Employee.Text, out val))
            {
                po.EmployeeID = val;
            }
            else
            {
                po.EmployeeID = 111;
            }
            po.PO_Date = dateTimePicker1.Value;
            po.DeliveryDate = dateTimePicker2.Value;
            po.Comment = textBox_Comment.Text;
            if (po.Comment.Length < 1)
                po.Comment = "create PO " + po.PO_ID.ToString();
            if (Convert.ToDateTime(dateTimePicker1.Text) > Convert.ToDateTime(dateTimePicker2.Text))
            {
                isvalid = false;
                MessageBox.Show("Order Date should not be greater than Delivery Date"); return;
            }



            //processDoc_ID = Utilities.DataBaseUtility.GetNextNumber("ProcessDocs", 0, "");
            
        }

        private void button_ConvertToSql_Click(object sender, EventArgs e)
        {
            string part1 = "INSERT into PURCHASE_ORDERS(DocNum,DocType,IntRef,ExtRef,status,DocRef,TextValue1,TextValue2,NumValue1,NumValue2,comment) values (";
            string part2 = String.Format("{0} ,{1},{2},{3},{4},{5},#{6}#,#{7}#,{8},{9},'{10}'",
                                   po.PO_ID, 11, po.EmployeeID, po.SupplierID, po.PO_Status, 0, po.DeliveryDate.ToShortDateString(), po.PO_Date.ToShortDateString(), totalProductCost, 0, po.Comment);

            string saveCommand = part1 + part2 + ");";
            dataStrings.Add(saveCommand);
            textBox_Commands.Text = saveCommand + "\r\n";

            part1 = "INSERT into ProcessDocs(DocNum,DocType,IntRef,ExtRef,status,DocRef,TextValue1,TextValue2,NumValue1,NumValue2,comments) values (";
            part2 = String.Format("{0} ,{1},{2},{3},{4},{5},#{6}#,#{7}#,{8},{9},'{10}'",
                                   po.PO_ID, 11, po.EmployeeID, po.SupplierID, po.PO_Status, po.PO_ID, po.DeliveryDate.ToShortDateString(), po.PO_Date.ToShortDateString(), totalProductCost, 0, po.Comment);
            //        0          1           2              3                4               5            6
            saveCommand = part1 + part2 + ");";
            dataStrings.Add(saveCommand);
            textBox_Commands.Text += saveCommand + "\r\n";


            
            for (int i = 0; i < _details.Count; i++)
            {
                PO_DetailItem pod = _details[i];
                //part1 = "INSERT into PURCHASE_ORDERS_Details(DocNum,DocType,Index1,Index2,ProcessID,Quantity,Price,Comment) values (";
                //part2 = String.Format("{0}  ,{1}  ,{2}  ,{3},{4},{5},{6},'{7}'",
                //      pod.PO_ID, 11, pod.ProductID, 0, po.PO_ID, pod.Quantity, pod.Price,"Product no:" + pod.ProductID.ToString() + "(" +  pod.Name + ")");

                part1 = "INSERT into PURCHASE_ORDERS_Details(DocNum,DocType,Index1,Index2,ProcessID,Quantity,Price,Comment) values (";
                part2 = String.Format("{0}  ,{1}  ,{2}  ,{3},{4},{5},{6},'{7}'",
                      pod.PO_ID, 11, pod.ProductID, 0, pod.ProductID, pod.Quantity, pod.Price, "Product no:" + pod.ProductID.ToString() + "(" + pod.Name + ")");
         
                saveCommand = part1 + part2 + ");";
                textBox_Commands.Text += saveCommand + "\r\n";
                

                part1 = "INSERT into ProcessDocs_Details(DocNum,DocType,Index1,Index2,ProcessID,Quantity,Price,Comment) values (";
                part2 = String.Format("{0}  ,{1}  ,{2}  ,{3},{4},{5},{6},'{7}'",
                      po.PO_ID, 11, pod.ProductID, 0, pod.ProductID, pod.Quantity, pod.Price, "Product no:" + pod.ProductID.ToString() + "(" + pod.Name + ")");
        
                saveCommand = part1 + part2 + ");";
                textBox_Commands.Text += saveCommand + "\r\n";
            }
        }


        private string CreateDeliverySql()
        {
            //int processDoc_ID = Utilities.DataBaseUtility.GetNextNumber("ProcessDocs", 0, "");
            //DeliveryDoc_ID = Utilities.DataBaseUtility.GetNextNumber(PODConstants.DELIVERY_TABLE_NAME, 0, "");

            List<string> dataStrings = new List<string>();
            string strCommands;

            string part1 = "INSERT into " + PODConstants.DELIVERY_TABLE_NAME + "(DocNum,DocType,IntRef,ExtRef,status,DocRef,TextValue1,TextValue2,NumValue1,NumValue2,comment) values (";
            string part2 = String.Format("{0} ,{1},{2},{3},{4},{5},#{6}#,#{7}#,{8},{9},'{10}'",
                                   po.PO_ID, 13, po.EmployeeID, po.SupplierID, po.PO_Status, po.PO_ID, po.DeliveryDate.ToShortDateString(), po.PO_Date.ToShortDateString(), totalProductCost, 0, po.Comment);

            string saveCommand = part1 + part2 + ");";
            dataStrings.Add(saveCommand);
            strCommands = saveCommand + "\r\n";

            part1 = "INSERT into ProcessDocs(DocNum,DocType,IntRef,ExtRef,status,DocRef,TextValue1,TextValue2,NumValue1,NumValue2,comments) values (";
            part2 = String.Format("{0} ,{1},{2},{3},{4},{5},#{6}#,#{7}#,{8},{9},'{10}'",
                                   po.PO_ID, 13, po.EmployeeID, po.SupplierID, po.PO_Status, po.PO_ID, po.DeliveryDate.ToShortDateString(), po.PO_Date.ToShortDateString(), totalProductCost, 0, po.Comment);
            //        0          1           2              3                4               5            6
            saveCommand = part1 + part2 + ");";
            dataStrings.Add(saveCommand);
            strCommands += saveCommand + "\r\n";

            for (int i = 0; i < _details.Count; i++)
            {
                PO_DetailItem pod = _details[i];
                //part1 = "INSERT into " + PODConstants.DELIVERY_DETAILS_TABLE_NAME + "(DocNum,DocType,Index1,Index2,ProcessID,Quantity,Price,Comment) values (";
                //part2 = String.Format("{0}  ,{1}  ,{2}  ,{3},{4},{5},{6},'{7}'",
                //      po.PO_ID, 13, pod.ProductID, 0, processDoc_ID, pod.Quantity, pod.Price,"Product no:" + pod.ProductID.ToString() + "(" +  pod.Name + ")");

                part1 = "INSERT into " + PODConstants.DELIVERY_DETAILS_TABLE_NAME + "(DocNum,DocType,Index1,Index2,ProcessID,Quantity,Price,Comment) values (";
                part2 = String.Format("{0}  ,{1}  ,{2}  ,{3},{4},{5},{6},'{7}'",
                      po.PO_ID, 13, pod.ProductID, 0, pod.ProductID, pod.Quantity, pod.Price, "Product no:" + pod.ProductID.ToString() + "(" + pod.Name + ")");

                saveCommand = part1 + part2 + ");";
                strCommands += saveCommand + "\r\n";

                part1 = "INSERT into ProcessDocs_Details(DocNum,DocType,Index1,Index2,ProcessID,Quantity,Price,Comment) values (";
                part2 = String.Format("{0}  ,{1}  ,{2}  ,{3},{4},{5},{6},'{7}'",
                      po.PO_ID, 13, pod.ProductID, 0, pod.ProductID, pod.Quantity, pod.Price, "Product no:" + pod.ProductID.ToString() + "(" +  pod.Name + ")");

                saveCommand = part1 + part2 + ");";
                strCommands += saveCommand + "\r\n";
            }

            string[] cmds = strCommands.Split(';');
            int last = cmds.Length - 1;
            string strreturn = "";
            for (int i = 0; i < last; i++)
            {
                //_action.Command = 
                strreturn = DataBaseUtility.Execute(cmds[i].Trim(), _ident);
                if (strreturn != "no errors")
                {
                    MessageBox.Show("Error while creating delivery records.  Please try again!");
                    return "error";
                    this.Close();
                }
            }

            return "no errors";
        }


        private void button_DataToText_Click(object sender, EventArgs e)
        {
            if (po == null)
            {
                button_Preview_Click(this, null);
               
            }

            for (int i = 0; i < _details.Count; i++)
            {
                PO_DetailItem pod = _details[i];
                totalProductCost += (pod.Price * pod.Quantity);
                
            }

            

            if (totalProductCost == 0)
            {
                MessageBox.Show("Please add atlease one product."); return;
            }

            string textString = String.Format("{0} ,{1},{2},{3},{4},{5},#{6}#,#{7}#,{8},{9},{10}",
                                   po.PO_ID, 11, po.EmployeeID, po.SupplierID, po.PO_Status, 0, po.DeliveryDate.ToShortDateString(), po.PO_Date.ToShortDateString(), totalProductCost, 0, po.Comment);

            dataStrings.Add(textString );
            
            textBox_Commands.Text += textString + "\r\n";


            for (int i = 0; i < _details.Count; i++)
            {
                PO_DetailItem pod = _details[i];

                textString = String.Format("{0}  ,{1}  ,{2}  ,{3},{4},{5},{6},'{7}'",
                      pod.PO_ID, 11, pod.ProductID,0, pod.PO_ID, pod.Quantity, pod.Price, "Product no:" + pod.ProductID.ToString());

                dataStrings.Add(textString);
                textBox_Commands.Text += textString  + "\r\n";
                
            }
       
        }

        private void comboBox_Products_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] strSelectedItem = comboBox_Products.SelectedItem.ToString().Split(':');
            if(strSelectedItem != null &&  strSelectedItem.Length > 0)
            {
                textBox_ProductID.Text = strSelectedItem[0].Trim();
                int _productID = Int32.Parse (textBox_ProductID.Text);
                textBox_Quantity.Text = "1";
                InventoryItem product = _products.FirstOrDefault(x => x.ProductID == _productID);
                textBox_Price.Text = product.Cost.ToString();
                textBox_MinQuantity.Text = product.MinQuantity.ToString();
                textBox_OnHand.Text = product.OnHand.ToString();
                textBox_PO_ID2.Text = product.ProductName.ToString();
            }
            //textBox_Price.Text = Utilities.DataBaseUtility.GetProductCost(_productID).ToString();
        }

        private void comboBox_Status_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox_Commands.Visible = !textBox_Commands.Visible;
        }

       
      
    }
}
