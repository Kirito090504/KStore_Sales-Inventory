using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace KStore_Sales_Inventory
{
    public partial class Form1 : Form
    {
        string connectionString = "Server=localhost;Database=k_store;User ID=root;Password=;";
        public Form1()
        {
            InitializeComponent();
        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = user_box.Text;
            string password = pass_box.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // SQL query to check if user exists with provided username and password
                    string query = "SELECT role FROM users WHERE username = @username AND password = @password";
                    MySqlCommand cmd = new MySqlCommand(query, connection);

                    // Bind parameters
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        string role = result.ToString();

                        // Check the role and take appropriate action
                        if (role.Equals("admin", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Login successful! Welcome, Admin.", "Success");

                            // Redirect to the admin dashboard or perform admin-specific actions
                            Dashboard adminDashboard = new Dashboard();
                            adminDashboard.Show();
                            this.Hide();  // Hide the login form if necessary
                        }
                        else if (role.Equals("employee", StringComparison.OrdinalIgnoreCase))
                        {
                            MessageBox.Show("Login successful! Welcome, Employee.", "Success");

                            // Redirect to the employee dashboard or perform employee-specific actions
                            Dashboard employeeDashboard = new Dashboard();
                            employeeDashboard.Show();
                            employeeDashboard.users_btn.Enabled = false;
                            this.Hide();  // Hide the login form if necessary
                        }
                        else
                        {
                            MessageBox.Show("Login successful, but role is not recognized.", "Warning");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
                }
            }
        }

        private void cancel_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
