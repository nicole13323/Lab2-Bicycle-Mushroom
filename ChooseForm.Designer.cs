namespace Lab2
{
    partial class ChooseForm
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
            lblAsk = new Label();
            btnMushroom = new Button();
            btnBicycle = new Button();
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
            pnlHeader.TabIndex = 2;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(325, 18);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(84, 30);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Choose";
            // 
            // lblAsk
            // 
            lblAsk.AutoSize = true;
            lblAsk.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAsk.Location = new Point(195, 126);
            lblAsk.Name = "lblAsk";
            lblAsk.Size = new Size(351, 37);
            lblAsk.TabIndex = 3;
            lblAsk.Text = "What would you like to do?";
            // 
            // btnMushroom
            // 
            btnMushroom.BackColor = Color.FromArgb(224, 224, 224);
            btnMushroom.FlatStyle = FlatStyle.Flat;
            btnMushroom.Location = new Point(547, 354);
            btnMushroom.Name = "btnMushroom";
            btnMushroom.Size = new Size(150, 55);
            btnMushroom.TabIndex = 4;
            btnMushroom.Text = "Mushroom";
            btnMushroom.UseVisualStyleBackColor = false;
            btnMushroom.Click += btnMushroom_Click_1;
            // 
            // btnBicycle
            // 
            btnBicycle.BackColor = Color.FromArgb(224, 224, 224);
            btnBicycle.FlatStyle = FlatStyle.Flat;
            btnBicycle.Location = new Point(124, 354);
            btnBicycle.Name = "btnBicycle";
            btnBicycle.Size = new Size(150, 55);
            btnBicycle.TabIndex = 5;
            btnBicycle.Text = "Bicycle rental";
            btnBicycle.UseVisualStyleBackColor = false;
            btnBicycle.Click += btnBicycle_Click_1;
            // 
            // ChooseForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnBicycle);
            Controls.Add(btnMushroom);
            Controls.Add(lblAsk);
            Controls.Add(pnlHeader);
            Name = "ChooseForm";
            Text = "Choose";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnlHeader;
        private Label lblTitle;
        private Label lblAsk;
        private Button btnMushroom;
        private Button btnBicycle;
    }
}