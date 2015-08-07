using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HrRecruiting
{
    public partial class HrRecruiting_Template : HAWK_Template_2
    {
        public HrRecruiting_Template(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        public HrRecruiting_Template()
        {
            
        }

        private void pictureBox_RightLogo_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox_LeftLogo_Click(object sender, EventArgs e)
        {

        }

        protected override void button_ListObjects_Click(object sender, EventArgs e)
        {
            
            ListObjects newapp = new ListObjects();
            newapp.Show();
        }

        protected override void button_DisplaySelectedObject_Click(object sender, EventArgs e)
        {
            DisplaySelectedObject newapp = new DisplaySelectedObject();
            newapp.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            HrRecruiting_Main newapp = new HrRecruiting_Main(ident);
            newapp.Show();
        }
    }
}
