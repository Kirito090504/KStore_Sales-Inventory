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
            string name = name_txtbox.Text;
            string username = user_txtbox.Text;
            string password = pass_txtbox.Text;
            string role = role_txtbox.Text;

            // Display the input data in a message box
            MessageBox.Show($"Name: {name}\nUsername: {username}\nPassword: {password}\nRole: {role}", "User Information");

            // Here you could add code to save this data to a database or file. not yet done
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
