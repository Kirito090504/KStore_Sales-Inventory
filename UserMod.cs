using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace KStore_Sales_Inventory
{
    public partial class UserMod : Form
    {
        string connectionString = "Server=localhost,3306;Database=k_store;User ID=root;Password=;";
        private Dashboard dbform;

        public UserMod(Dashboard dbform)
        {
            InitializeComponent();
            this.dbform = dbform;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO users (Username, Name, Role, Date) VALUES (@Username, @Name, @Role, @Date)";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                using (MySqlCommand command = new MySqlCommand(query, connection))
                {
                    // Adding values from text boxes and date picker
                    command.Parameters.AddWithValue("@Username", username_txtbox.Text);
                    command.Parameters.AddWithValue("@Name", name_txtbox.Text);
                    command.Parameters.AddWithValue("@Role", role_txtbox.Text);
                    command.Parameters.AddWithValue("@Date", dateTimePicker1.Value);

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

        private void search_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
