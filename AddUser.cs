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
    public partial class AddUser : Form
    {
        public AddUser()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {

        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            name_txtbox.Clear();
            user_txtbox.Clear();
            pass_txtbox.Clear();
            role_txtbox.Clear();
        }

        private void b_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
