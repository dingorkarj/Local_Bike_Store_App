namespace Payroll
{
    partial class Payroll_Main
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
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button_GrossPay = new System.Windows.Forms.Button();
            this.button_Deductions = new System.Windows.Forms.Button();
            this.button_NetPay = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(308, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 63);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add Timecard";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(523, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 63);
            this.button2.TabIndex = 3;
            this.button2.Text = "Review Timecard";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(710, 216);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(107, 63);
            this.button3.TabIndex = 4;
            this.button3.Text = "Approve Timecard";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_GrossPay
            // 
            this.button_GrossPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button_GrossPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_GrossPay.Location = new System.Drawing.Point(308, 337);
            this.button_GrossPay.Name = "button_GrossPay";
            this.button_GrossPay.Size = new System.Drawing.Size(107, 63);
            this.button_GrossPay.TabIndex = 6;
            this.button_GrossPay.Text = "View Gross Pay";
            this.button_GrossPay.UseVisualStyleBackColor = false;
            this.button_GrossPay.Click += new System.EventHandler(this.button_GrossPay_Click);
            // 
            // button_Deductions
            // 
            this.button_Deductions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button_Deductions.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Deductions.Location = new System.Drawing.Point(522, 337);
            this.button_Deductions.Name = "button_Deductions";
            this.button_Deductions.Size = new System.Drawing.Size(107, 63);
            this.button_Deductions.TabIndex = 7;
            this.button_Deductions.Text = "View Deductions";
            this.button_Deductions.UseVisualStyleBackColor = false;
            this.button_Deductions.Click += new System.EventHandler(this.button_Deductions_Click);
            // 
            // button_NetPay
            // 
            this.button_NetPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button_NetPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_NetPay.Location = new System.Drawing.Point(712, 337);
            this.button_NetPay.Name = "button_NetPay";
            this.button_NetPay.Size = new System.Drawing.Size(107, 63);
            this.button_NetPay.TabIndex = 8;
            this.button_NetPay.Text = "View Net Pay";
            this.button_NetPay.UseVisualStyleBackColor = false;
            this.button_NetPay.Click += new System.EventHandler(this.button_NetPay_Click);
            // 
            // Payroll_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 733);
            this.Controls.Add(this.button_NetPay);
            this.Controls.Add(this.button_Deductions);
            this.Controls.Add(this.button_GrossPay);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Payroll_Main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.button3, 0);
            this.Controls.SetChildIndex(this.button_GrossPay, 0);
            this.Controls.SetChildIndex(this.button_Deductions, 0);
            this.Controls.SetChildIndex(this.button_NetPay, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button_GrossPay;
        private System.Windows.Forms.Button button_Deductions;
        private System.Windows.Forms.Button button_NetPay;
    }
}
