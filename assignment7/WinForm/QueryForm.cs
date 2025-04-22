using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using order;
namespace WinForm
{
    public enum QueryType
    {
        OrderId,
        CustomerName,
        ProductName,
        AmountRange
    }

    public partial class QueryForm : Form
    {
        public QueryType QueryType { get; private set; }
        public string QueryValue { get; private set; }
        public decimal MinAmount { get; private set; }
        public decimal MaxAmount { get; private set; }

        public QueryForm()
        {
            InitializeComponent();
            SetQueryUI(QueryType.OrderId);
        }

        private void rbOrderId_CheckedChanged(object sender, EventArgs e)
        {
            if (rbOrderId.Checked) SetQueryUI(QueryType.OrderId);
        }

        private void rbCustomerName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCustomerName.Checked) SetQueryUI(QueryType.CustomerName);
        }

        private void rbProductName_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProductName.Checked) SetQueryUI(QueryType.ProductName);
        }

        private void rbAmountRange_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAmountRange.Checked) SetQueryUI(QueryType.AmountRange);
        }

        private void SetQueryUI(QueryType queryType)
        {
            txtQueryValue.Visible = queryType != QueryType.AmountRange;
            numMinAmount.Visible = queryType == QueryType.AmountRange;
            numMaxAmount.Visible = queryType == QueryType.AmountRange;
            lblTo.Visible = queryType == QueryType.AmountRange;

            txtQueryValue.Text = "";
            numMinAmount.Value = 0;
            numMaxAmount.Value = 1000;
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (rbOrderId.Checked)
            {
                QueryType = QueryType.OrderId;
                QueryValue = txtQueryValue.Text;
            }
            else if (rbCustomerName.Checked)
            {
                QueryType = QueryType.CustomerName;
                QueryValue = txtQueryValue.Text;
            }
            else if (rbProductName.Checked)
            {
                QueryType = QueryType.ProductName;
                QueryValue = txtQueryValue.Text;
            }
            else if (rbAmountRange.Checked)
            {
                QueryType = QueryType.AmountRange;
                MinAmount = numMinAmount.Value;
                MaxAmount = numMaxAmount.Value;

                if (MinAmount > MaxAmount)
                {
                    MessageBox.Show("Minimum amount cannot be greater than maximum amount.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
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
