using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Purchases
{
    public partial class PurchaseOrderDisplay : PurchaseOrder_Template 
    {
        public string CustomerEmailAddress;
        List<String> _product_Names;
    //    IdentityObject _ident;
        public PurchaseOrderDisplay(IdentityObject in_ident, string _purchOrder)
        {
            InitializeComponent();
            label_SubName.Text = "Purchase Orders";
            base.SaveIdent(in_ident);
            loadPO_IDs();
            textBox_PurchaseOrderNbr.Text = _purchOrder;
            button_Display_Click(this, null);
        }
        public PurchaseOrderDisplay(IdentityObject in_ident)
        {
            InitializeComponent();
            loadPO_IDs();
            base.SaveIdent( in_ident);
            button_Display_Click(this, null);
        }
        public PurchaseOrderDisplay(string[] _purchOrderStrings)
        {
            InitializeComponent();
            //button_CreateObject_2.Visible = false ;
            button_Preview.Visible = true ;
            button_Retern.Visible = true ;
            string mainString = _purchOrderStrings[0];
            int indx = mainString.IndexOf("(");
            string datastring = mainString.Substring(indx + 1);
            int indx2 = datastring.IndexOf(")");
            datastring = datastring.Substring(0, indx2 );
            string[] field = datastring.Split(',');
            textBox_PurchaseOrderNbr.Text = field[0];
            PurchaseOrder _order = new PurchaseOrder(field);
            //string poCmd = "Select * from PurchaseOrders PO WHERE PO.PO_ID = " + textBox_PurchaseOrderNbr.Text;
            //DataTable poTable = Utilities.DataBaseUtility.GetTable(poCmd);
            //dataGridView1.DataSource = poTable;
            string _supplierID = field[4];// poTable.Rows[0][4].ToString();
            string supplierCmd = "Select * from suppliers WHERE supplierID = " + _supplierID;
            DataTable supplierTable = Utilities.DataBaseUtility.GetTable(supplierCmd);
            dataGridView2.DataSource = supplierTable;
            gboOrderStatus.Visible = true;

         //   _order = _order.GetPurchaseOrder(Convert.ToInt32(textBox_PurchaseOrderNbr.Text));
            string _supplierName = Convert.ToString(supplierTable.Rows[0]["Name"]);
            string _supplierAddress = Convert.ToString(supplierTable.Rows[0]["Address"]);
            string _supplierAddress2 = Convert.ToString(supplierTable.Rows[0]["City"]) + ", " + Convert.ToString(supplierTable.Rows[0]["State"]) + " " + Convert.ToString(supplierTable.Rows[0]["PostalCode"]);
            string _supplierPhone = Convert.ToString(supplierTable.Rows[0]["Phone"]);
            string _supplierEmail = Convert.ToString(supplierTable.Rows[0]["WebAddress"]);
            lblInvNumValue.Text = textBox_PurchaseOrderNbr.Text;    //_ Convert.ToString(_order.PurchaseOrderID);
            label_SupplierName.Text = _supplierName;
            label_SupplierAddr.Text = _supplierAddress;
            label_SupplierAddress2.Text = _supplierAddress2;
            lblPhone.Text = Convert.ToString(_supplierPhone);
            label_ShipName.Text = "Local Bikes";
            label_ShippingAddr2.Text = "2700 Bay Area Blvd";
            label_ShipAddress.Text = "Houston, TX, 77058";
            lblDateValue.Text = _order.PO_Date.ToString();
            label_SupplierEmail.Text = _supplierEmail;
            comboBox2.SelectedIndex = _order.PO_Status;
            label_Status.Text = comboBox2.SelectedItem.ToString();
            gboOrderStatus.Visible = true;
            int recnbr1 = 1;
            double partsTotal = 0.0;  //           double partsTax = 0.0;
            lvProducts.Items.Clear();
            while (recnbr1 < _purchOrderStrings.Length - 1  )
            {
                 mainString = _purchOrderStrings[recnbr1 ];
                // textBox1.Text = mainString;
                 indx = mainString.IndexOf("(");
                 datastring = mainString.Substring(indx + 1);
                 indx2 = datastring.IndexOf(")");
                datastring = datastring.Substring(0, indx2);
                textBox2.Text = datastring;
                string[] fields = datastring.Split(',');
                textBox_PurchaseOrderNbr.Text = fields[0];
               // PurchaseOrderDetails _details = new PurchaseOrderDetails(fields);
                string productCode = fields[1];  // detailsTable.Rows[recnbr1][1].ToString();
                detailsTable  = Utilities.DataBaseUtility.GetTable("Select * from products where productID = " + productCode);
                dataGridView2.DataSource = detailsTable;
                ListViewItem lvi = lvProducts.Items.Add(productCode); 
                lvi.SubItems.Add( detailsTable.Rows[0][1].ToString());
                double _quant = Double.Parse(fields[2]);  //detailsTable.Rows[recnbr1][2].ToString());
                lvi.SubItems.Add(fields[3]);  //  detailsTable.Rows[recnbr1][2].ToString());
                double _price =  Double.Parse(fields[3]);
                _price = Double.Parse(detailsTable.Rows[0][8].ToString());
                lvi.SubItems.Add(string.Format("{0:C}", _price));
                lvi.SubItems.Add(string.Format("{0:C}", 0.00));
                double _total = _quant * _price;
                lvi.SubItems.Add(string.Format("{0:C}", _total));

                partsTotal += _total;    // order.POProdDetails[recnbr1].DetailProductLineTotal;
                recnbr1++;
            }

            lblPartsSubTotalValue.Text = string.Format("{0:C}", partsTotal);
            //  lblSubTotalTaxValue.Text = string.Format("{0:C}", partsTotal * .0825);

            // int recnbr2 = 0;
            // double serviceTotal = 0.0;


            lblShippingCostValue.Text = string.Format("{0:C}", partsTotal * .04);
            double _totalCost = partsTotal + partsTotal * .04;
            lblGrandTotalValue.Text = string.Format("{0:C}", _totalCost);
            
        }

        DataTable detailsTable;
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            clearPurchaseOrder();
        }


        private void clearPurchaseOrder()
        {
            while (lvProducts.Items.Count > 0)
            {
                lvProducts.Items.Remove(lvProducts.Items[0]);
            }

        }

        private void loadPO_IDs()
        {

            List<string> po_Names = Utilities.DataBaseUtility.GetList("Select DocNum from PURCHASE_ORDERS where doctype =11"); //order by PurchasOrderID");
            comboBox1.Items.Clear();
            for (int i =1; i< po_Names.Count; i++)
                comboBox1.Items.Add(po_Names[i]);
        }
        private void button_Display2_Click(object sender, EventArgs e)
        {
            try
            {
                //button_CreateObject_2.Visible = true;
                button_Preview.Visible = false;
                button_Retern.Visible = false;
                PurchaseOrder _order = new PurchaseOrder();
                string poCmd = "Select * from PURCHASE_ORDERS PO WHERE PO.DocNum = " + textBox_PurchaseOrderNbr.Text;
                DataTable poTable = Utilities.DataBaseUtility.GetTable(poCmd);
                dataGridView1.DataSource = poTable;
                string _supplierID = poTable.Rows[0][2].ToString();
                string supplierCmd = "Select * from suppliers WHERE supplierID = " + _supplierID;
                DataTable supplierTable = Utilities.DataBaseUtility.GetTable(supplierCmd);
                dataGridView2.DataSource = supplierTable;
                string detailsCmd = "Select * from PURCHASE_ORDERS_DETAILS WHERE DocNum = " + Convert.ToInt32(textBox_PurchaseOrderNbr.Text);
                detailsTable = Utilities.DataBaseUtility.GetTable(detailsCmd);
                gboOrderStatus.Visible = true;

                _order = _order.GetPurchaseOrder(Convert.ToInt32(textBox_PurchaseOrderNbr.Text));
                string _supplierName = Convert.ToString(supplierTable.Rows[0]["Name"]);
                string _supplierAddress = Convert.ToString(supplierTable.Rows[0]["Address"]);
                string _supplierAddress2 = Convert.ToString(supplierTable.Rows[0]["City"]) + ", " + Convert.ToString(supplierTable.Rows[0]["State"]) + " " + Convert.ToString(supplierTable.Rows[0]["PostalCode"]);
                string _supplierPhone = Convert.ToString(supplierTable.Rows[0]["Phone"]);
                string _supplierEmail = Convert.ToString(supplierTable.Rows[0]["WebAddress"]);

                lblInvNumValue.Text = textBox_PurchaseOrderNbr.Text;    //_ Convert.ToString(_order.PurchaseOrderID);
                label_SupplierName.Text = _supplierName;
                label_SupplierAddr.Text = _supplierAddress;
                label_SupplierAddress2.Text = _supplierAddress2;
                lblPhone.Text = Convert.ToString(_supplierPhone);
                label_ShipName.Text = "Local Bikes";
                label_ShippingAddr2.Text = "2700 Bay Area Blvd";
                label_ShipAddress.Text = "Houston, TX, 77058";
                lblDateValue.Text = _order.PO_Date.ToString();
                label_SupplierEmail.Text = _supplierEmail;
                comboBox2.SelectedIndex = _order.PO_Status;
                label_Status.Text = comboBox2.SelectedItem.ToString();
                gboOrderStatus.Visible = true;
                int recnbr1 = 0;
                double partsTotal = 0.0;  //           double partsTax = 0.0;
                lvProducts.Items.Clear();
                while (recnbr1 < detailsTable.Rows.Count)
                {
                    string productCode = detailsTable.Rows[recnbr1][2].ToString();
                    _product_Names = Utilities.DataBaseUtility.GetList("Select ProductName from Products where ProductID = " + productCode);
                    ListViewItem lvi = lvProducts.Items.Add(productCode);  //detailsTable.Rows[recnbr1][1].ToString());
                    if (_product_Names.Count > 1 && _product_Names[1] != null)
                    {
                        lvi.SubItems.Add(_product_Names[1]);
                    }
                    //else
                    //{
                    //    MessageBox.Show("Please check the products and inventory data, the inventory product " + productCode + " not available in products table");
                    //}
                    lvi.SubItems.Add(detailsTable.Rows[recnbr1][5].ToString());
                    double _price = Double.Parse(detailsTable.Rows[recnbr1][6].ToString());
                    double _quant = Double.Parse(detailsTable.Rows[recnbr1][5].ToString());
                    lvi.SubItems.Add(string.Format("{0:C}", _price));
                    lvi.SubItems.Add(string.Format("{0:C}", 0.00));
                    double _total = _quant * _price;
                    lvi.SubItems.Add(string.Format("{0:C}", _total));

                    partsTotal += _total;    // order.POProdDetails[recnbr1].DetailProductLineTotal;
                    recnbr1++;
                }

                lblPartsSubTotalValue.Text = string.Format("{0:C}", partsTotal);
                //  lblSubTotalTaxValue.Text = string.Format("{0:C}", partsTotal * .0825);

                // int recnbr2 = 0;
                // double serviceTotal = 0.0;


                lblShippingCostValue.Text = string.Format("{0:C}", partsTotal * .04);
                double _totalCost = partsTotal + partsTotal * .04;
                lblGrandTotalValue.Text = string.Format("{0:C}", _totalCost);

                // pnlService.Visible = true;

            }
            catch (Exception ex) { MessageBox.Show("Due to invalid or old data in Database, Application could not load the purchase order"); }
        }

       
        private void btnEmail_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("mailto:" + CustomerEmailAddress);

        }

        private void button_Display_Click(object sender, EventArgs e)
        {
            clearPurchaseOrder();
            loadPO_IDs();
    
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_PurchaseOrderNbr.Text = comboBox1.SelectedItem.ToString();
            lblInvNumValue.Text = comboBox1.SelectedItem.ToString();
            lvProducts.Items.Clear();
            gboOrderStatus.Visible = false;
          
        }

   
    
        public PurchaseOrderDisplay()
        {
            InitializeComponent();
            loadPO_IDs();
            //    comboBox1.SelectedIndex = 0;
        }
 
    }
}
