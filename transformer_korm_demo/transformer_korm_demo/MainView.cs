﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace transformer_korm_demo
{
    public partial class MainView : Form
    {
        private MainViewModel _viewModel;

        public MainView(MainViewModel mainViewModel)
        {
            InitializeComponent();
            _viewModel = mainViewModel;
        }

        private void btn_loadCustomers_Click(object sender, EventArgs e)
        {
            _viewModel.LoadCustomers();
            dgv_mainGridView.DataSource = _viewModel.Customers;
        }

        private void btn_LoadOrders_Click(object sender, EventArgs e)
        {
            _viewModel.LoadOrders();
            dgv_mainGridView.DataSource = _viewModel.Orders;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            _viewModel.SaveCustomers();
            dgv_mainGridView.DataSource = _viewModel.Orders;
        }
    }
}
