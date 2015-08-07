using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesAndMarketing
{
    public partial class SalesAndMarketingMain : SalesAndMarketing_template
    {
        public SalesAndMarketingMain()
        {
            InitializeComponent();

        }
        public SalesAndMarketingMain(IdentityObject ident)
        {

            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
           label_SubName.Text = "Sales And Marketing";

        }

    
        private void button_presales_Click(object sender, EventArgs e)
        {
            PreSales preSales = new PreSales(ident);
            preSales.ShowDialog();
        }

        private void button_ServiceOrders_Click(object sender, EventArgs e)
        {
            new Sales_sm.Sales_sm_Main(base.ident).Show();
        }
    }
}
