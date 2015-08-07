namespace Accounting.Account_Payable
{
    partial class Account_Payable_Main
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
            this.DeliveryDocGdview = new System.Windows.Forms.DataGridView();
            this.btnMakePayment = new System.Windows.Forms.Button();
            this.btndiplayDdoc = new System.Windows.Forms.Button();
            this.btnUpdateAccPayable = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button_DisplayPayableDocs = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDocGdview)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Return
            // 
            this.button_Return.Location = new System.Drawing.Point(20, 19);
            // 
            // label_SubName
            // 
            this.label_SubName.Size = new System.Drawing.Size(0, 28);
            this.label_SubName.Text = "";
            // 
            // DeliveryDocGdview
            // 
            this.DeliveryDocGdview.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeliveryDocGdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DeliveryDocGdview.Location = new System.Drawing.Point(191, 264);
            this.DeliveryDocGdview.Name = "DeliveryDocGdview";
            this.DeliveryDocGdview.Size = new System.Drawing.Size(939, 263);
            this.DeliveryDocGdview.TabIndex = 7;
            this.DeliveryDocGdview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DeliveryDocGdview_CellContentClick);
            // 
            // btnMakePayment
            // 
            this.btnMakePayment.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.btnMakePayment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnMakePayment.Location = new System.Drawing.Point(508, 155);
            this.btnMakePayment.Name = "btnMakePayment";
            this.btnMakePayment.Size = new System.Drawing.Size(112, 73);
            this.btnMakePayment.TabIndex = 6;
            this.btnMakePayment.Text = "  Make   Payment";
            this.btnMakePayment.UseVisualStyleBackColor = false;
            this.btnMakePayment.Click += new System.EventHandler(this.btnMakePayment_Click);
            // 
            // btndiplayDdoc
            // 
            this.btndiplayDdoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.btndiplayDdoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btndiplayDdoc.Location = new System.Drawing.Point(202, 151);
            this.btndiplayDdoc.Name = "btndiplayDdoc";
            this.btndiplayDdoc.Size = new System.Drawing.Size(108, 73);
            this.btndiplayDdoc.TabIndex = 5;
            this.btndiplayDdoc.Text = "Display Delivery Documents";
            this.btndiplayDdoc.UseVisualStyleBackColor = false;
            this.btndiplayDdoc.Click += new System.EventHandler(this.btndiplayDdoc_Click);
            // 
            // btnUpdateAccPayable
            // 
            this.btnUpdateAccPayable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.btnUpdateAccPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.btnUpdateAccPayable.Location = new System.Drawing.Point(669, 160);
            this.btnUpdateAccPayable.Name = "btnUpdateAccPayable";
            this.btnUpdateAccPayable.Size = new System.Drawing.Size(106, 69);
            this.btnUpdateAccPayable.TabIndex = 8;
            this.btnUpdateAccPayable.Text = "Update Account Payable";
            this.btnUpdateAccPayable.UseVisualStyleBackColor = false;
            this.btnUpdateAccPayable.Click += new System.EventHandler(this.btnUpdateButton_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(839, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 70);
            this.button1.TabIndex = 9;
            this.button1.Text = "Crystal   Report";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_CrystalReport_Click);
            // 
            // button_DisplayPayableDocs
            // 
            this.button_DisplayPayableDocs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.button_DisplayPayableDocs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button_DisplayPayableDocs.Location = new System.Drawing.Point(355, 153);
            this.button_DisplayPayableDocs.Name = "button_DisplayPayableDocs";
            this.button_DisplayPayableDocs.Size = new System.Drawing.Size(108, 73);
            this.button_DisplayPayableDocs.TabIndex = 10;
            this.button_DisplayPayableDocs.Text = "Display Payable Documents";
            this.button_DisplayPayableDocs.UseVisualStyleBackColor = false;
            this.button_DisplayPayableDocs.Click += new System.EventHandler(this.button_DisplayPayableDocs_Click);
            // 
            // Account_Payable_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.button_DisplayPayableDocs);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdateAccPayable);
            this.Controls.Add(this.DeliveryDocGdview);
            this.Controls.Add(this.btnMakePayment);
            this.Controls.Add(this.btndiplayDdoc);
            this.Name = "Account_Payable_Main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.btndiplayDdoc, 0);
            this.Controls.SetChildIndex(this.btnMakePayment, 0);
            this.Controls.SetChildIndex(this.DeliveryDocGdview, 0);
            this.Controls.SetChildIndex(this.btnUpdateAccPayable, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button_DisplayPayableDocs, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DeliveryDocGdview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DeliveryDocGdview;
        private System.Windows.Forms.Button btnMakePayment;
        private System.Windows.Forms.Button btndiplayDdoc;
        private System.Windows.Forms.Button btnUpdateAccPayable;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_DisplayPayableDocs;
    }
}
