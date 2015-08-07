using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Materials
{
    public partial class Materials_Main : Materials_Template
    {
        public Materials_Main()
        {
            InitializeComponent();
        }
        public Materials_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //new Materials.LowMaterials_List(base.ident).Show();
          //  new Purchases.PurchaseOrder_Main(base.ident).Show();
            Purchases.PurchaseOrder_Main newApp = new Purchases.PurchaseOrder_Main(base.ident);
            newApp.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InventoryManagement.InventoryManagement_All  newapp = new InventoryManagement.InventoryManagement_All (ident);
            newapp.Show();
        }

        
    }
}
