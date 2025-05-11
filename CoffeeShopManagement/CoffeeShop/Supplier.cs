using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class Supplier : Form
    {
        private SqlDataAdapter adapter;
        private DataSet dataset;
        private SqlConnection cn;

        public Supplier()
        {
            InitializeComponent();
            string cnStr = "Data Source=.\\SQLEXPRESS01;Initial Catalog=CoffeeShop;Integrated Security=True";
            cn = new SqlConnection(cnStr);
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            try
            {
                string sql = "SELECT * FROM Supplier";
                adapter = new SqlDataAdapter(sql, cn);

                dataset = new DataSet();
                adapter.Fill(dataset, "Supplier");

                dgvSup.DataSource = dataset.Tables["Supplier"];
                dgvSup.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            }
            catch (SqlException ex)
            { MessageBox.Show(ex.Message); }            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //DELETE
            string sql = "DELETE * FROM Supplier WHERE id = @ma";
            SqlCommand d_cmd = new SqlCommand(sql, cn);
            d_cmd.CommandType = CommandType.Text;
            d_cmd.Parameters.Add("@ma", SqlDbType.VarChar, 20, "id");

            adapter.DeleteCommand = d_cmd;

            //INSERT
            sql = "INSERT INTO Supplier VALUES(@ma, @ten, @diachi)";
            SqlCommand i_cmd = new SqlCommand(sql, cn);
            i_cmd.CommandType = CommandType.Text;
            i_cmd.Parameters.Add("@ma", SqlDbType.VarChar, 20, "id");
            i_cmd.Parameters.Add("@ten", SqlDbType.NVarChar, 100, "name");
            i_cmd.Parameters.Add("@diachi", SqlDbType.NVarChar, 200, "address");

            adapter.InsertCommand = i_cmd;

            //Save
            adapter.Update(dataset.Tables["Supplier"]);
        }
    }
}
