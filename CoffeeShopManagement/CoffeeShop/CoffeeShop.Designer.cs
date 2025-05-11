namespace CoffeeShop
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
            lbWelcome = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lbWelcome);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(335, 1012);
            panel1.TabIndex = 0;
            // 
            // lbWelcome
            // 
            lbWelcome.AutoSize = true;
            lbWelcome.BackColor = SystemColors.ActiveCaption;
            lbWelcome.Font = new Font("Segoe UI", 10, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbWelcome.Location = new Point(16, 14);
            lbWelcome.Name = "lbWelcome";
            lbWelcome.Size = new Size(0, 71);
            lbWelcome.TabIndex = 0;
            lbWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CoffeeShop
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1292, 1032);
            Controls.Add(panel1);
            Name = "CoffeeShop";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += CoffeeShop_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label lbWelcome;
    }
}
