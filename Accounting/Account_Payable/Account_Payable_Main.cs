using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Accounting.Account_Payable
{
    public partial class Account_Payable_Main : Account_Payable_Template
    {
        int docNum = 0;
        int docType = 0;
        int extRef = 0;
        int intRef = 0;
        int status = 0;
        int docRef = 0;
        string textValue1 = "";
        string textValue2 = "";
        double numValue1 = 0.0;
        double numValue2 = 0.0;
        string comments = "";
        /*
        double price = 0;
        int quantity = 0;
        int processID = 0;
        */

        public Account_Payable_Main()
        {
            InitializeComponent();
        }


        public Account_Payable_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

      // to diplay  the Purchase order data on to the  grid view in main form 
             private void btndiplayDdoc_Click(object sender, EventArgs e)
        {
            String dataforgdview = "Select * from ProcessDocs where DocType=13";

            DataTable doctable = Utilities.DataBaseUtility.GetTable(dataforgdview);
            DeliveryDocGdview.DataSource = doctable;
           

        }




        // to get the contents of grid view on to Invoice form
             private void DeliveryDocGdview_CellContentClick(object sender, DataGridViewCellEventArgs e)
             {
                 
                 docNum = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[0].Value);
                 docType = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[1].Value);
                 string ditype = docType.ToString();
                 string diNum = docNum.ToString();
               
                
                 extRef = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[2].Value);
                 intRef = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[3].Value);
                 status = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[4].Value);
                 docRef = Convert.ToInt32(DeliveryDocGdview.Rows[e.RowIndex].Cells[5].Value);
                 textValue1 = DeliveryDocGdview.Rows[e.RowIndex].Cells[6].Value.ToString();
                 textValue2 = DeliveryDocGdview.Rows[e.RowIndex].Cells[7].Value.ToString();
              
                 numValue1 = Convert.ToDouble(DeliveryDocGdview.Rows[e.RowIndex].Cells[8].Value);
                 numValue2 = Convert.ToDouble(DeliveryDocGdview.Rows[e.RowIndex].Cells[9].Value);
                 comments = DeliveryDocGdview.Rows[e.RowIndex].Cells[10].Value.ToString();
                
                 
                 Invoice inv = new Invoice(base.ident, docNum, docType);
                 inv.populateFileds(docNum,docType,extRef,intRef,status,docRef,textValue1,textValue2,numValue1,numValue2,comments);
               
                 inv.Show();
                 inv.changevisibility(docType);
                 new Utilities.Documents.DisplaySelectedObject(base.ident,"ProcessDocs", ditype, diNum).Show();
             }


        //  to get the payment table data on to grid view 
             private void btnMakePayment_Click(object sender, EventArgs e)
             {
                 {
                     String dataforgdview = "Select * from PayableDocs where DocType=41";

                     DataTable doctable = Utilities.DataBaseUtility.GetTable(dataforgdview);
                     DeliveryDocGdview.DataSource = doctable;
                    

                 }
             }
             public static object[,] ToArray(DataTable data)
             {
                 var ret = Array.CreateInstance(typeof(object), data.Rows.Count, data.Columns.Count) as object[,];
                 for (var i = 0; i < data.Rows.Count - 1; i++)
                     for (var j = 0; j < data.Columns.Count - 1; j++)
                         ret[i, j] = data.Rows[i][j];
                 return ret;
             }
             

        //batch update 
             private void btnUpdateButton_Click(object sender, EventArgs e)
             {
                 try
                 {
/*

                     //string insertIntoPayableDocs = "update account_payable set  into PayableDocs values('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')";
                     int r4 = 0;
                     //string insertIntoPayment="insert into PayableDocs values('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')"; "
                     string select; //= "Select //extRef , sum(numValue1)  from Payment  group by extRef";// where p.ExtRef=pd.ExtRef group by p.ExtRef";
                     //select = "select * from payment";
                     select ="SELECT PayableDocs.ExtRef, (Sum(PayableDocs.numvalue2)-Sum(Payment.numvalue2)) AS balance FROM PayableDocs, payment WHERE (((payment.DocNum)=[PayableDocs].[docnum]) and ([PayableDocs].[doctype]=41) and (Payment.doctype=42)) GROUP BY PayableDocs.ExtRef";
                     DataTable doctable = Utilities.DataBaseUtility.GetTable(select);
                     DeliveryDocGdview.DataSource = doctable;
                     r4 = Utilities.DataBaseUtility.Execute(ident, select);
                     // r3 = Utilities.DataBaseUtility.Execute(ident, select);
                     MessageBox.Show(r4.ToString());
                     //DataTable table;
                     String d = (String)doctable.Rows[0][3];
 
 

                     //Bulk Update fetch  data from both tables and order by the ext  ref  and group by ext ref 

                     string pd = "SELect ExtRef, sum(NumValue1) from payabledocs group by Extref;";
                       string py="select ExtRef ,sum(NumValue1) from payment group by ExtRef";

                       DataTable pddt = Utilities.DataBaseUtility.GetTable(pd);
                       DataTable pydt = Utilities.DataBaseUtility.GetTable(py);



                      int a[,]= ToArray(pddt);
                     

                     u

                       

*/

                 }

                 catch(Exception ex)
                 {

                 }
             }

             private void button_CrystalReport_Click(object sender, EventArgs e)
             {
                 //LocalBikesPlatform_Fall14.Accounting.Account_Payable.CrystalReport1  rept
                 //    = new LocalBikesPlatform_Fall14.Accounting.Account_Payable.CrystalReport1();
                 //CrystalReport CR_Form = new CrystalReport();
                 //CR_Form.crystalReportViewer1.ReportSource = rept;
                 //CR_Form.Show();
       
             }

             private void button_DisplayPayableDocs_Click(object sender, EventArgs e)
             {
                 String dataforgdview = "Select * from ProcessDocs where DocType=43";

                 DataTable doctable = Utilities.DataBaseUtility.GetTable(dataforgdview);
                 DeliveryDocGdview.DataSource = doctable;
             }
        



                 


    }
}
