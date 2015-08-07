using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        public DisplaySelectedObject()
        {
            InitializeComponent();
            textBox_TableName.Text = "Sales_sm";
            		button_ResetCommand_Click(this, null);
            		button_LoadSelectionList_Click(this, null);

        }
        public DisplaySelectedObject(IdentityObject ident)
        {
            InitializeComponent();
          //  textBox_TableName.Text = "Sales_sm";
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }
        public DisplaySelectedObject(IdentityObject _ident, string _tableName,
                                                  string _docType, string _docNum)
        {
            InitializeComponent();
           // textBox_TableName.Text = "Sales_sm";
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_TableName.Text = _tableName;
            LoadSelectionInfo(_tableName, _docType, _docNum);
            button_LoadSelectionList_Click(this, null);
        }

        private void button_DisplayDoc_Click(object sender, EventArgs e)
        {
            //DataTable dt1 = Utilities.DataBaseUtility.GetTable(textBox_Cmd.Text);
            //dataGridView2.DataSource = dt1;
            List<string> _records = new List<string>();
            try
            {
                //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                _records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("  error in reading table : " + textBox_TableName.Text, ex.Message);
                return;
            }
            if (_records.Count < 2)
            {
                MessageBox.Show("  error in reading table : " + textBox_TableName.Text);
                return;
            } _records.RemoveAt(0);
          //  textBox_DataStrings.Text = _records[0];
            string[] _documentValues = _records[0].Split(',');
            //dataGridView1.DataSource = _documentValues;
            textBox_DocNum.Text = _documentValues[0].ToString();
            int docNumber = Int32.Parse(textBox_DocNum.Text);
            textBox_DocType.Text = _documentValues[1].ToString();
            int docType = Int32.Parse(textBox_DocType.Text);
            textBox_ExtAgent.Text = _documentValues[2].ToString();
            textBox_IntAgent.Text = _documentValues[3].ToString();
            textBox_Status.Text = _documentValues[4].ToString();
            // string tablename = "GenDocs";
            textBox_ProcessID.Text = _documentValues[5].ToString();
            textBox_TextValue1.Text = _documentValues[6].ToString();
            textBox_TextValue2.Text = _documentValues[7].ToString();     //  StatusDate
            textBox_NumValue1.Text = _documentValues[8].ToString();     //  quotedAmount 
            textBox_NumValue2.Text = _documentValues[9].ToString();     //  actualAmount
            textBox_Comment.Text = _documentValues[10].ToString();
            string cmdStr2 = String.Format("select * from {0}_Details where docNum = {1} and doctype = {2}",
                                         textBox_TableName.Text.Trim(), docNumber, docType);
            _records = new List<string>();
            try
            {
                //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                //_records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
                _records = Utilities.DataBaseUtility.GetList(cmdStr2);
            }
            catch (Exception) { }

            if (_records.Count < 2) return;
            for (int i = 1; i < _records.Count; i++)
            {
                DocDetailItem _detail = new DocDetailItem(_records[i]);
           //    textBox_DataStrings.Text += "\r\n" + _records[i];  // _detail.ToString();
            }
            DataTable _documentTable = Utilities.DataBaseUtility.GetTable(cmdStr2);
            dataGridView2.DataSource = _documentTable;
            dataGridView2.Visible = true;
            //panel1.Visible = true;
        }	


    }
}
