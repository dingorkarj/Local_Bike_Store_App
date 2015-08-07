using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accounting.Account_Payable
{
    public partial class Invoice : Accounting.Account_Payable.Account_Payable_Template
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
        public Invoice()
        {
            InitializeComponent();
        }

        public Invoice(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }


        public Invoice(IdentityObject ident,int docNum,int docType)
        {
            
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            this.docNum = Convert.ToInt32(docNum);
            this.docType = Convert.ToInt32(docType) ;
          

        }

        private void Invoice_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
               

                docNum = Convert.ToInt32(textBox1.Text);
                docType =Convert.ToInt32(textBox2.Text);
                extRef = Convert.ToInt32(textBox3.Text);
                intRef = int.Parse(textBox4.Text);
                status = int.Parse(textBox5.Text);
                docRef = int.Parse(textBox6.Text);
                textValue1 = textBox7.Text;
                textValue2 = textBox8.Text;
                numValue1 = int.Parse(textBox9.Text);
                numValue2 = int.Parse(textBox10.Text);
                comments = textBox11.Text;


              string insertIntoPayableDocs = "insert into PayableDocs values('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')";
              int r3 = 0;
              int r4 = 0;
              int r5=0;
              int r6=0;

                   

                    string insertIntoProcessDocs = "insert into ProcessDocs values ('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')";
                    r3 = Utilities.DataBaseUtility.Execute(ident, insertIntoPayableDocs);
                    r4 = Utilities.DataBaseUtility.Execute(ident, insertIntoProcessDocs);
                    MessageBox.Show("Payable doc created for the delivery document go ahead with payment");

                    string insertIntoPayabledocDeatails = " INSERT INTO payableDocs_details  SELECT * FROM [ProcessDocs_Details] where DocType=12 and DocNum="+docNum;
                    string updatePAyabledocDetails= "update payableDocs_details set doctype= 41 "  ;  
                    r5 = Utilities.DataBaseUtility.Execute(ident, insertIntoPayabledocDeatails);
                    r6 = Utilities.DataBaseUtility.Execute(ident, updatePAyabledocDetails);
                   
              
                   
               
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }


        }


        // enable button on the form 
       public void changevisibility(int doctype)
        {

            if(doctype==41)
            {
                button1.Visible = false;
                dataGridView1.Visible = false;
                button3.Visible = false;

            }
            else
            {
                button2.Visible = false;
            }

        }


        //populating fileds  on to form  from grid view
        public void populateFileds(int docNum, int docType, int extRef, int intRef, int status, int docRef, string textValue1, string textValue2, double numValue1, double numValue2, string comments)
   
    {
            try
            {
                textBox1.Text = docNum.ToString();
                textBox2.Text = docType.ToString();
                textBox3.Text = extRef.ToString();
                textBox4.Text = intRef.ToString();
                textBox5.Text = status.ToString();
                textBox6.Text = docRef.ToString();
                textBox7.Text = textValue1;
                textBox8.Text = textValue2;
                textBox9.Text = numValue1.ToString();
                textBox10.Text = numValue2.ToString();
                textBox11.Text = comments;
               
                 
            }
            catch (Exception ex)
            {

            }
        
        
        
        
        }

        //Create a payment doc
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               

                docNum = Convert.ToInt32(textBox1.Text);
                docType =Convert.ToInt32(textBox2.Text);
                extRef = Convert.ToInt32(textBox3.Text);
                intRef = int.Parse(textBox4.Text);
                status = int.Parse(textBox5.Text);
                docRef = int.Parse(textBox6.Text);
                textValue1 = textBox7.Text;
                textValue2 = textBox8.Text;
                numValue1 = int.Parse(textBox9.Text);
                numValue2 = int.Parse(textBox10.Text);
                comments = textBox11.Text;
                    string insertIntoPayment = "insert into Payment values('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')";
                    int r3 = 0;
                    int r4 = 0;
                    string insertIntoProcessDocs="insert into ProcessDocs values('" + docNum + "','" + docType + "','" + extRef + "','" + intRef + "','" + status + "','" + docRef + "','" + textValue1 + "',' " + textValue2 + " ','" + numValue1 + "','" + numValue2 + "','" + comments + "')";
                    


                    r3 = Utilities.DataBaseUtility.Execute(ident, insertIntoPayment);
                    r4 = Utilities.DataBaseUtility.Execute(ident, insertIntoProcessDocs);
                    MessageBox.Show("Payament made for the payable doc");

                
            }
            catch (Exception ex)
            {

            }

        }

        //get details for ProcessDocs_Details 

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {


                docNum = Convert.ToInt32(textBox1.Text);
                docType = Convert.ToInt32(textBox2.Text);


                String dataforgdview = "Select * from ProcessDocs_Details where DocNum=" + docNum + "and DocType =" + docType;

                DataTable doctable = Utilities.DataBaseUtility.GetTable(dataforgdview);
                dataGridView1.DataSource = doctable;
            }
            catch (Exception ex)
            {

            }
        }
    
    
    }



}
