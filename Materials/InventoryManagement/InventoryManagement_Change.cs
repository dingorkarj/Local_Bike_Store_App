using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class InventoryManagement_Change : Inventory_New_Template
    {
        public InventoryManagement_Change()
        {
            InitializeComponent();

        }
        public InventoryManagement_Change( IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }
       
        
       
        

        private void button1_Click(object sender, EventArgs e)
        {

            InventoryManagement.ShippingDoc t6 = new InventoryManagement.ShippingDoc(ident);
            t6.Show();
        }
       

        private void button2_Click_1(object sender, EventArgs e)
        {
            InventoryManagement.Update_Inventory t6 = new InventoryManagement.Update_Inventory();
            t6.Show();
        }
    }

}
