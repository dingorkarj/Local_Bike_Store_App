namespace SalesAndMarketing
{
    partial class PreSales
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SelectBundles = new System.Windows.Forms.Label();
            this.totalPriceLabel = new System.Windows.Forms.Label();
            this.originalPricelabel = new System.Windows.Forms.Label();
            this.Discountlabel = new System.Windows.Forms.Label();
            this.ORLabel = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // button_DisplaySelectedObject
            // 
            this.button_DisplaySelectedObject.Location = new System.Drawing.Point(20, 270);
            this.button_DisplaySelectedObject.Size = new System.Drawing.Size(112, 73);
            this.button_DisplaySelectedObject.Visible = true;
            this.button_DisplaySelectedObject.Click += new System.EventHandler(this.button_DisplaySelectedObject_Click);
            // 
            // button_ListObjects
            // 
            this.button_ListObjects.Visible = true;
            this.button_ListObjects.Click += new System.EventHandler(this.button_ListObjects_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button1.Location = new System.Drawing.Point(938, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select Individual Products";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(168, 214);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(433, 172);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_RowHeaderMouseClick);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(167, 417);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(433, 95);
            this.dataGridView2.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button2.Location = new System.Drawing.Point(938, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 67);
            this.button2.TabIndex = 3;
            this.button2.Text = "Proceed to CheckOut";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(716, 169);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(143, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Select Individual Product";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SelectBundles
            // 
            this.SelectBundles.AutoSize = true;
            this.SelectBundles.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectBundles.Location = new System.Drawing.Point(280, 176);
            this.SelectBundles.Name = "SelectBundles";
            this.SelectBundles.Size = new System.Drawing.Size(186, 18);
            this.SelectBundles.TabIndex = 6;
            this.SelectBundles.Text = "Select Promo Bundles";
            // 
            // totalPriceLabel
            // 
            this.totalPriceLabel.AutoSize = true;
            this.totalPriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalPriceLabel.Location = new System.Drawing.Point(551, 545);
            this.totalPriceLabel.Name = "totalPriceLabel";
            this.totalPriceLabel.Size = new System.Drawing.Size(91, 20);
            this.totalPriceLabel.TabIndex = 7;
            this.totalPriceLabel.Text = "Total Price: ";
            // 
            // originalPricelabel
            // 
            this.originalPricelabel.AutoSize = true;
            this.originalPricelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.originalPricelabel.Location = new System.Drawing.Point(551, 568);
            this.originalPricelabel.Name = "originalPricelabel";
            this.originalPricelabel.Size = new System.Drawing.Size(109, 20);
            this.originalPricelabel.TabIndex = 8;
            this.originalPricelabel.Text = "Original Price: ";
            // 
            // Discountlabel
            // 
            this.Discountlabel.AutoSize = true;
            this.Discountlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Discountlabel.Location = new System.Drawing.Point(551, 593);
            this.Discountlabel.Name = "Discountlabel";
            this.Discountlabel.Size = new System.Drawing.Size(136, 20);
            this.Discountlabel.TabIndex = 9;
            this.Discountlabel.Text = "Discount you get: ";
            // 
            // ORLabel
            // 
            this.ORLabel.AutoSize = true;
            this.ORLabel.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ORLabel.Location = new System.Drawing.Point(622, 176);
            this.ORLabel.Name = "ORLabel";
            this.ORLabel.Size = new System.Drawing.Size(38, 23);
            this.ORLabel.TabIndex = 10;
            this.ORLabel.Text = "OR";
            // 
            // PreSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 679);
            this.Controls.Add(this.ORLabel);
            this.Controls.Add(this.Discountlabel);
            this.Controls.Add(this.originalPricelabel);
            this.Controls.Add(this.totalPriceLabel);
            this.Controls.Add(this.SelectBundles);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "PreSales";
            this.Text = "PreSales";
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.SelectBundles, 0);
            this.Controls.SetChildIndex(this.totalPriceLabel, 0);
            this.Controls.SetChildIndex(this.originalPricelabel, 0);
            this.Controls.SetChildIndex(this.Discountlabel, 0);
            this.Controls.SetChildIndex(this.ORLabel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label SelectBundles;
        private System.Windows.Forms.Label totalPriceLabel;
        private System.Windows.Forms.Label originalPricelabel;
        private System.Windows.Forms.Label Discountlabel;
        private System.Windows.Forms.Label ORLabel;
    }
}