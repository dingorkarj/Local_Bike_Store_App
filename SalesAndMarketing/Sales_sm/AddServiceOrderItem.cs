using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
    public partial class AddServiceOrderItem : HAWK_Template_2
    {
  // public string customerEmailAddress;
        // DataTable dtable;
        List<string> _ServiceTypes;
        List<string> _ServiceTypesList;
        String ProdTypeSql;


        public string ResultString { get; set; } // In .NET 3.0 or newer

        public AddServiceOrderItem()
        {
            InitializeComponent();
        }
         public AddServiceOrderItem(IdentityObject _ident,  String _ServiceProductType ,String _DocNUM, String _DocType, String _ProductID, String _Quantity , String _Comment)
        {
            InitializeComponent();
            base.SaveIdent( _ident);
            //FillCustomerList();
            panel1.Visible = true;

            DataTable Services = Utilities.DataBaseUtility.GetTable("Select ServiceProductType, ServiceProductDescription from Service_Type");
            ServiceProductTypeCombobox.DataSource = Services;
            ServiceProductTypeCombobox.DisplayMember = "ServiceProductDescription";
            ServiceProductTypeCombobox.ValueMember = "ServiceProductType";

            CommentTxt.Text = _Comment;
            ORDER_DOCNUMTXT.Text = _DocNUM;
            ORDERDOCTYPETXT.Text = _DocType;
            ProductIDTXT.Text = _ProductID;
            QuanitytTXT.Text = _Quantity;
             
             //If service product is passed then it is update else it is add item
            if (!String.IsNullOrEmpty(_ServiceProductType) )
        { ServiceProductTypeCombobox.SelectedValue = _ServiceProductType;
            button2.Text = "Update ServiceOrder";
            }
           // _ServiceTypes = Utilities.DataBaseUtility.GetList("select DocNum, DocType, EmployeeID, ServiceProductType, ServiceProductDescription, Rate, Standard_Hrs, GrossPrice, DateCreated, DateModified from Service_Type  " + ProdTypeSql );
            //FillTextBoxes();
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
            // textBox1.Text = _items[0];
             //textBox4.Text = _items[1];
             textBox1.Text = _items[3];
             textBox5.Text = _items[4];
             textBox6.Text = _items[5];
             textBox7.Text = _items[6];
             textBox8.Text = _items[7];
             //textBox9.Text = _items[8];
             //textBox10.Text = _items[9];
         }


         private void button1_Click(object sender, EventArgs e)
         {
             panel1.Visible = true;
             _ServiceTypes = Utilities.DataBaseUtility.GetList("select DocNum, DocType, EmployeeID, ServiceProductType, ServiceProductDescription, Rate, Standard_Hrs, GrossPrice, DateCreated, DateModified from Service_Type where ServiceProductType = " + textBox1.Text);
             FillTextBoxes();

         }

         private void AddServiceOrderItem_Load(object sender, EventArgs e)
         {

         }

         private void textBox5_TextChanged(object sender, EventArgs e)
         {

         }

         private void button2_Click(object sender, EventArgs e)
         {
            string DocNum_var =  ORDER_DOCNUMTXT.Text ;
             string DocType_var =  ORDERDOCTYPETXT.Text ;
             string ProductID_var = ProductIDTXT.Text;
             string Quantity_var = QuanitytTXT.Text;
            //string EmployeeID_var =  textBox3.Text ;
            string ServiceProductType_var =  textBox1.Text ;
            string ServiceProductDesc_var = "'" + textBox5.Text +"'" ;
            string ServiceProductDesc_var1 =   textBox5.Text ;
            string Rate_var =  textBox6.Text ;
            string hours_var =  textBox7.Text ;
            string GrossPrice_var =  textBox8.Text ;
            string Comment_Var = CommentTxt.Text;

      


            //String Sqlstmt1 = "insert into Service_Type(DocNum,DocType,EmployeeID,ServiceProductType , ServiceProductDescription,Rate,Standard_Hrs, GrossPrice , DateCreated, DateModified )  values(" +  DocNum_var + ", "+ DocType_var + ", " + EmployeeID_var + ", " + ServiceProductType_var + ", " + ServiceProductDesc_var + ", " + Rate_var + ", " + hours_var + ", " + GrossPrice_var + ", " + DateCreated_var + ", " + DateModified_var + " );";
            //textBox11.Text = Sqlstmt1;
           //  string returncode = Utilities.DataBaseUtility.Execute( Sqlstmt1, base.ident );
            // textBox11.Text += "REsult : "+ returncode;

            ResultString = ServiceProductType_var + ", " + ServiceProductDesc_var1 + ", " + Rate_var + ", " + hours_var + ", " + GrossPrice_var + ", " + Comment_Var + ", " + DocNum_var + ", " + DocType_var  +", "+ ProductID_var +", " + Quantity_var ;
             this.Close();
         }

         
        


         private void button1_Click_1(object sender, EventArgs e)
         {
             this.Close();
         }

         private void label1_Click(object sender, EventArgs e)
         {

         }

         private void ServiceProductTypeCombobox_SelectedIndexChanged(object sender, EventArgs e)
         {

             if (ServiceProductTypeCombobox.SelectedIndex != -1)
             {
                 string SelectedServiceType = ((DataRowView)ServiceProductTypeCombobox.SelectedItem).Row["ServiceProductType"].ToString();
                 if (!String.IsNullOrEmpty(SelectedServiceType))
                 {

                     _ServiceTypes = Utilities.DataBaseUtility.GetList("select DocNum, DocType, EmployeeID, ServiceProductType, ServiceProductDescription, Rate, Standard_Hrs, GrossPrice, DateCreated, DateModified from Service_Type where ServiceProductType = " + SelectedServiceType);
                     FillTextBoxes();
                 }
             }
             else
             {
                 textBox1.Text =  "";
                 textBox5.Text = "";
                 textBox6.Text = "0";
                 textBox7.Text = "0";
                 textBox8.Text = "0";
             }

         }

        
   
    }


}
