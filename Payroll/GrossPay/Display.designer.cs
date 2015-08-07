namespace Payroll
{
    partial class Display
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
            this.button_ChangeDoc = new System.Windows.Forms.Button();
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
            this.textBox_overTime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_workHours = new System.Windows.Forms.TextBox();
            this.label_workHours = new System.Windows.Forms.Label();
            this.textBox_endDate = new System.Windows.Forms.TextBox();
            this.label_overtime = new System.Windows.Forms.Label();
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
            this.textBox_approval = new System.Windows.Forms.TextBox();
            this.label_Approval = new System.Windows.Forms.Label();
            this.textBox_DocType = new System.Windows.Forms.TextBox();
            this.label_DocType = new System.Windows.Forms.Label();
            this.textBox_comments = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_approve = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Return
            // 
            this.button_Return.Click += new System.EventHandler(this.button_Return_Click_1);
            // 
            // button_ChangeDoc
            // 
            this.button_ChangeDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button_ChangeDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ChangeDoc.Location = new System.Drawing.Point(787, 190);
            this.button_ChangeDoc.Name = "button_ChangeDoc";
            this.button_ChangeDoc.Size = new System.Drawing.Size(90, 59);
            this.button_ChangeDoc.TabIndex = 59;
            this.button_ChangeDoc.Text = "Edit Record";
            this.button_ChangeDoc.UseVisualStyleBackColor = false;
            this.button_ChangeDoc.Click += new System.EventHandler(this.button_ChangeDoc_Click_1);
            // 
            // button_ResetCommand
            // 
            this.button_ResetCommand.Location = new System.Drawing.Point(469, 204);
            this.button_ResetCommand.Name = "button_ResetCommand";
            this.button_ResetCommand.Size = new System.Drawing.Size(70, 41);
            this.button_ResetCommand.TabIndex = 58;
            this.button_ResetCommand.Text = "Reset Command";
            this.button_ResetCommand.UseVisualStyleBackColor = true;
            this.button_ResetCommand.Visible = false;
            this.button_ResetCommand.Click += new System.EventHandler(this.button_ResetCommand_Click_1);
            // 
            // button_LoadSelectionList
            // 
            this.button_LoadSelectionList.Location = new System.Drawing.Point(551, 203);
            this.button_LoadSelectionList.Name = "button_LoadSelectionList";
            this.button_LoadSelectionList.Size = new System.Drawing.Size(70, 41);
            this.button_LoadSelectionList.TabIndex = 57;
            this.button_LoadSelectionList.Text = "Load Selections";
            this.button_LoadSelectionList.UseVisualStyleBackColor = true;
            this.button_LoadSelectionList.Visible = false;
            this.button_LoadSelectionList.Click += new System.EventHandler(this.button_LoadSelectionList_Click);
            // 
            // textBox_TableName
            // 
            this.textBox_TableName.Location = new System.Drawing.Point(312, 186);
            this.textBox_TableName.Name = "textBox_TableName";
            this.textBox_TableName.ReadOnly = true;
            this.textBox_TableName.Size = new System.Drawing.Size(98, 20);
            this.textBox_TableName.TabIndex = 56;
            // 
            // label1_TableName
            // 
            this.label1_TableName.AutoSize = true;
            this.label1_TableName.Location = new System.Drawing.Point(201, 190);
            this.label1_TableName.Name = "label1_TableName";
            this.label1_TableName.Size = new System.Drawing.Size(65, 13);
            this.label1_TableName.TabIndex = 55;
            this.label1_TableName.Text = "Table Name";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label_EmplID);
            this.panel1.Controls.Add(this.label_ExtRef);
            this.panel1.Controls.Add(this.label_Status);
            this.panel1.Controls.Add(this.label_docRef);
            this.panel1.Controls.Add(this.label_periodStart);
            this.panel1.Controls.Add(this.textBox_overTime);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_workHours);
            this.panel1.Controls.Add(this.label_workHours);
            this.panel1.Controls.Add(this.textBox_endDate);
            this.panel1.Controls.Add(this.label_overtime);
            this.panel1.Controls.Add(this.textBox_empID);
            this.panel1.Controls.Add(this.textBox_manID);
            this.panel1.Controls.Add(this.textBox_status);
            this.panel1.Controls.Add(this.textBox_docRef);
            this.panel1.Controls.Add(this.textBox_startDate);
            this.panel1.Location = new System.Drawing.Point(185, 263);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 220);
            this.panel1.TabIndex = 54;
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
            this.label_periodStart.Location = new System.Drawing.Point(17, 123);
            this.label_periodStart.Name = "label_periodStart";
            this.label_periodStart.Size = new System.Drawing.Size(88, 13);
            this.label_periodStart.TabIndex = 8;
            this.label_periodStart.Text = "Period Start Date";
            // 
            // textBox_overTime
            // 
            this.textBox_overTime.Location = new System.Drawing.Point(132, 199);
            this.textBox_overTime.Name = "textBox_overTime";
            this.textBox_overTime.ReadOnly = true;
            this.textBox_overTime.Size = new System.Drawing.Size(93, 20);
            this.textBox_overTime.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(85, 13);
            this.label10.TabIndex = 26;
            this.label10.Text = "Period End Date";
            // 
            // textBox_workHours
            // 
            this.textBox_workHours.Location = new System.Drawing.Point(130, 173);
            this.textBox_workHours.Name = "textBox_workHours";
            this.textBox_workHours.ReadOnly = true;
            this.textBox_workHours.Size = new System.Drawing.Size(93, 20);
            this.textBox_workHours.TabIndex = 30;
            // 
            // label_workHours
            // 
            this.label_workHours.AutoSize = true;
            this.label_workHours.Location = new System.Drawing.Point(16, 174);
            this.label_workHours.Name = "label_workHours";
            this.label_workHours.Size = new System.Drawing.Size(64, 13);
            this.label_workHours.TabIndex = 28;
            this.label_workHours.Text = "Work Hours";
            // 
            // textBox_endDate
            // 
            this.textBox_endDate.Location = new System.Drawing.Point(131, 147);
            this.textBox_endDate.Name = "textBox_endDate";
            this.textBox_endDate.ReadOnly = true;
            this.textBox_endDate.Size = new System.Drawing.Size(93, 20);
            this.textBox_endDate.TabIndex = 27;
            // 
            // label_overtime
            // 
            this.label_overtime.AutoSize = true;
            this.label_overtime.Location = new System.Drawing.Point(16, 199);
            this.label_overtime.Name = "label_overtime";
            this.label_overtime.Size = new System.Drawing.Size(49, 13);
            this.label_overtime.TabIndex = 29;
            this.label_overtime.Text = "Overtime";
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
            this.textBox_startDate.Location = new System.Drawing.Point(130, 120);
            this.textBox_startDate.Name = "textBox_startDate";
            this.textBox_startDate.ReadOnly = true;
            this.textBox_startDate.Size = new System.Drawing.Size(96, 20);
            this.textBox_startDate.TabIndex = 9;
            // 
            // textBox_DataStrings
            // 
            this.textBox_DataStrings.Location = new System.Drawing.Point(452, 341);
            this.textBox_DataStrings.Multiline = true;
            this.textBox_DataStrings.Name = "textBox_DataStrings";
            this.textBox_DataStrings.Size = new System.Drawing.Size(500, 137);
            this.textBox_DataStrings.TabIndex = 53;
            this.textBox_DataStrings.Visible = false;
            // 
            // textBox_Cmd
            // 
            this.textBox_Cmd.Location = new System.Drawing.Point(452, 262);
            this.textBox_Cmd.Multiline = true;
            this.textBox_Cmd.Name = "textBox_Cmd";
            this.textBox_Cmd.Size = new System.Drawing.Size(425, 62);
            this.textBox_Cmd.TabIndex = 52;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(153, 524);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(860, 160);
            this.dataGridView1.TabIndex = 51;
            // 
            // button_DisplayDoc
            // 
            this.button_DisplayDoc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button_DisplayDoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DisplayDoc.Location = new System.Drawing.Point(810, 150);
            this.button_DisplayDoc.Name = "button_DisplayDoc";
            this.button_DisplayDoc.Size = new System.Drawing.Size(38, 34);
            this.button_DisplayDoc.TabIndex = 50;
            this.button_DisplayDoc.Text = "Display Document";
            this.button_DisplayDoc.UseVisualStyleBackColor = false;
            this.button_DisplayDoc.Visible = false;
            this.button_DisplayDoc.Click += new System.EventHandler(this.button_DisplayDoc_Click);
            // 
            // textBox_DocNum
            // 
            this.textBox_DocNum.Location = new System.Drawing.Point(313, 211);
            this.textBox_DocNum.Name = "textBox_DocNum";
            this.textBox_DocNum.ReadOnly = true;
            this.textBox_DocNum.Size = new System.Drawing.Size(95, 20);
            this.textBox_DocNum.TabIndex = 49;
            // 
            // label_DocNumber
            // 
            this.label_DocNumber.AutoSize = true;
            this.label_DocNumber.Location = new System.Drawing.Point(199, 211);
            this.label_DocNumber.Name = "label_DocNumber";
            this.label_DocNumber.Size = new System.Drawing.Size(96, 13);
            this.label_DocNumber.TabIndex = 48;
            this.label_DocNumber.Text = "Document Number";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(192, 160);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 47;
            this.label8.Text = "Select Document";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(313, 158);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(437, 21);
            this.comboBox1.TabIndex = 46;
            // 
            // textBox_approval
            // 
            this.textBox_approval.Location = new System.Drawing.Point(278, 491);
            this.textBox_approval.Name = "textBox_approval";
            this.textBox_approval.ReadOnly = true;
            this.textBox_approval.Size = new System.Drawing.Size(85, 20);
            this.textBox_approval.TabIndex = 45;
            // 
            // label_Approval
            // 
            this.label_Approval.AutoSize = true;
            this.label_Approval.Location = new System.Drawing.Point(183, 494);
            this.label_Approval.Name = "label_Approval";
            this.label_Approval.Size = new System.Drawing.Size(82, 13);
            this.label_Approval.TabIndex = 44;
            this.label_Approval.Text = "Approval Status";
            // 
            // textBox_DocType
            // 
            this.textBox_DocType.Location = new System.Drawing.Point(313, 237);
            this.textBox_DocType.Name = "textBox_DocType";
            this.textBox_DocType.ReadOnly = true;
            this.textBox_DocType.Size = new System.Drawing.Size(98, 20);
            this.textBox_DocType.TabIndex = 43;
            // 
            // label_DocType
            // 
            this.label_DocType.AutoSize = true;
            this.label_DocType.Location = new System.Drawing.Point(199, 239);
            this.label_DocType.Name = "label_DocType";
            this.label_DocType.Size = new System.Drawing.Size(83, 13);
            this.label_DocType.TabIndex = 42;
            this.label_DocType.Text = "Document Type";
            // 
            // textBox_comments
            // 
            this.textBox_comments.Location = new System.Drawing.Point(517, 491);
            this.textBox_comments.Name = "textBox_comments";
            this.textBox_comments.Size = new System.Drawing.Size(278, 20);
            this.textBox_comments.TabIndex = 61;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(455, 496);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 60;
            this.label1.Text = "Comments";
            // 
            // button_approve
            // 
            this.button_approve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(155)))), ((int)(((byte)(255)))));
            this.button_approve.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_approve.Location = new System.Drawing.Point(663, 190);
            this.button_approve.Name = "button_approve";
            this.button_approve.Size = new System.Drawing.Size(101, 62);
            this.button_approve.TabIndex = 62;
            this.button_approve.Text = "Approve";
            this.button_approve.UseVisualStyleBackColor = false;
            this.button_approve.Click += new System.EventHandler(this.button_approve_Click);
            // 
            // Display
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(1178, 733);
            this.Controls.Add(this.button_approve);
            this.Controls.Add(this.textBox_comments);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_ChangeDoc);
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
            this.Controls.Add(this.textBox_approval);
            this.Controls.Add(this.label_Approval);
            this.Controls.Add(this.textBox_DocType);
            this.Controls.Add(this.label_DocType);
            this.Name = "Display";
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.label_DocType, 0);
            this.Controls.SetChildIndex(this.textBox_DocType, 0);
            this.Controls.SetChildIndex(this.label_Approval, 0);
            this.Controls.SetChildIndex(this.textBox_approval, 0);
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
            this.Controls.SetChildIndex(this.button_ChangeDoc, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textBox_comments, 0);
            this.Controls.SetChildIndex(this.button_approve, 0);
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

        protected System.Windows.Forms.Button button_ChangeDoc;
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
        protected System.Windows.Forms.TextBox textBox_overTime;
        protected System.Windows.Forms.Label label10;
        protected System.Windows.Forms.TextBox textBox_workHours;
        protected System.Windows.Forms.Label label_workHours;
        protected System.Windows.Forms.TextBox textBox_endDate;
        protected System.Windows.Forms.Label label_overtime;
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
        protected System.Windows.Forms.TextBox textBox_approval;
        private System.Windows.Forms.Label label_Approval;
        protected System.Windows.Forms.TextBox textBox_DocType;
        private System.Windows.Forms.Label label_DocType;
        protected System.Windows.Forms.TextBox textBox_comments;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_approve;
    }
}
