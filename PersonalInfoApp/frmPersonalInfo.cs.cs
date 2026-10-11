using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PersonalInfoApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Empty handlers kept because the Designer still references them
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Clear the output labels at startup
            lblDisplayName.Text = "";
            lblDisplaySureName.Text = "";
            lblDisplayUserName.Text = "";
            lblDisplayPassword.Text = "";
            lblDisplayEmail.Text = "";
            lblDisplayAge.Text = "";
        }

        // NAME 
        private void button1_Click(object sender, EventArgs e)
        {
            string value = txtName.Text.Trim();
            if (value == "")
            {
                MessageBox.Show("Please enter your name.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtName.Focus();
                return;
            }
            lblDisplayName.Text = value;
            MessageBox.Show("Name submitted successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // SURNAME 
        private void button2_Click(object sender, EventArgs e)
        {
            string value = txtSureName.Text.Trim();
            if (value == "")
            {
                MessageBox.Show("Please enter your sure name.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSureName.Focus();
                return;
            }
            lblDisplaySureName.Text = value;
            MessageBox.Show("Sure name submitted successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // USERNAME
        private void button3_Click(object sender, EventArgs e)
        {
            string value = txtUserName.Text.Trim();
            if (value == "")
            {
                MessageBox.Show("Please enter your username.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUserName.Focus();
                return;
            }
            lblDisplayUserName.Text = value;
            MessageBox.Show("Username submitted successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // PASSWORD 
        private void button4_Click(object sender, EventArgs e)
        {
            string value = txtPassword.Text;
            if (value == "")
            {
                MessageBox.Show("Please enter your password.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return;
            }
            // Show the password masked in the output area (e.g. ******)
            lblDisplayPassword.Text = new string('*', value.Length);
            MessageBox.Show("Password submitted successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //  EMAIl
        private void button5_Click(object sender, EventArgs e)
        {
            string value = txtEmail.Text.Trim();
            if (value == "")
            {
                MessageBox.Show("Please enter your email.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            // Basic format check: needs '@' and a '.' after it
            int at = value.IndexOf('@');
            if (at < 1 || value.IndexOf('.', at) < at + 2 || value.EndsWith("."))
            {
                MessageBox.Show("Please enter a valid email address (e.g. name@example.com).",
                    "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return;
            }
            lblDisplayEmail.Text = value;
            MessageBox.Show("Email submitted successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        // AGE
        private void button6_Click(object sender, EventArgs e)
        {
            string value = txtAge.Text.Trim();
            if (value == "")
            {
                MessageBox.Show("Please enter your age.", "Missing Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAge.Focus();
                return;
            }
            // int.TryParse rejects text such as "abc", "hello", "twenty"
            int age;
            if (!int.TryParse(value, out age) || age < 1 || age > 120)
            {
                MessageBox.Show("Please enter a valid age as a number between 1 and 120.",
                    "Invalid Age", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAge.Focus();
                return;
            }
            lblDisplayAge.Text = age.ToString();
            MessageBox.Show("Age submitted successfully.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}