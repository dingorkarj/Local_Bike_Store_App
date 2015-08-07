using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Inventory_New_Main : Inventory_New_Template
    {
        public Inventory_New_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
            
        }
        public Inventory_New_Main()
        {
            InitializeComponent();
        }

        private void buttoninv_Click(object sender, EventArgs e)
        {
            InventoryManagement.InventoryManagement_All newapp = new InventoryManagement.InventoryManagement_All(ident);
            newapp.Show();
        }


    }
}
