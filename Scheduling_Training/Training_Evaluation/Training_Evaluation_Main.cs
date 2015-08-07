using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class Training_Evaluation_Main : Training_Evaluation.Training_Evaluation_Template
    {
        public Training_Evaluation_Main()
        {
            InitializeComponent();
        }
        public Training_Evaluation_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
           base.DisplayIdent(ident);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Training_Evaluation.Training_Main app = new Training_Evaluation.Training_Main(ident);
            app.Show();
        }

    }
}
