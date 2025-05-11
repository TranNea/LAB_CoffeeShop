namespace Presentation
{
    partial class CoffeeShop
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            btnSupplier = new Button();
            lbWelcome = new Label();
            panel3 = new Panel();
            pnMain = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnSupplier);
            panel1.Controls.Add(lbWelcome);
            panel1.Location = new Point(2, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 1030);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(403, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(1326, 1030);
            panel2.TabIndex = 1;
            // 
            // btnSupplier
            // 
            btnSupplier.Location = new Point(20, 266);
            btnSupplier.Name = "btnSupplier";
            btnSupplier.Size = new Size(360, 58);
            btnSupplier.TabIndex = 1;
            btnSupplier.Text = "Supplier";
            btnSupplier.UseVisualStyleBackColor = true;
            btnSupplier.Click += btnSupplier_Click;
            // 
            // lbWelcome
            // 
            lbWelcome.BackColor = SystemColors.ActiveCaption;
            lbWelcome.Font = new Font("Segoe UI", 10.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.Location = new Point(3, 0);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(394, 248);
            lbWelcome.TabIndex = 0;
            lbWelcome.Text = "label1";
            lbWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pnMain);
            panel3.Location = new Point(405, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1326, 1030);
            panel3.TabIndex = 1;
            // 
            // pnMain
            // 
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(1326, 1030);
            pnMain.TabIndex = 0;
            // 
            // CoffeeShop
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1730, 1035);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Name = "CoffeeShop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += CoffeeShop_Load;
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbWelcome;
        private Button btnSupplier;
        private Panel panel2;
        private Panel panel3;
        private Panel pnMain;
    }
}
