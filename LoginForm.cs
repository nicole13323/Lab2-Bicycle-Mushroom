using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                textBox2.Clear();
                this.Hide();
                using (ChooseForm choose = new ChooseForm())
                {
                    choose.ShowDialog();
                }
                this.Show();   // back to login after logout
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Empty handlers (harmless). Keep them: the designer file may refer to them.
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void lblTitle_Click(object sender, EventArgs e) { }
        private void lblUser_Click(object sender, EventArgs e) { }
        private void lblPass_Click(object sender, EventArgs e) { }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin" && textBox2.Text == "1234")
            {
                textBox2.Clear();
                this.Hide();
                using (ChooseForm choose = new ChooseForm())
                {
                    choose.ShowDialog();
                }
                this.Show();   // back to login after logout
            }
            else
            {
                MessageBox.Show("Wrong username or password.", "Login failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}