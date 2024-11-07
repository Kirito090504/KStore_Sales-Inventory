using MySql.Data.MySqlClient;
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

namespace KStore_Sales_Inventory
{
    public partial class FrmSales : Form
    {
        string connectionString = "Server=localhost;Database=k_store;User ID=root;Password=;";

        public FrmSales()
        {
            InitializeComponent();
            LoadData();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM items WHERE ItemId = @ItemId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Item_Id", ItemID_txtbox.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ItmName_txtbox.Text = reader["Name"].ToString();
                        brand_txtbox.Text = reader["Brand"].ToString();
                        category_box.Text = reader["Category"].ToString();
                        quan_txtbox.Text = reader["Stock"].ToString();
                        dtp1.Value = reader.GetDateTime("Date");
                        total_txtbox.Text = reader["Note"].ToString();
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

        private void FrmSales_Load(object sender, EventArgs e)
        {

        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO sales (Name, Brand, Category, Price, Quantity, Date, Status, Note) " +
                                   "VALUES (@Name, @Brand, @Category, @Price, @Quantity, @Date, @Status, @Note)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Name", ItmName_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Brand", brand_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Category", category_box.Text);
                    cmd.Parameters.AddWithValue("@Quantity", quan_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Date", dtp1.Value);
                    cmd.Parameters.AddWithValue("Note", total_txtbox.Text);

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
            ItemID_txtbox.Clear();
            ItmName_txtbox.Clear();
            brand_txtbox.Clear();
            category_box.SelectedIndex = -1;
            quan_txtbox.Clear();
            total_txtbox.Clear();
            dtp1.Value = DateTime.Today;
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE sales SET Name = @Name, Brand = @Brand, Category = @Category, Price = @Price, " +
                                   "Stock = @Stock, Date = @Date, Status = @Status, Note = @Note WHERE ItemId = @ItemId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ItemId", ItemID_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Name", ItmName_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Brand", brand_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Category", category_box.Text);
                    cmd.Parameters.AddWithValue("@Stock", quan_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Date", dtp1.Value);
                    cmd.Parameters.AddWithValue("@Note", total_txtbox.Text);

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
                    string query = "DELETE FROM sales WHERE ItemId = @ItemId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ItemId", ItemID_txtbox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item deleted successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
                }
            }
        }

        private void LoadData()
        {
            string query1 = "SELECT * FROM sales";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    {
                        using (MySqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "SELECT * FROM sales";
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {

                                while (reader.Read()) 
                                {
                                    dtp2.Rows.Add(
                                        reader.GetInt32("Transaction_id"),
                                        reader.GetInt32("ItemId"),
                                        reader.GetString("Name")
                                        );
                                }
                            }
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

        private void dtp2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = dtp2.Rows[e.RowIndex];

                ItemID_txtbox.Text = row.Cells[0].Value?.ToString();
                ItmName_txtbox.Text = row.Cells[1].Value?.ToString();
                brand_txtbox.Text = row.Cells[2].Value?.ToString();
                category_box.Text = row.Cells[3].Value?.ToString();
                quan_txtbox.Text = row.Cells[5].Value?.ToString();
                dtp1.Text = row.Cells[6].Value?.ToString();
                total_txtbox.Text = row.Cells[7].Value?.ToString();
            }
        }

        private void quan_txtbox_TextChanged(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM items WHERE ItemId = @ItemId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Item_Id", ItemID_txtbox.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ItmName_txtbox.Text = reader["Name"].ToString();
                        brand_txtbox.Text = reader["Brand"].ToString();
                        category_box.Text = reader["Category"].ToString();

                        double price = Convert.ToDouble(reader["Price"]);

                        int quantity = Convert.ToInt32(quan_txtbox.Text);

                        double total = price * quantity;

                        total_txtbox.Text = total.ToString();

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
    }
}
