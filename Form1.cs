using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace lesson1_Z
{
    public partial class Form1 : Form
    {
        string registeredName = "";
        string registeredEmail = "";
        string registeredPassword = "";

        public Form1()
        {
            InitializeComponent();

            // Placeholders
            textBox1.PlaceholderText = "Full Name";
            textBox2.PlaceholderText = "Email";
            textBox3.PlaceholderText = "Password";
            textBox4.PlaceholderText = "Confirm Password";

            textBox5.PlaceholderText = "Email";
            textBox6.PlaceholderText = "Password";
        }


        // REGISTER
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" ||
                textBox2.Text == "" ||
                textBox3.Text == "" ||
                textBox4.Text == "")
            {
                MessageBox.Show(
                    "Please fill in all fields!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else if (!textBox2.Text.Contains("@"))
            {
                MessageBox.Show(
                    "Please enter a valid email address!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else if (textBox3.Text.Length < 6)
            {
                MessageBox.Show(
                    "Password must be at least 6 characters long!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else if (textBox3.Text != textBox4.Text)
            {
                MessageBox.Show(
                    "Passwords do not match!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else
            {
                registeredName = textBox1.Text;
                registeredEmail = textBox2.Text;
                registeredPassword = textBox3.Text;

                MessageBox.Show(
                    "Registration completed successfully!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                textBox5.Text = registeredEmail;

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }
        }


        // LOGIN
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "" ||
                textBox6.Text == "")
            {
                MessageBox.Show(
                    "Please enter your email and password!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }

            else if (textBox5.Text == registeredEmail &&
                     textBox6.Text == registeredPassword)
            {
                MessageBox.Show(
                    "Welcome, " + registeredName + "!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }

            else
            {
                MessageBox.Show(
                    "Incorrect email or password!",
                    "Notification",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }


        // SHOW REGISTER PASSWORD
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                textBox3.UseSystemPasswordChar = false;
                textBox4.UseSystemPasswordChar = false;
            }
            else
            {
                textBox3.UseSystemPasswordChar = true;
                textBox4.UseSystemPasswordChar = true;
            }
        }


        // SHOW LOGIN PASSWORD
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                textBox6.UseSystemPasswordChar = false;
            }
            else
            {
                textBox6.UseSystemPasswordChar = true;
            }
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }
}