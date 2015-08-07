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
    public partial class DisplaySupplier : Suppliers_Template 
    {
        List<String> _supplierNames;
        DataTable _supplierValues;
        public DisplaySupplier()
        {
            InitializeComponent();
            _supplierNames = Utilities.DataBaseUtility.GetList(" select Name from suppliers");
            for (int i = 1; i < 8; i++)
            {
                comboBox1.Items.Add(i.ToString() + " :  " + _supplierNames[i]);
            }
        }
        public DisplaySupplier(IdentityObject _ident)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            _supplierNames = Utilities.DataBaseUtility.GetList(" select Name from suppliers");
            for (int i = 1; i < 8; i++)
            {
                comboBox1.Items.Add(i.ToString() + " :  " + _supplierNames[i]);
            }
        }
        public DisplaySupplier(IdentityObject _ident,string supplierID)
        {
            InitializeComponent();
            base.SaveIdent(_ident);
            _supplierNames = Utilities.DataBaseUtility.GetList(" select Name from suppliers");
            for (int i = 1; i < 8; i++)
            {
                comboBox1.Items.Add(i.ToString() + " :  " + _supplierNames[i]);
            }
            textBox0.Text = supplierID;
            button1_Click(this, null);
        }

        private void OLD_button1_Click(object sender, EventArgs e)
        {

            Utilities.DataBaseUtility ins = new Utilities.DataBaseUtility();
            DataTable id = new DataTable();
            int idnum;
           // string _supplierValues;

            //Handles generating a +1 value of the highest ID number in the table. This is to get around the AutoNumber feature missing from the table.
            id = Utilities.DataBaseUtility.GetTable("Select MAX([SupplierID]) from Suppliers");
            idnum = Convert.ToInt32(id.Rows[0][0]) + 1;

            string  _OLD_supplierValues = "('"+idnum.ToString()+"','"+txtName.Text+ "','"+txtAddr.Text+"','"+txtAddr2.Text+"','"+txtCity.Text+"','"+txtState.Text+"','"+txtCountry.Text+"','"+txtZIP.Text+"','"+txtPhone.Text+"','"+txtURL.Text+"')";

           // txtResultTxt.Text = _supplierValues;

           // txtSQL.Text = "INSERT INTO Suppliers ([SupplierID],[Name],[Address],[Address2],[City],[Region],[Country],[PostalCode],[Phone],[WebAddress]) VALUES " + _supplierValues;

            //Turn on the code below when ready to submit to database.
            //ins.Insert("INSERT INTO Suppliers ([SupplierID],[Name],[Address],[Address2],[City],[Region],[Country],[PostalCode],[Phone],[WebAddress]) VALUES " + values);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResetBoxes()
        {
            txtName.Text = "";
            txtAddr.Text = "";
            txtAddr2.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZIP.Text = "";
            txtCountry.Text = "";
            txtAmountDue.Text = "";
            txtPhone.Text = "";
            txtURL.Text = "";
            txtName.Text = "";
        }
            private void button1_Click(object sender, EventArgs e)
        {
            _supplierValues = Utilities.DataBaseUtility.GetTable("select * from suppliers where supplierID = " + textBox0.Text);
         //   dataGridView1.DataSource = _supplierValues;
            txtName.Text = _supplierValues.Rows[0][1].ToString();
            txtAddr.Text = _supplierValues.Rows[0][2].ToString();
            txtAddr2.Text = _supplierValues.Rows[0][3].ToString();
            txtCity.Text = _supplierValues.Rows[0][4].ToString();
            txtState.Text = _supplierValues.Rows[0][5].ToString();
            txtZIP.Text = _supplierValues.Rows[0][6].ToString();
            txtCountry.Text = _supplierValues.Rows[0][7].ToString();
            txtPhone.Text = _supplierValues.Rows[0][9].ToString();
            txtURL.Text = _supplierValues.Rows[0][10].ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox0.Text = (comboBox1.SelectedIndex +1).ToString();
            ResetBoxes();
        }


    }
}
