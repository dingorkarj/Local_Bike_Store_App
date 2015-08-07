using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountsReceivable
{
    public partial class AccountsReceivable_Main : AccountsReceivable.AccountsReceivable_Template
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
        int deptNo = 0;
        public AccountsReceivable_Main()
        {
            InitializeComponent();
        }

        public AccountsReceivable_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
             deptNo = base.ident.Dept;
            //MessageBox.Show(deptNo.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if(deptNo == 5 || deptNo == 4){
              //  MessageBox.Show(base.ident.UserName + "Welcome to Accounting section !!!");
           // string q1 = "select * from ProcessDocs where DocType = 22";

            string q1 = "select * from ProcessDocs where DocType = 14";
            DataTable dTable1 = Utilities.DataBaseUtility.GetTable(q1);
            dataGridView1.DataSource = dTable1;
        
           // }
            
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           PaymentDoc payDoc = new PaymentDoc(ident);
            payDoc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UpdatePayment updatePay = new UpdatePayment(ident);
             updatePay.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string s1 = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            string s2 = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            string s3 = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            string s4 = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string s5 = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            string s6 = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            string s7 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            string s8 = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            string s9 = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            string s10 = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            string s11 = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();


            docNum = Convert.ToInt32(s1);
            //docType = Convert.ToInt32(s2);
            docType = 45;
            extRef = Convert.ToInt32(s3);
            intRef = Convert.ToInt32(s4);
            status = Convert.ToInt32(s5);
            docRef = Convert.ToInt32(s6);
            textValue1 = s7;
            textValue2 = s8;
            numValue1 = Convert.ToInt32(s9);
            numValue2 = Convert.ToInt32(s10);
            comments = s11;


         DisplaySelectedObject disp = new DisplaySelectedObject(ident, docNum, docType, extRef, intRef, status, docRef, textValue1, textValue1, numValue1, numValue2, comments);
           // DisplaySelectedObject disp = new DisplaySelectedObject(ident);
            disp.populateFields(ident, docNum, docType, extRef, intRef, status, docRef, textValue1, textValue1, numValue1, numValue2, comments);
          disp.Show();
        }

        private void button_DisplayReceivables_Click(object sender, EventArgs e)
        {
           string q1 = "select * from ProcessDocs where DocType = 48";
            DataTable dTable1 = Utilities.DataBaseUtility.GetTable(q1);
            dataGridView1.DataSource = dTable1;
        
        }

        private void button_CrystalReport_Click(object sender, EventArgs e)
        {
           LocalBikesPlatform_Fall14.Accounting.AccountsReceivable.CrystalReport1
                 rept = new LocalBikesPlatform_Fall14.Accounting.AccountsReceivable.CrystalReport1();
           CrystalReport CR_Form = new CrystalReport();
           CR_Form.crystalReportViewer1.ReportSource = rept;
           CR_Form.Show();

        }


    }
}
