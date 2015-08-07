using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Training_Evaluation
{
    public partial class Training_Main : Training_Evaluation.Training_Evaluation_Template
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
            int deptNo = base.ident.Dept;
            if (deptNo == 7)
            {
                button1.Visible = true;
                button2.Visible = true;
            }
            else
            {
                button1.Visible = true ;
                button2.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Training_Evaluation.Instructor_Main app = new Training_Evaluation.Instructor_Main(ident);
            app.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Training_Evaluation.Trainee_Main app = new Training_Evaluation.Trainee_Main(ident);
            app.Show();
        }

        private void Training_Main_Load(object sender, EventArgs e)
        {

        }
    }
}
