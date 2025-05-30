﻿using DataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TransferObject;

namespace BusinessLayer
{
    public class SupplierBL
    {
        private SupplierDL supplierDL;
        public SupplierBL() { supplierDL = new SupplierDL(); }
        public List<Supplier> GetSuppliers()
        {
            try { return supplierDL.GetSuppliers(); }
            catch (SqlException ex) { throw ex; }
        }
        public int AddSupplier(Supplier s)
        {
            if (s.Id.Length != 8) { throw new Exception("Ma phai hon 8 ki tu"); }
            else
            {
                try { return supplierDL.AddSupplier(s); }
                catch (SqlException ex) { throw ex; }
            }                
        }
        public int DeleteSupplier(string id)
        {
            try { return supplierDL.DeleteSupplier(id); }
            catch (SqlException ex) { throw ex; }
        }
    }
}
