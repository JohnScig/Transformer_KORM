using System.Collections.Generic;
using System.ComponentModel;


namespace transformer_korm_demo
{
    public class MainViewModel
    {
        #region private fields
        private CustomerRepository _customerRepository;

        #endregion


        #region constructors
        public MainViewModel(CustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        #endregion



        #region public properties and methods
        public BindingList<CustomerDTO> Customers { get; set; }


        public void LoadCustomers()
            => Customers = new BindingList<CustomerDTO>((List<CustomerDTO>) _customerRepository.GetCustomers());
        
        #endregion



    }
}
