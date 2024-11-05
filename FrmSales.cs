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

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM items WHERE Itemid = @Itemid";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Item_id", ItemID_txtbox.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ItmName_txtbox.Text = reader["Name"].ToString();
                        brand_txtbox.Text = reader["Brand"].ToString();
                        category_box.Text = reader["Category"].ToString();
                        price_txtbox.Text = reader["Price"].ToString();
                        stock_txtbox.Text = reader["Stock"].ToString();
                        dtp1.Value = Convert.ToDateTime(reader["Date"]);
                        status_txtbox.Text = reader["Status"].ToString();
                        note_txtbox.Text = reader["Note"].ToString();
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
                    cmd.Parameters.AddWithValue("@Price", price_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Quantity", stock_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Date", dtp1.Value);
                    cmd.Parameters.AddWithValue("@Status", status_txtbox.Text);
                    cmd.Parameters.AddWithValue("Note", note_txtbox.Text);

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
            price_txtbox.Clear();
            stock_txtbox.Clear();
            status_txtbox.Clear();
            note_txtbox.Clear();
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
                                   "Stock = @Stock, Date = @Date, Status = @Status, Note = @Note WHERE Itemid = @Itemid";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Itemid", ItemID_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Name", ItmName_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Brand", brand_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Category", category_box.Text);
                    cmd.Parameters.AddWithValue("@Price", price_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Stock", stock_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Date", dtp1.Value);
                    cmd.Parameters.AddWithValue("@Status", status_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Note", note_txtbox.Text);

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
                    string query = "DELETE FROM sales WHERE Itemid = @Itemid";
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

        private void paid_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE sales SET status = 'Paid' WHERE Itemid = @Itemid";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Itemid", ItemID_txtbox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item marked as Paid.", "Success");
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
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(query1, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Check if DataTable has data before assigning to DataGridView
                        if (dataTable.Rows.Count > 0)
                        {
                            dtp2.DataSource = dataTable; // Assuming dtp3 is a DataGridView
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
