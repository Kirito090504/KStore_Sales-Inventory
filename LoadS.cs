using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KStore_Sales_Inventory
{
    public partial class LoadS : Form
    {
        public LoadS()
        {
            InitializeComponent();
        }

        private void LoadS_Load(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(ShowProgress));
            thread.Start();
        }

        private void ShowProgress()
        {
            for (int i = 0; i <= 100; i++)
            {
                // Update the progress bar on the UI thread
                UpdateProgress(i);
                Thread.Sleep(50); // Simulate work by sleeping
            }

            // Switch to the login form once the progress is complete
            this.Invoke((MethodInvoker)delegate
            {
                Form1 loginForm = new Form1();
                loginForm.Show();
                this.Hide(); // Hide the main form
            });
        }

        private void UpdateProgress(int value)
        {
            if (progressBar1.InvokeRequired)
            {
                progressBar1.Invoke((MethodInvoker)delegate { progressBar1.Value = value; });
            }
            else
            {
                progressBar1.Value = value;
            }
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }
    }
}
