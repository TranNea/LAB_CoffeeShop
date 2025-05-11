namespace Presentation
{
    partial class FrmNewSupplier
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
            btnSave = new Button();
            txtID = new TextBox();
            txtName = new TextBox();
            txtAddress = new TextBox();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(26, 170);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(150, 46);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtID
            // 
            txtID.Location = new Point(26, 23);
            txtID.Name = "txtID";
            txtID.Size = new Size(360, 39);
            txtID.TabIndex = 1;
            // 
            // txtName
            // 
            txtName.Location = new Point(26, 68);
            txtName.Name = "txtName";
            txtName.Size = new Size(360, 39);
            txtName.TabIndex = 2;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(26, 113);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(360, 39);
            txtAddress.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(236, 170);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(150, 46);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // FrmNewSupplier
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(420, 243);
            Controls.Add(btnCancel);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(txtID);
            Controls.Add(btnSave);
            Name = "FrmNewSupplier";
            Text = "FrmNewSupplier";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private TextBox txtID;
        private TextBox txtName;
        private TextBox txtAddress;
        private Button btnCancel;
    }
}