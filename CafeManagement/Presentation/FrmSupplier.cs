using BusinessLayer;
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

namespace Presentation
{
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }

        private void LoadSupplier()
        {
            try { dgvSup.DataSource = new SupplierBL().GetSuppliers(); }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
        }
        private DataGridView CustomDataGridView(DataGridView dgv)
        {
            dgv.Rows.Clear();
            List<String> names = new List<String>() { "Id", "Name", "Address" };
            for (int i = 0; i < names.Count; i++)
            { dgv.Columns.Add(new DataGridViewTextBoxColumn()); /*Tự động tạo cột thay vì add thủ công bên Design*/ }
            for (int i = 0; i < names.Count; i++)
            {
                dgv.Columns[i].Name = names[i];
                dgv.Columns[i].DataPropertyName = names[i];
            }
            DataGridViewImageColumn deleteColumn = new DataGridViewImageColumn
            {
                Name = "Delete",
                Image = Properties.Resources.cat_write,
                ImageLayout = DataGridViewImageCellLayout.Zoom
            };
            dgv.Columns.Add(deleteColumn);
            return dgv;
        }
        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            LoadSupplier();
            CustomDataGridView(dgvSup);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmNewSupplier frmNewSupplier = new FrmNewSupplier();
            DialogResult result = frmNewSupplier.ShowDialog();
            if (result == DialogResult.OK)
            {  LoadSupplier(); }
        }

        private void dgvSup_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int col = e.ColumnIndex;
            if (dgvSup.Columns[col] is DataGridViewImageColumn)
            {
                int row = e.RowIndex;
                string id = dgvSup.Rows[row].Cells["Id"].Value.ToString();
                MessageBox.Show(id.ToString());
            }
        }
    }
}
