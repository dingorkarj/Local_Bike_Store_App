using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Purchases
{
    public partial class PurchaseOrder_Main : PurchaseOrder_Template
    {
        public PurchaseOrder_Main()
        {
            InitializeComponent();
        }
        public PurchaseOrder_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new Purchases.LowMaterials_List(base.ident).Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new Purchases.PurchaseOrder_List(base.ident).Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new Purchases.Deliveries_List(base.ident).Show();
        }

        private void button_ChangeObject_Click_1(object sender, EventArgs e)
        {
            //
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Utilities.Suppliers_List(base.ident).Show();
        }

        private void button_ProcessDocs_Click(object sender, EventArgs e)
        {
            new Utilities.Documents.ListObjects(base.ident, "processDocs", "11").Show();
        }

       
       
    }
}
