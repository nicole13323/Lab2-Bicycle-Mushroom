using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab2
{
    public partial class BicycleForm : Form
    {
        public BicycleForm()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            int start;
            int end;

            // int.TryParse rejects decimals such as "7.5"
            if (!int.TryParse(textBox1.Text, out start) ||
                !int.TryParse(textBox3.Text, out end))
            {
                MessageBox.Show("Please enter whole numbers only (no decimals).",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (start < 0 || start > 23 || end < 1 || end > 24)
            {
                MessageBox.Show("Start must be 0-23 and end must be 1-24.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (start >= end)
            {
                MessageBox.Show("Start time must be less than end time.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = 0;
            for (int h = start; h < end; h++)    // each turn = one rented hour
            {
                total += RateForHour(h);
            }
            txtTotal.Text = total.ToString("N0");
        }

        private static int RateForHour(int h)
        {
            if (h < 7 || h >= 21) return 500;    // 0-7 and 21-24
            if (h < 14) return 1000;             // 7-14
            if (h < 19) return 1500;             // 14-19
            return 1000;                         // 19-21
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Abort;
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click_1(object sender, EventArgs e)
        {
            int start;
            int end;

            if (!int.TryParse(textBox1.Text, out start) || !int.TryParse(textBox3.Text, out end))
            {
                MessageBox.Show("Please enter whole numbers only (no decimals).",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (start < 0 || start > 23 || end < 1 || end > 24)
            {
                MessageBox.Show("Start must be 0-23 and end must be 1-24.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (start >= end)
            {
                MessageBox.Show("Start time must be less than end time.",
                    "Invalid input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int total = 0;
            for (int h = start; h < end; h++)
            {
                total += RateForHour(h);
            }
            txtTotal.Text = total.ToString("N0");
        }
    }
}