namespace Training
{
    partial class Training_Main
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
            this.button_Scheduling = new System.Windows.Forms.Button();
            this.button_Evaluation = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Scheduling
            // 
            this.button_Scheduling.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button_Scheduling.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Scheduling.Location = new System.Drawing.Point(353, 230);
            this.button_Scheduling.Name = "button_Scheduling";
            this.button_Scheduling.Size = new System.Drawing.Size(154, 88);
            this.button_Scheduling.TabIndex = 2;
            this.button_Scheduling.Text = "Scheduling";
            this.button_Scheduling.UseVisualStyleBackColor = false;
            this.button_Scheduling.Click += new System.EventHandler(this.button_Scheduling_Click);
            // 
            // button_Evaluation
            // 
            this.button_Evaluation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(255)))));
            this.button_Evaluation.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Evaluation.Location = new System.Drawing.Point(640, 230);
            this.button_Evaluation.Name = "button_Evaluation";
            this.button_Evaluation.Size = new System.Drawing.Size(154, 88);
            this.button_Evaluation.TabIndex = 3;
            this.button_Evaluation.Text = "Evaluation";
            this.button_Evaluation.UseVisualStyleBackColor = false;
            this.button_Evaluation.Click += new System.EventHandler(this.button_Evaluation_Click);
            // 
            // Training_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 736);
            this.Controls.Add(this.button_Evaluation);
            this.Controls.Add(this.button_Scheduling);
            this.Name = "Training_Main";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.button_Scheduling, 0);
            this.Controls.SetChildIndex(this.button_Evaluation, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_Scheduling;
        private System.Windows.Forms.Button button_Evaluation;
    }
}
