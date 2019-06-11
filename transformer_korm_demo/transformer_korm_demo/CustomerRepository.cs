using Kros.KORM.Query;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformer_korm_demo
{
    public class CustomerRepository
    {
        private KormDatabase _database = new KormDatabase();
        private IDbSet<CustomerDTO> _customers;

        public IEnumerable GetCustomers()
        {
            _customers = _database.GetAllData<CustomerDTO>();
            IEnumerable ret = _customers.Where(x => x.Country == "Germany").ToList<CustomerDTO>();

            return ret;
        }

        public void SaveCustomers(IEnumerable<CustomerDTO> customers)
        {
            foreach (var person in customers)
            {
                _customers.Edit(person);
            }

            _customers.BulkUpdate();
        }
    }
}
