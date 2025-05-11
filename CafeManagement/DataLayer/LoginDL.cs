using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace DataLayer
{
    public class LoginDL : DataProvider
    {
        public bool Login(Account account) 
        {
			string sql = "SELECT COUNT(Username) FROM Users WHERE Username = '" + account.Username + "' AND password = '" + account.Password + "'";
            try
			{
                return ((int)MyExecuteScalar(sql, CommandType.Text) > 0);
			}
			catch (SqlException ex) { throw ex; }
        }
    }
}
