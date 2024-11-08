namespace KStore_Sales_Inventory
{
    partial class FrmSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSales));
            this.ItemID_txtbox = new System.Windows.Forms.TextBox();
            this.ItmName_txtbox = new System.Windows.Forms.TextBox();
            this.brand_txtbox = new System.Windows.Forms.TextBox();
            this.category_box = new System.Windows.Forms.ComboBox();
            this.quan_txtbox = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DataGridView();
            this.total_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.receipt = new System.Windows.Forms.Button();
            this.exp = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Transaction_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Brand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Category = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtp2)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemID_txtbox
            // 
            this.ItemID_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ItemID_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemID_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemID_txtbox.ForeColor = System.Drawing.Color.White;
            this.ItemID_txtbox.Location = new System.Drawing.Point(128, 73);
            this.ItemID_txtbox.Name = "ItemID_txtbox";
            this.ItemID_txtbox.Size = new System.Drawing.Size(247, 20);
            this.ItemID_txtbox.TabIndex = 0;
            // 
            // ItmName_txtbox
            // 
            this.ItmName_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ItmName_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItmName_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItmName_txtbox.ForeColor = System.Drawing.Color.White;
            this.ItmName_txtbox.Location = new System.Drawing.Point(128, 127);
            this.ItmName_txtbox.Name = "ItmName_txtbox";
            this.ItmName_txtbox.Size = new System.Drawing.Size(247, 20);
            this.ItmName_txtbox.TabIndex = 1;
            // 
            // brand_txtbox
            // 
            this.brand_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.brand_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.brand_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.brand_txtbox.ForeColor = System.Drawing.Color.White;
            this.brand_txtbox.Location = new System.Drawing.Point(128, 179);
            this.brand_txtbox.Name = "brand_txtbox";
            this.brand_txtbox.Size = new System.Drawing.Size(247, 20);
            this.brand_txtbox.TabIndex = 2;
            // 
            // category_box
            // 
            this.category_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.category_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_box.ForeColor = System.Drawing.Color.White;
            this.category_box.FormattingEnabled = true;
            this.category_box.Items.AddRange(new object[] {
            "Electronics",
            "General items"});
            this.category_box.Location = new System.Drawing.Point(128, 234);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(247, 28);
            this.category_box.TabIndex = 4;
            // 
            // quan_txtbox
            // 
            this.quan_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.quan_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.quan_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quan_txtbox.ForeColor = System.Drawing.Color.White;
            this.quan_txtbox.Location = new System.Drawing.Point(128, 295);
            this.quan_txtbox.Name = "quan_txtbox";
            this.quan_txtbox.Size = new System.Drawing.Size(247, 20);
            this.quan_txtbox.TabIndex = 5;
            this.quan_txtbox.TextChanged += new System.EventHandler(this.quan_txtbox_TextChanged);
            // 
            // dtp1
            // 
            this.dtp1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(128, 350);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(247, 22);
            this.dtp1.TabIndex = 7;
            // 
            // dtp2
            // 
            this.dtp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtp2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Transaction_id,
            this.ItemId,
            this.ItemName,
            this.Brand,
            this.Category,
            this.Quantity,
            this.Date,
            this.Total});
            this.dtp2.Location = new System.Drawing.Point(405, 12);
            this.dtp2.Name = "dtp2";
            this.dtp2.RowHeadersWidth = 51;
            this.dtp2.RowTemplate.Height = 24;
            this.dtp2.Size = new System.Drawing.Size(493, 641);
            this.dtp2.TabIndex = 8;
            this.dtp2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtp2_CellContentClick);
            // 
            // total_txtbox
            // 
            this.total_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.total_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.total_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_txtbox.ForeColor = System.Drawing.Color.White;
            this.total_txtbox.Location = new System.Drawing.Point(128, 398);
            this.total_txtbox.Multiline = true;
            this.total_txtbox.Name = "total_txtbox";
            this.total_txtbox.Size = new System.Drawing.Size(247, 25);
            this.total_txtbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Item ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(3, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 11;
            this.label2.Text = "Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 25);
            this.label3.TabIndex = 12;
            this.label3.Text = "Brand:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 237);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(3, 294);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Quantity:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 347);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(7, 398);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Total:";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(257, 443);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(106, 34);
            this.search_btn.TabIndex = 23;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(145, 443);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(106, 34);
            this.clear_btn.TabIndex = 24;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = false;
            this.clear_btn.Click += new System.EventHandler(this.clear_btn_Click);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(25, 443);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(114, 74);
            this.add_btn.TabIndex = 26;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // modify_btn
            // 
            this.modify_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.modify_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.modify_btn.FlatAppearance.BorderSize = 0;
            this.modify_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_btn.ForeColor = System.Drawing.Color.White;
            this.modify_btn.Location = new System.Drawing.Point(145, 483);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(106, 34);
            this.modify_btn.TabIndex = 27;
            this.modify_btn.Text = "MODIFY";
            this.modify_btn.UseVisualStyleBackColor = false;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(257, 483);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(106, 34);
            this.delete_btn.TabIndex = 28;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // receipt
            // 
            this.receipt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.receipt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("receipt.BackgroundImage")));
            this.receipt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.receipt.FlatAppearance.BorderSize = 0;
            this.receipt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.receipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receipt.ForeColor = System.Drawing.Color.White;
            this.receipt.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.receipt.Location = new System.Drawing.Point(302, 541);
            this.receipt.Name = "receipt";
            this.receipt.Size = new System.Drawing.Size(61, 49);
            this.receipt.TabIndex = 30;
            this.receipt.UseVisualStyleBackColor = false;
            // 
            // exp
            // 
            this.exp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.exp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("exp.BackgroundImage")));
            this.exp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.exp.FlatAppearance.BorderSize = 0;
            this.exp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exp.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exp.ForeColor = System.Drawing.Color.White;
            this.exp.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.exp.Location = new System.Drawing.Point(239, 541);
            this.exp.Name = "exp";
            this.exp.Size = new System.Drawing.Size(47, 49);
            this.exp.TabIndex = 29;
            this.exp.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(160, 25);
            this.label8.TabIndex = 32;
            this.label8.Text = "Transaction ID:";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(195, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(180, 20);
            this.textBox1.TabIndex = 31;
            // 
            // Transaction_id
            // 
            this.Transaction_id.HeaderText = "Transaction ID";
            this.Transaction_id.MinimumWidth = 6;
            this.Transaction_id.Name = "Transaction_id";
            this.Transaction_id.Width = 125;
            // 
            // ItemId
            // 
            this.ItemId.HeaderText = "Item ID";
            this.ItemId.MinimumWidth = 6;
            this.ItemId.Name = "ItemId";
            this.ItemId.Width = 125;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.MinimumWidth = 6;
            this.ItemName.Name = "ItemName";
            this.ItemName.Width = 125;
            // 
            // Brand
            // 
            this.Brand.HeaderText = "Brand";
            this.Brand.MinimumWidth = 6;
            this.Brand.Name = "Brand";
            this.Brand.Width = 125;
            // 
            // Category
            // 
            this.Category.HeaderText = "Category";
            this.Category.MinimumWidth = 6;
            this.Category.Name = "Category";
            this.Category.Width = 125;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // Date
            // 
            this.Date.HeaderText = "Date";
            this.Date.MinimumWidth = 6;
            this.Date.Name = "Date";
            this.Date.Width = 125;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.MinimumWidth = 6;
            this.Total.Name = "Total";
            this.Total.Width = 125;
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(910, 665);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.receipt);
            this.Controls.Add(this.exp);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.total_txtbox);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.quan_txtbox);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.brand_txtbox);
            this.Controls.Add(this.ItmName_txtbox);
            this.Controls.Add(this.ItemID_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSales";
            ((System.ComponentModel.ISupportInitialize)(this.dtp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemID_txtbox;
        private System.Windows.Forms.TextBox ItmName_txtbox;
        private System.Windows.Forms.TextBox brand_txtbox;
        private System.Windows.Forms.ComboBox category_box;
        private System.Windows.Forms.TextBox quan_txtbox;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridView dtp2;
        private System.Windows.Forms.TextBox total_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button modify_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button receipt;
        private System.Windows.Forms.Button exp;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transaction_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Brand;
        private System.Windows.Forms.DataGridViewTextBoxColumn Category;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}