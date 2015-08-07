using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        private IdentityObject identityObject;

        public DisplaySelectedObject()
        {
            InitializeComponent();

            textBox_TableName.Text = "Training_Scheduling";
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);

            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public DisplaySelectedObject(IdentityObject identityObject)
        {
            // TODO: Complete member initialization
            this.identityObject = identityObject;
        }
        public DisplaySelectedObject(IdentityObject _ident, string _tableName,
                                                  string _docType, string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_TableName.Text = _tableName;
            LoadSelectionInfo(_tableName, _docType, _docNum);
            button_LoadSelectionList_Click(this, null);
        }

    }
}
