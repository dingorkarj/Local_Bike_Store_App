namespace Training_Scheduling
{
    partial class ClassRoster
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
            this.Label9 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblsessionid = new System.Windows.Forms.Label();
            this.cmbsessionid = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Modern No. 20", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label9.Location = new System.Drawing.Point(505, 147);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(123, 24);
            this.Label9.TabIndex = 107;
            this.Label9.Text = "Class Roster";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(237, 302);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(723, 224);
            this.dataGridView1.TabIndex = 110;
            // 
            // lblsessionid
            // 
            this.lblsessionid.AutoSize = true;
            this.lblsessionid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsessionid.Location = new System.Drawing.Point(442, 219);
            this.lblsessionid.Name = "lblsessionid";
            this.lblsessionid.Size = new System.Drawing.Size(97, 20);
            this.lblsessionid.TabIndex = 111;
            this.lblsessionid.Text = "Session ID";
            // 
            // cmbsessionid
            // 
            this.cmbsessionid.FormattingEnabled = true;
            this.cmbsessionid.Location = new System.Drawing.Point(575, 218);
            this.cmbsessionid.Name = "cmbsessionid";
            this.cmbsessionid.Size = new System.Drawing.Size(121, 21);
            this.cmbsessionid.TabIndex = 112;
            this.cmbsessionid.SelectedIndexChanged += new System.EventHandler(this.cmbsessionid_SelectedIndexChanged_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(406, 255);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(386, 13);
            this.label1.TabIndex = 113;
            this.label1.Text = "Select the Session Id to view the customers who have registered for the Training";
            // 
            // ClassRoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbsessionid);
            this.Controls.Add(this.lblsessionid);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Label9);
            this.Name = "ClassRoster";
            this.Load += new System.EventHandler(this.ClassRoster_Load);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.Label9, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.lblsessionid, 0);
            this.Controls.SetChildIndex(this.cmbsessionid, 0);
            this.Controls.SetChildIndex(this.label1, 0);
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

        internal System.Windows.Forms.Label Label9;
        private System.Windows.Forms.DataGridView dataGridView1;
        internal System.Windows.Forms.Label lblsessionid;
        private System.Windows.Forms.ComboBox cmbsessionid;
        private System.Windows.Forms.Label label1;
    }
}
