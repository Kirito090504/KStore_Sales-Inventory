using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Diagnostics;
using System.IO;
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
            string query = "UPDATE items SET Name = @Name, Brand = @Brand, Category = @Category, Price = @Price, Stock = @Stock, Date = @Date WHERE ItemId = @ItemId";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
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
                    command.Parameters.AddWithValue("@SearchTerm", "%" + name_txtbox.Text + "%");

                    try
                    {
                        connection.Open();
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);

                            if (dataTable.Rows.Count > 0)
                            {
                                dtp3.DataSource = dataTable; 
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

  
                        if (dataTable.Rows.Count > 0)
                        {
                            dtp3.DataSource = dataTable;
                        }
                        else
                        {
                            MessageBox.Show("No data found.");
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

        private void dtp3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
            if (e.RowIndex >= 0)
            {
  
                DataGridViewRow row = dtp3.Rows[e.RowIndex];

                ItemID_txtbox.Text = row.Cells[0].Value?.ToString();
                name_txtbox.Text = row.Cells[1].Value?.ToString(); 
                brand_txtbox.Text = row.Cells[2].Value?.ToString(); 
                category_box.Text = row.Cells[3].Value?.ToString(); 
                price_txtbox.Text = row.Cells[4].Value?.ToString(); 
                stock_txtbox.Text = row.Cells[5].Value?.ToString(); 
            }
        }

        private void exp_Click(object sender, EventArgs e)
        {
            string filePath = "InventoryReport.pdf";
            Document document = new Document(PageSize.A4.Rotate());
            try
            {

                PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));


                document.Open();


                PdfPTable table = new PdfPTable(dtp3.ColumnCount);


                foreach (DataGridViewColumn column in dtp3.Columns)
                {
                    PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText));
                    table.AddCell(headerCell);
                }


                foreach (DataGridViewRow row in dtp3.Rows)
                {
                    if (row.IsNewRow) continue;

                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        table.AddCell(new Phrase(cell.Value?.ToString() ?? ""));
                    }
                }


                document.Add(table);
                MessageBox.Show("PDF export successful! File saved at " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error generating PDF: " + ex.Message);
            }
            finally
            {
                document.Close();
            }

            try
            {
                Process.Start(filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening PDF: " + ex.Message);
            }
        }
    }
}
    