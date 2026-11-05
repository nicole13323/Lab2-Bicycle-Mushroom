namespace Lab2
{
    partial class BicycleForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlHeader = new Panel();
            lblTitle = new Label();
            lblStart = new Label();
            lblEnd = new Label();
            lblTotal = new Label();
            textBox1 = new TextBox();
            txtTotal = new TextBox();
            textBox3 = new TextBox();
            btnCalculate = new Button();
            btnLogout = new Button();
            pnlHeader.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(0, 121, 107);
            pnlHeader.Controls.Add(lblTitle);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(800, 60);
            pnlHeader.TabIndex = 3;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(325, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(143, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Bicycle Rental";
            // 
            // lblStart
            // 
            lblStart.AutoSize = true;
            lblStart.Location = new Point(42, 110);
            lblStart.Name = "lblStart";
            lblStart.Size = new Size(93, 15);
            lblStart.TabIndex = 4;
            lblStart.Text = "Start hour (0-23)";
            // 
            // lblEnd
            // 
            lblEnd.AutoSize = true;
            lblEnd.Location = new Point(42, 215);
            lblEnd.Name = "lblEnd";
            lblEnd.Size = new Size(89, 15);
            lblEnd.TabIndex = 5;
            lblEnd.Text = "End hour (1-24)";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(42, 344);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(67, 15);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total (RWF)";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(159, 107);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 23);
            textBox1.TabIndex = 7;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // txtTotal
            // 
            txtTotal.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtTotal.Location = new Point(159, 336);
            txtTotal.Name = "txtTotal";
            txtTotal.ReadOnly = true;
            txtTotal.Size = new Size(100, 33);
            txtTotal.TabIndex = 8;
            txtTotal.TextAlign = HorizontalAlignment.Right;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(159, 207);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 23);
            textBox3.TabIndex = 9;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // btnCalculate
            // 
            btnCalculate.BackColor = Color.Silver;
            btnCalculate.FlatStyle = FlatStyle.Flat;
            btnCalculate.Location = new Point(372, 258);
            btnCalculate.Name = "btnCalculate";
            btnCalculate.Size = new Size(75, 30);
            btnCalculate.TabIndex = 10;
            btnCalculate.Text = "Calculate";
            btnCalculate.UseVisualStyleBackColor = false;
            btnCalculate.Click += btnCalculate_Click_1;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Silver;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(372, 380);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(75, 28);
            btnLogout.TabIndex = 11;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // BicycleForm
            // 
            AcceptButton = btnCalculate;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLogout);
            Controls.Add(btnCalculate);
            Controls.Add(textBox3);
            Controls.Add(txtTotal);
            Controls.Add(textBox1);
            Controls.Add(lblTotal);
            Controls.Add(lblEnd);
            Controls.Add(lblStart);
            Controls.Add(pnlHeader);
            Name = "BicycleForm";
            Text = "BicycleForm";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblStart;
        private Label lblEnd;
        private Label lblTotal;
        private TextBox textBox1;
        private TextBox txtTotal;
        private TextBox textBox3;
        private Button btnCalculate;
        private Button btnLogout;
    }
}