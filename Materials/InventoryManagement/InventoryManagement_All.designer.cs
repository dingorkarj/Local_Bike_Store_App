namespace InventoryManagement
{
    partial class InventoryManagement_All
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
            this.button_AllInventory = new System.Windows.Forms.Button();
            this.buttonCreateShippingDocument = new System.Windows.Forms.Button();
            this.button_Update = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AllInventory
            // 
            this.button_AllInventory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.button_AllInventory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_AllInventory.Location = new System.Drawing.Point(366, 213);
            this.button_AllInventory.Name = "button_AllInventory";
            this.button_AllInventory.Size = new System.Drawing.Size(145, 93);
            this.button_AllInventory.TabIndex = 2;
            this.button_AllInventory.Text = "All Inventory Items";
            this.button_AllInventory.UseVisualStyleBackColor = false;
            this.button_AllInventory.Click += new System.EventHandler(this.button_AllInventory_Click);
            // 
            // buttonCreateShippingDocument
            // 
            this.buttonCreateShippingDocument.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(68)))), ((int)(((byte)(255)))));
            this.buttonCreateShippingDocument.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateShippingDocument.Location = new System.Drawing.Point(515, 360);
            this.buttonCreateShippingDocument.Name = "buttonCreateShippingDocument";
            this.buttonCreateShippingDocument.Size = new System.Drawing.Size(145, 93);
            this.buttonCreateShippingDocument.TabIndex = 5;
            this.buttonCreateShippingDocument.Text = "Update";
            this.buttonCreateShippingDocument.UseVisualStyleBackColor = false;
            this.buttonCreateShippingDocument.Click += new System.EventHandler(this.buttonCreateShippingDocument_Click);
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(255)))));
            this.button_Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Update.Location = new System.Drawing.Point(650, 213);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(145, 93);
            this.button_Update.TabIndex = 6;
            this.button_Update.Text = "Create shipping document";
            this.button_Update.UseVisualStyleBackColor = false;
            this.button_Update.Click += new System.EventHandler(this.button_UpdateInventoryLevels_Click);
            // 
            // InventoryManagement_All
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1131, 537);
            this.Controls.Add(this.button_Update);
            this.Controls.Add(this.buttonCreateShippingDocument);
            this.Controls.Add(this.button_AllInventory);
            this.Name = "InventoryManagement_All";
            this.Text = "InventoryManagement_All";
            this.Load += new System.EventHandler(this.InventoryManagement_All_Load);
            this.Controls.SetChildIndex(this.button_AllInventory, 0);
            this.Controls.SetChildIndex(this.buttonCreateShippingDocument, 0);
            this.Controls.SetChildIndex(this.button_Update, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AllInventory;
        private System.Windows.Forms.Button buttonCreateShippingDocument;
        private System.Windows.Forms.Button button_Update;
    }
}