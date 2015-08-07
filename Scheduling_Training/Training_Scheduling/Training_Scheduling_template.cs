using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Scheduling
{
    public partial class Training_Scheduling_template : HAWK_Template_2
    {
        public Training_Scheduling_template()
        {
            InitializeComponent();
            label_SubName.Text = "Training and Consulting";
            
        }

        private void Training_Scheduling_template_Load(object sender, EventArgs e)
        {

        }
        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            ListObject mylist = new ListObject(base.ident);
            mylist.Show();

        }
        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            DisplaySelectedObject app = new DisplaySelectedObject(base.ident);
            app.Show();
            
        }

       
    }
}
