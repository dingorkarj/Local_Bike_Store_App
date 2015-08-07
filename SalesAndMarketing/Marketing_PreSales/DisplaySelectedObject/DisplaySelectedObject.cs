using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndMarketing
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject()
        {
            InitializeComponent();
            textBox_TableName.Text = "SalesAndMarketing";
            button_LoadSelectionList_Click(this, null);
        }
        public DisplaySelectedObject(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }
        public DisplaySelectedObject(IdentityObject _ident,string _tableName,string _docType, string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_TableName.Text = _tableName;
            LoadSelectionInfo(_tableName,_docType,_docNum);
            button_LoadSelectionList_Click(this,null);
        }
    }
}
