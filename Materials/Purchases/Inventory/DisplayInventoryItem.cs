using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Purchases
{
    public partial class DisplayInventoryItem : Purchases.PurchaseOrder_Template 
    {

        DataTable _productValues;
        DataTable _detailValues;
        IdentityObject _ident;
        InventoryItem item;
        public DisplayInventoryItem(IdentityObject in_ident)
        {
            InitializeComponent();
            _ident = in_ident;
            base.ident = in_ident;
            label_Ident.Text = _ident.UserID.ToString() + " :  " + _ident.UserName; 
        }
        public DisplayInventoryItem(IdentityObject in_ident, string _productID)
        {
            InitializeComponent();
            label_SubName.Text = "Display Low Inventory - Product";
            _ident = in_ident;
            textBox0.Text = _productID;
            label_Ident.Text = _ident.UserID.ToString() + " :  " + _ident.UserName;
            button1_Click(this, null);
        }

      
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBoxes()
        {
            textBox_SupplierID.Text = "";
            textBox_Maker.Text = "";
            textBox_Model.Text = "";
            textBox_MinQuantity.Text = "";
            textBox_OnHand.Text = ""; 
            textBox_InventoryValue.Text = "";
       
        }
            private void button1_Click(object sender, EventArgs e)
        {

            List<string> invValues = Utilities.DataBaseUtility.GetList("select InvID,12,SupplierID,Max,Min,OnHand,Category,year,Price,UnitCost,ProductName,ProductID from " + PODConstants.INVENTORY_LIST + " where productID = " + textBox0.Text);
            
            if (invValues != null && invValues.Count < 2)
            {
                MessageBox.Show("Inventory item not found");
                return;
            }
            item = new InventoryItem(invValues[1]);

            List<string> _productValues = Utilities.DataBaseUtility.GetList("select Maker, Model from Products where productID = " + textBox0.Text);
            if (_productValues != null && _productValues.Count >= 2)
            {
                string strProduct = _productValues[1];
                string[] strMakerModel = strProduct.Split(',')
                                        .Select(s => s.Trim())
                                        .Where(s => s != String.Empty)
                                        .ToArray();
                
                textBox_Maker.Text = strMakerModel[0];
                textBox_Model.Text = strMakerModel[1];
            }
            textBox_SupplierID.Text = item.Supplier.ToString();
            textBox_MinQuantity.Text = item.MinQuantity.ToString();
            textBox_OnHand.Text = item.OnHand.ToString();
            textBox_InventoryValue.Text = item.Cost.ToString();
            textBox_category.Text = item.Category; 
            textBox_year.Text = item.Year.ToString();

            }

        

        private void button_Order_Click(object sender, EventArgs e)
        {
            Purchases.CreatePurchaseOrder newapp = new Purchases.CreatePurchaseOrder(ident, item);
            this.Close();
            newapp.Show();
        }

        
      
     }
}
