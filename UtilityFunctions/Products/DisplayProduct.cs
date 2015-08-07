using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Utilities
{
    public partial class DisplayProduct : Products_Template 
    {
      //  List<String> _productNames;
        DataTable _productValues;
        public DisplayProduct(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent( _ident);
            _productValues = Utilities.DataBaseUtility.GetTable(" select productID, productName from Products");
            for (int i = 0; i < _productValues.Rows.Count ; i++)
            {
                //      comboBox1.Items.Add(_productNames[i][0] + " :  " + _productNames[i][1]);
                comboBox1.Items.Add(_productValues.Rows[i][0].ToString() + " :  " + _productValues.Rows[i][1].ToString());
            }
        }
        public DisplayProduct(IdentityObject _ident, string _productID)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            _productValues = Utilities.DataBaseUtility.GetTable(" select productID, productName from Products");
            for (int i = 0; i < _productValues.Rows.Count ; i++)
            {
                //      comboBox1.Items.Add(_productNames[i][0] + " :  " + _productNames[i][1]);
                comboBox1.Items.Add(_productValues.Rows[i][0].ToString() + " :  " + _productValues.Rows[i][1].ToString());
            }
            textBox0.Text = _productID;
            button1_Click(this, null);
        }

     

        private void ResetBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox8.Text = "";
           
        }
            private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string cmdStr = String.Format(" select * from products where productID = '{0}'", textBox0.Text);
                _productValues = Utilities.DataBaseUtility.GetTable(cmdStr);
               // if (_productValues.Rows.Count < 1)
                textBox1.Text = _productValues.Rows[0][1].ToString();
                textBox2.Text = _productValues.Rows[0][2].ToString();
                textBox3.Text = _productValues.Rows[0][3].ToString();
                textBox4.Text = _productValues.Rows[0][4].ToString();
                textBox5.Text = _productValues.Rows[0][5].ToString();
                textBox6.Text = _productValues.Rows[0][6].ToString();
                textBox7.Text = _productValues.Rows[0][7].ToString();
                textBox8.Text = _productValues.Rows[0][8].ToString();
                //    txtURL.Text = _productValues.Rows[0][10].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error in reading product : " + textBox0.Text + "  " + ex.Message); 
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox0.Text = (comboBox1.SelectedItem).ToString().Substring(0,3);
            ResetBoxes();
        }


    }
}
