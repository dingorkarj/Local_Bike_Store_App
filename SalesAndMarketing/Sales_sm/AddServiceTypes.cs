using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
    public partial class AddServiceTypes : HAWK_Template_2
    {
        // public string customerEmailAddress;
        // DataTable dtable;
        List<string> _ServiceTypes;
        List<string> _ServiceTypesList;
        IdentityObject ident_local = new IdentityObject();

        public AddServiceTypes()
        {
            InitializeComponent();
        }
         public AddServiceTypes(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent( _ident);
            base.DisplayIdent(_ident);
            ident_local = _ident;
            //FillCustomerList();
            textBox1.Text = "0";
            textBox2.Text = "25";
            _ServiceTypes = Utilities.DataBaseUtility.GetList("select max(Docnum)+1, max(ServiceProductType)+1 from Service_Type" );
            FillTextBoxes();
        }
         public AddServiceTypes(IdentityObject _ident, String DocNum)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            base.DisplayIdent(_ident);
            ident_local = _ident;
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
             textBox1.Text = _items[0];
             textBox4.Text = _items[1];
             if (ident_local == null) ident_local = new IdentityObject();
             if (ident_local.UserID.Equals("user")) { textBox3.Text = "000"; } else { textBox3.Text = ident_local.UserID; }
         //    textBox3.Text = ident_local.UserID;
             // label_UserName.Text = ident.UserName;
             //textBox4.Text = _items[3];
             //textBox5.Text = _items[4];
             //textBox6.Text = _items[5];
             //textBox7.Text = _items[6];
             //textBox8.Text = _items[7];
             //textBox9.Text = _items[8];
             //textBox10.Text = _items[9];
         }


         private void button1_Click(object sender, EventArgs e)
         {
             panel1.Visible = true;
             _ServiceTypes = Utilities.DataBaseUtility.GetList("select DocNum, DocType, EmployeeID, ServiceProductType, ServiceProductDescription, Rate, Standard_Hrs, GrossPrice, DateCreated, DateModified from Service_Type where DocNum = " + textBox1.Text);
             FillTextBoxes();

         }

         private void AddServiceTypes_Load(object sender, EventArgs e)
         {

         }

         private void textBox5_TextChanged(object sender, EventArgs e)
         {

         }

         private void button2_Click(object sender, EventArgs e)
         {
            string DocNum_var =  textBox1.Text ;
             string DocType_var =  textBox2.Text ;
            string EmployeeID_var =  textBox3.Text ;
            string ServiceProductType_var =  textBox4.Text ;
            string ServiceProductDesc_var = "'" + textBox5.Text +"'" ;
            string Rate_var =  textBox6.Text ;
            string hours_var =  textBox7.Text ;
            string GrossPrice_var =  textBox8.Text ;
           string DateCreated_var = " NOW()";
            string DateModified_var = "NOW()";


            String Sqlstmt1 = "insert into Service_Type(DocNum,DocType,EmployeeID,ServiceProductType , ServiceProductDescription,Rate,Standard_Hrs, GrossPrice , DateCreated, DateModified )  values(" +  DocNum_var + ", "+ DocType_var + ", " + EmployeeID_var + ", " + ServiceProductType_var + ", " + ServiceProductDesc_var + ", " + Rate_var + ", " + hours_var + ", " + GrossPrice_var + ", " + DateCreated_var + ", " + DateModified_var + " );";
            textBox11.Text = Sqlstmt1;
             string returncode = Utilities.DataBaseUtility.Execute( Sqlstmt1, base.ident );
             textBox11.Text += "REsult : "+ returncode;
         }

         private void textBox7_TextChanged(object sender, EventArgs e)
         {
             if (float.Parse(textBox7.Text) > 0.0 )
             {
                 textBox8.Text = (float.Parse(textBox7.Text) * float.Parse(textBox6.Text)).ToString("0.00");
             }

         }
        

         private void textBox6_TextChanged_1(object sender, EventArgs e)
         {
             if (float.Parse(textBox6.Text) > 0.0)
             {
                 textBox8.Text = (float.Parse(textBox7.Text) * float.Parse(textBox6.Text)).ToString("0.00");
             }


         }

         private void button1_Click_1(object sender, EventArgs e)
         {
             this.Close();
         }
    }
}
