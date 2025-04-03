using order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public partial class OrderEditForm : Form
    {
        public Order Order { get; private set; }
        private bool isNewOrder;

        public OrderEditForm()
        {
            InitializeComponent();
            isNewOrder = true;
            Order = new Order
            {
                OrderId = GenerateOrderId(),
                OrderDate = DateTime.Now,
                Customer = new Customer(),
                Details = new List<OrderDetails>()
            };
            SetupBindings();
        }

        public OrderEditForm(Order orderToEdit)
        {
            InitializeComponent();
            isNewOrder = false;
            Order = new Order
            {
                OrderId = orderToEdit.OrderId,
                OrderDate = orderToEdit.OrderDate,
                Customer = new Customer
                {
                    CustomerId = orderToEdit.Customer.CustomerId,
                    Name = orderToEdit.Customer.Name,
                    ContactInfo = orderToEdit.Customer.ContactInfo
                },
                Details = new List<OrderDetails>(orderToEdit.Details.Select(d => new OrderDetails
                {
                    Product = new Product
                    {
                        ProductId = d.Product.ProductId,
                        Name = d.Product.Name,
                        Price = d.Product.Price
                    },
                    Quantity = d.Quantity
                }))
            };
            SetupBindings();
        }

        private string GenerateOrderId()
        {
            return "ORD" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void SetupBindings()
        {
            txtOrderId.DataBindings.Add("Text", Order, "OrderId");
            dtpOrderDate.DataBindings.Add("Value", Order, "OrderDate");

            txtCustomerId.DataBindings.Add("Text", Order.Customer, "CustomerId");
            txtCustomerName.DataBindings.Add("Text", Order.Customer, "Name");
            txtCustomerContact.DataBindings.Add("Text", Order.Customer, "ContactInfo");

            detailsBindingSource.DataSource = Order.Details;
            dgvOrderDetails.DataSource = detailsBindingSource;
        }

        private void btnAddDetail_Click(object sender, EventArgs e)
        {
            var detailForm = new OrderDetailForm();
            if (detailForm.ShowDialog() == DialogResult.OK)
            {
                Order.Details.Add(detailForm.OrderDetail);
                detailsBindingSource.ResetBindings(false);
            }
        }

        private void btnEditDetail_Click(object sender, EventArgs e)
        {
            if (detailsBindingSource.Current == null)
            {
                MessageBox.Show("Please select a detail to edit.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var currentDetail = (OrderDetails)detailsBindingSource.Current;
            var detailForm = new OrderDetailForm(currentDetail);
            if (detailForm.ShowDialog() == DialogResult.OK)
            {
                var index = Order.Details.IndexOf(currentDetail);
                Order.Details[index] = detailForm.OrderDetail;
                detailsBindingSource.ResetBindings(false);
            }
        }

        private void btnRemoveDetail_Click(object sender, EventArgs e)
        {
            if (detailsBindingSource.Current == null)
            {
                MessageBox.Show("Please select a detail to remove.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (MessageBox.Show("Are you sure you want to remove this detail?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                var currentDetail = (OrderDetails)detailsBindingSource.Current;
                Order.Details.Remove(currentDetail);
                detailsBindingSource.ResetBindings(false);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Order.Details.Count == 0)
            {
                MessageBox.Show("Please add at least one order detail.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(Order.Customer.Name))
            {
                MessageBox.Show("Customer name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void dgvOrderDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        
    }
}
