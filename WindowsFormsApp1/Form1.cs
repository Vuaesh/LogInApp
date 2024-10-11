using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoggedIn;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {


		public Form1()
		{
			InitializeComponent();
		}



		private void label2_Click(object sender, EventArgs e)
        {

        }

        


        private void button1_Click(object sender, EventArgs e)
        {
            string email = textBox1.Text; // Get email from a TextBox
            bool isValid = IsValidEmail(email);

            if (isValid && textBox2.Text.Length > 6)
            {
                var loggedInForm = new LoggedIn.Form1(); // Correctly reference Form1 from LoggedIn
                loggedInForm.Show();
            }
            else
            {
                MessageBox.Show("Email or password is invalid");
            }
        }

        static bool IsValidEmail(string email)
        {
            // Regular expression for validating an email address
            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.PasswordChar == '*')
            {
                textBox2.PasswordChar = '\0';
                button2.Text = "🔓";
            }
            else
            {
                textBox2.PasswordChar = '*';
                button2.Text = "🔒";
            }
        }
    }
}
