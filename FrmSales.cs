﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace KStore_Sales_Inventory
{
    public partial class FrmSales : Form
    {
        string connectionString = "Server=localhost,3306;Database=k_store;User ID=root;Password=;";

        public FrmSales()
        {
            InitializeComponent();
            LoadData();
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM sales WHERE ItemId = @ItemId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ItemId", ItemID_txtbox.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        ItmName_txtbox.Text = reader["Name"].ToString();
                        brand_txtbox.Text = reader["Brand"].ToString();
                        category_box.Text = reader["Category"].ToString();
                        quan_txtbox.Text = reader["Stock"].ToString();
                    }

                    else
                    {
                        MessageBox.Show("Transaction not found.", "Not Found");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void add_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "INSERT INTO sales (ItemId, Name, Brand, Category, Quantity, Date, Total) " +
                                   "VALUES (@ItemId, @Name, @Brand, @Category, @Quantity, @Date, @Total)";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ItemId", ItemID_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Name", ItmName_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Brand", brand_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Category", category_box.Text);
                    cmd.Parameters.AddWithValue("@Quantity", quan_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Date", dtp1.Value);
                    cmd.Parameters.AddWithValue("@Total", total_txtbox.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item added successfully.", "Success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error");
                    throw ex;
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
                    string query = @"
                UPDATE sales SET ItemId = @ItemId, Name=@Name, Brand=@Brand,
                Category=@Category, Quantity=@Quantity, Date=@Date, Total=@Total
                WHERE Transaction_id = @Transaction_id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ItemId", ItemID_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Name", ItmName_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Brand", brand_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Category", category_box.Text);
                    cmd.Parameters.AddWithValue("@Quantity", quan_txtbox.Text);
                    cmd.Parameters.AddWithValue("@Date", dtp1.Value);
                    cmd.Parameters.AddWithValue("@Transaction_id", textBox1.Text);
                    cmd.Parameters.AddWithValue("@Total", total_txtbox.Text);

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
                LoadData();
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
                    MySqlCommand cmd = new MySqlCommand(query1, connection);
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
                                        reader.GetString("Name"),
                                        reader.GetString("Brand"),
                                        reader.GetString("Category"),
                                        reader.GetInt32("Quantity"),
                                        reader.GetDateTime("Date"),
                                        reader.GetFloat("Total")
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

                textBox1.Text = row.Cells[0].Value?.ToString();
                ItemID_txtbox.Text = row.Cells[1].Value?.ToString();
                ItmName_txtbox.Text = row.Cells[2].Value?.ToString();
                brand_txtbox.Text = row.Cells[3].Value?.ToString();
                category_box.Text = row.Cells[4].Value?.ToString();
                quan_txtbox.Text = row.Cells[5].Value?.ToString();
                dtp1.Text = row.Cells[6].Value?.ToString();
                total_txtbox.Text = row.Cells[7].Value?.ToString();
            }
        }

        private void quan_txtbox_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(quan_txtbox.Text)) {
                ItmName_txtbox.Clear();
                brand_txtbox.Clear();
                category_box.SelectedIndex = -1;
                quan_txtbox.Clear();
                total_txtbox.Clear();
                dtp1.Value = DateTime.Today;
                return;
            }

            try { int.Parse(quan_txtbox.Text); }
            catch (FormatException) { return; }


            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM items WHERE ItemId = @ItemId";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@ItemId", ItemID_txtbox.Text);

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

        private void exp_Click(object sender, EventArgs e)
        {
                string filePath = "InventoryReport.pdf";
                Document document = new Document(PageSize.A4.Rotate());
                try
                {

                    PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));


                    document.Open();


                    PdfPTable table = new PdfPTable(dtp2.ColumnCount);


                    foreach (DataGridViewColumn column in dtp2.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText));
                        table.AddCell(headerCell);
                    }


                    foreach (DataGridViewRow row in dtp2.Rows)
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
