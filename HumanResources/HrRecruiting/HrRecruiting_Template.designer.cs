namespace HrRecruiting
{
    partial class HrRecruiting_Template
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_DisplaySelectedObject
            // 
   //         this.button_DisplaySelectedObject.Click += new System.EventHandler(this.button_DisplaySelectedObject_Click);
            // 
            // button_ListObjects
            // 
   //         this.button_ListObjects.Click += new System.EventHandler(this.button_ListObjects_Click);
            // 
            // panel_TopPanel
            // 
            this.panel_TopPanel.Controls.Add(this.label3);
            this.panel_TopPanel.Controls.Add(this.label2);
            this.panel_TopPanel.Controls.SetChildIndex(this.pictureBox_LeftLogo, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.pictureBox_RightLogo, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_UserPre, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_UserID, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_Connector, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_UserName, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label_SubName, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label2, 0);
            this.panel_TopPanel.Controls.SetChildIndex(this.label3, 0);
            // 
            // pictureBox_RightLogo
            // 
            this.pictureBox_RightLogo.Click += new System.EventHandler(this.pictureBox_RightLogo_Click);
            // 
            // pictureBox_LeftLogo
            // 
            this.pictureBox_LeftLogo.Click += new System.EventHandler(this.pictureBox_LeftLogo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(389, 275);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 68);
            this.button1.TabIndex = 2;
            this.button1.Text = "HR Recruiting";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(735, 275);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(174, 68);
            this.button2.TabIndex = 3;
            this.button2.Text = "HR Benefits";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(441, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(330, 57);
            this.label2.TabIndex = 59;
            this.label2.Text = "Local Bikes, Inc.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(519, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 28);
            this.label3.TabIndex = 60;
            this.label3.Text = "HR Resources";
            // 
            // HrRecruiting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "HrRecruiting";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}
