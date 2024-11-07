using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace KStore_Sales_Inventory
{
    public partial class Inventory : Form
    {
        string connectionString = "Server=localhost,3306;Database=k_store;User ID=root;Password=;";
        public Inventory()
        {
            InitializeComponent();
            LoadData();
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO items (Name, Brand, Category, Price, Stock, Date) " +
                                   "VALUES (@Name, @Brand, @Category, @Price, @Stock, @Date)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Name", name_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Brand", brand_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Category", category_box.Text);
                    cmd.Parameters.AddWithValue("@Price", price_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Stock", stock_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item added successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
                }
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            ItemID_txtbox.Text = "";
            name_txtbox.Text = "";
            brand_txtbox.Text = "";
            category_box.SelectedIndex = -1;
            price_txtbox.Text = "";
            stock_txtbox.Text = "";
            dateTimePicker1.Value = DateTime.Now;
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            string query = "UPDATE items SET Name = @Name, Brand = @Brand, Category = @Category, Price = @Price, Stock = @Stock, Date = @Date WHERE ItemId = @ItemId";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameters to avoid SQL injection
                    command.Parameters.AddWithValue("@ItemId", ItemID_txtbox.Text);
                    command.Parameters.AddWithValue("@Name", name_txtbox.Text);
                    command.Parameters.AddWithValue("@Brand", brand_txtbox.Text);
                    command.Parameters.AddWithValue("@Category", category_box.Text);
                    command.Parameters.AddWithValue("@Price", price_txtbox.Text);
                    command.Parameters.AddWithValue("@Stock", stock_txtbox.Text);
                    command.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadData();
                            MessageBox.Show("Item updated successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No item found with the specified ID.");
                        }
                    }
                    catch (MySqlException mySqlEx)
                    {
                        MessageBox.Show("MySQL Error: " + mySqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                } 
            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM items WHERE ItemId = @ItemId";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameter to avoid SQL injection
                    command.Parameters.AddWithValue("@ItemId", ItemID_txtbox.Text);

                    try
                    {
                        connection.Open();
                        int rowsAffected = command.ExecuteNonQuery();

                        if (rowsAffected > 0)
                        {
                            LoadData();
                            MessageBox.Show("Item deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No item found with the specified ID.");
                        }
                    }
                    catch (MySqlException mySqlEx)
                    {
                        MessageBox.Show("MySQL Error: " + mySqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
        private void search_btn_Click(object sender, EventArgs e)
        {
            string query = "SELECT * FROM items WHERE Name LIKE @SearchTerm OR Brand LIKE @SearchTerm";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Add parameter with wildcard search
                    command.Parameters.AddWithValue("@SearchTerm", "%" + search_btn + "%");

                    try
                    {
                        connection.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                dtp3.DataSource = dataTable; // Populate DataGridView with search results
                            }
                            else
                            {
                                MessageBox.Show("No items found matching the search term.");
                            }
                        }
                    }
                    catch (MySqlException mySqlEx)
                    {
                        MessageBox.Show("MySQL Error: " + mySqlEx.Message);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred: " + ex.Message);
                    }
                }
            }
        }
        private void LoadData()
        {
            string query1 = "SELECT * FROM items";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query1, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check if DataTable has data before assigning to DataGridView
                        if (dataTable.Rows.Count > 0)
                        {
                            dtp3.DataSource = dataTable; // Assuming dtp3 is a DataGridView
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
                        }
                    }
                }
                catch (MySqlException mySqlEx) // Change to MySqlException
                {
                    MessageBox.Show("MySQL Error: " + mySqlEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void dtp3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is on a valid row, not on the header
            if (e.RowIndex >= 0)
            {
                // Access the selected row
                DataGridViewRow row = dtp3.Rows[e.RowIndex];

                // Assign values from specific columns to each TextBox
                ItemID_txtbox.Text = row.Cells[0].Value?.ToString(); // Column 1
                name_txtbox.Text = row.Cells[1].Value?.ToString(); // Column 2
                brand_txtbox.Text = row.Cells[2].Value?.ToString(); // Column 3
                category_box.Text = row.Cells[3].Value?.ToString(); // Column 4
                price_txtbox.Text = row.Cells[4].Value?.ToString(); // Column 5
                stock_txtbox.Text = row.Cells[5].Value?.ToString(); // Column 6
            }
        }
    }
}
    