using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountsReceivable
{
    public partial class PaymentDoc : AccountsReceivable.AccountsReceivable_Template
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


        public PaymentDoc()
        {
            InitializeComponent();
        }

        public PaymentDoc(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string invData = "";
            string ip = "";
            try
            { 
            invData = "select * from RECEIVABLE_DOCS where DocNum = " + textBox1.Text + " ";
            DataTable dt2 = Utilities.DataBaseUtility.GetTable(invData);
            int rowCount1 = 0;
            rowCount1 = dt2.Rows.Count;
          
                ip = textBox1.Text;


            if ((invData.Equals("")) || (rowCount1 == 0) || (ip.Equals("")))
            {
                MessageBox.Show("Please enter a valid DocNum");
            }
            else
            {
                 DataTable dt1 = Utilities.DataBaseUtility.GetTable(invData);

            int rowCount = 0;
            rowCount = dt1.Rows.Count;

            for (int i = 0; i < rowCount; i++)
            {
                docType = Convert.ToInt32(dt1.Rows[i]["DocType"]);
                extRef = Convert.ToInt32(dt1.Rows[i]["ExtRef"]);
                intRef = Convert.ToInt32(dt1.Rows[i]["IntRef"]);
                status = Convert.ToInt32(dt1.Rows[i]["Status"]);
                docRef = Convert.ToInt32(dt1.Rows[i]["DocRef"]);
                // textValue1 = dt1.Rows[i]["TextValue1"].ToString();
                textValue2 = dt1.Rows[i]["DueDate"].ToString();
                numValue2 = Convert.ToInt32(dt1.Rows[i]["QuotedValue"]);
            }
            //  textBox2.Text = docType.ToString();
            textBox2.Text = "49";
            textBox3.Text = extRef.ToString();
            textBox4.Text = intRef.ToString();
            textBox5.Text = status.ToString();
            textBox6.Text = docRef.ToString();
            textBox8.Text = textValue2;
            textBox10.Text = numValue2.ToString();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("DocNum filed cannot be empty");
            }
            }

        private void button1_Click(object sender, EventArgs e)
        {
            String s = null;
            s = textBox1.Text;

            try
            {
               
                docType = 49;
                docNum = Convert.ToInt32(textBox1.Text);
                textValue1 = textBox7.Text;
                numValue1 = int.Parse(textBox9.Text);
                comments = textBox11.Text;

                // INSERT into PayableDocs Table
                string q = "";
                string insertIntoPayableDocs = "insert into PAYMENT_DOCS values('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')";

                string insertIntoProcessDocs = "";
                 insertIntoProcessDocs = "insert into ProcessDocs values('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')";
                int r3 = 0;
                r3 = Utilities.DataBaseUtility.Execute(ident, insertIntoProcessDocs);



                q = Utilities.DataBaseUtility.Execute(insertIntoPayableDocs, ident);
                if ((q != ""))
                {
                    MessageBox.Show(" Payament Document creation successfull!!!");
                }
                else
                {
                    MessageBox.Show(" Payament Document creation failed !!!");
                }

            }
            catch (Exception ex)
            {

            }
        }



    }
}
