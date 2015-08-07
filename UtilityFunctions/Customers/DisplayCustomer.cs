using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Utilities
{
    public partial class DisplayCustomer :  Customers_Template  
    {   
       // public string customerEmailAddress;
       // DataTable dtable;
        List<string> _customer;
        List<string> _customerList;
        public DisplayCustomer(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent( _ident);
            FillCustomerList();
        }
        public DisplayCustomer(IdentityObject _ident, string custID)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            textBox1.Text = custID;
            FillCustomerList();
        }

        private void FillCustomerList()
        {
            comboBox1.Items.Clear();
            string _cmd = "select customerID, firstname, lastname from Customers";
            _customerList = Utilities.DataBaseUtility.GetList(_cmd);
            for (int i = 1; i < _customerList.Count; i++)
            {
                string[] _items = _customerList[i].Split(',');
                comboBox1.Items.Add(_items[0].Trim() + "  :  " + _items[1].Trim() + " " + _items[2].Trim());
            }
        }
      
        private void FillTextBoxes()
        {
            string[] _items = _customer[1].ToString().Split(',');
            textBox2.Text = _items[1];
            textBox3.Text = _items[2];
            textBox4.Text = _items[3];
            textBox5.Text = _items[4];
            textBox6.Text = _items[5];
            textBox7.Text = _items[6];
            textBox8.Text = _items[7];
            textBox9.Text = _items[8];
            textBox10.Text = _items[9];
        }

    

         private void button2_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
  //          MessageBox.Show("this page is under construction", "Page not released ");
    
        }

        private void button_DisplayCustomer_Click(object sender, EventArgs e)
        {
            //dtable = Utilities.DataBaseUtility.GetTable("select * from Customers where CustomerID = "  + textBox1.Text);
            //dataGridView1.DataSource = dtable;
            panel3.Visible = true;
            _customer = Utilities.DataBaseUtility.GetList("select * from Customers where CustomerID = " + textBox1.Text);
            FillTextBoxes();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            panel3.Visible = false;
            textBox1.Text = comboBox1.SelectedItem.ToString().Substring(0, 3).Trim();
        }


    }
}
