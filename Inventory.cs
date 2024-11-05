using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE items SET name = @name, brand = @brand, category = @category, price = @price, " +
                                   "stock = @stock, date = @date WHERE item_id = @item_id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Itemid", ItemID_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Name", name_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Brand", brand_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Category", category_box.Text);
                    cmd.Parameters.AddWithValue("@Price", price_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Stock", stock_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item updated successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
                }
            }
        }


        private void delete_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM items WHERE Itemid = @id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Itemid", ItemID_txtbox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item deleted successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
                }
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM items WHERE Itemid = @Itemid";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Itemid", ItemID_txtbox.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        name_txtbox.Text = reader["Name"].ToString();
                        brand_txtbox.Text = reader["Brand"].ToString();
                        category_box.Text = reader["Category"].ToString();
                        price_txtbox.Text = reader["Price"].ToString();
                        stock_txtbox.Text = reader["Stock"].ToString();
                        dateTimePicker1.Value = Convert.ToDateTime(reader["Date"]);
                    }
                    else
                    {
                        MessageBox.Show("Item not found.", "Not Found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
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
    }
    }
    