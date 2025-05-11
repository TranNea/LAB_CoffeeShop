using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TransferObject;

namespace Presentation
{
    public partial class FrmNewSupplier : Form
    {
        private SupplierBL supplierBL;
        public FrmNewSupplier()
        {
            InitializeComponent();
            supplierBL = new SupplierBL();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string id, name, address;
            id = txtID.Text;
            name = txtName.Text;
            address = txtAddress.Text;

            Supplier s = new Supplier(id, name, address);
            try 
            { 
                int numberOfRows = supplierBL.AddSupplier(s);
                if (numberOfRows > 0)
                {
                    this.DialogResult = DialogResult.OK;
                }
            }
            catch (SqlException ex) { MessageBox.Show(ex.Message); }
            finally {  this.Visible = false; }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
