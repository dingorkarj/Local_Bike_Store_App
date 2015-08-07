using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountsReceivable
{
    public partial class DisplaySelectedObject : Utilities.Documents.DisplaySelectedObject
    {
        int docNum = 0;
        int docType = 0;
        int extRef = 0;
        int intRef = 0;
        int status = 0;
        int docRef = 0;
        string textValue1 = null;
        string textValue2 = null;
        double numValue1 = 0.0;
        double numValue2 = 0.0;
        string comments = null;
        string genDocNum = "";

        public DisplaySelectedObject()
        {
            InitializeComponent();
        }

        public DisplaySelectedObject(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public DisplaySelectedObject(IdentityObject ident, string _tablename, string _docType, string _docNum)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            textBox_DocNum.Text = _docNum;
            textBox_DocType.Text = _docType;
            textBox_TableName.Text = _tablename;
            LoadSelectionInfo(_tablename, _docType, _docNum);
            button_ResetCommand_Click(this, null);
            button_LoadSelectionList_Click(this, null);

        }

        public DisplaySelectedObject(IdentityObject ident, int docNum, int docType, int extRef, int intRef, int status, int docRef, string textValue1, string textValue2, double numValue1, double numValue2, string comments)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            //   textBox_DocNum.Text = docNum.ToString();
            // genDocNum = docNum.ToString();
            this.docNum = docNum;
            this.docRef = docRef;
            this.docType = docType;
            this.extRef = extRef;
            this.intRef = intRef;
            this.status = status;
            this.textValue1 = textValue1;
            this.textValue2 = textValue2;
            this.numValue1 = numValue1;
            this.numValue2 = numValue2;
            this.comments = comments;
            button_DisplayDoc.Visible = false;
            button_ChangeDoc.Visible = false;
            dataGridView1.Visible = false;
        }

        public void populateFields(IdentityObject ident, int docNum, int docType, int extRef, int intRef, int status, int docRef, string textValue1, string textValue2, double numValue1, double numValue2, string comments)
        {

            textBox_DocNum.Text = docNum.ToString();
            //  textBox_DocType.Text = docType.ToString();
            textBox_DocType.Text = "48";
            textBox_ExtAgent.Text = extRef.ToString();
            textBox_IntAgent.Text = intRef.ToString();
            textBox_Status.Text = status.ToString();
            textBox_ProcessID.Text = docRef.ToString();
            textBox_TextValue1.Text = textValue1;
            textBox_TextValue2.Text = textValue2;
            textBox_NumValue1.Text = numValue1.ToString();
            textBox_NumValue2.Text = numValue2.ToString();
            textBox_Comment.Text = comments;

        }

        private void button_DisplayDoc_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                 docNum = Convert.ToInt32(textBox_DocNum.Text);

                docType = Convert.ToInt32(textBox_DocType.Text);
                extRef = Convert.ToInt32(textBox_ExtAgent.Text);
                intRef = int.Parse(textBox_IntAgent.Text);
                status = int.Parse(textBox_Status.Text);
                docRef = int.Parse(textBox_ProcessID.Text);
                textValue1 = textBox_TextValue1.Text;
                textValue2 = textBox_TextValue2.Text;
                numValue1 = int.Parse(textBox_NumValue1.Text);
                numValue2 = int.Parse(textBox_NumValue2.Text);
                comments = textBox_Comment.Text;
                docType = 48;

                StringBuilder sb1 = new StringBuilder();
                sb1.Append(5);
                sb1.Append(extRef);

               // MessageBox.Show(sb1.ToString());

                int docNum1 = 0;
                docNum1 = Convert.ToInt32(sb1.ToString());


             //   MessageBox.Show(this.docNum + "\n" + docType + "\n" + extRef + "\n" + intRef + "\n" + status + "\n" + docRef + "\n" + "'" + textValue1 + "'" + "\n" + "'" + textValue2 + "'" + "\n" + numValue1 + "\n" + "'" + comments + "'");

                string r1 = "";
                string insertIntoReceivable_Docs = "insert into RECEIVABLE_DOCS values('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue1 + " ','" + numValue1 + "','" + numValue1 + "','" + comments + "')";
                r1 = Utilities.DataBaseUtility.Execute(insertIntoReceivable_Docs, ident);
               
                string insertIntoAcc_Receivables = "insert into ACC_RECEIVABLE values('" + docNum1 + "',52,'" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')";
               int r2 = Utilities.DataBaseUtility.Execute(ident, insertIntoAcc_Receivables);


                string insertIntoProcessDocs = "insert into ProcessDocs values('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')";
                int r3 = 0,r4=0,r5=0,r6=0;
               r3 = Utilities.DataBaseUtility.Execute(ident, insertIntoProcessDocs);
              // new Utilities.Documents.DisplaySelectedObject(base.ident, "ProcessDocs", "48", textBox_DocNum.Text).Show();
                /*
                string s11 = "";
                string s12 = "";
                string s13 = "";
                string s14 = "";
                string s15 = "";
                string s16 = "";
                string s17 = "";

                string d1 = "";
                string dDocNum = "";
                d1 = "SELECT DocNum FROM [ProcessDocs_Details] where DocNum=" + docNum;
                dDocNum = 

                string dDocType = "";
                dDocType = "SELECT DocType FROM [ProcessDocs_Details] where DocNum=" + docNum;


                string dintRef = "";
                dintRef = "SELECT Index1 FROM [ProcessDocs_Details] where DocNum=" + docNum;

                string dextRef = "";
                dextRef = "SELECT ExtRef FROM [ProcessDocs_Details] where DocNum=" + docNum;

                string dQuant = "";
                dQuant = "SELECT Quantity FROM [ProcessDocs_Details] where DocNum=" + docNum;

                string dPrice = "";
                string dComments = "";
                dPrice = "SELECT Price FROM [ProcessDocs_Details] where DocNum=" + docNum;
                dComments = "SELECT Comments FROM [ProcessDocs_Details] where DocNum=" + docNum;

                string insertIntoRecs_Doc_Details = "INSERT INTO RECEIVABLE_DOCS_DETAILS values('"++"','','','','','','')";
                */

               string insertIntoPayabledocDeatails = " INSERT INTO RECEIVABLE_DOCS_DETAILS  SELECT * FROM [ProcessDocs_Details] where DocType=14 and DocNum=" + docNum;
                r5 = Utilities.DataBaseUtility.Execute(ident, insertIntoPayabledocDeatails);
           

                string updateReceivabledocDetails = "update RECEIVABLE_DOCS_DETAILS set DocType= 48 ";
                r6 = Utilities.DataBaseUtility.Execute(ident, updateReceivabledocDetails);


                if ((!(r1.Equals(" "))) || (!(r2 == 0)) || (!(r3 == 0)))
                {
                    MessageBox.Show("Invoice creation successfull !!!");
                }
                else
                {
                    MessageBox.Show("Invoice creation failed !!! ");
                }
            }
            catch (Exception ex1)
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("In Detialed Docs click");

            try { 
            string s1 = "";
           
            s1 = "select * from ProcessDocs_Details where DocNum=" + docNum + " and DocType = 14";
          
            DataTable dt1 = Utilities.DataBaseUtility.GetTable(s1);
            dataGridView2.DataSource = dt1;

            }
            catch(Exception ex)
            {

            }
        }

        private void DisplaySelectedObject_Load(object sender, EventArgs e)
        {

        }

    }
}
