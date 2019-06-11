using Kros.KORM;
using Kros.KORM.Query;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformer_korm_demo
{
    public class KormDatabase
    {
        private string _connectionString = string.Empty;

        public KormDatabase()
        {
            InitConnectionString();
        }

        private void InitConnectionString()
        {
            var connBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = @"TRANSFORMER10\SQLEXPRESS2017",
                InitialCatalog = "Northwind",
                IntegratedSecurity = true
            };

            _connectionString = connBuilder.ConnectionString;
        }


        public IDbSet<T> GetAllData<T>()
        {
            IDbSet<T> ret = null;

            using (Database db = new Database(_connectionString, "System.Data.SqlClient"))
            {
                ret = db.Query<T>().AsDbSet();
            }

            return ret;
        }

    }
}
