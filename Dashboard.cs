using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KStore_Sales_Inventory
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();


            lblpg.Text = "Sales";
            this.MainPanel.Controls.Clear();
            FrmSales FrmSales_Vrb = new FrmSales() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSales_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(FrmSales_Vrb);
            FrmSales_Vrb.Show();
        }


        private void POS_btn_Click(object sender, EventArgs e)
        {
            lblpg.Text = "Sales";
            this.MainPanel.Controls.Clear();
            FrmSales FrmSales_Vrb = new FrmSales() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            FrmSales_Vrb.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(FrmSales_Vrb);
            FrmSales_Vrb.Show();
        }

        private void Inv_btn_Click(object sender, EventArgs e)
        {
            lblpg.Text = "Inventory";
            this.MainPanel.Controls.Clear();
            Inventory InventoryForm = new Inventory() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            InventoryForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(InventoryForm);
            InventoryForm.Show();
        }

        private void SRep_btn_Click(object sender, EventArgs e)
        {
            lblpg.Text = "Sales Report";
            this.MainPanel.Controls.Clear();
            SalesReport SalesRepForm = new SalesReport() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            SalesRepForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(SalesRepForm);
            SalesRepForm.Show();
        }

        private void users_btn_Click(object sender, EventArgs e)
        {
            lblpg.Text = "Users";
            this.MainPanel.Controls.Clear();
            UserMod userForm = new UserMod(this) { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            userForm.FormBorderStyle = FormBorderStyle.None;
            this.MainPanel.Controls.Add(userForm);
            userForm.Show();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
