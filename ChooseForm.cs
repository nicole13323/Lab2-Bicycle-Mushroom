using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lab2
{
    public partial class ChooseForm : Form
    {
        public ChooseForm()
        {
            InitializeComponent();
        }

        private void btnBicycle_Click(object sender, EventArgs e)
        {
            OpenForm(new BicycleForm());
        }

        private void btnMushroom_Click(object sender, EventArgs e)
        {
            OpenForm(new MushroomForm());
        }

        private void OpenForm(Form f)
        {
            this.Hide();
            DialogResult result = f.ShowDialog();
            f.Dispose();

            if (result == DialogResult.Abort)    // Logout was pressed
            {
                this.DialogResult = DialogResult.Abort;
                this.Close();                    // returns to Login
            }
            else
            {
                this.Show();                     // back to Choose
            }
        }

        private void btnBicycle_Click_1(object sender, EventArgs e)
        {
            OpenForm(new BicycleForm());
        }

        private void btnMushroom_Click_1(object sender, EventArgs e)
        {
            OpenForm(new MushroomForm());
        }
    }
}