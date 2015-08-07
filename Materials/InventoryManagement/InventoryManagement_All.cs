using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class InventoryManagement_All : Inventory_New_Template
    {
        public InventoryManagement_All()
        {
            InitializeComponent();
        }



        public InventoryManagement_All(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();

            
        }

        private void button_AllInventory_Click(object sender, EventArgs e)
        {
            //HAWK_Template_5 ();
           // NewApplication.NewApplication_Main newapp = new NewApplication.NewApplication_Main(base.ident); newapp.Show();
            InventoryManagement.InventoryManagement_List t5 = new InventoryManagement.InventoryManagement_List(ident);
            t5.Show();
            
            

         
        }

        private void InventoryManagement_All_Load(object sender, EventArgs e)
        {

        }

        private void buttonCreateShippingDocument_Click(object sender, EventArgs e)
        {


          //  InventoryManagement.ShippingDoc t6 = new InventoryManagement.ShippingDoc(ident);

            InventoryManagement.Inventory_product1 t6 = new InventoryManagement.Inventory_product1(ident);
            t6.Show();

        }

        private void button_UpdateInventoryLevels_Click(object sender, EventArgs e)
        {
           
           Utilities.Documents.DisplaySelectedObject t6 = new Utilities.Documents.DisplaySelectedObject();
          t6.Show();




        }
    }
}
