using MySql.Data.MySqlClient;
using System;
using System.Diagnostics;
using System.Drawing.Printing;
using System.IO;
using System.Windows.Forms;
using System.Xml.Linq;
using iTextSharp.text;
using iTextSharp.text.pdf;

namespace KStore_Sales_Inventory
{
    public partial class SalesReport : Form
    {

        string connectionString = "Server=localhost,3306;Database=k_store;User ID=root;Password=;";


        public SalesReport()
        {
            InitializeComponent();
            LoadData();
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
                                    dtp5.Rows.Add(
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
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MySqlCommand cmd = new MySqlCommand(query1, connection);
                    {
                        using (MySqlCommand command = connection.CreateCommand())
                        {
                            command.CommandText = "SELECT SUM(Total) AS t FROM sales";
                            using (MySqlDataReader reader = command.ExecuteReader())
                            {

                                while (reader.Read())
                                {
                                    f_total.Text = Convert.ToString(reader.GetDouble("t"));
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
        private void dtp4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //show here the transactions and sales
        }

        private void dtp5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //show here the remaining stocks and etc (remove if you can fit it all in 1 table)
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM sales WHERE Transaction_id = @Transaction_id";
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@Transaction_id", tranID_box.Text);

                    MySqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        dtp5.Rows.Clear();
                            dtp5.Rows.Add(
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

        private void exp_Click(object sender, EventArgs e)
        {
           
                string filePath = "InventoryReport.pdf";
                Document document = new Document(PageSize.A4.Rotate());
                try
                {

                    PdfWriter.GetInstance(document, new FileStream(filePath, FileMode.Create));


                    document.Open();


                    PdfPTable table = new PdfPTable(dtp5.ColumnCount);


                    foreach (DataGridViewColumn column in dtp5.Columns)
                    {
                        PdfPCell headerCell = new PdfPCell(new Phrase(column.HeaderText));
                        table.AddCell(headerCell);
                    }


                    foreach (DataGridViewRow row in dtp5.Rows)
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


