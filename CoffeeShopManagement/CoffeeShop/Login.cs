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

namespace CoffeeShop
{
    public partial class Login : Form
    {
        private SqlCommand cmd;
        private DataProvider provider;
        public string user;

        public Login()
        {
            InitializeComponent();
            provider = new DataProvider();
        }

        private void Login_Load(object sender, EventArgs e) { }
        private bool UserLogin(string username, string password)
        {
            int result = 0;
            string sql = "SELECT COUNT(Username) FROM Users WHERE Username = '" + username + "' AND password = '" + password + "'";
            cmd = new SqlCommand(sql, provider.cn);
            cmd.CommandType = CommandType.Text;

            try
            {
                provider.Connect();
                result = (int)cmd.ExecuteScalar();   
                user = txtUsername.Text;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
            finally
            { provider.Disconnect(); }
            return (result > 0);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username, password;
            username = txtUsername.Text.Trim();
            password = txtPassword.Text;

            if (UserLogin(username, password))
            {
                this.DialogResult = DialogResult.OK;
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
