using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KStore_Sales_Inventory
{
    public partial class UserMod : Form
    {
        private Dashboard dbform;

        public UserMod(Dashboard dbform)
        {
            InitializeComponent();
            this.dbform = dbform;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddUser().Show();

            if (dbform != null)
            {
                dbform.Hide();
            }

            this.Hide();
        }
    }
}
