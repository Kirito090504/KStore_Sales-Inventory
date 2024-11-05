namespace KStore_Sales_Inventory
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.Board = new System.Windows.Forms.Panel();
            this.logo = new System.Windows.Forms.PictureBox();
            this.users_btn = new System.Windows.Forms.Button();
            this.Inv_btn = new System.Windows.Forms.Button();
            this.SRep_btn = new System.Windows.Forms.Button();
            this.POS_btn = new System.Windows.Forms.Button();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.lblpg = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Button();
            this.Board.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.SuspendLayout();
            // 
            // Board
            // 
            this.Board.Controls.Add(this.logo);
            this.Board.Controls.Add(this.users_btn);
            this.Board.Controls.Add(this.Inv_btn);
            this.Board.Controls.Add(this.SRep_btn);
            this.Board.Controls.Add(this.POS_btn);
            this.Board.Dock = System.Windows.Forms.DockStyle.Left;
            this.Board.Location = new System.Drawing.Point(0, 0);
            this.Board.Name = "Board";
            this.Board.Size = new System.Drawing.Size(208, 776);
            this.Board.TabIndex = 0;
            // 
            // logo
            // 
            this.logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logo.BackgroundImage")));
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.logo.Location = new System.Drawing.Point(0, 0);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(208, 185);
            this.logo.TabIndex = 4;
            this.logo.TabStop = false;
            // 
            // users_btn
            // 
            this.users_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.users_btn.FlatAppearance.BorderSize = 0;
            this.users_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.users_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.users_btn.ForeColor = System.Drawing.Color.White;
            this.users_btn.Location = new System.Drawing.Point(3, 353);
            this.users_btn.Name = "users_btn";
            this.users_btn.Size = new System.Drawing.Size(208, 48);
            this.users_btn.TabIndex = 3;
            this.users_btn.Text = "USERS";
            this.users_btn.UseVisualStyleBackColor = false;
            this.users_btn.Click += new System.EventHandler(this.users_btn_Click);
            // 
            // Inv_btn
            // 
            this.Inv_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.Inv_btn.FlatAppearance.BorderSize = 0;
            this.Inv_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Inv_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Inv_btn.ForeColor = System.Drawing.Color.White;
            this.Inv_btn.Location = new System.Drawing.Point(0, 245);
            this.Inv_btn.Name = "Inv_btn";
            this.Inv_btn.Size = new System.Drawing.Size(208, 48);
            this.Inv_btn.TabIndex = 1;
            this.Inv_btn.Text = "INVENTORY";
            this.Inv_btn.UseVisualStyleBackColor = false;
            this.Inv_btn.Click += new System.EventHandler(this.Inv_btn_Click);
            // 
            // SRep_btn
            // 
            this.SRep_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.SRep_btn.FlatAppearance.BorderSize = 0;
            this.SRep_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SRep_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SRep_btn.ForeColor = System.Drawing.Color.White;
            this.SRep_btn.Location = new System.Drawing.Point(0, 299);
            this.SRep_btn.Name = "SRep_btn";
            this.SRep_btn.Size = new System.Drawing.Size(208, 48);
            this.SRep_btn.TabIndex = 2;
            this.SRep_btn.Text = "SALES REPORT";
            this.SRep_btn.UseVisualStyleBackColor = false;
            this.SRep_btn.Click += new System.EventHandler(this.SRep_btn_Click);
            // 
            // POS_btn
            // 
            this.POS_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(32)))), ((int)(((byte)(48)))));
            this.POS_btn.FlatAppearance.BorderSize = 0;
            this.POS_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.POS_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.POS_btn.ForeColor = System.Drawing.Color.White;
            this.POS_btn.Location = new System.Drawing.Point(0, 191);
            this.POS_btn.Name = "POS_btn";
            this.POS_btn.Size = new System.Drawing.Size(208, 48);
            this.POS_btn.TabIndex = 0;
            this.POS_btn.Text = "SALES";
            this.POS_btn.UseVisualStyleBackColor = false;
            this.POS_btn.Click += new System.EventHandler(this.POS_btn_Click);
            // 
            // MainPanel
            // 
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MainPanel.Location = new System.Drawing.Point(208, 111);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(910, 665);
            this.MainPanel.TabIndex = 1;
            // 
            // lblpg
            // 
            this.lblpg.AutoSize = true;
            this.lblpg.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblpg.ForeColor = System.Drawing.Color.White;
            this.lblpg.Location = new System.Drawing.Point(245, 40);
            this.lblpg.Name = "lblpg";
            this.lblpg.Size = new System.Drawing.Size(47, 32);
            this.lblpg.TabIndex = 2;
            this.lblpg.Text = "lbl";
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.exit.FlatAppearance.BorderSize = 0;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(1064, 12);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(42, 26);
            this.exit.TabIndex = 3;
            this.exit.Text = "X";
            this.exit.UseVisualStyleBackColor = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(25)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(1118, 776);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.lblpg);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Board);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Board.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Board;
        private System.Windows.Forms.Button users_btn;
        private System.Windows.Forms.Button SRep_btn;
        private System.Windows.Forms.Button Inv_btn;
        private System.Windows.Forms.Button POS_btn;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Label lblpg;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.PictureBox logo;
    }
}