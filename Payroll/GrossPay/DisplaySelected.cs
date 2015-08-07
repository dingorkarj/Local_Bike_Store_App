using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Payroll
{
    public partial class DisplaySelected : Utilities.Documents.DisplaySelectedObject
    {
    //    public DisplaySelected(IdentityObject identObject, String table, String docnum, String doctype)
    //    {
    //        InitializeComponent();
    //        base.SaveIdent(identObject);
    //        textBox_TableName.Text = table;
    //        textBox_DocNum.Text = docnum;
    //        textBox_DocType.Text = doctype;
    //        //this.button_DisplaySelectedObject_Click(object sender, EventArgs a);
    //        button_ResetCommand_Click(this, null);
    //        button_LoadSelectionList_Click(this, null);
    //    }
                public   DisplaySelected(IdentityObject _ident, string _tableName, string _docType, string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
           
            LoadBBasicDocInfo();
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();        
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_TableName.Text = _tableName;
            LoadSelectionInfo(_tableName, _docType, _docNum);
            //button_LoadSelectionList_Click(this, null);
        }
        public DisplaySelected(String table, String doctype,IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();        
            textBox_TableName.Text = table;
            
            textBox_DocType.Text = doctype;
            //this.button_DisplaySelectedObject_Click(object sender, EventArgs a);
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);
        }

        public DisplaySelected(String table, String docnum, String doctype)
        {
            InitializeComponent();

            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();        
            
            textBox_TableName.Text = table;
            textBox_DocNum.Text = docnum;
            textBox_DocType.Text = doctype;
            //this.button_DisplaySelectedObject_Click(object sender, EventArgs a);
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);
        }

        //private override void button_Display_Click(object sender, EventArgs e)
        //{
        //    List<string> _records = new List<string>();
        //    try
        //    {
        //        //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
        //        _records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("  error in reading table : " + textBox_TableName.Text, ex.Message);
        //        return;
        //    }
        //    if (_records.Count < 2)
        //    {
        //        MessageBox.Show("  error in reading table : " + textBox_TableName.Text);
        //        return;
        //    } _records.RemoveAt(0);
        //    //textBox_DataStrings.Text = _records[0];
        //    string[] _documentValues = _records[0].Split(',');
        //    //dataGridView1.DataSource = _documentValues;
        //    textBox_DocNum.Text = _documentValues[0].ToString();
        //    int docNumber = Int32.Parse(textBox_DocNum.Text);
        //    textBox_DocType.Text = _documentValues[1].ToString();
        //    int docType = Int32.Parse(textBox_DocType.Text);
        //    textBox_ExtAgent.Text = _documentValues[2].ToString();
        //    textBox_IntAgent.Text = _documentValues[3].ToString();
        //    textBox_Status.Text = _documentValues[4].ToString();
        //    // string tablename = "GenDocs";
        //    textBox_ProcessID.Text = _documentValues[5].ToString();
        //    textBox_TextValue1.Text = _documentValues[6].ToString();
        //    textBox_TextValue2.Text = _documentValues[7].ToString();     //  StatusDate
        //    textBox_NumValue1.Text = _documentValues[8].ToString();     //  quotedAmount 
        //    textBox_NumValue2.Text = _documentValues[9].ToString();     //  actualAmount
        //    textBox_Comment.Text = _documentValues[10].ToString();
        //    string cmdStr2 = String.Format("select * from {0}_Details where docNum = {1} and doctype = {2}",
        //                                 textBox_TableName.Text.Trim(), docNumber, docType);
        //    _records = new List<string>();
        //    try
        //    {
        //        //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
        //        //_records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
        //        _records = Utilities.DataBaseUtility.GetList(cmdStr2);
        //    }
        //    catch (Exception) { }

        //    if (_records.Count < 2) return;
        //    for (int i = 1; i < _records.Count; i++)
        //    {
        //        DocDetailItem _detail = new DocDetailItem(_records[i]);
        //        textBox_DataStrings.Text += "\r\n" + _records[i];  // _detail.ToString();
        //    }
        //    DataTable _documentTable = Utilities.DataBaseUtility.GetTable(cmdStr2);
        //    dataGridView1.DataSource = _documentTable;
        //    dataGridView1.Visible = true;
        //    panel1.Visible = true;
        //}
    }
}
