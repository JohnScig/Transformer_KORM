using System;
using System.Collections.Generic;
using System.ComponentModel;


namespace transformer_korm_demo
{
    public class MainViewModel
    {
        #region private fields
        private CustomerRepository _customerRepository;
        private OrderRepository _orderRepository;
        #endregion


        #region constructors
        public MainViewModel(CustomerRepository customerRepository, OrderRepository orderRepository)
        {
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
        }

        #endregion



        #region public properties and methods
        public BindingList<CustomerDTO> Customers { get; set; }
        public BindingList<OrderDTO> Orders { get; set; }


        public void LoadCustomers()
            => Customers = new BindingList<CustomerDTO>((List<CustomerDTO>) _customerRepository.GetCustomers());

        internal void LoadOrders()
            => Orders = new BindingList<OrderDTO>((List <OrderDTO>) _orderRepository.GetOrders());


        #endregion



    }
}
