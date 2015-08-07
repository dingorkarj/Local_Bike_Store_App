namespace Sales_sm
{
    partial class AddServiceOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeliveryDate = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.CustomerRequest = new System.Windows.Forms.TextBox();
            this.Orderstatus = new System.Windows.Forms.ComboBox();
            this.Service_order_id = new System.Windows.Forms.TextBox();
            this.CustomerID = new System.Windows.Forms.TextBox();
            this.EmployeeID = new System.Windows.Forms.TextBox();
            this.Doctype = new System.Windows.Forms.TextBox();
            this.Status = new System.Windows.Forms.Label();
            this.DocNum = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.total_amt = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveOrderBtn = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "OrderNum";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.DeliveryDate);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox11);
            this.panel1.Controls.Add(this.CustomerRequest);
            this.panel1.Controls.Add(this.Orderstatus);
            this.panel1.Controls.Add(this.Service_order_id);
            this.panel1.Controls.Add(this.CustomerID);
            this.panel1.Controls.Add(this.EmployeeID);
            this.panel1.Controls.Add(this.Doctype);
            this.panel1.Controls.Add(this.Status);
            this.panel1.Controls.Add(this.DocNum);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(315, 249);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 156);
            this.panel1.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(254, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Comments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 15;
            this.label2.Text = "Delivery Date";
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.Location = new System.Drawing.Point(373, 42);
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Size = new System.Drawing.Size(211, 26);
            this.DeliveryDate.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 83);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Employee Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "CustomerID";
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(740, 106);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(100, 26);
            this.textBox11.TabIndex = 11;
            this.textBox11.Visible = false;
            // 
            // CustomerRequest
            // 
            this.CustomerRequest.Location = new System.Drawing.Point(373, 80);
            this.CustomerRequest.Name = "CustomerRequest";
            this.CustomerRequest.Size = new System.Drawing.Size(329, 26);
            this.CustomerRequest.TabIndex = 10;
            // 
            // Orderstatus
            // 
            this.Orderstatus.FormattingEnabled = true;
            this.Orderstatus.Items.AddRange(new object[] {
            "0: Received",
            "1: Inprogress",
            "2: Ready for Delivery"});
            this.Orderstatus.Location = new System.Drawing.Point(373, 7);
            this.Orderstatus.Name = "Orderstatus";
            this.Orderstatus.Size = new System.Drawing.Size(211, 28);
            this.Orderstatus.TabIndex = 9;
            this.Orderstatus.SelectedIndexChanged += new System.EventHandler(this.Orderstatus_SelectedIndexChanged);
            // 
            // Service_order_id
            // 
            this.Service_order_id.Location = new System.Drawing.Point(740, 40);
            this.Service_order_id.Name = "Service_order_id";
            this.Service_order_id.Size = new System.Drawing.Size(100, 26);
            this.Service_order_id.TabIndex = 8;
            this.Service_order_id.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.Location = new System.Drawing.Point(134, 47);
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Size = new System.Drawing.Size(100, 26);
            this.CustomerID.TabIndex = 7;
            // 
            // EmployeeID
            // 
            this.EmployeeID.Location = new System.Drawing.Point(134, 80);
            this.EmployeeID.Name = "EmployeeID";
            this.EmployeeID.Size = new System.Drawing.Size(100, 26);
            this.EmployeeID.TabIndex = 6;
            this.EmployeeID.TextChanged += new System.EventHandler(this.EmployeeID_TextChanged);
            // 
            // Doctype
            // 
            this.Doctype.Location = new System.Drawing.Point(740, 8);
            this.Doctype.Name = "Doctype";
            this.Doctype.Size = new System.Drawing.Size(100, 26);
            this.Doctype.TabIndex = 5;
            this.Doctype.Visible = false;
            this.Doctype.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(254, 12);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(56, 20);
            this.Status.TabIndex = 4;
            this.Status.Text = "Status";
            this.Status.Click += new System.EventHandler(this.label2_Click);
            // 
            // DocNum
            // 
            this.DocNum.Location = new System.Drawing.Point(134, 7);
            this.DocNum.Name = "DocNum";
            this.DocNum.Size = new System.Drawing.Size(100, 26);
            this.DocNum.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(391, 703);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Order Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.total_amt);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Location = new System.Drawing.Point(315, 408);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(843, 277);
            this.panel2.TabIndex = 5;
            // 
            // total_amt
            // 
            this.total_amt.Location = new System.Drawing.Point(134, 3);
            this.total_amt.Name = "total_amt";
            this.total_amt.Size = new System.Drawing.Size(100, 26);
            this.total_amt.TabIndex = 1;
            this.total_amt.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(16, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(812, 292);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // SaveOrderBtn
            // 
            this.SaveOrderBtn.Location = new System.Drawing.Point(885, 703);
            this.SaveOrderBtn.Name = "SaveOrderBtn";
            this.SaveOrderBtn.Size = new System.Drawing.Size(258, 34);
            this.SaveOrderBtn.TabIndex = 6;
            this.SaveOrderBtn.Text = "Save Order";
            this.SaveOrderBtn.UseVisualStyleBackColor = true;
            this.SaveOrderBtn.Click += new System.EventHandler(this.SaveOrderBtn_Click);
            // 
            // AddServiceOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.ClientSize = new System.Drawing.Size(1767, 1038);
            this.Controls.Add(this.SaveOrderBtn);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "AddServiceOrder";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.SaveOrderBtn, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox DocNum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveOrderBtn;
        private System.Windows.Forms.TextBox Doctype;
        private System.Windows.Forms.Label Status;
        private System.Windows.Forms.TextBox Service_order_id;
        private System.Windows.Forms.TextBox CustomerID;
        private System.Windows.Forms.TextBox EmployeeID;
        private System.Windows.Forms.ComboBox Orderstatus;
        private System.Windows.Forms.TextBox CustomerRequest;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DeliveryDate;
        private System.Windows.Forms.TextBox total_amt;
        private System.Windows.Forms.Label label5;
    }
}
