namespace KStore_Sales_Inventory
{
    partial class SalesReport
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
            this.dtp4 = new System.Windows.Forms.DataGridView();
            this.dtp5 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tranID_box = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtp4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp5)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp4
            // 
            this.dtp4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtp4.Location = new System.Drawing.Point(12, 99);
            this.dtp4.Name = "dtp4";
            this.dtp4.RowHeadersWidth = 51;
            this.dtp4.RowTemplate.Height = 24;
            this.dtp4.Size = new System.Drawing.Size(434, 554);
            this.dtp4.TabIndex = 0;
            this.dtp4.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtp4_CellContentClick);
            // 
            // dtp5
            // 
            this.dtp5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtp5.Location = new System.Drawing.Point(463, 99);
            this.dtp5.Name = "dtp5";
            this.dtp5.RowHeadersWidth = 51;
            this.dtp5.RowTemplate.Height = 24;
            this.dtp5.Size = new System.Drawing.Size(435, 554);
            this.dtp5.TabIndex = 1;
            this.dtp5.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtp5_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "TRANSACTION ID:";
            // 
            // tranID_box
            // 
            this.tranID_box.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.tranID_box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tranID_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tranID_box.ForeColor = System.Drawing.Color.White;
            this.tranID_box.Location = new System.Drawing.Point(220, 38);
            this.tranID_box.Name = "tranID_box";
            this.tranID_box.Size = new System.Drawing.Size(226, 21);
            this.tranID_box.TabIndex = 3;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.Color.White;
            this.search_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.search_btn.Location = new System.Drawing.Point(775, 31);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(123, 35);
            this.search_btn.TabIndex = 4;
            this.search_btn.Text = "SEARCH";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // SalesReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(910, 665);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.tranID_box);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtp5);
            this.Controls.Add(this.dtp4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SalesReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SalesReport";
            ((System.ComponentModel.ISupportInitialize)(this.dtp4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtp4;
        private System.Windows.Forms.DataGridView dtp5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tranID_box;
        private System.Windows.Forms.Button search_btn;
    }
}