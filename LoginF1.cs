using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Login
{
    public partial class LoginF1 : Form
    {
        public LoginF1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Simulate a login process (replace with actual authentication logic)
            if (username == "admin" && password == "password")
            {
                MessageBox.Show("Login successful!");
                // Proceed to the next form or main application
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
    }
}