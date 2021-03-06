﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Display : Payroll.Payroll_Template
    {
        
        List<String>  _documentValues;
        int DocumentID, DocumentType;
        string cmdStr;
        string _type;
        public Display(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent( _ident);
            LoadBBasicDocInfo();
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
            
        }
        public Display()
        {
            InitializeComponent();
            LoadSelectionInfo();
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
   //         LoadBBasicDocInfo();
        }
        public void LoadBBasicDocInfo()
        {
            string cmd = " select DocNum, DocType, TableName, comments from ProcessDocs";
            _documentValues = Utilities.DataBaseUtility.GetList(cmd);
            for (int i = 1; i < _documentValues.Count; i++)
            {
                string[] fields = _documentValues[i].Split(',');
                comboBox1.Items.Add(fields[0] + " , " + fields[1] + " , " + fields[2] + " , " + fields[3]);
            }
        }
        public void LoadBBasicDocInfo_SpecificType(string _tableName, string _type)
        {
            string cmd = " select DocNum, DocType, comments from ProcessDocs where DocType = " + _type ;
            comboBox1.Items.Clear();
            _documentValues = Utilities.DataBaseUtility.GetList(cmd );
            for (int i = 1; i < _documentValues.Count; i++)
            {
                string[] fields = _documentValues[i].Split(',');
                comboBox1.Items.Add(fields[0] + " , " + fields[1] + " , " + _tableName + " , " + fields[2]);
            }
        }
        public   Display(IdentityObject _ident, string _tableName, string _docType, string _docNum, String type)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
            base.DisplayIdent(_ident);
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_TableName.Text = _tableName;
            LoadSelectionInfo(_tableName, _docType, _docNum);
            button_LoadSelectionList_Click(this, null);
            if (type=="view")
            {
                _type = "view";
                button_approve.Visible = false;
            }
            else if(type=="approve")
            {
                _type = "approve";
                button_approve.Visible = true;
            }
            button_DisplayDoc_Click(this,null);
        }

        protected void LoadSelectionInfo()
        {
            LoadSelectionInfo("ProcessDocs", "*", "*");
        }
         protected void LoadSelectionInfo(string _tableName, string _docType, string _docNum)
         {try
            {
                textBox_DocNum.Text = _docNum;
                textBox_DocType.Text = _docType ;
                textBox_TableName.Text = _tableName;
                 button_ResetCommand_Click_1(this, null);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(" cant read 'GenDocs' table; " + ex1.Message);
            }
        }
     
        private void ResetBoxes()
        {
             textBox_manID.Text = "";
            textBox_empID.Text = "";
            textBox_startDate.Text = "";
            textBox_endDate.Text = "";
            textBox_docRef.Text = "";
            textBox_approval.Text = "";
        
        }
        

        protected void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fields = comboBox1.SelectedItem.ToString().Split(',');
            textBox_DocNum.Text = fields[0];
            textBox_DocType.Text = fields[1];
            textBox_TableName.Text = fields[2];
            panel1.Visible = false;
            DocumentID = Int32.Parse(textBox_DocNum.Text);
            DocumentType = Int32.Parse(textBox_DocType.Text);
            string cmdStr =  String.Format("select * from  {0} where docNum = {1} and doctype = {2}",
                                                textBox_TableName.Text, DocumentID,      DocumentType);
            textBox_Cmd.Text = cmdStr;
            ResetBoxes();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pStr2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string pStr4 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            int pType = Int32.Parse(pStr2);
        }

        private void button_DisplayRawData_Click(object sender, EventArgs e)
        {
            textBox_DataStrings.Visible = true;

        }

        private void button_HideRawData_Click(object sender, EventArgs e)
        {
            textBox_DataStrings.Visible = false ;

        }

       
        private void button_approve_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Do you want to approval this time card ?", "Verify Operation",
                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                MessageBox.Show(" Operation Cancelled by user ");
                return;
            }
            String CMD = "update emp_time_card set Approval = 1 where DocNum =" + textBox_DocNum.Text;
            DataTable utable = Utilities.DataBaseUtility.GetTable(CMD);
            button_DisplayDoc_Click(this, null);
        }

        private void button_DisplayDoc_Click(object sender, EventArgs e)
        {
            List<string> _records = new List<string>();
            try
            {
                Console.WriteLine(textBox_Cmd.Text);
                //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                _records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
                Console.WriteLine(_records);
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
            textBox_DataStrings.Text = _records[0];
            string[] _documentValues = _records[0].Split(',');
            //dataGridView1.DataSource = _documentValues;
            textBox_DocNum.Text = _documentValues[0].ToString();
            int docNumber = Int32.Parse(textBox_DocNum.Text);
            textBox_DocType.Text = _documentValues[1].ToString();
            int docType = Int32.Parse(textBox_DocType.Text);
            textBox_empID.Text = _documentValues[2].ToString();
            textBox_manID.Text = _documentValues[3].ToString();
            textBox_docRef.Text = _documentValues[4].ToString();
            // string tablename = "GenDocs";
            textBox_status.Text = _documentValues[5].ToString();
            textBox_startDate.Text = _documentValues[6].ToString();
            textBox_endDate.Text = _documentValues[7].ToString();
            textBox_workHours.Text = _documentValues[8].ToString();
            textBox_overTime.Text = _documentValues[9].ToString();
            textBox_approval.Text = _documentValues[10].ToString();
            textBox_comments.Text = _documentValues[11].ToString();
            string cmdStr2 = String.Format("select * from {0} where docNum = {1} and doctype = {2}",
                                             textBox_TableName.Text.Trim(), docNumber, docType);
            _records = new List<string>();
            try
            {
                //  _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr);
                //_records = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
                _records = Utilities.DataBaseUtility.GetList(cmdStr2);
            }
            catch (Exception) { }

            //if (_records.Count < 2) return;
            //for (int i = 1; i < _records.Count; i++)
            //{
            //    DocDetailItem _detail = new DocDetailItem(_records[i]);
            //    textBox_DataStrings.Text += "\r\n" + _records[i];  // _detail.ToString();
            //}
            DataTable _documentTable = Utilities.DataBaseUtility.GetTable(cmdStr2);
            dataGridView1.DataSource = _documentTable;
            dataGridView1.Visible = true;
            panel1.Visible = true;
        }

        private void button_ResetCommand_Click_1(object sender, EventArgs e)
        {
            string _docType = textBox_DocType.Text.Trim();
            string _docNum = textBox_DocNum.Text.Trim();
            string part1 = " select * from  " + textBox_TableName.Text; ;
            string part2 = "";
            string part3 = "";

            if ((_docType != "*") && (_docType != " ") && (_docType != ""))
                part2 = " where DocType = " + _docType;
            if ((_docNum != "*") && (_docNum != " ") && (_docNum != ""))
            {
                if (part2 == "")
                    part3 = " where DocNum = " + _docNum;
                else part3 = " and DocNum = " + _docNum;
            }
            string cmdStr = part1 + part2 + part3;
            textBox_Cmd.Text = cmdStr;
               
        }

        private void button_LoadSelectionList_Click(object sender, EventArgs e)
           {
                //  LoadSelectionInfo(textBox_TableName.Text, textBox_DocType.Text, textBox_DocNum.Text);
                comboBox1.Items.Clear();
                _documentValues = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
                for (int i = 1; i < _documentValues.Count; i++)
                {
                    string[] fields = _documentValues[i].Split(',');
                    comboBox1.Items.Add(fields[0] + " , " + fields[1] + " , " + textBox_TableName.Text + " , " + fields[10]);
                }

            }

        private void button_ChangeDoc_Click_1(object sender, EventArgs e)
        {
            Change app = new Change(base.ident, textBox_Cmd.Text, textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text, _type); app.Show();
           // this.Close();
        }

        private void button_Return_Click_1(object sender, EventArgs e)
        {

        }
        

     

      
    }
}
