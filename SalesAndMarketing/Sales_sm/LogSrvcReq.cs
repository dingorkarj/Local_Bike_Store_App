using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
     public partial class LogSrvcReq : Sales_sm.Sales_sm_template
    {
        public LogSrvcReq()
        {
            InitializeComponent();
        }

      
        public LogSrvcReq(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            label_SubName.Text="SALES S&M > LIST OF SERVICES";
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtable = Utilities.DataBaseUtility.GetTable(textBox1.Text);
            dataGridView1.DataSource = dtable;


        }
     }
    }
