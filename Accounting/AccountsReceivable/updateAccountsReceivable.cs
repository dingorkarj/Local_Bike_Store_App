using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountsReceivable
{
    public partial class updateAccountsReceivable : AccountsReceivable.AccountsReceivable_Template
    {
         int docNum = 0;
        int docType = 0;
        int extRef = 0;
        int intRef = 0;
        int status = 0;
        int docRef = 0;
        string textValue1 = null;
        int processID = 0;
        string textValue2 = null;
        double numValue1 = 0.0;
        double numValue2 = 0.0;
      
        double bal = 0.0;
        string comments = "";

        public updateAccountsReceivable()
        {
            InitializeComponent();
        }

        public updateAccountsReceivable(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public void populateFields(IdentityObject _ident, int docNum, int docType, int extRef, int intRef, int status, int docRef, string textValue1, string textValue2, double numValue1, double numValue2, string comments)
        {
           
            this.docNum = docNum;
            this.extRef = extRef;
            this.processID = docRef;
            this.numValue1 = numValue1;
            String aB = "";
            int paidAmnt = 0, numRows = 0; ;
      
            try
            {
                aB = "select InvoiceAmount from PAYMENT_DOCS where ExtRef = " + extRef + " ";
                //aB = "select InvoiceAmount from PAYMENT_DOCS where ExtRef = " + extRef + " and DocNum = "+docNum+" ";
                DataTable dTable1 = Utilities.DataBaseUtility.GetTable(aB);
                numRows = dTable1.Rows.Count;

                for (int index = 0; index < numRows; index++)
                {
                    paidAmnt += Convert.ToInt32(dTable1.Rows[index]["InvoiceAmount"]);
                }
              //  MessageBox.Show(paidAmnt.ToString());
                textBox1.Text = numValue1.ToString();
                textBox2.Text = paidAmnt.ToString();
                bal = numValue1 - paidAmnt;

                if (bal <= 0)
                {
                    textBox3.Text = "0" ;
                    textBox4.Text = "Payment is complete";
                    
                }
                else
                {

                     textBox3.Text = bal.ToString();
                    // comments = textBox4.Text;
                }

                comments = textBox4.Text;
                
            }
            catch (Exception ea)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a1 = 0.0;
            double a2 = 0.0;
            double a3 = 0.0;
            a1 = Convert.ToInt32(textBox1.Text);
            a2 = Convert.ToInt32(textBox2.Text);
          //  a3 = a1 - a2;
            a3 = Convert.ToInt32(textBox3.Text);
            string  comments1 = "";
            comments1 = textBox4.Text;
           // MessageBox.Show(docNum.ToString() + a3 + comments1);

            //string updateReceivables = "update Acc_Receivable set NumValue1 = '" + a3 + " ' and comments = ' " + comments1 + " ' where DocNum = " + docNum + " ";
            string updateReceivables = "UPDATE ACC_RECEIVABLE set QuotedValue = ' " + a3 + " ',comments = ' " + comments1 + " ' where DocNum = " + docNum + " ";

            string update1 = "";
            update1 = Utilities.DataBaseUtility.Execute(updateReceivables, ident);

            string insertIntoProcessDocs = "insert into ProcessDocs values('" + docNum + "','" + 46 + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + a3 + "','" + numValue2 + "','" + comments1 + "')";
            int r3 = 0;
            r3 = Utilities.DataBaseUtility.Execute(ident, insertIntoProcessDocs);
           

            if (( update1 != "" ))
            {
                MessageBox.Show("Update successfull !!!");
            }
            else
            {

                MessageBox.Show("Update failed !!!");
            }
        }
        
    }
}
