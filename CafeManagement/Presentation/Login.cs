using BusinessLayer;
using DataLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace CoffeeShop
{
    public partial class Login : Form
    {
        private LoginBL loginBL;
        public string user;

        public Login()
        {
            InitializeComponent();
            loginBL = new LoginBL();
        }

        private void Login_Load(object sender, EventArgs e) { }
        private bool UserLogin(Account account)
        {
            try
            {
                return loginBL.Login(account);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text.Trim();
            password = txtPassword.Text;

            Account acc = new Account(username, password);

            if (UserLogin(acc))
            {
                this.DialogResult = DialogResult.OK;
                user = txtUsername.Text;
            }
            else
            {
                string m = "U and P are incorrect.";
                DialogResult result = MessageBox.Show(m, "Login", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                if(result == DialogResult.Retry)
                {
                    txtPassword.Clear();
                    txtUsername.Focus();
                }
                else
                {  this.DialogResult = DialogResult.Cancel; }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
