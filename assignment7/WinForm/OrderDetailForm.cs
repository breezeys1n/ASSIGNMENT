using order;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    public partial class OrderDetailForm : Form
    {
        public OrderDetails OrderDetail { get; private set; }

        public OrderDetailForm()
        {
            InitializeComponent();
            OrderDetail = new OrderDetails
            {
                Product = new Product(),
                Quantity = 1
            };
            SetupBindings();
        }

        public OrderDetailForm(OrderDetails detailToEdit)
        {
            InitializeComponent();
            OrderDetail = new OrderDetails
            {
                Product = new Product
                {
                    ProductId = detailToEdit.Product.ProductId,
                    Name = detailToEdit.Product.Name,
                    Price = detailToEdit.Product.Price
                },
                Quantity = detailToEdit.Quantity
            };
            SetupBindings();
        }

        private void SetupBindings()
        {
            txtProductId.DataBindings.Add("Text", OrderDetail.Product, "ProductId");
            txtProductName.DataBindings.Add("Text", OrderDetail.Product, "Name");
            numPrice.DataBindings.Add("Value", OrderDetail.Product, "Price");
            numQuantity.DataBindings.Add("Value", OrderDetail, "Quantity");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(OrderDetail.Product.Name))
            {
                MessageBox.Show("Product name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (OrderDetail.Quantity <= 0)
            {
                MessageBox.Show("Quantity must be greater than zero.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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


    }
}
