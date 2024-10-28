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
    public partial class SalesReport : Form
    {
        public SalesReport()
        {
            InitializeComponent();
        }

        private void dtp4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //show here the transactions and sales
        }

        private void dtp5_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //show here the remaining stocks and etc (remove if you can fit it all in 1 table)
        }
    }
}
