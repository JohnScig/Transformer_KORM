using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformer_korm_demo
{
    public class OrderRepository
    {
        private KormDatabase _database = new KormDatabase();

        public IEnumerable GetOrders()
            => _database.GetAllData<OrderDTO>().Take(5).ToList<OrderDTO>();
    }
}
