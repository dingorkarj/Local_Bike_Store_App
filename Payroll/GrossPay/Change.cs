using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Payroll
{
    public partial class Change : Payroll.Payroll_Template
   {
       GenDoc myDoc;
        DataTable  _documentValues;
        List<String> _documentList;
        int _documentNum, _documentType;
        public Change(IdentityObject _ident, string cmd, string tableName)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            textBox_Cmd.Text = cmd;
            textBox_TableName.Text = tableName;
            LoadBBasicDocInfo();
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }
        public Change(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            LoadBBasicDocInfo();
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();

        }
        public Change()
        {
            InitializeComponent();
            LoadSelectionInfo();
            LoadBBasicDocInfo();
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }
        public void LoadBBasicDocInfo()
        { string cmd = String.Format( textBox_Cmd.Text  );
           _documentList = Utilities.DataBaseUtility.GetList( cmd );
           for (int i = 1; i < _documentList.Count; i++)
           {

               string[] items = _documentList[i].Split(',');
               comboBox1.Items.Add(items[0] + " , " + items[1] + " , " + items[i][2]);
           }
        }
        public Change(IdentityObject _ident, string _docType, string _docNum, string tablename)
        {
            InitializeComponent();
            base.ident = _ident;
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
            //   LoadSelectionInfo(_docType, _docNum, tablename );
            textBox_TableName.Text = tablename;
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_DataStrings.Visible = true;
               LoadBBasicDocInfo();
            button_GetDoc_Click(this, null);
        }
        public Change(IdentityObject _ident, string _cmd, string tablename, string _docNum,string _docType, string type)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
            textBox_Cmd.Text = _cmd;
            textBox_TableName.Text = tablename;
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_DataStrings.Visible = true;
            //LoadSelectionInfo(_docType, _docNum);
            LoadBBasicDocInfo();
          //  button_GetDocument_Click(this, null);
            if (type == "view")
            {
                button_approve.Visible = false;
            }
            else if (type == "approve")
            {
                button_approve.Visible = true;
            }
            button_GetDoc_Click(this, null);
        }

        protected void LoadSelectionInfo()
        {
            LoadSelectionInfo("0", "0");
        }
         protected void LoadSelectionInfo(string _docType, string _docNum)
         {try
            {
                string part1 = " select DocNum, DocType, comments from   " + textBox_TableName.Text;
                string part2 = "";
                string part3 = "";

                if ((_docType != "*") && (_docType != "0") ) part2 = " where DocType = " + _docType ;
                if ((_docNum != "*"))
                {
                   part3 = " and DocNum = " + _docNum;
                }
                string cmdStr = part1 + part2 + part3;
                textBox_Cmd.Text = cmdStr;
                _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr );
                for (int i = 1; i < _documentValues.Rows.Count; i++)
                {
                    comboBox1.Items.Add(_documentValues.Rows[i][0].ToString() + " , " + _documentValues.Rows[i][1].ToString()
                                     + " , " + _documentValues.Rows[i][2].ToString());
                }
                textBox_DocNum.Text = _docNum;
                textBox_DocType.Text = _docType ;
                button_GetDoc_Click(this, null);
            }
            catch (Exception ex1)
            {
                MessageBox.Show(" cant read file :  " + textBox_TableName.Text + "   " + ex1.Message);
            }
        }
     
        private void ResetBoxes()
        {
           // textBox_DocNumber.Text = "";
           // textBox_DocType.Text = "";
            textBox_manID.Text = "";
            textBox_empID.Text = "";
            textBox_startDate.Text = "";
            textBox_endDate.Text = "";
            textBox_docRef.Text = "";
            textBox_approve.Text = "";
        
        }
           
        

        //protected void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
       


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string pStr2 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string pStr4 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            int pType = Int32.Parse(pStr2);
        }

        private void button_DisplayRawData_Click(object sender, EventArgs e)
        {
            listBox_DataStrings.Visible = true;

        }

        private void button_HideRawData_Click(object sender, EventArgs e)
        {
            listBox_DataStrings.Visible = false ;

        }

        //private void button_Save_Click(object sender, EventArgs e)
        //{
        //    // string retMessage = myDoc.SaveDocument(base.ident, textBox_TableName.Text, textBox_DocumentID.Text, textBox_DocType.Text, myData);
        //}

        //private void button_Delete_Click(object sender, EventArgs e)
        //{
           
        //}

        //private void button_AddDetailItem_Click(object sender, EventArgs e)
        //{
        //    MessageBox.Show("are you sure that you want to delete ?");
        //    //  if (response == "yes")
        //    //   Utilities.DataBaseUtility.DeleteDocument(textBox_DocumentID.Text, textBox_DocType);
    
        //}

        protected override  void button_ChangeObject_Click(object sender, EventArgs e)
        {
            Change app = new Change(base.ident); app.Show();
        }

        //private void button_ValidateData_Click(object sender, EventArgs e)
        //{
            
        //}

        //private void button_ResetCommand_Click(object sender, EventArgs e)
        //{
           
         
        //}

        //private void button_LoadOptions_Click(object sender, EventArgs e)
        //{
            
        //}

        private void button_approve_Click(object sender, EventArgs e)
        {
            if (textBox_approve.Text=="False")
                textBox_approve.Text = "True";
            else
                textBox_approve.Text = "False";
        }

        private void button_GetDoc_Click(object sender, EventArgs e)
        {
            {
                // try
                // {
                _documentNum = Int32.Parse(textBox_DocNum.Text);
                _documentType = Int32.Parse(textBox_DocType.Text);
                panel1.Visible = true;
                string cmdStr = string.Format(" select * from {0} where DocType = {1} and DocNum = {2} ",
                                                    textBox_TableName.Text, _documentType, _documentNum);
                //    List<string> myData = Utilities.DataBaseUtility.GetDocumentData(textBox_TableName.Text, _documentType, _documentNum);
                List<string> myData = Utilities.DataBaseUtility.GetDocumentData(textBox_Cmd.Text);
                if (myData.Count < 2)
                {
                    MessageBox.Show("can't find document for : " + cmdStr);
                }
                myData.RemoveAt(0);
                myDoc = new GenDoc(myData);
                //  string cmdStr = "select * from GenDocs " +
                //           String.Format("where docNum = {0} and docType = {1}", _documentID, _documentType);
                textBox_DataStrings.Text = myData[0];

                //List<string> _records = Utilities.DataBaseUtility.GetList(cmdStr);
                listBox_DataStrings.Items.Clear();
                listBox_DataStrings.Items.Add(myData[0]);
                string[] fields = myData[0].Split(',');
                textBox_status.Text = fields[0].ToString();
                int docNumber = Int32.Parse(textBox_status.Text);
                textBox_DocType.Text = fields[1].ToString();
                textBox_empID.Text = fields[2].ToString();
                textBox_manID.Text = fields[3].ToString();
                textBox_docRef.Text = fields[4].ToString();

                textBox_status.Text = fields[5].ToString();
                textBox_startDate.Text = fields[6].ToString();
                textBox_endDate.Text = fields[7].ToString();     
                textBox_workHours.Text = fields[8].ToString();     
                textBox_overTime.Text = fields[9].ToString();     
                textBox_approve.Text = fields[10].ToString();
                textBox_comments.Text = fields[11].ToString();
                string cmdStr2 = String.Format("select * from {0} where docNum = {1} and doctype = {2}",
                           textBox_TableName.Text.Trim(), _documentNum, _documentType);
                _documentValues = Utilities.DataBaseUtility.GetTable(cmdStr2);
                dataGridView1.DataSource = _documentValues;
                myData = Utilities.DataBaseUtility.GetList(cmdStr2);
                if (myData.Count < 3) return;
                
                for (int i = 1; i < myData.Count; i++)
                {

                    textBox_DataStrings.Text += "\r\n" + myData[i];
                    listBox_DataStrings.Items.Add(myData[i]);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] fields = comboBox1.SelectedItem.ToString().Split(',');
            textBox_DocNum.Text = fields[0];
            textBox_DocType.Text = fields[1];
            panel1.Visible = false;
            ResetBoxes();

            string cmdStr = String.Format("select * from {0} where docNum = {1} and DocType = {2}",
                                 textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text);
            textBox_Cmd.Text = cmdStr;
        }

        private void button_LoadOptions_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            _documentList = Utilities.DataBaseUtility.GetList(textBox_Cmd.Text);
            for (int i = 1; i < _documentList.Count; i++)
            {
                string[] fields = _documentList[i].Split(',');
                comboBox1.Items.Add(fields[0] + " , " + fields[1] + " , " + textBox_TableName.Text + " , " + fields[10]);
            }
            String tmp = listBox_DataStrings.Items.IndexOf(0).ToString();

        }

        private void button_ResetCommand_Click(object sender, EventArgs e)
        {
            string _docType = textBox_DocType.Text;
            string _docNum = textBox_DocNum.Text;
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

        private void button_ValidateData_Click(object sender, EventArgs e)
        {
            List<string> datastrings = new List<string>();
            listBox_DataStrings.Items.Clear();
            StringBuilder dataString1 = new StringBuilder();
            dataString1.Append(textBox_DocNum.Text + " ,");
            dataString1.Append(textBox_DocType.Text + " ,");
            dataString1.Append(textBox_empID.Text + " ,");
            dataString1.Append(textBox_manID.Text + " ,");
            dataString1.Append(textBox_docRef.Text + " ,");
            dataString1.Append(textBox_status.Text + " ,");
            dataString1.Append("'" + textBox_startDate.Text + "' ,");
            dataString1.Append("'" + textBox_endDate.Text + "' ,");
            dataString1.Append(textBox_workHours.Text + " ,");
            dataString1.Append(textBox_overTime.Text + " ,");
            dataString1.Append(textBox_approve.Text.Trim() + ",");
            dataString1.Append("'" + textBox_comments.Text + "'");
            Console.WriteLine(dataString1.ToString());

            listBox_DataStrings.Items.Add(dataString1.ToString());
            datastrings.Add(dataString1.ToString());
            int lastrow = dataGridView1.Rows.Count - 1;
            for (int i = 0; i < lastrow; i++)
            {
                StringBuilder dataString2 = new StringBuilder();
                dataString2.Append(dataGridView1.Rows[i].Cells[0].Value.ToString());
                for (int j = 1; j < 11; j++)
                    dataString2.Append(" ," + (dataGridView1.Rows[i].Cells[j]).Value.ToString());
                dataString2.Append(" ,'" + (dataGridView1.Rows[i].Cells[11]).Value.ToString() + "'");
                listBox_DataStrings.Items.Add(dataString2.ToString());
                datastrings.Add(dataString1.ToString());

            }
            GenDoc testObject = new GenDoc(datastrings);
            int returnValue = testObject.CheckValues(datastrings);
            string[] fieldNames = {"DocNumber","DocType","Employee ID(IntRef)","Manager ID(ExtRef)","Status","DocRef",
                                   "Period Start Date","Period End Date","Work Hours","Overtime","Approval","Comments"};
            if (returnValue > 0)
            {
                int indx = returnValue;
                string[] fields = datastrings[0].Split(',');
                string errorMessage = string.Format(" Error in {0}. \r\n \r\n Error in field {1}. \r\n Value {2} is not valid", textBox_TableName.Text, fieldNames[indx], fields[indx]);
                MessageBox.Show(errorMessage);
            }
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure that you want to save ?", "Verify Operation",
                           MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dr == DialogResult.No)
            {
                MessageBox.Show(" Operation Cancelled by user ");
                return;
            }
            //   (response == "yes") 
            //string _tableName = textBox_TableName.Text;
            //List<string> myData = new List<string>();
            ////for (int i = listBox_DataStrings.Items.Count-1; i >0 ; i--)
            //Console.WriteLine(listBox_DataStrings.Items[0].ToString());
            //Console.WriteLine(listBox_DataStrings.Items[1].ToString());
            //    myData.Add(listBox_DataStrings.Items[0].ToString());
            //int myDataCount = myData.Count;
            //int retcode = myDoc.SaveDocument(base.ident, _tableName, textBox_DocNum.Text, textBox_DocType.Text, myData);
            String upCMD ="update " + textBox_TableName.Text +" set IntRef= "+ textBox_empID.Text 
                                                      +", ExtRef = "+ textBox_manID.Text
                                                      +", Status = "+ textBox_status.Text
                                                      +", DocRef = "+ textBox_docRef.Text
                                                      //+", Payperiod_Startdate ="+ textBox_startDate.Text
                                                      //+", Payperiod_Enddate ="+ textBox_endDate.Text
                                                      +", work_hours ="+ textBox_workHours.Text
                                                      +", over_time ="+ textBox_overTime.Text
                                                      +", Approval ="+ textBox_approve.Text
                                                      +", Comment = '"+ textBox_comments.Text +"'"
                                                      +" where Docnum = "+ textBox_DocNum.Text ;
            //Console.WriteLine(upCMD);
            DataTable update = Utilities.DataBaseUtility.GetTable(upCMD);

            String upProcess = "update ProcessDocs set IntRef= " + textBox_empID.Text
                                                      + ", ExtRef = " + textBox_manID.Text
                                                      + ", Status = " + textBox_status.Text
                                                      + ", DocRef = " + textBox_docRef.Text
                                                      + ", TextValue1 = '" + textBox_startDate.Text+"'"
                                                      + ", TextValue2 = '" + textBox_endDate.Text + "'" 
                                                      + ", NumValue1 =" + textBox_workHours.Text
                                                      + ", NumValue2 =" + textBox_overTime.Text
                                                      + ", comments = '" + textBox_comments.Text + "'"
                                                      + " where DocNum = " + textBox_DocNum.Text
                                                      + " and DocType = " + textBox_DocNum.Text;
            DataTable dtProcessDoc = Utilities.DataBaseUtility.GetTable(upProcess);
                      
            button_GetDoc_Click(this, null);
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("are you sure that you want to delete ?");
            if (dr == DialogResult.No)
            {
                MessageBox.Show(" Operation Cancelled by user ");
                return;
            }
            //  if (response == "yes")
            Utilities.DataBaseUtility.DeleteDocument(base.ident, textBox_TableName.Text, textBox_DocNum.Text, textBox_DocType.Text);
            this.Close();
        }


    }
}

