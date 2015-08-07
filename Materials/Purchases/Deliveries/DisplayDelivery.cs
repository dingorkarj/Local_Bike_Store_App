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
    public partial class DisplayDelivery : Deliveries_Template 
    {
       // IdentityObject ident;
        public string CustomerEmailAddress;
        List<String> _product_Names;


        public DisplayDelivery(IdentityObject _ident)
        {
            InitializeComponent();
            ident = _ident;
            LoadDelivery();
            //    comboBox1.SelectedIndex = 0;
        }
        public DisplayDelivery(IdentityObject _ident, string docNumber)
        {
            InitializeComponent();
            ident = _ident; 
            LoadDelivery();
            textBox_DocNumber.Text = docNumber ;
            button_Display_Click(this, null);
        }

        DataTable detailsTable;
        private void cmdSearch_Click(object sender, EventArgs e)
        {
            ClearDelivery();
        }


        private void ClearDelivery()
        {
            while (lvProducts.Items.Count > 0)
            {
                lvProducts.Items.Remove(lvProducts.Items[0]);
            }

        }

        private void LoadDelivery()
        {

         //   int poNum;
            Delivery _order = new Delivery();

            List<string> _ids = Utilities.DataBaseUtility.GetList("Select DocNum from " + PODConstants.DELIVERY_TABLE_NAME + " Where DocType = 13"); //order by PurchasOrderID");
            comboBox1.Items.Clear();
            for (int i =1; i< _ids.Count; i++)
                comboBox1.Items.Add(_ids[i]);
        }
        private void button_Display_Click(object sender, EventArgs e)
        {
            try
            {

                Delivery _order = new Delivery();
                string _cmd = "Select * from " + PODConstants.DELIVERY_TABLE_NAME + " WHERE DocNum = " + textBox_DocNumber.Text + " and DocType = 13";
                DataTable _table = Utilities.DataBaseUtility.GetTable(_cmd);
                dataGridView1.DataSource = _table;
                string _supplierID = "3";
                if (_table != null && _table.Rows != null && _table.Rows.Count > 0)
                    _supplierID = _table.Rows[0][2].ToString();
                string supplierCmd = "Select * from suppliers WHERE supplierID = " + _supplierID;
                DataTable supplierTable = Utilities.DataBaseUtility.GetTable(supplierCmd);
                dataGridView2.DataSource = supplierTable;
                string detailsCmd = "Select * from " + PODConstants.DELIVERY_DETAILS_TABLE_NAME + " WHERE DocNum = " + Convert.ToInt32(textBox_DocNumber.Text) + " and DocType = 13";
                detailsTable = Utilities.DataBaseUtility.GetTable(detailsCmd);
                gboOrderStatus.Visible = true;

                _order = _order.GetDelivery(Convert.ToInt32(textBox_DocNumber.Text));
                string _supplierName = Convert.ToString(supplierTable.Rows[0]["Name"]);
                string _supplierAddress = Convert.ToString(supplierTable.Rows[0]["Address"]);
                string _supplierAddress2 = Convert.ToString(supplierTable.Rows[0]["City"]) + ", " + Convert.ToString(supplierTable.Rows[0]["State"]) + " " + Convert.ToString(supplierTable.Rows[0]["PostalCode"]);
                string _supplierPhone = Convert.ToString(supplierTable.Rows[0]["Phone"]);
                string _supplierEmail = Convert.ToString(supplierTable.Rows[0]["WebAddress"]);

                lblInvNumValue.Text = textBox_DocNumber.Text;    //_ Convert.ToString(_order.DeliveryID);
                //label_PO_Info.Text = _supplierName + "\r\n";  
                label_SupplierName.Text = _supplierName;
                label_SupplierAddr.Text = _supplierAddress;
                label_SupplierAddress2.Text = _supplierAddress2;
                lblPhone.Text = Convert.ToString(_supplierPhone);
                label_ShipName.Text = "Local Bikes";
                label_ShippingAddr2.Text = "2700 Bay Area Blvd";
                label_ShipAddress.Text = "Houston, TX, 77058";
                lblDateValue.Text = _order.PO_Date.ToShortDateString();
                label_SupplierEmail.Text = _supplierEmail;
                comboBox2.SelectedIndex = _order.Status;
                label_Status.Text = "Status: " + comboBox2.SelectedItem.ToString();
                label_deliverydate.Text = _order.DeliveryDate.ToShortDateString();
                gboOrderStatus.Visible = true;
                int recnbr1 = 0;
                double partsTotal = 0.0;  //           double partsTax = 0.0;
                lvProducts.Items.Clear();
                while (recnbr1 < detailsTable.Rows.Count)
                {
                    string productCode = detailsTable.Rows[recnbr1][2].ToString();
                    _product_Names = Utilities.DataBaseUtility.GetList("Select productName from products where productID = " + productCode);
                    ListViewItem lvi = lvProducts.Items.Add(productCode);  //detailsTable.Rows[recnbr1][1].ToString());
                    if (_product_Names.Count > 1 && _product_Names[1] != null)
                    {
                        lvi.SubItems.Add(_product_Names[1]);
                    }
                    //else
                    //{
                    //    MessageBox.Show("Please check the products and inventory data, the inventory product " + productCode + " not available in products table");
                    //}
                    //lvi.SubItems.Add(detailsTable.Rows[recnbr1][2].ToString());
                    double _price = Double.Parse(detailsTable.Rows[recnbr1][6].ToString());
                    double _quant = Double.Parse(detailsTable.Rows[recnbr1][5].ToString());
                    lvi.SubItems.Add(_quant.ToString());
                    lvi.SubItems.Add(string.Format("{0:C}", _price));
                    lvi.SubItems.Add(string.Format("{0:C}", 0.00));
                    double _total = _quant * _price;
                    lvi.SubItems.Add(string.Format("{0:C}", _total));

                    partsTotal += _total;    // order.POProdDetails[recnbr1].DetailProductLineTotal;
                    recnbr1++;
                }

                lblPartsSubTotalValue.Text = string.Format("{0:C}", partsTotal);

                // int recnbr2 = 0;
                // double serviceTotal = 0.0;


                lblShippingCostValue.Text = string.Format("{0:C}", partsTotal * .04);
                double _totalCost = partsTotal + partsTotal * .04;
                lblGrandTotalValue.Text = string.Format("{0:C}", _totalCost);

                // pnlService.Visible = true;

            }
            catch (Exception ex) { MessageBox.Show("Due to invalid or old data in Database, Application could not load the Delivery doc."); }
        }

       
        private void btnEmail_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("mailto:" + CustomerEmailAddress);

        }

        //private void button_Display_Click(object sender, EventArgs e)
        //{
        //    ClearDelivery();
        //    LoadDelivery();
    
        //}

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox_DocNumber.Text = comboBox1.SelectedItem.ToString();
            lblInvNumValue.Text = comboBox1.SelectedItem.ToString();
            lvProducts.Items.Clear();
            gboOrderStatus.Visible = false;
          
        }

        //private void button_Display_Click_1(object sender, EventArgs e)
        //{
        //    ClearDelivery();
        //    LoadDelivery();
  
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    clearDelivery();
        //    loadDelivery();
  
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            Deliveries_List app1 = new Deliveries_List(ident);
            app1.Show();
        }

        protected override  void button_ListObjects_Click(object sender, EventArgs e)
        {
            this.Close();
            Deliveries_List app1 = new Deliveries_List(ident);
            app1.Show();
         }

        protected override  void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            this.Close();
            DisplayDelivery disp = new DisplayDelivery(ident);
            disp.Show();
        }
    }
}
