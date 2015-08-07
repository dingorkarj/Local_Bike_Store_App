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
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        IdentityObject _ident;
        InventoryItem item;
        public DisplaySelectedObject()
        {
            InitializeComponent();
        }

        public DisplaySelectedObject(IdentityObject ident)
        {    
            InitializeComponent();
            textBox_TableName.Text = PODConstants.INVENTORY_LIST;
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);
            label_SubName.Text = "Display Low Inventory";
            
           
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        
        }

        public DisplaySelectedObject(IdentityObject _ident, string _tableName, 
                                                  string _docType,  string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            ident = _ident;
            label_SubName.Text = "Display Low Inventory - Product";
            button_DisplayDoc.Text = "Display Product";
            button_ChangeDoc.Visible = false;
            textBox_DocNum.Text = _docNum;
            textBox_TableName.Text = _tableName;
            label_TextValue1.Text = "Category";
            label10.Text = "Year";
            label_IntAgent.Text = "Max";
            label_ProcNum.Text = "Min";
            label7.Text = "On Hand";
            textBox_Cmd.Text = "Select DocNum,DocType,ExtRef,Max,Min,OnHand,Category,year,Price,UnitCost,Comments from " + PODConstants.INVENTORY_LIST + " Where DocNum = " + _docNum;
            var _records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
            if (_records == null || _records != null && _records.Count < 2)
               return;
            item = new InventoryItem(_records[1]);

            //comment the below code after new db changed invid as integer;
            //button_DisplayDoc.Visible = false;
            //textBox_DocNum.Text = item.InvID;
            //textBox_DocType.Text = "12";
            //textBox_ExtAgent.Text = item.Supplier.ToString();
            //textBox_IntAgent.Text = item.MaxQuantity.ToString();
            //textBox_Status.Text = item.MinQuantity.ToString();
            //textBox_ProcessID.Text = item.OnHand.ToString();
            //textBox_TextValue1.Text = item.Category;
            //textBox_TextValue2.Text = item.Year.ToString(); //  StatusDate
            //textBox_NumValue1.Text = item.Price.ToString();    //  quotedAmount 
            //textBox_NumValue2.Text = item.Cost.ToString();    //  actualAmount
            
        }




        private void button2_Click(object sender, EventArgs e)
        {
            Purchases.CreatePurchaseOrder newapp = new Purchases.CreatePurchaseOrder(ident, item);
            this.Close();
            newapp.Show();
        }

        


    }
}
