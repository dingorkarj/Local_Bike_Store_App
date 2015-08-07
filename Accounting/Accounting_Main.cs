using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Accounting
{
    public partial class Accounting_Main : HAWK_Template_1 
    {
    

        public Accounting_Main()
        {
            InitializeComponent();
        }


        public Accounting_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }


        private void button_AccPayable_Click(object sender, EventArgs e)
        {
            Account_Payable.Account_Payable_Main app = new Account_Payable.Account_Payable_Main(base.ident); app.Show();
            //Account_Payable. Account_Payable.Account_Payable_Main(base.ident).Show();
          //  new NewApplication.NewApplication_Main(base.ident).Show();
        }
        private void button_AccReceivable_Click(object sender, EventArgs e)
        {
            //new AccountsReceivable.AccountsReceivable_Main(base.ident).Show();
           // new NewApplication.NewApplication_Main(base.ident).Show();

            AccountsReceivable.AccountsReceivable_Main newAp = new AccountsReceivable.AccountsReceivable_Main(base.ident);
            newAp.Show();
        }
        






    }
}
