namespace Purchases
{
    partial class CreatePurchaseOrder
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_Products = new System.Windows.Forms.ComboBox();
            this.textBox_Quantity = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_SubmitOrder = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_PurchaseOrderID = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox_Status = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Supplier = new System.Windows.Forms.TextBox();
            this.textBox_Type = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBox_Employee = new System.Windows.Forms.TextBox();
            this.button_Preview = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.textBox_Comment = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.textBox_Role = new System.Windows.Forms.TextBox();
            this.textBox_Commands = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.textBox_OnHand = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBox_MinQuantity = new System.Windows.Forms.TextBox();
            this.dataGridResults = new System.Windows.Forms.DataGridView();
            this.ProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_DataToText = new System.Windows.Forms.Button();
            this.button_ConvertToSql = new System.Windows.Forms.Button();
            this.textBox_PO_ID2 = new System.Windows.Forms.TextBox();
            this.textBox_ProductID = new System.Windows.Forms.TextBox();
            this.textBox_Price = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_AuthLevel = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this._panel2_LeftControlPanel.SuspendLayout();
            this.panel_TopPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(52, 104);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(94, 20);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(199, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Date Created";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(630, 198);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(256, 20);
            this.textBox2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(538, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Supplier";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(720, 160);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Visible = false;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(293, 213);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker2.Location = new System.Drawing.Point(293, 244);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(89, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(536, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Supplier Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(533, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Address";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(631, 224);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(256, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(537, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "City";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(633, 249);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(253, 20);
            this.textBox4.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(739, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Zip Code";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(808, 276);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(79, 20);
            this.textBox5.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(537, 277);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "State";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(633, 275);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(202, 338);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 17);
            this.label9.TabIndex = 18;
            this.label9.Text = "Products";
            // 
            // comboBox_Products
            // 
            this.comboBox_Products.FormattingEnabled = true;
            this.comboBox_Products.Location = new System.Drawing.Point(284, 336);
            this.comboBox_Products.Name = "comboBox_Products";
            this.comboBox_Products.Size = new System.Drawing.Size(209, 21);
            this.comboBox_Products.TabIndex = 19;
            this.comboBox_Products.SelectedIndexChanged += new System.EventHandler(this.comboBox_Products_SelectedIndexChanged);
            // 
            // textBox_Quantity
            // 
            this.textBox_Quantity.Location = new System.Drawing.Point(451, 374);
            this.textBox_Quantity.Name = "textBox_Quantity";
            this.textBox_Quantity.Size = new System.Drawing.Size(95, 20);
            this.textBox_Quantity.TabIndex = 20;
            // 
            // button_Add
            // 
            this.button_Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Add.Location = new System.Drawing.Point(540, 329);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(72, 35);
            this.button_Add.TabIndex = 22;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_SubmitOrder
            // 
            this.button_SubmitOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_SubmitOrder.Location = new System.Drawing.Point(784, 455);
            this.button_SubmitOrder.Name = "button_SubmitOrder";
            this.button_SubmitOrder.Size = new System.Drawing.Size(113, 66);
            this.button_SubmitOrder.TabIndex = 3;
            this.button_SubmitOrder.Text = "Submit Order";
            this.button_SubmitOrder.UseVisualStyleBackColor = true;
            this.button_SubmitOrder.Click += new System.EventHandler(this.button_SubmitOrder_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(201, 145);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(134, 20);
            this.label13.TabIndex = 31;
            this.label13.Text = "Purchase Order";
            // 
            // textBox_PurchaseOrderID
            // 
            this.textBox_PurchaseOrderID.Location = new System.Drawing.Point(361, 146);
            this.textBox_PurchaseOrderID.Name = "textBox_PurchaseOrderID";
            this.textBox_PurchaseOrderID.ReadOnly = true;
            this.textBox_PurchaseOrderID.Size = new System.Drawing.Size(131, 20);
            this.textBox_PurchaseOrderID.TabIndex = 32;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(308, 181);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(37, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(199, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Delivery date";
            // 
            // comboBox_Status
            // 
            this.comboBox_Status.FormattingEnabled = true;
            this.comboBox_Status.Items.AddRange(new object[] {
            "0:   no status assigned",
            "1:   in preparation",
            "2:   prepared, not sent",
            "3:   sent",
            "4:   completed (paid)",
            "5:   overdue",
            "6:   inconsistent amount",
            "7:   other problem"});
            this.comboBox_Status.Location = new System.Drawing.Point(361, 178);
            this.comboBox_Status.Name = "comboBox_Status";
            this.comboBox_Status.Size = new System.Drawing.Size(131, 21);
            this.comboBox_Status.TabIndex = 5;
            this.comboBox_Status.SelectedIndexChanged += new System.EventHandler(this.comboBox_Status_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Monotype Corsiva", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(456, 85);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(205, 26);
            this.label11.TabIndex = 5;
            this.label11.Text = "Create Purchase Order";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(188, 653);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(752, 81);
            this.dataGridView1.TabIndex = 36;
            this.dataGridView1.Visible = false;
            // 
            // textBox_Supplier
            // 
            this.textBox_Supplier.Location = new System.Drawing.Point(630, 162);
            this.textBox_Supplier.Name = "textBox_Supplier";
            this.textBox_Supplier.ReadOnly = true;
            this.textBox_Supplier.Size = new System.Drawing.Size(61, 20);
            this.textBox_Supplier.TabIndex = 37;
            // 
            // textBox_Type
            // 
            this.textBox_Type.Location = new System.Drawing.Point(257, 178);
            this.textBox_Type.Name = "textBox_Type";
            this.textBox_Type.ReadOnly = true;
            this.textBox_Type.Size = new System.Drawing.Size(43, 20);
            this.textBox_Type.TabIndex = 38;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(214, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 39;
            this.label12.Text = "Type";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(205, 276);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 40;
            this.label14.Text = "Employee";
            // 
            // textBox_Employee
            // 
            this.textBox_Employee.Location = new System.Drawing.Point(266, 273);
            this.textBox_Employee.Name = "textBox_Employee";
            this.textBox_Employee.ReadOnly = true;
            this.textBox_Employee.Size = new System.Drawing.Size(49, 20);
            this.textBox_Employee.TabIndex = 41;
            // 
            // button_Preview
            // 
            this.button_Preview.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Preview.Location = new System.Drawing.Point(666, 383);
            this.button_Preview.Name = "button_Preview";
            this.button_Preview.Size = new System.Drawing.Size(110, 67);
            this.button_Preview.TabIndex = 42;
            this.button_Preview.Text = "Preview Action Request";
            this.button_Preview.UseVisualStyleBackColor = true;
            this.button_Preview.Click += new System.EventHandler(this.button_Preview_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(205, 306);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(51, 13);
            this.label19.TabIndex = 46;
            this.label19.Text = "Comment";
            // 
            // textBox_Comment
            // 
            this.textBox_Comment.Location = new System.Drawing.Point(266, 301);
            this.textBox_Comment.Name = "textBox_Comment";
            this.textBox_Comment.Size = new System.Drawing.Size(227, 20);
            this.textBox_Comment.TabIndex = 47;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(369, 279);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(29, 13);
            this.label20.TabIndex = 48;
            this.label20.Text = "Role";
            // 
            // textBox_Role
            // 
            this.textBox_Role.Location = new System.Drawing.Point(409, 276);
            this.textBox_Role.Name = "textBox_Role";
            this.textBox_Role.ReadOnly = true;
            this.textBox_Role.Size = new System.Drawing.Size(82, 20);
            this.textBox_Role.TabIndex = 49;
            // 
            // textBox_Commands
            // 
            this.textBox_Commands.Location = new System.Drawing.Point(205, 543);
            this.textBox_Commands.Multiline = true;
            this.textBox_Commands.Name = "textBox_Commands";
            this.textBox_Commands.Size = new System.Drawing.Size(571, 137);
            this.textBox_Commands.TabIndex = 50;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(643, 346);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(50, 13);
            this.label21.TabIndex = 51;
            this.label21.Text = "On Hand";
            // 
            // textBox_OnHand
            // 
            this.textBox_OnHand.Location = new System.Drawing.Point(705, 342);
            this.textBox_OnHand.Name = "textBox_OnHand";
            this.textBox_OnHand.ReadOnly = true;
            this.textBox_OnHand.Size = new System.Drawing.Size(37, 20);
            this.textBox_OnHand.TabIndex = 52;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(757, 347);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(69, 13);
            this.label22.TabIndex = 53;
            this.label22.Text = "Min. Quantity";
            // 
            // textBox_MinQuantity
            // 
            this.textBox_MinQuantity.Location = new System.Drawing.Point(845, 343);
            this.textBox_MinQuantity.Name = "textBox_MinQuantity";
            this.textBox_MinQuantity.ReadOnly = true;
            this.textBox_MinQuantity.Size = new System.Drawing.Size(41, 20);
            this.textBox_MinQuantity.TabIndex = 54;
            // 
            // dataGridResults
            // 
            this.dataGridResults.AllowUserToOrderColumns = true;
            this.dataGridResults.BackgroundColor = System.Drawing.Color.Beige;
            this.dataGridResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridResults.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductID,
            this.ProductName,
            this.Quantity,
            this.Price});
            this.dataGridResults.Location = new System.Drawing.Point(206, 400);
            this.dataGridResults.Name = "dataGridResults";
            this.dataGridResults.ReadOnly = true;
            this.dataGridResults.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridResults.Size = new System.Drawing.Size(454, 138);
            this.dataGridResults.TabIndex = 71;
            // 
            // ProductID
            // 
            this.ProductID.HeaderText = "Product ID";
            this.ProductID.Name = "ProductID";
            this.ProductID.ReadOnly = true;
            this.ProductID.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ProductName
            // 
            this.ProductName.HeaderText = "Name";
            this.ProductName.Name = "ProductName";
            this.ProductName.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Price";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // button_DataToText
            // 
            this.button_DataToText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_DataToText.Location = new System.Drawing.Point(784, 385);
            this.button_DataToText.Name = "button_DataToText";
            this.button_DataToText.Size = new System.Drawing.Size(113, 64);
            this.button_DataToText.TabIndex = 72;
            this.button_DataToText.Text = "Capture Data to Text  Strings";
            this.button_DataToText.UseVisualStyleBackColor = true;
            this.button_DataToText.Click += new System.EventHandler(this.button_DataToText_Click);
            // 
            // button_ConvertToSql
            // 
            this.button_ConvertToSql.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ConvertToSql.Location = new System.Drawing.Point(666, 456);
            this.button_ConvertToSql.Name = "button_ConvertToSql";
            this.button_ConvertToSql.Size = new System.Drawing.Size(110, 65);
            this.button_ConvertToSql.TabIndex = 73;
            this.button_ConvertToSql.Text = "Convert to SQL commands";
            this.button_ConvertToSql.UseVisualStyleBackColor = true;
            this.button_ConvertToSql.Click += new System.EventHandler(this.button_ConvertToSql_Click);
            // 
            // textBox_PO_ID2
            // 
            this.textBox_PO_ID2.Location = new System.Drawing.Point(351, 374);
            this.textBox_PO_ID2.Name = "textBox_PO_ID2";
            this.textBox_PO_ID2.ReadOnly = true;
            this.textBox_PO_ID2.Size = new System.Drawing.Size(94, 20);
            this.textBox_PO_ID2.TabIndex = 74;
            // 
            // textBox_ProductID
            // 
            this.textBox_ProductID.Location = new System.Drawing.Point(248, 374);
            this.textBox_ProductID.Name = "textBox_ProductID";
            this.textBox_ProductID.ReadOnly = true;
            this.textBox_ProductID.Size = new System.Drawing.Size(97, 20);
            this.textBox_ProductID.TabIndex = 75;
            // 
            // textBox_Price
            // 
            this.textBox_Price.Location = new System.Drawing.Point(550, 375);
            this.textBox_Price.Name = "textBox_Price";
            this.textBox_Price.ReadOnly = true;
            this.textBox_Price.Size = new System.Drawing.Size(97, 20);
            this.textBox_Price.TabIndex = 76;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(323, 279);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "/";
            // 
            // textBox_AuthLevel
            // 
            this.textBox_AuthLevel.Location = new System.Drawing.Point(341, 275);
            this.textBox_AuthLevel.Name = "textBox_AuthLevel";
            this.textBox_AuthLevel.ReadOnly = true;
            this.textBox_AuthLevel.Size = new System.Drawing.Size(22, 20);
            this.textBox_AuthLevel.TabIndex = 78;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(812, 545);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 61);
            this.button1.TabIndex = 79;
            this.button1.Text = "Display Raw Data";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreatePurchaseOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(1083, 742);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox_AuthLevel);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.textBox_Price);
            this.Controls.Add(this.textBox_ProductID);
            this.Controls.Add(this.textBox_PO_ID2);
            this.Controls.Add(this.button_ConvertToSql);
            this.Controls.Add(this.button_DataToText);
            this.Controls.Add(this.dataGridResults);
            this.Controls.Add(this.textBox_MinQuantity);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.textBox_OnHand);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.textBox_Commands);
            this.Controls.Add(this.textBox_Role);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.textBox_Comment);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.button_Preview);
            this.Controls.Add(this.button_SubmitOrder);
            this.Controls.Add(this.textBox_Employee);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.textBox_Type);
            this.Controls.Add(this.textBox_Supplier);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox_Status);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.textBox_PurchaseOrderID);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.textBox_Quantity);
            this.Controls.Add(this.comboBox_Products);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "CreatePurchaseOrder";
            this.Text = "Create_Sales_Order";
            this.Controls.SetChildIndex(this._panel2_LeftControlPanel, 0);
            this.Controls.SetChildIndex(this.panel_TopPanel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textBox2, 0);
            this.Controls.SetChildIndex(this.comboBox1, 0);
            this.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.textBox3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.textBox4, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.textBox5, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.textBox6, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.label9, 0);
            this.Controls.SetChildIndex(this.comboBox_Products, 0);
            this.Controls.SetChildIndex(this.textBox_Quantity, 0);
            this.Controls.SetChildIndex(this.button_Add, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.textBox_PurchaseOrderID, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.comboBox_Status, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.textBox_Supplier, 0);
            this.Controls.SetChildIndex(this.textBox_Type, 0);
            this.Controls.SetChildIndex(this.label12, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.textBox_Employee, 0);
            this.Controls.SetChildIndex(this.button_SubmitOrder, 0);
            this.Controls.SetChildIndex(this.button_Preview, 0);
            this.Controls.SetChildIndex(this.label19, 0);
            this.Controls.SetChildIndex(this.textBox_Comment, 0);
            this.Controls.SetChildIndex(this.label20, 0);
            this.Controls.SetChildIndex(this.textBox_Role, 0);
            this.Controls.SetChildIndex(this.textBox_Commands, 0);
            this.Controls.SetChildIndex(this.label21, 0);
            this.Controls.SetChildIndex(this.textBox_OnHand, 0);
            this.Controls.SetChildIndex(this.label22, 0);
            this.Controls.SetChildIndex(this.textBox_MinQuantity, 0);
            this.Controls.SetChildIndex(this.dataGridResults, 0);
            this.Controls.SetChildIndex(this.button_DataToText, 0);
            this.Controls.SetChildIndex(this.button_ConvertToSql, 0);
            this.Controls.SetChildIndex(this.textBox_PO_ID2, 0);
            this.Controls.SetChildIndex(this.textBox_ProductID, 0);
            this.Controls.SetChildIndex(this.textBox_Price, 0);
            this.Controls.SetChildIndex(this.label10, 0);
            this.Controls.SetChildIndex(this.textBox_AuthLevel, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this._panel2_LeftControlPanel.ResumeLayout(false);
            this.panel_TopPanel.ResumeLayout(false);
            this.panel_TopPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RightLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LeftLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_Products;
        private System.Windows.Forms.TextBox textBox_Quantity;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button_SubmitOrder;
        private System.Windows.Forms.TextBox textBox_PurchaseOrderID;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox_Status;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Supplier;
        private System.Windows.Forms.TextBox textBox_Type;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBox_Employee;
        private System.Windows.Forms.Button button_Preview;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBox_Comment;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBox_Role;
        private System.Windows.Forms.TextBox textBox_Commands;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBox_OnHand;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox textBox_MinQuantity;
        private System.Windows.Forms.DataGridView dataGridResults;
        private System.Windows.Forms.Button button_DataToText;
        private System.Windows.Forms.Button button_ConvertToSql;
        private System.Windows.Forms.TextBox textBox_PO_ID2;
        private System.Windows.Forms.TextBox textBox_ProductID;
        private System.Windows.Forms.TextBox textBox_Price;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox_AuthLevel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}