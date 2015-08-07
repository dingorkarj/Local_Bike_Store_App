using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Account_Payable
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject()
        {
            InitializeComponent();
        }
        public DisplaySelectedObject(IdentityObject iden)
        {
            InitializeComponent();
            textBox_TableName.Text = "Acc_Payable";
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);
            base.SaveIdent(iden);
            base.DisplayIdent(iden);
        }
        public DisplaySelectedObject(IdentityObject _iden,string _tableName,string _docType,string _docNum)
        {
            InitializeComponent();
            textBox_TableName.Text = _tableName;
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);
            base.SaveIdent(_iden);
            base.DisplayIdent(_iden);
        }
    }
}
