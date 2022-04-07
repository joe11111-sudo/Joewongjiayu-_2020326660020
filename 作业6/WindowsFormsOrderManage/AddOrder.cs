﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsOrderManage
{
    public partial class AddOrder : Form
    {
        public Order NewOrder { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }

        public AddOrder()
        {
            InitializeComponent();
        }

        private void AddOrder_Load(object sender, EventArgs e)
        {
            NewOrder = new Order();
            CustomerName = "";
            Address = "";
            txtCustomerName.DataBindings.Add("Text", this, "CustomerName");
            txtAddress.DataBindings.Add("Text", this, "Address");
            itemBindingSource.DataSource = NewOrder.OrderItemList;
        }

        private void dgvOrderItem_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("无效的数据格式！","ERROR");
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(CustomerName == "")
            {
                MessageBox.Show("客户名不能为空！");
                return;
            }

            if(Address == "")
            {
                MessageBox.Show("配送地址不能为空！");
                return;
            }
            NewOrder.CustomerName = CustomerName;
            NewOrder.Address = Address;

            foreach(OrderItem item in NewOrder.OrderItemList)
            {
                NewOrder.TotalPrice += item.ProductPrice * item.ProductAmount;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
