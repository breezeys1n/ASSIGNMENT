using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using order;
namespace WinForm
{
    public partial class MainForm : Form
    {

        private OrderService orderService = new OrderService();
        private BindingSource orderBindingSource = new BindingSource();
        private BindingSource detailBindingSource = new BindingSource();

        public MainForm()
        {
            InitializeComponent();
            SetupDataGridView();
            SetupBindings();
            LoadOrders();
        }

        private void SetupDataGridView()
        {
            // Configure the main DataGridView for orders
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderId",
                HeaderText = "Order ID",
                Width = 100
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Customer.Name",
                HeaderText = "Customer",
                Width = 150
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "OrderDate",
                HeaderText = "Date",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "yyyy-MM-dd" }
            });
            dgvOrders.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalAmount",
                HeaderText = "Total Amount",
                Width = 120,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });

            // Configure the details DataGridView
            dgvOrderDetails.AutoGenerateColumns = false;
            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Product.Name",
                HeaderText = "Product",
                Width = 150
            });
            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Product.Price",
                HeaderText = "Price",
                Width = 80,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "Quantity",
                HeaderText = "Qty",
                Width = 60
            });
            dgvOrderDetails.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "TotalPrice",
                HeaderText = "Total",
                Width = 90,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "C2" }
            });
        }

        private void SetupBindings()
        {
            orderBindingSource.DataSource = typeof(List<Order>);
            dgvOrderDetails.DataSource = orderBindingSource;

            detailBindingSource.DataSource = orderBindingSource;
            detailBindingSource.DataMember = "Details";
            dgvOrderDetails.DataSource = detailBindingSource;
        }

        private void LoadOrders()
        {
            orderBindingSource.DataSource = orderService.GetAllOrders();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var editForm = new OrderEditForm();
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    orderService.AddOrder(editForm.Order);
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error adding order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current == null)
            {
                MessageBox.Show("Please select an order to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var currentOrder = (Order)orderBindingSource.Current;
            var editForm = new OrderEditForm(currentOrder);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    orderService.UpdateOrder(editForm.Order);
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (orderBindingSource.Current == null)
            {
                MessageBox.Show("Please select an order to delete.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to delete this order?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    var order = (Order)orderBindingSource.Current;
                    orderService.RemoveOrder(order.OrderId);
                    LoadOrders();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error deleting order: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            var queryForm = new QueryForm();
            if (queryForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    List<Order> results = null;
                    switch (queryForm.QueryType)
                    {
                        case QueryType.OrderId:
                            results = orderService.QueryByOrderId(queryForm.QueryValue);
                            break;
                        case QueryType.CustomerName:
                            results = orderService.QueryByCustomer(queryForm.QueryValue);
                            break;
                        case QueryType.ProductName:
                            results = orderService.QueryByProductName(queryForm.QueryValue);
                            break;
                        case QueryType.AmountRange:
                            results = orderService.QueryByAmountRange(queryForm.MinAmount, queryForm.MaxAmount);
                            break;
                    }

                    orderBindingSource.DataSource = results;
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error querying orders: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadOrders();
        }

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }


    }
}
