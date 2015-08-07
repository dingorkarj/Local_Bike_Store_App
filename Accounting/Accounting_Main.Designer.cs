namespace Accounting
{
    partial class Accounting_Main
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
            this.button_AccPayable = new System.Windows.Forms.Button();
            this.button_AccReceivable = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label_SubName
            // 
            this.label_SubName.Location = new System.Drawing.Point(482, 77);
            this.label_SubName.Size = new System.Drawing.Size(126, 28);
            this.label_SubName.Text = " Accounting";
            // 
            // button_AccPayable
            // 
            this.button_AccPayable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button_AccPayable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button_AccPayable.Location = new System.Drawing.Point(339, 243);
            this.button_AccPayable.Name = "button_AccPayable";
            this.button_AccPayable.Size = new System.Drawing.Size(123, 64);
            this.button_AccPayable.TabIndex = 9;
            this.button_AccPayable.Text = "Accounts Payable";
            this.button_AccPayable.UseVisualStyleBackColor = false;
            this.button_AccPayable.Click += new System.EventHandler(this.button_AccPayable_Click);
            // 
            // button_AccReceivable
            // 
            this.button_AccReceivable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button_AccReceivable.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.button_AccReceivable.Location = new System.Drawing.Point(611, 242);
            this.button_AccReceivable.Name = "button_AccReceivable";
            this.button_AccReceivable.Size = new System.Drawing.Size(123, 64);
            this.button_AccReceivable.TabIndex = 10;
            this.button_AccReceivable.Text = "Accounts Receivable";
            this.button_AccReceivable.UseVisualStyleBackColor = false;
            this.button_AccReceivable.Click += new System.EventHandler(this.button_AccReceivable_Click);
            // 
            // Accounting_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.button_AccReceivable);
            this.Controls.Add(this.button_AccPayable);
            this.Name = "Accounting_Main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button_AccPayable, 0);
            this.Controls.SetChildIndex(this.button_AccReceivable, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AccPayable;
        private System.Windows.Forms.Button button_AccReceivable;

       
    }
}
