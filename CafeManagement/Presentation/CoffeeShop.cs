using CoffeeShop;

namespace Presentation
{
    public partial class CoffeeShop : Form
    {
        public CoffeeShop() { InitializeComponent(); }
        public void AddForm(Form form)
        {
            form.TopLevel = false;
            this.pnMain.Controls.Clear();
            this.pnMain.Controls.Add(form);

            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Show();
        }
        private void CoffeeShop_Load(object sender, EventArgs e)
        {
            this.Show();
            this.Enabled = false;

            Login login = new Login();
            DialogResult result = login.ShowDialog();
            if (result == DialogResult.OK)
            {
                lbWelcome.Text = "Welcome " + login.user;
                this.Enabled = true;
            }
            else Application.Exit();
        }

        private void btnSupplier_Click(object sender, EventArgs e) { AddForm(new FrmSupplier()); }
    }
}
