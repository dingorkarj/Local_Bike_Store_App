using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class Training_Evaluation_Template : HAWK_Template_2
    {
        public Training_Evaluation_Template()
        {
            InitializeComponent();
            label_SubName.Text = "Training and Evaluation" ;
        }

        public Training_Evaluation_Template(IdentityObject ident)
        {
            InitializeComponent();
            label_SubName.Text = "Training and Evaluation";
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void label_SubName_Click(object sender, EventArgs e)
        {

        }
    }
}
