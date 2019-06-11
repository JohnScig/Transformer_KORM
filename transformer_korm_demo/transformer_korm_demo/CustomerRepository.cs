﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformer_korm_demo
{
    public class CustomerRepository
    {
        private KormDatabase _database = new KormDatabase();

        public IEnumerable GetCustomers()
        {
            IEnumerable ret = _database.GetAllData<CustomerDTO>().Where(x=>x.Country=="Germany").ToList<CustomerDTO>();

            return ret;
        }
    }
}
