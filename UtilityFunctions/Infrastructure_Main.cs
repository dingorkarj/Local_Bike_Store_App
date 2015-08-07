using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Infrastructure
{
    public partial class Infrastructure_Main : HAWK_Template_1 
    {
     
        public Infrastructure_Main(IdentityObject _ident_Object)
        {
            InitializeComponent();
            base.SaveIdent(_ident_Object);
            base.DisplayIdent(_ident_Object);
        }


        private void button_Transactions_Click(object sender, EventArgs e)
        {
          //  Accounting.Transactions.  Transactions_List app4 = new Infrastructure.Transactions_List(base.ident );   app4.Show();
  
        }

        private void button_Employees_Click(object sender, EventArgs e)
        {
          
            Utilities.Employees.Employees_List el = new Utilities.Employees.Employees_List(base.ident);  el.Show();
        }

        private void button_Customers_Click(object sender, EventArgs e)
        {
            Utilities.Customer_List app = new Utilities.Customer_List(base.ident);        app.Show();
        }

        private void button_Reports_Click(object sender, EventArgs e)
        {
          //  Utilities.  .Reports.Reports_Main app = new Utilities.Reports.Reports_Main(base.ident); app.Show();
        }

        private void button_Suppliers_Click(object sender, EventArgs e)
        {
            Utilities.Suppliers_List app = new Utilities.Suppliers_List(base.ident); app.Show();
        }

        private void button_Products_Click(object sender, EventArgs e)
        {
             Utilities.Products.Products_Main app = new Utilities.Products.Products_Main(base.ident);     app.Show();
        }

        private void button_Documents_Click(object sender, EventArgs e)
        {
           Utilities.Documents.Documents_Main  disp2 = new Utilities.Documents.Documents_Main  (base.ident);// disp2.ShowDialog();
        }

        private void button_Processes_Click(object sender, EventArgs e)
        {
            Utilities.Processes.Process_List app = new Utilities.Processes.Process_List(base.ident); app.Show();
        }

    }
}
