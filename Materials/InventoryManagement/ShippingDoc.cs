using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryManagement
{
    public partial class ShippingDoc : Inventory_New_Template
    {
        
        public ShippingDoc( IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }
        public ShippingDoc()
        {
            InitializeComponent();
            base.SaveIdent(ident);
            label_UserName.Text = base.ident.UserName.Trim();
            label_UserID.Text = base.ident.UserID.Trim();
        }
        
        

        private void button1_Click(object sender, EventArgs e)
        {
            //int DocNum = textBox13.Text.
            int docNum = 0;
            int count = 0;
          
            
                if ((docNum1.Text) != "")
                {

                   docNum = int.Parse(docNum1.Text);
                }
                else
                {
                    MessageBox.Show("Please enter Document Number");
                }

                
                int extAgent = 0;
                if (textBox4.Text != "")
                {
                    extAgent = int.Parse(textBox4.Text);
                }
                int docType = 22;
     
                    int intAgent = 0;

                    if (textBox5.Text != "")
                    {
                        intAgent = int.Parse(textBox5.Text);
                    }
           
                
                int procNum = 0;
                if (textBox6.Text != "")
                {
                    procNum = int.Parse(textBox6.Text);
                }

                int status = 0;
                if (textBox7.Text != "")
                {

                    if (int.Parse(textBox7.Text) == 0 || int.Parse(textBox7.Text) == 1 || int.Parse(textBox7.Text)==2)
                    {
                status = int.Parse(textBox7.Text);
                    }
                    else
                    {
                        MessageBox.Show("Invalid status");
                        count++;

                    }
                }
                else
                {
                    MessageBox.Show("Please enter status");

                 

                       
                       
                }
                int docRef = 0;
                if (textBox13.Text!="")
                {
                    docRef = int.Parse(textBox13.Text);
                }
             //   String strtDate = textBox8.Text;

               // String statDate = textBox9.Text;

                int quotAmount = 0;
                if (textBox10.Text != "")
                {
                    quotAmount = int.Parse(textBox10.Text);
                }
                int actAmount = 0;
                if (textBox11.Text != "")
                {
                    actAmount = int.Parse(textBox11.Text);
                }
                String comment = "";
                if (textBox12.Text != "")
                {
                    comment = textBox12.Text;
                }
         
                DateTime value = new DateTime(2010, 1, 18);

                if (textBox8.Text != "")
                {
                    value = Convert.ToDateTime(textBox8.Text);
                }
                else
                {

                    MessageBox.Show("Please eneter Start date");
                }
             //   System.Windows.Forms.MessageBox.Show(value.ToString());
            
                DateTime value1 = new DateTime(2010, 1, 18);

                if (textBox9.Text != "")
                {
                    value1 = Convert.ToDateTime(textBox9.Text);

                }
                else
                {
                    MessageBox.Show("Please eneter Status Due date");
                }

                int ProcId = 0;
            if(textBox6.Text!="")
            {

                ProcId = int.Parse(textBox6.Text);
            }


            int price = 0;
            if (textBox14.Text != "")
            {

                price = int.Parse(textBox14.Text);
            }

            int quant = 0;
            if (textBox15.Text != "")
            {

                quant = int.Parse(textBox15.Text);
            }

          //  String query = "INSERT INTO ProcessDocs"
            //    + "(DocNum, DocType, ExtRef, Price) " + "VALUES"
              //  + "(1002,32,32,62)";




       //     String query = "INSERT INTO ProcessDocs"
         //       + "(DocNum, DocType, ExtRef,IntRef,status,DocRef,NumValue1,NumValue2) " + "VALUES"
           //  + "(1002,32,32,62,2,300,100,200)";


             String query = "INSERT INTO ProcessDocs"
             + "(DocNum, DocType, ExtRef,IntRef,status,DocRef,NumValue1,NumValue2,comments,Textvalue1,TextValue2) " + "VALUES"
          + "('" + docNum + "','"+ docType +"','"+ extAgent +"','"+ intAgent +"','"+ status +"','"+ docRef +"','"+ quotAmount +"','"+ actAmount +"','"+comment+"','"+value+"','"+value1+"')";


             //ProcessDocs_Details
             int index1 = 0;
             if (textBox16.Text != "")
             {
                 index1 = int.Parse(textBox16.Text);
             }
            int index2 = 1;
       String query2 = "INSERT INTO ProcessDocs_Details"
             + "(DocNum, DocType,Index1,Index2,ProcessID,Quantity,Price,comment) " + "VALUES"
          + "('" + docNum + "','" + docType + "','" + index1 + "','" + index2 + "','" + ProcId + "','" + quant + "','" + price + "','" + comment + "')";

       if (docNum != 0 && (textBox7.Text)!="" && count==0)
            {

                 int rows = Utilities.DataBaseUtility.Execute(ident, query);

                 int rows2 = Utilities.DataBaseUtility.Execute(ident, query2);


                 MessageBox.Show("Record Inserted Succesfully");

                 InventoryManagement.Update_Inventory t7 = new InventoryManagement.Update_Inventory();
                 t7.Show();

                 t7.acces(index1);
                 t7.totalItems(index1);
                 t7.Quantity(quant);
            }

            else
            {
              //  MessageBox.Show("Record  Not Inserted ");

            }




          

           

      




   

        }
        



        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void ShippingDoc_Load(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
