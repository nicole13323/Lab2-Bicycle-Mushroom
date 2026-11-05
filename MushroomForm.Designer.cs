namespace Lab2
{
    partial class MushroomForm
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
            lblInfo = new Label();
            btnLogout = new Button();
            btnStart = new Button();
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
            lblTitle.Size = new Size(199, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Mushroom Guesser";
            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInfo.Location = new Point(53, 125);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(643, 25);
            lblInfo.TabIndex = 4;
            lblInfo.Text = "Think of one of the six mushrooms, then press Start and answer yes or no.";
            lblInfo.Click += lblInfo_Click;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.Gray;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Location = new Point(469, 314);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(150, 45);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click_1;
            // 
            // btnStart
            // 
            btnStart.BackColor = Color.Gray;
            btnStart.FlatStyle = FlatStyle.Flat;
            btnStart.Location = new Point(102, 314);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(150, 45);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = false;
            btnStart.Click += btnStart_Click_1;
            // 
            // MushroomForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnStart);
            Controls.Add(btnLogout);
            Controls.Add(lblInfo);
            Controls.Add(pnlHeader);
            Name = "MushroomForm";
            Text = "Mushroom Guesser";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblInfo;
        private Button btnLogout;
        private Button btnStart;
    }
}