﻿namespace KStore_Sales_Inventory
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
            this.ItemID_txtbox = new System.Windows.Forms.TextBox();
            this.ItmName_txtbox = new System.Windows.Forms.TextBox();
            this.brand_txtbox = new System.Windows.Forms.TextBox();
            this.price_txtbox = new System.Windows.Forms.TextBox();
            this.category_box = new System.Windows.Forms.ComboBox();
            this.stock_txtbox = new System.Windows.Forms.TextBox();
            this.status_txtbox = new System.Windows.Forms.TextBox();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.dtp2 = new System.Windows.Forms.DataGridView();
            this.note_txtbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.search_btn = new System.Windows.Forms.Button();
            this.clear_btn = new System.Windows.Forms.Button();
            this.paid_btn = new System.Windows.Forms.Button();
            this.add_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtp2)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemID_txtbox
            // 
            this.ItemID_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.ItemID_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ItemID_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemID_txtbox.ForeColor = System.Drawing.Color.White;
            this.ItemID_txtbox.Location = new System.Drawing.Point(141, 22);
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
            this.ItmName_txtbox.Location = new System.Drawing.Point(141, 76);
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
            this.brand_txtbox.Location = new System.Drawing.Point(141, 128);
            this.brand_txtbox.Name = "brand_txtbox";
            this.brand_txtbox.Size = new System.Drawing.Size(247, 20);
            this.brand_txtbox.TabIndex = 2;
            this.brand_txtbox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // price_txtbox
            // 
            this.price_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.price_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.price_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_txtbox.ForeColor = System.Drawing.Color.White;
            this.price_txtbox.Location = new System.Drawing.Point(141, 243);
            this.price_txtbox.Name = "price_txtbox";
            this.price_txtbox.Size = new System.Drawing.Size(247, 20);
            this.price_txtbox.TabIndex = 3;
            // 
            // category_box
            // 
            this.category_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.category_box.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.category_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.category_box.ForeColor = System.Drawing.Color.White;
            this.category_box.FormattingEnabled = true;
            this.category_box.Location = new System.Drawing.Point(141, 183);
            this.category_box.Name = "category_box";
            this.category_box.Size = new System.Drawing.Size(247, 28);
            this.category_box.TabIndex = 4;
            // 
            // stock_txtbox
            // 
            this.stock_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.stock_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stock_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stock_txtbox.ForeColor = System.Drawing.Color.White;
            this.stock_txtbox.Location = new System.Drawing.Point(141, 306);
            this.stock_txtbox.Name = "stock_txtbox";
            this.stock_txtbox.Size = new System.Drawing.Size(247, 20);
            this.stock_txtbox.TabIndex = 5;
            // 
            // status_txtbox
            // 
            this.status_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.status_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.status_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.status_txtbox.ForeColor = System.Drawing.Color.White;
            this.status_txtbox.Location = new System.Drawing.Point(141, 413);
            this.status_txtbox.Name = "status_txtbox";
            this.status_txtbox.Size = new System.Drawing.Size(247, 20);
            this.status_txtbox.TabIndex = 6;
            // 
            // dtp1
            // 
            this.dtp1.CalendarTitleBackColor = System.Drawing.SystemColors.ControlText;
            this.dtp1.CalendarTitleForeColor = System.Drawing.Color.White;
            this.dtp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp1.Location = new System.Drawing.Point(141, 362);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(247, 22);
            this.dtp1.TabIndex = 7;
            // 
            // dtp2
            // 
            this.dtp2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtp2.Location = new System.Drawing.Point(405, 12);
            this.dtp2.Name = "dtp2";
            this.dtp2.RowHeadersWidth = 51;
            this.dtp2.RowTemplate.Height = 24;
            this.dtp2.Size = new System.Drawing.Size(493, 641);
            this.dtp2.TabIndex = 8;
            // 
            // note_txtbox
            // 
            this.note_txtbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.note_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.note_txtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.note_txtbox.ForeColor = System.Drawing.Color.White;
            this.note_txtbox.Location = new System.Drawing.Point(141, 468);
            this.note_txtbox.Multiline = true;
            this.note_txtbox.Name = "note_txtbox";
            this.note_txtbox.Size = new System.Drawing.Size(247, 76);
            this.note_txtbox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 24);
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
            this.label2.Location = new System.Drawing.Point(16, 78);
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
            this.label3.Location = new System.Drawing.Point(16, 130);
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
            this.label4.Location = new System.Drawing.Point(16, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 25);
            this.label4.TabIndex = 13;
            this.label4.Text = "Category:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Price:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 308);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Stock:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 359);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 16;
            this.label7.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 415);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 25);
            this.label8.TabIndex = 17;
            this.label8.Text = "Status:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(20, 468);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 25);
            this.label9.TabIndex = 18;
            this.label9.Text = "Note:";
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.search_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.Location = new System.Drawing.Point(145, 564);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(106, 34);
            this.search_btn.TabIndex = 23;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // clear_btn
            // 
            this.clear_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.clear_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.clear_btn.FlatAppearance.BorderSize = 0;
            this.clear_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_btn.ForeColor = System.Drawing.Color.White;
            this.clear_btn.Location = new System.Drawing.Point(25, 564);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(114, 34);
            this.clear_btn.TabIndex = 24;
            this.clear_btn.Text = "CLEAR";
            this.clear_btn.UseVisualStyleBackColor = false;
            // 
            // paid_btn
            // 
            this.paid_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.paid_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.paid_btn.FlatAppearance.BorderSize = 0;
            this.paid_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.paid_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paid_btn.ForeColor = System.Drawing.Color.White;
            this.paid_btn.Location = new System.Drawing.Point(257, 564);
            this.paid_btn.Name = "paid_btn";
            this.paid_btn.Size = new System.Drawing.Size(114, 34);
            this.paid_btn.TabIndex = 25;
            this.paid_btn.Text = "PAID";
            this.paid_btn.UseVisualStyleBackColor = false;
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.add_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.add_btn.FlatAppearance.BorderSize = 0;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(25, 604);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(114, 34);
            this.add_btn.TabIndex = 26;
            this.add_btn.Text = "ADD";
            this.add_btn.UseVisualStyleBackColor = false;
            // 
            // modify_btn
            // 
            this.modify_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.modify_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.modify_btn.FlatAppearance.BorderSize = 0;
            this.modify_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_btn.ForeColor = System.Drawing.Color.White;
            this.modify_btn.Location = new System.Drawing.Point(145, 604);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(106, 34);
            this.modify_btn.TabIndex = 27;
            this.modify_btn.Text = "MODIFY";
            this.modify_btn.UseVisualStyleBackColor = false;
            // 
            // delete_btn
            // 
            this.delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.delete_btn.Cursor = System.Windows.Forms.Cursors.Default;
            this.delete_btn.FlatAppearance.BorderSize = 0;
            this.delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delete_btn.ForeColor = System.Drawing.Color.White;
            this.delete_btn.Location = new System.Drawing.Point(257, 604);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(114, 34);
            this.delete_btn.TabIndex = 28;
            this.delete_btn.Text = "DELETE";
            this.delete_btn.UseVisualStyleBackColor = false;
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(910, 665);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.modify_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.paid_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.note_txtbox);
            this.Controls.Add(this.dtp2);
            this.Controls.Add(this.dtp1);
            this.Controls.Add(this.status_txtbox);
            this.Controls.Add(this.stock_txtbox);
            this.Controls.Add(this.category_box);
            this.Controls.Add(this.price_txtbox);
            this.Controls.Add(this.brand_txtbox);
            this.Controls.Add(this.ItmName_txtbox);
            this.Controls.Add(this.ItemID_txtbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSales";
            this.Load += new System.EventHandler(this.FrmSales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtp2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ItemID_txtbox;
        private System.Windows.Forms.TextBox ItmName_txtbox;
        private System.Windows.Forms.TextBox brand_txtbox;
        private System.Windows.Forms.TextBox price_txtbox;
        private System.Windows.Forms.ComboBox category_box;
        private System.Windows.Forms.TextBox stock_txtbox;
        private System.Windows.Forms.TextBox status_txtbox;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.DataGridView dtp2;
        private System.Windows.Forms.TextBox note_txtbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button paid_btn;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button modify_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}