using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training
{
    public partial class Training_Main : Training.Training_Template
    {
        public Training_Main()
        {
            InitializeComponent();
        }
        public Training_Main(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
        }

        private void button_Scheduling_Click(object sender, EventArgs e)
        {
            new Training_Scheduling.Training_Scheduling_Main(base.ident).Show();
        }

        private void button_Evaluation_Click(object sender, EventArgs e)
        {
            new Training_Evaluation.Training_Main(base.ident).Show();
        }

    }
}
