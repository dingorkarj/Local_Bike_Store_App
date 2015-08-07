using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Sales_sm
{
    public partial class ListofServices : Sales_sm.Sales_sm_template
    {
        double a;
        double b = 0;
        public ListofServices()
        {
            InitializeComponent();
        }

      
        public ListofServices(IdentityObject ident)
        {
            InitializeComponent();
            base.SaveIdent(ident);
            base.DisplayIdent(ident);
            label_SubName.Text="SALES S&M > LIST OF SERVICES";
           
        }

        public void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            a = 90;
            b += a;
        }

        public void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = String.Format("{0:C}", Convert.ToString(b));
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            a = 50;
            b += a;
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            a = 20;
            b += a;
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            a = 10;
            b += a;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            a = 7.5;
            b += a;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            a = 50;
            b += a;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            a = 5;
            b += a;
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            a = 80;
            b += a;
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            a = 60;
            b += a;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            a = 112.5;
            b += a;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            a = 112.5;
            b += a;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            a = 30;
            b += a;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            a = 3;
            b += a;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
     }
}