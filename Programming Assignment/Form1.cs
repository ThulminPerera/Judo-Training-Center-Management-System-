using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Programming_Assignment
{
    public partial class Form1 : Form
    {
        private string correctUsername = "admin";
        private string correctPassword = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtLoginID.Text;
            string enteredPassword = txtPassword.Text;
            if (enteredUsername == correctUsername && enteredPassword == correctPassword)
            {
                MessageBox.Show("Login successful! Welcome, Admin.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                
                Form5 form5 = new Form5();
                form5.Show();
                this.Hide(); 
            }
            else
            {
                MessageBox.Show("Invalid Login ID or Password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                
                txtLoginID.Clear();
                txtPassword.Clear();
                txtLoginID.Focus();
            }
        }

             
        

        private void button2_Click_1(object sender, EventArgs e)
        {

            txtLoginID.Clear();
            txtPassword.Clear();
            MessageBox.Show("Fields Resetted.", "Fields Resetted", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            {
                Application.Exit();
               

            }
        }
    }
}

