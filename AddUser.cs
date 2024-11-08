using MySql.Data.MySqlClient;
using System;
using System.Windows.Forms;

namespace KStore_Sales_Inventory
{
    public partial class AddUser : Form
    {
        string connectionString = "Server=localhost,3306;Database=k_store;User ID=root;Password=;";
        public AddUser()
        {
            InitializeComponent();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO users (Username, Name, Password, Role) VALUES (@Username, @Name, @Password, @Role)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Adding values from text boxes and date picker
                    command.Parameters.AddWithValue("@Username", user_txtbox.Text);
                    command.Parameters.AddWithValue("@Name", name_txtbox.Text);
                    command.Parameters.AddWithValue("@Password", pass_txtbox);
                    command.Parameters.AddWithValue("@Role", role_txtbox.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record added successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Failed to add the record.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
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
