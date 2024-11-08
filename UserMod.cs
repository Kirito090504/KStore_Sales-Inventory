using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace KStore_Sales_Inventory
{
    public partial class UserMod : Form
    {
        string connectionString = "Server=localhost,3306;Database=k_store;User ID=root;Password=;";
        private Dashboard dbform;

        public UserMod(Dashboard dbform)
        {
            
            InitializeComponent();
            LoadUserData();
            this.dbform = dbform;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddUser().Show();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM users WHERE Username = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username_txtbox.Text);

                    try
                    {
                        connection.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                LoadUserData();
                                dtp6.DataSource = dataTable;
                            }
                            else
                            {
                                MessageBox.Show("No records found.");
                                dtp6.DataSource = null;
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void delete_btn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM users WHERE Username = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username_txtbox.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record deleted successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE users SET Name = @Name, Role = @Role WHERE Username = @Username";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username_txtbox.Text);
                    command.Parameters.AddWithValue("@Name", name_txtbox.Text);
                    command.Parameters.AddWithValue("@Role", role_txtbox.Text);


                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Record updated successfully!");
                        }
                        else
                        {
                            MessageBox.Show("Record not found.");
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
            // Clearing text boxes
            username_txtbox.Text = string.Empty;
            name_txtbox.Text = string.Empty;
            role_txtbox.Text = string.Empty;
        }
        private void LoadUserData()
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT * FROM users";
                    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, connection);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dtp6.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while loading sales data: " + ex.Message);
            }
        }

        private void dtp6_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dtp6.Rows[e.RowIndex];

                username_txtbox.Text = row.Cells[0].Value?.ToString(); 
                name_txtbox.Text = row.Cells[1].Value?.ToString(); 
                role_txtbox.Text = row.Cells[3].Value?.ToString(); 
            }
        }
    }
}
    
