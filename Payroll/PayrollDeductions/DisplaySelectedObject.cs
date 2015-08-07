using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PayrollDeductions
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject()
        {
            InitializeComponent();
        }

        public DisplaySelectedObject(IdentityObject ident)
        {
            InitializeComponent();
            textBox_TableName.Text = "EmployeePayrollDeduction";
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }
        public DisplaySelectedObject(IdentityObject _ident, string _tableName, string _docType, string _docNum)
        {

            InitializeComponent();
            //  MessageBox.Show("In constructor");
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_DocNum.Text = _docNum;

            textBox_DocType.Text = _docType;
            textBox_TableName.Text = _tableName;
            LoadSelectionInfo(_tableName, _docType, _docNum);
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);
          }

        private void button_ListObjects_Click_1(object sender, EventArgs e)
        {

        }

    }
}
