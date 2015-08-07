using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Account_Payable
{
    public partial class ListObjects : HAWK_Template_3
    {
        public ListObjects()
        {
            InitializeComponent();
        }
    
     public ListObjects(IdentityObject iden)
        {
            InitializeComponent();
            base.SaveIdent(iden);
            base.DisplayIdent(iden);
        }

     private void button_Display_Click(object sender, EventArgs e)
     {
         String dataforgdview = "Select * from payabledocs";

         DataTable doctable = Utilities.DataBaseUtility.GetTable(dataforgdview);
         listObjectsdataGridView.DataSource = doctable;


     }

     private void listObjectsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
     {
         string docTypeStr = listObjectsdataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
         string docNumStr = listObjectsdataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();

         DisplaySelectedObject pds = new DisplaySelectedObject(base.ident, textBox_TableName.Text, docTypeStr, docNumStr);
         pds.Show();

     }

     private void button_Return_Click_1(object sender, EventArgs e)
     {

     }

}
}