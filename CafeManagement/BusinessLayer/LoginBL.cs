using DataLayer;
using System.Data.SqlClient;
using System.Data;
using TransferObject;

namespace BusinessLayer
{
    public class LoginBL
    {
        private LoginDL loginDL;
        public LoginBL() { loginDL = new LoginDL(); }
        public bool Login(Account account)
        {
            try
            {
                return loginDL.Login(account);
            }
            catch (SqlException ex) { throw ex; }
        }
    }
}
