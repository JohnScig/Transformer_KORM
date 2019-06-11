using Kros.KORM.Metadata.Attribute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformer_korm_demo
{
    [Alias("Customers")] // in case the class is named differently than the DB table
    public class CustomerDTO
    {
        [Key]
        [Alias("CustomerID")] // in case the property is named differently than the column in the database
        public string CustomerID { get; set; }
        public string CompanyName { get; set; }
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }

        [NoMap]
        public string MyTestProperty { get; set; }
    }
}



