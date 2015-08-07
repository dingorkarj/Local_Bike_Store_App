namespace Payroll
{
    partial class DisplayGross
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
            this.textBox_comments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_ResetCommand = new System.Windows.Forms.Button();
            this.button_LoadSelectionList = new System.Windows.Forms.Button();
            this.textBox_TableName = new System.Windows.Forms.TextBox();
            this.label1_TableName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label_EmplID = new System.Windows.Forms.Label();
            this.label_ExtRef = new System.Windows.Forms.Label();
            this.label_Status = new System.Windows.Forms.Label();
            this.label_docRef = new System.Windows.Forms.Label();
            this.label_periodStart = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_grossAmount = new System.Windows.Forms.TextBox();
            this.label_workHours = new System.Windows.Forms.Label();
            this.textBox_endDate = new System.Windows.Forms.TextBox();
            this.textBox_empID = new System.Windows.Forms.TextBox();
            this.textBox_manID = new System.Windows.Forms.TextBox();
            this.textBox_status = new System.Windows.Forms.TextBox();
            this.textBox_docRef = new System.Windows.Forms.TextBox();
            this.textBox_startDate = new System.Windows.Forms.TextBox();
            this.textBox_DataStrings = new System.Windows.Forms.TextBox();
            this.textBox_Cmd = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_DisplayDoc = new System.Windows.Forms.Button();
            this.textBox_DocNum = new System.Windows.Forms.TextBox();
            this.label_DocNumber = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox_DocType = new System.Windows.Forms.TextBox();
            this.label_DocType = new System.Windows.Forms.Label();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_comments
            // 
            this.textBox_comments.Location = new System.Drawing.Point(307, 504);
            this.textBox_comments.Name = "textBox_comments";
            this.textBox_comments.Size = new System.Drawing.Size(278, 20);
            this.textBox_comments.TabIndex = 82;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(245, 509);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "Comments";
            // 
            // button_ResetCommand
            // 
            this.button_ResetCommand.Location = new System.Drawing.Point(515, 214);
            this.button_ResetCommand.Name = "button_ResetCommand";
            this.button_ResetCommand.Size = new System.Drawing.Size(70, 41);
            this.button_ResetCommand.TabIndex = 79;
            this.button_ResetCommand.Text = "Reset Command";
            this.button_ResetCommand.UseVisualStyleBackColor = true;
            this.button_ResetCommand.Visible = false;
            this.button_ResetCommand.Click += new System.EventHandler(this.button_ResetCommand_Click);
            // 
            // button_LoadSelectionList
            // 
            this.button_LoadSelectionList.Location = new System.Drawing.Point(597, 213);
            this.button_LoadSelectionList.Name = "button_LoadSelectionList";
            this.button_LoadSelectionList.Size = new System.Drawing.Size(70, 41);
            this.button_LoadSelectionList.TabIndex = 78;
            this.button_LoadSelectionList.Text = "Load Selections";
            this.button_LoadSelectionList.UseVisualStyleBackColor = true;
            this.button_LoadSelectionList.Visible = false;
            this.button_LoadSelectionList.Click += new System.EventHandler(this.button_LoadSelectionList_Click);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Location = new System.Drawing.Point(358, 196);
            this.textBox_TableName.Name = "textBox_TableName";
            this.textBox_TableName.ReadOnly = true;
            this.textBox_TableName.Size = new System.Drawing.Size(98, 20);
            this.textBox_TableName.TabIndex = 77;
            // 
            // label1_TableName
            // 
            this.label1_TableName.AutoSize = true;
            this.label1_TableName.Location = new System.Drawing.Point(247, 200);
            this.label1_TableName.Name = "label1_TableName";
            this.label1_TableName.Size = new System.Drawing.Size(65, 13);
            this.label1_TableName.TabIndex = 76;
            this.label1_TableName.Text = "Table Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_EmplID);
            this.panel1.Controls.Add(this.label_ExtRef);
            this.panel1.Controls.Add(this.label_Status);
            this.panel1.Controls.Add(this.label_docRef);
            this.panel1.Controls.Add(this.label_periodStart);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_grossAmount);
            this.panel1.Controls.Add(this.label_workHours);
            this.panel1.Controls.Add(this.textBox_empID);
            this.panel1.Controls.Add(this.textBox_manID);
            this.panel1.Controls.Add(this.textBox_endDate);
            this.panel1.Controls.Add(this.textBox_status);
            this.panel1.Controls.Add(this.textBox_docRef);
            this.panel1.Controls.Add(this.textBox_startDate);
            this.panel1.Location = new System.Drawing.Point(231, 273);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 220);
            this.panel1.TabIndex = 75;
            // 
            // label_EmplID
            // 
            this.label_EmplID.AutoSize = true;
            this.label_EmplID.Location = new System.Drawing.Point(18, 17);
            this.label_EmplID.Name = "label_EmplID";
            this.label_EmplID.Size = new System.Drawing.Size(67, 13);
            this.label_EmplID.TabIndex = 6;
            this.label_EmplID.Text = "Employee ID";
            // 
            // label_ExtRef
            // 
            this.label_ExtRef.AutoSize = true;
            this.label_ExtRef.Location = new System.Drawing.Point(19, 43);
            this.label_ExtRef.Name = "label_ExtRef";
            this.label_ExtRef.Size = new System.Drawing.Size(63, 13);
            this.label_ExtRef.TabIndex = 4;
            this.label_ExtRef.Text = "Manager ID";
            // 
            // label_Status
            // 
            this.label_Status.AutoSize = true;
            this.label_Status.Location = new System.Drawing.Point(18, 67);
            this.label_Status.Name = "label_Status";
            this.label_Status.Size = new System.Drawing.Size(37, 13);
            this.label_Status.TabIndex = 0;
            this.label_Status.Text = "Status";
            // 
            // label_docRef
            // 
            this.label_docRef.AutoSize = true;
            this.label_docRef.Location = new System.Drawing.Point(18, 92);
            this.label_docRef.Name = "label_docRef";
            this.label_docRef.Size = new System.Drawing.Size(44, 13);
            this.label_docRef.TabIndex = 12;
            this.label_docRef.Text = "DocRef";
            // 
            // label_periodStart
            // 
            this.label_periodStart.AutoSize = true;
            this.label_periodStart.Location = new System.Drawing.Point(14, 165);
            this.label_periodStart.Name = "label_periodStart";
            this.label_periodStart.Size = new System.Drawing.Size(88, 13);
            this.label_periodStart.TabIndex = 8;
            this.label_periodStart.Text = "Period Start Date";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 191);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Period End Date";
            // 
            // textBox_grossAmount
            // 
            this.textBox_grossAmount.Location = new System.Drawing.Point(127, 127);
            this.textBox_grossAmount.Name = "textBox_grossAmount";
            this.textBox_grossAmount.ReadOnly = true;
            this.textBox_grossAmount.Size = new System.Drawing.Size(93, 20);
            this.textBox_grossAmount.TabIndex = 30;
            // 
            // label_workHours
            // 
            this.label_workHours.AutoSize = true;
            this.label_workHours.Location = new System.Drawing.Point(16, 130);
            this.label_workHours.Name = "label_workHours";
            this.label_workHours.Size = new System.Drawing.Size(73, 13);
            this.label_workHours.TabIndex = 28;
            this.label_workHours.Text = "Gross Amount";
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Location = new System.Drawing.Point(128, 189);
            this.textBox_endDate.Name = "textBox_endDate";
            this.textBox_endDate.ReadOnly = true;
            this.textBox_endDate.Size = new System.Drawing.Size(93, 20);
            this.textBox_endDate.TabIndex = 27;
            // 
            // textBox_empID
            // 
            this.textBox_empID.Location = new System.Drawing.Point(128, 10);
            this.textBox_empID.Name = "textBox_empID";
            this.textBox_empID.ReadOnly = true;
            this.textBox_empID.Size = new System.Drawing.Size(96, 20);
            this.textBox_empID.TabIndex = 7;
            // 
            // textBox_manID
            // 
            this.textBox_manID.Location = new System.Drawing.Point(128, 36);
            this.textBox_manID.Name = "textBox_manID";
            this.textBox_manID.ReadOnly = true;
            this.textBox_manID.Size = new System.Drawing.Size(96, 20);
            this.textBox_manID.TabIndex = 5;
            // 
            // textBox_status
            // 
            this.textBox_status.Location = new System.Drawing.Point(128, 60);
            this.textBox_status.Name = "textBox_status";
            this.textBox_status.ReadOnly = true;
            this.textBox_status.Size = new System.Drawing.Size(96, 20);
            this.textBox_status.TabIndex = 1;
            // 
            // textBox_docRef
            // 
            this.textBox_docRef.Location = new System.Drawing.Point(128, 89);
            this.textBox_docRef.Name = "textBox_docRef";
            this.textBox_docRef.ReadOnly = true;
            this.textBox_docRef.Size = new System.Drawing.Size(96, 20);
            this.textBox_docRef.TabIndex = 13;
            // 
            // textBox_startDate
            // 
            this.textBox_startDate.Location = new System.Drawing.Point(127, 162);
            this.textBox_startDate.Name = "textBox_startDate";
            this.textBox_startDate.ReadOnly = true;
            this.textBox_startDate.Size = new System.Drawing.Size(96, 20);
            this.textBox_startDate.TabIndex = 9;
            // 
            // textBox_DataStrings
            // 
            this.textBox_DataStrings.Location = new System.Drawing.Point(476, 347);
            this.textBox_DataStrings.Multiline = true;
            this.textBox_DataStrings.Name = "textBox_DataStrings";
            this.textBox_DataStrings.Size = new System.Drawing.Size(500, 137);
            this.textBox_DataStrings.TabIndex = 74;
            this.textBox_DataStrings.Visible = false;
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Location = new System.Drawing.Point(498, 272);
            this.textBox_Cmd.Multiline = true;
            this.textBox_Cmd.Name = "textBox_Cmd";
            this.textBox_Cmd.Size = new System.Drawing.Size(425, 62);
            this.textBox_Cmd.TabIndex = 73;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(199, 534);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(860, 160);
            this.dataGridView1.TabIndex = 72;
            // 
            // button_DisplayDoc
            // 
            this.button_DisplayDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button_DisplayDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DisplayDoc.Location = new System.Drawing.Point(684, 200);
            this.button_DisplayDoc.Name = "button_DisplayDoc";
            this.button_DisplayDoc.Size = new System.Drawing.Size(112, 59);
            this.button_DisplayDoc.TabIndex = 71;
            this.button_DisplayDoc.Text = "Display Document";
            this.button_DisplayDoc.UseVisualStyleBackColor = false;
            this.button_DisplayDoc.Click += new System.EventHandler(this.button_DisplayDoc_Click);
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Location = new System.Drawing.Point(359, 221);
            this.textBox_DocNum.Name = "textBox_DocNum";
            this.textBox_DocNum.ReadOnly = true;
            this.textBox_DocNum.Size = new System.Drawing.Size(95, 20);
            this.textBox_DocNum.TabIndex = 70;
            // 
            // label_DocNumber
            // 
            this.label_DocNumber.AutoSize = true;
            this.label_DocNumber.Location = new System.Drawing.Point(245, 221);
            this.label_DocNumber.Name = "label_DocNumber";
            this.label_DocNumber.Size = new System.Drawing.Size(96, 13);
            this.label_DocNumber.TabIndex = 69;
            this.label_DocNumber.Text = "Document Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(238, 170);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Select Document";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(359, 168);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(437, 21);
            this.comboBox1.TabIndex = 67;
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Location = new System.Drawing.Point(359, 247);
            this.textBox_DocType.Name = "textBox_DocType";
            this.textBox_DocType.ReadOnly = true;
            this.textBox_DocType.Size = new System.Drawing.Size(98, 20);
            this.textBox_DocType.TabIndex = 64;
            // 
            // label_DocType
            // 
            this.label_DocType.AutoSize = true;
            this.label_DocType.Location = new System.Drawing.Point(245, 249);
            this.label_DocType.Name = "label_DocType";
            this.label_DocType.Size = new System.Drawing.Size(83, 13);
            this.label_DocType.TabIndex = 63;
            this.label_DocType.Text = "Document Type";
            // 
            // DisplayGross
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 733);
            this.Controls.Add(this.textBox_comments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ResetCommand);
            this.Controls.Add(this.button_LoadSelectionList);
            this.Controls.Add(this.textBox_TableName);
            this.Controls.Add(this.label1_TableName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.textBox_DataStrings);
            this.Controls.Add(this.textBox_Cmd);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_DisplayDoc);
            this.Controls.Add(this.textBox_DocNum);
            this.Controls.Add(this.label_DocNumber);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox_DocType);
            this.Controls.Add(this.label_DocType);
            this.Name = "DisplayGross";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.label_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label_DocNumber, 0);
            this.Controls.SetChildIndex(this.textBox_DocNum, 0);
            this.Controls.SetChildIndex(this.button_DisplayDoc, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.textBox_Cmd, 0);
            this.Controls.SetChildIndex(this.textBox_DataStrings, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.label1_TableName, 0);
            this.Controls.SetChildIndex(this.textBox_TableName, 0);
            this.Controls.SetChildIndex(this.button_LoadSelectionList, 0);
            this.Controls.SetChildIndex(this.button_ResetCommand, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox_comments, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.TextBox textBox_comments;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.Button button_ResetCommand;
        protected System.Windows.Forms.Button button_LoadSelectionList;
        protected System.Windows.Forms.TextBox textBox_TableName;
        private System.Windows.Forms.Label label1_TableName;
        private System.Windows.Forms.Panel panel1;
        protected System.Windows.Forms.Label label_EmplID;
        protected System.Windows.Forms.Label label_ExtRef;
        protected System.Windows.Forms.Label label_Status;
        protected System.Windows.Forms.Label label_docRef;
        protected System.Windows.Forms.Label label_periodStart;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.TextBox textBox_grossAmount;
        protected System.Windows.Forms.Label label_workHours;
        protected System.Windows.Forms.TextBox textBox_endDate;
        protected System.Windows.Forms.TextBox textBox_empID;
        protected System.Windows.Forms.TextBox textBox_manID;
        protected System.Windows.Forms.TextBox textBox_status;
        protected System.Windows.Forms.TextBox textBox_docRef;
        protected System.Windows.Forms.TextBox textBox_startDate;
        private System.Windows.Forms.TextBox textBox_DataStrings;
        protected System.Windows.Forms.TextBox textBox_Cmd;
        private System.Windows.Forms.DataGridView dataGridView1;
        protected System.Windows.Forms.Button button_DisplayDoc;
        protected System.Windows.Forms.TextBox textBox_DocNum;
        private System.Windows.Forms.Label label_DocNumber;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox1;
        protected System.Windows.Forms.TextBox textBox_DocType;
        private System.Windows.Forms.Label label_DocType;
    }
}
