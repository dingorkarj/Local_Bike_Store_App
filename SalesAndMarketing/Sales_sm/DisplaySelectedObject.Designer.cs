namespace Sales_sm
{
    partial class DisplaySelectedObject
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_Cmd.Size = new System.Drawing.Size(425, 42);
            this.textBox_Cmd.Text = " select * from  Service_Order";
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Margin = new System.Windows.Forms.Padding(2);
            this.textBox_TableName.Text = "Service_Order";
            // 
            // textBox_ProcessID
            // 
            this.textBox_ProcessID.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_IntAgent
            // 
            this.textBox_IntAgent.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_ExtAgent
            // 
            this.textBox_ExtAgent.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_TextValue1
            // 
            this.textBox_TextValue1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_Status
            // 
            this.textBox_Status.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_TextValue2
            // 
            this.textBox_TextValue2.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_NumValue1
            // 
            this.textBox_NumValue1.Margin = new System.Windows.Forms.Padding(2);
            // 
            // textBox_NumValue2
            // 
            this.textBox_NumValue2.Margin = new System.Windows.Forms.Padding(2);
            // 
            // button_DisplayDoc
            // 
            this.button_DisplayDoc.Click += new System.EventHandler(this.button_DisplayDoc_Click);
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Margin = new System.Windows.Forms.Padding(2);
            // 
            // label_SubName
            // 
            this.label_SubName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_SubName.Size = new System.Drawing.Size(182, 28);
            this.label_SubName.Text = "Sales and Services";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(186, 499);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(861, 169);
            this.dataGridView2.TabIndex = 42;
            // 
            // DisplaySelectedObject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1058, 668);
            this.Controls.Add(this.dataGridView2);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "DisplaySelectedObject";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_Comment, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_DisplayDoc, 0);
            this.Controls.SetChildIndex(this.textBox_Cmd, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.button_LoadSelectionList, 0);
            this.Controls.SetChildIndex(this.button_ResetCommand, 0);
            this.Controls.SetChildIndex(this.button_ChangeDoc, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
