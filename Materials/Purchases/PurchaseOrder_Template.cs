using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Purchases
{
    public partial class PurchaseOrder_Template : HAWK_Template_2
    {
        

        //const string DELIVERY_TABLE_NAME = "Deliveries";
        //const string DELIVERY_DETAILS_TABLE_NAME = "DeliveryDetails";
        public PurchaseOrder_Template()
        {
            InitializeComponent();
        }
        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            //  this.Close();
            PurchaseOrder_List listObjs = new PurchaseOrder_List(base.ident); listObjs.Show();

        }
        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            // this.Close();
            PurchaseOrderDisplay dispObj = new PurchaseOrderDisplay(base.ident); dispObj.Show();

        }

        private void button_ChangeObject_Click_1(object sender, EventArgs e)
        {
           // new Purchases.CreatePurchaseOrder(base.ident).Show();
        }
    }
}
