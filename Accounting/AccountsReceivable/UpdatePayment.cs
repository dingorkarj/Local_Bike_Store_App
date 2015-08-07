using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AccountsReceivable
{
    public partial class UpdatePayment : AccountsReceivable.AccountsReceivable_Template
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
        string comments = null;

        public UpdatePayment()
        {
            InitializeComponent();
        }

        public UpdatePayment(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);

        }

        private void button1_Click(object sender, EventArgs e)
        {
              int deptNumber = base.ident.Dept;
              if (deptNumber == 5 || deptNumber == 4 || deptNumber == 2)
              {
                  MessageBox.Show(base.ident.UserName + "!!!! Welcome to Accounting");

                  try
                  {
                      string aB = "";
                      aB = "select * from ACC_RECEIVABLE where DocType = 52";
                      DataTable dTable1 = Utilities.DataBaseUtility.GetTable(aB);
                      dataGridView1.DataSource = dTable1;
                  }
                  catch (Exception ex)
                  {

                  }
              }
              else
              {
                  MessageBox.Show("Acess denied!!" + "\n" + "Accounting details cannot be viewed by a non accountant !!!!");
              }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             int deptNumber = base.ident.Dept;
             if (deptNumber == 5 || deptNumber == 4)
             {

                 try
                 {
                     /*
                         docNum = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                         docType  = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].Value);
                         extRef = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[2].Value);
                         intRef = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[3].Value);
                         status = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[4].Value);
                         processID = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[5].Value); 
                         textValue1 = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
                         textValue2 =dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
                         numValue1 = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[9].Value);
                         numValue2=Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[10].Value);
                         comments = dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString();
               */
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
                     docType = Convert.ToInt32(s2);
                     extRef = Convert.ToInt32(s3);
                     intRef = int.Parse(s4);
                     status = int.Parse(s5);
                     docRef = int.Parse(s6);
                     textValue1 = s7;
                     textValue2 = s8;
                     numValue1 = int.Parse(s9);
                     numValue2 = int.Parse(s10);
                     comments = s11;


                     //MessageBox.Show(docNum + "\n" + docType + "\n" + extRef + "\n" + intRef + "\n" + status + "\n" + docRef + "\n" + "'" + textValue1 + "'" + "\n" + "'" + textValue2 + "'" + "\n" + numValue1 + "\n" + numValue2 + "\n" + "'" + comments + "'");

                     updateAccountsReceivable updteForm = new updateAccountsReceivable(ident);

                     updteForm.populateFields(base.ident, docNum, docType, extRef, intRef, status, docRef, textValue1, textValue2, numValue1, numValue2, comments);
                     updteForm.Show();

                 }
                 catch (Exception ex2)
                 {
                     MessageBox.Show("Acess denied!!" + "\n" + "Accounting details cannot be modified by a non accountant !!!!");
                 }
             }
             else
             {
                 MessageBox.Show("Access Denied!!!");
             }
        }
    }
}
