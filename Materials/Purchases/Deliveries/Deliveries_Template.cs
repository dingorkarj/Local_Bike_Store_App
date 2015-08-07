using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Purchases
{
    public partial class Deliveries_Template : HAWK_Template_2
    {
      

        //const string DELIVERY_TABLE_NAME = "Deliveries";
        //const string DELIVERY_DETAILS_TABLE_NAME = "DeliveryDetails";
        public Deliveries_Template()
        {
            InitializeComponent();
        }

        protected override  void button_ListObjects_Click(object sender, EventArgs e)
        {
            Deliveries_List app = new Deliveries_List(base.ident);
            app.Show();
        }

        protected override  void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            DisplayDelivery app = new DisplayDelivery(base.ident);
            app.Show();
        }

        protected override void button_ChangeObject_Click(object sender, EventArgs e)
        {
            //CreateDelivery app = new CreateDelivery(base.ident);
            //app.Show();
        }

        
    }
}
