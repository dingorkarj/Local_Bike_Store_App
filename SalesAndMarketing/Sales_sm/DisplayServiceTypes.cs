using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
    public partial class DisplayServiceTypes : HAWK_Template_2
    {
        // public string customerEmailAddress;
        // DataTable dtable;
        List<string> _ServiceTypes;
        List<string> _ServiceTypesList;
        public DisplayServiceTypes()
        {
            InitializeComponent();
        }
         public DisplayServiceTypes(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent( _ident);
            base.DisplayIdent(ident);
            //FillCustomerList();
        }
         public DisplayServiceTypes(IdentityObject _ident, String DocNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(ident);
            textBox1.Text =  DocNum;
            
        }

         private void textBox1_TextChanged(object sender, EventArgs e)
         {

         }

         private void pictureBox_RightLogo_Click(object sender, EventArgs e)
         {

         }

         private void panel1_Paint(object sender, PaintEventArgs e)
         {

         }

         private void FillTextBoxes()
         {
             string[] _items = _ServiceTypes[1].ToString().Split(',');
             textBox2.Text = _items[1];
             textBox3.Text = _items[2];
             textBox4.Text = _items[3];
             textBox5.Text = _items[4];
             textBox6.Text = _items[5];
             textBox7.Text = _items[6];
             textBox8.Text = _items[7];
             textBox9.Text = _items[8];
             textBox10.Text = _items[9];
         }


         private void button1_Click(object sender, EventArgs e)
         {
             panel1.Visible = true;
             _ServiceTypes = Utilities.DataBaseUtility.GetList("select DocNum, DocType, EmployeeID, ServiceProductType, ServiceProductDescription, Rate, Standard_Hrs, GrossPrice, DateCreated, DateModified from Service_Type where DocNum = " + textBox1.Text);
             FillTextBoxes();

         }

         private void DisplayServiceTypes_Load(object sender, EventArgs e)
         {

         }

         private void textBox5_TextChanged(object sender, EventArgs e)
         {

         }

         private void button2_Click(object sender, EventArgs e)
         {
            string DocType_var = "DocType = " + textBox2.Text + "";
            string EmployeeID_var = "EmployeeID = " + textBox3.Text + "";
            string ServiceProductType_var = "ServiceProductType = " + textBox4.Text + "";
            string ServiceProductDesc_var = "ServiceProductDescription = '" + textBox5.Text + "'";
            string Rate_var = "Rate = " + textBox6.Text + "";
            string hours_var = "Standard_Hrs = " + textBox7.Text + "";
            string GrossPrice_var = "GrossPrice = " + textBox8.Text + "";
            //string DateCreated_var = "DateCreated = '" + textBox9.Text + "'";
            string DateModified_var = "DateModified = NOW()";


            String Sqlstmt1 = "update Service_Type  set " + DocType_var + ", " + EmployeeID_var + ", " + ServiceProductType_var + ", " + ServiceProductDesc_var + ", " + Rate_var + ", " + hours_var + ", " + GrossPrice_var + ", " + DateModified_var + " where docnum  = " + textBox1.Text + ";";
            textBox11.Text = Sqlstmt1;
             string returncode = Utilities.DataBaseUtility.Execute( Sqlstmt1, base.ident );
             textBox11.Text += "REsult : "+ returncode;
         }

         private void label2_Click(object sender, EventArgs e)
         {

         }

         private void label9_Click(object sender, EventArgs e)
         {

         }

         private void button3_Click(object sender, EventArgs e)
         {
             this.Close();
         }
    }
}
