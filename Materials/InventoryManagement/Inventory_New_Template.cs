using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class Inventory_New_Template : HAWK_Template_2
    {
        public Inventory_New_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }
        public Inventory_New_Template()
        {
            InitializeComponent();
        }

        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {

            InventoryManagement.InventoryManagement_List t5 = new InventoryManagement.InventoryManagement_List(ident);
            t5.Show();
        }

        protected override void button_ChangeObject_Click(object sender, EventArgs e)
        {
            InventoryManagement.InventoryManagement_Change t4 = new InventoryManagement.InventoryManagement_Change();
            t4.Show();
        }
    }
}
