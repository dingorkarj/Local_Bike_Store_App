namespace Purchases
{
    partial class Deliveries_List
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
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.textBox_CMD = new System.Windows.Forms.TextBox();
            this.button_Display = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Status = new System.Windows.Forms.TextBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radioBtn_SalesOrders = new System.Windows.Forms.RadioButton();
            this.radioBtn_Invoices = new System.Windows.Forms.RadioButton();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Supplier";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "all suppliers"});
            this.comboBox1.Location = new System.Drawing.Point(289, 154);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.Location = new System.Drawing.Point(481, 158);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.Size = new System.Drawing.Size(150, 20);
            this.textBox_Supplier.TabIndex = 4;
            // 
            // textBox_CMD
            // 
            this.textBox_CMD.Location = new System.Drawing.Point(652, 155);
            this.textBox_CMD.Multiline = true;
            this.textBox_CMD.Name = "textBox_CMD";
            this.textBox_CMD.Size = new System.Drawing.Size(254, 104);
            this.textBox_CMD.TabIndex = 5;
            this.textBox_CMD.Text = "select * from " + PODConstants.DELIVERY_TABLE_NAME + " Where DocType = 13"; ;
            // 
            // button_Display
            // 
            this.button_Display.Location = new System.Drawing.Point(481, 224);
            this.button_Display.Name = "button_Display";
            this.button_Display.Size = new System.Drawing.Size(133, 35);
            this.button_Display.TabIndex = 6;
            this.button_Display.Text = "display results";
            this.button_Display.UseVisualStyleBackColor = true;
            this.button_Display.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(204, 277);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(715, 244);
            this.dataGridView1.TabIndex = 7;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // textBox_Status
            // 
            this.textBox_Status.Location = new System.Drawing.Point(483, 194);
            this.textBox_Status.Name = "textBox_Status";
            this.textBox_Status.Size = new System.Drawing.Size(150, 20);
            this.textBox_Status.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "all status",
            "0:   no status assigned",
            "1:   in preparation",
            "2:   prepared, not sent",
            "3:   sent",
            "4:   completed (paid)",
            "5:   overdue",
            "6:   inconsistent amount",
            "7:   other problem"});
            this.comboBox2.Location = new System.Drawing.Point(291, 190);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(158, 21);
            this.comboBox2.TabIndex = 9;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(218, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Status";
            // 
            // radioBtn_SalesOrders
            // 
            this.radioBtn_SalesOrders.AutoSize = true;
            this.radioBtn_SalesOrders.Location = new System.Drawing.Point(289, 224);
            this.radioBtn_SalesOrders.Name = "radioBtn_SalesOrders";
            this.radioBtn_SalesOrders.Size = new System.Drawing.Size(104, 17);
            this.radioBtn_SalesOrders.TabIndex = 11;
            this.radioBtn_SalesOrders.Text = "Purchase Orders";
            this.radioBtn_SalesOrders.UseVisualStyleBackColor = true;
            this.radioBtn_SalesOrders.Visible = false;
            // 
            // radioBtn_Invoices
            // 
            this.radioBtn_Invoices.AutoSize = true;
            this.radioBtn_Invoices.Checked = true;
            this.radioBtn_Invoices.Location = new System.Drawing.Point(289, 248);
            this.radioBtn_Invoices.Name = "radioBtn_Invoices";
            this.radioBtn_Invoices.Size = new System.Drawing.Size(71, 17);
            this.radioBtn_Invoices.TabIndex = 12;
            this.radioBtn_Invoices.TabStop = true;
            this.radioBtn_Invoices.Text = "Deliveries";
            this.radioBtn_Invoices.UseVisualStyleBackColor = true;
            this.radioBtn_Invoices.Visible = false;
            // 
            // Deliveries_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(940, 650);
            this.Controls.Add(this.radioBtn_Invoices);
            this.Controls.Add(this.radioBtn_SalesOrders);
            this.Controls.Add(this.textBox_Status);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Display);
            this.Controls.Add(this.textBox_CMD);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Name = "Deliveries_List";
            this.Text = "List of Purchase Orders";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.textBox_Supplier, 0);
            this.Controls.SetChildIndex(this.textBox_CMD, 0);
            this.Controls.SetChildIndex(this.button_Display, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.comboBox2, 0);
            this.Controls.SetChildIndex(this.textBox_Status, 0);
            this.Controls.SetChildIndex(this.radioBtn_SalesOrders, 0);
            this.Controls.SetChildIndex(this.radioBtn_Invoices, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.TextBox textBox_CMD;
        private System.Windows.Forms.Button button_Display;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Status;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBtn_SalesOrders;
        private System.Windows.Forms.RadioButton radioBtn_Invoices;
    }
}

