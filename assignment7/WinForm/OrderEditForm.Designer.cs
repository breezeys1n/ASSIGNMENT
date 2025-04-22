using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    partial class OrderEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            lblOrderId = new Label();
            lblOrderDate = new Label();
            lblCustomerId = new Label();
            lblCustomerName = new Label();
            lblCustomerContact = new Label();
            lblOrderDetails = new Label();
            txtOrderId = new TextBox();
            dtpOrderDate = new DateTimePicker();
            txtCustomerId = new TextBox();
            txtCustomerName = new TextBox();
            txtCustomerContact = new TextBox();
            dgvOrderDetails = new DataGridView();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailsBindingSource = new BindingSource(components);
            btnAddDetail = new Button();
            btnEditDetail = new Button();
            btnRemoveDetail = new Button();
            btnSave = new Button();
            btnCancel = new Button();
            panelOrderInfo = new Panel();
            panelDetails = new Panel();
            panelDetailButtons = new Panel();
            panelFormButtons = new Panel();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).BeginInit();
            panelOrderInfo.SuspendLayout();
            panelDetails.SuspendLayout();
            panelDetailButtons.SuspendLayout();
            panelFormButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // lblOrderId
            // 
            lblOrderId.AutoSize = true;
            lblOrderId.Location = new Point(37, 37);
            lblOrderId.Margin = new Padding(6, 0, 6, 0);
            lblOrderId.Name = "lblOrderId";
            lblOrderId.Size = new Size(89, 24);
            lblOrderId.TabIndex = 0;
            lblOrderId.Text = "Order ID:";
            // 
            // lblOrderDate
            // 
            lblOrderDate.AutoSize = true;
            lblOrderDate.Location = new Point(37, 111);
            lblOrderDate.Margin = new Padding(6, 0, 6, 0);
            lblOrderDate.Name = "lblOrderDate";
            lblOrderDate.Size = new Size(111, 24);
            lblOrderDate.TabIndex = 2;
            lblOrderDate.Text = "Order Date:";
            // 
            // lblCustomerId
            // 
            lblCustomerId.AutoSize = true;
            lblCustomerId.Location = new Point(37, 185);
            lblCustomerId.Margin = new Padding(6, 0, 6, 0);
            lblCustomerId.Name = "lblCustomerId";
            lblCustomerId.Size = new Size(121, 24);
            lblCustomerId.TabIndex = 4;
            lblCustomerId.Text = "Customer ID:";
            // 
            // lblCustomerName
            // 
            lblCustomerName.AutoSize = true;
            lblCustomerName.Location = new Point(37, 258);
            lblCustomerName.Margin = new Padding(6, 0, 6, 0);
            lblCustomerName.Name = "lblCustomerName";
            lblCustomerName.Size = new Size(154, 24);
            lblCustomerName.TabIndex = 6;
            lblCustomerName.Text = "Customer Name:";
            // 
            // lblCustomerContact
            // 
            lblCustomerContact.AutoSize = true;
            lblCustomerContact.Location = new Point(37, 332);
            lblCustomerContact.Margin = new Padding(6, 0, 6, 0);
            lblCustomerContact.Name = "lblCustomerContact";
            lblCustomerContact.Size = new Size(169, 24);
            lblCustomerContact.TabIndex = 8;
            lblCustomerContact.Text = "Customer Contact:";
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.AutoSize = true;
            lblOrderDetails.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderDetails.Location = new Point(6, 0);
            lblOrderDetails.Margin = new Padding(6, 0, 6, 0);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Size = new Size(123, 20);
            lblOrderDetails.TabIndex = 0;
            lblOrderDetails.Text = "Order Details";
            // 
            // txtOrderId
            // 
            txtOrderId.Location = new Point(220, 31);
            txtOrderId.Margin = new Padding(6);
            txtOrderId.Name = "txtOrderId";
            txtOrderId.ReadOnly = true;
            txtOrderId.Size = new Size(363, 30);
            txtOrderId.TabIndex = 1;
            // 
            // dtpOrderDate
            // 
            dtpOrderDate.Format = DateTimePickerFormat.Short;
            dtpOrderDate.Location = new Point(220, 105);
            dtpOrderDate.Margin = new Padding(6);
            dtpOrderDate.Name = "dtpOrderDate";
            dtpOrderDate.Size = new Size(217, 30);
            dtpOrderDate.TabIndex = 3;
            // 
            // txtCustomerId
            // 
            txtCustomerId.Location = new Point(220, 179);
            txtCustomerId.Margin = new Padding(6);
            txtCustomerId.Name = "txtCustomerId";
            txtCustomerId.Size = new Size(363, 30);
            txtCustomerId.TabIndex = 5;
            // 
            // txtCustomerName
            // 
            txtCustomerName.Location = new Point(220, 253);
            txtCustomerName.Margin = new Padding(6);
            txtCustomerName.Name = "txtCustomerName";
            txtCustomerName.Size = new Size(363, 30);
            txtCustomerName.TabIndex = 7;
            // 
            // txtCustomerContact
            // 
            txtCustomerContact.Location = new Point(220, 327);
            txtCustomerContact.Margin = new Padding(6);
            txtCustomerContact.Name = "txtCustomerContact";
            txtCustomerContact.Size = new Size(363, 30);
            txtCustomerContact.TabIndex = 9;
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.AutoGenerateColumns = false;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Columns.AddRange(new DataGridViewColumn[] { quantityDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn });
            dgvOrderDetails.DataSource = detailsBindingSource;
            dgvOrderDetails.Dock = DockStyle.Fill;
            dgvOrderDetails.Location = new Point(0, 0);
            dgvOrderDetails.Margin = new Padding(6);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowHeadersWidth = 62;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new Size(917, 210);
            dgvOrderDetails.TabIndex = 10;
            dgvOrderDetails.CellContentClick += dgvOrderDetails_CellContentClick;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 8;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.MinimumWidth = 8;
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.ReadOnly = true;
            totalPriceDataGridViewTextBoxColumn.Width = 150;
            // 
            // productDataGridViewTextBoxColumn
            // 
            productDataGridViewTextBoxColumn.DataPropertyName = "Product";
            productDataGridViewTextBoxColumn.HeaderText = "Product";
            productDataGridViewTextBoxColumn.MinimumWidth = 8;
            productDataGridViewTextBoxColumn.Name = "productDataGridViewTextBoxColumn";
            productDataGridViewTextBoxColumn.ReadOnly = true;
            productDataGridViewTextBoxColumn.Width = 150;
            // 
            // detailsBindingSource
            // 
            detailsBindingSource.DataSource = typeof(order.OrderDetails);
            // 
            // btnAddDetail
            // 
            btnAddDetail.Location = new Point(18, 18);
            btnAddDetail.Margin = new Padding(6);
            btnAddDetail.Name = "btnAddDetail";
            btnAddDetail.Size = new Size(165, 55);
            btnAddDetail.TabIndex = 11;
            btnAddDetail.Text = "Add";
            btnAddDetail.UseVisualStyleBackColor = true;
            btnAddDetail.Click += btnAddDetail_Click;
            // 
            // btnEditDetail
            // 
            btnEditDetail.Location = new Point(202, 18);
            btnEditDetail.Margin = new Padding(6);
            btnEditDetail.Name = "btnEditDetail";
            btnEditDetail.Size = new Size(165, 55);
            btnEditDetail.TabIndex = 12;
            btnEditDetail.Text = "Edit";
            btnEditDetail.UseVisualStyleBackColor = true;
            btnEditDetail.Click += btnEditDetail_Click;
            // 
            // btnRemoveDetail
            // 
            btnRemoveDetail.Location = new Point(385, 18);
            btnRemoveDetail.Margin = new Padding(6);
            btnRemoveDetail.Name = "btnRemoveDetail";
            btnRemoveDetail.Size = new Size(165, 55);
            btnRemoveDetail.TabIndex = 13;
            btnRemoveDetail.Text = "Remove";
            btnRemoveDetail.UseVisualStyleBackColor = true;
            btnRemoveDetail.Click += btnRemoveDetail_Click;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(550, 18);
            btnSave.Margin = new Padding(6);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(165, 55);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(733, 18);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 55);
            btnCancel.TabIndex = 15;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panelOrderInfo
            // 
            panelOrderInfo.Controls.Add(lblOrderId);
            panelOrderInfo.Controls.Add(txtOrderId);
            panelOrderInfo.Controls.Add(lblOrderDate);
            panelOrderInfo.Controls.Add(dtpOrderDate);
            panelOrderInfo.Controls.Add(lblCustomerId);
            panelOrderInfo.Controls.Add(txtCustomerId);
            panelOrderInfo.Controls.Add(lblCustomerName);
            panelOrderInfo.Controls.Add(txtCustomerName);
            panelOrderInfo.Controls.Add(lblCustomerContact);
            panelOrderInfo.Controls.Add(txtCustomerContact);
            panelOrderInfo.Dock = DockStyle.Top;
            panelOrderInfo.Location = new Point(0, 0);
            panelOrderInfo.Margin = new Padding(6);
            panelOrderInfo.Name = "panelOrderInfo";
            panelOrderInfo.Padding = new Padding(37);
            panelOrderInfo.Size = new Size(917, 406);
            panelOrderInfo.TabIndex = 16;
            // 
            // panelDetails
            // 
            panelDetails.Controls.Add(dgvOrderDetails);
            panelDetails.Controls.Add(lblOrderDetails);
            panelDetails.Dock = DockStyle.Fill;
            panelDetails.Location = new Point(0, 406);
            panelDetails.Margin = new Padding(6);
            panelDetails.Name = "panelDetails";
            panelDetails.Padding = new Padding(0, 0, 0, 92);
            panelDetails.Size = new Size(917, 302);
            panelDetails.TabIndex = 17;
            // 
            // panelDetailButtons
            // 
            panelDetailButtons.Controls.Add(btnAddDetail);
            panelDetailButtons.Controls.Add(btnEditDetail);
            panelDetailButtons.Controls.Add(btnRemoveDetail);
            panelDetailButtons.Dock = DockStyle.Bottom;
            panelDetailButtons.Location = new Point(0, 708);
            panelDetailButtons.Margin = new Padding(6);
            panelDetailButtons.Name = "panelDetailButtons";
            panelDetailButtons.Size = new Size(917, 92);
            panelDetailButtons.TabIndex = 18;
            // 
            // panelFormButtons
            // 
            panelFormButtons.Controls.Add(btnSave);
            panelFormButtons.Controls.Add(btnCancel);
            panelFormButtons.Dock = DockStyle.Bottom;
            panelFormButtons.Location = new Point(0, 800);
            panelFormButtons.Margin = new Padding(6);
            panelFormButtons.Name = "panelFormButtons";
            panelFormButtons.Size = new Size(917, 92);
            panelFormButtons.TabIndex = 19;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // OrderEditForm
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(917, 892);
            Controls.Add(panelDetails);
            Controls.Add(panelDetailButtons);
            Controls.Add(panelOrderInfo);
            Controls.Add(panelFormButtons);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderEditForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Edit Order";
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).EndInit();
            panelOrderInfo.ResumeLayout(false);
            panelOrderInfo.PerformLayout();
            panelDetails.ResumeLayout(false);
            panelDetails.PerformLayout();
            panelDetailButtons.ResumeLayout(false);
            panelFormButtons.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtOrderId;
        private DateTimePicker dtpOrderDate;
        private TextBox txtCustomerId;
        private TextBox txtCustomerName;
        private TextBox txtCustomerContact;
        private DataGridView dgvOrderDetails;
        private Button btnAddDetail;
        private Button btnEditDetail;
        private Button btnRemoveDetail;
        private Button btnSave;
        private Button btnCancel;
        private Panel panelOrderInfo;
        private Panel panelDetails;
        private Panel panelDetailButtons;
        private Panel panelFormButtons;
        private ErrorProvider errorProvider;
        private BindingSource detailsBindingSource;
        private Label lblOrderId;
        private Label lblOrderDate;
        private Label lblCustomerId;
        private Label lblCustomerName;
        private Label lblCustomerContact;
        private Label lblOrderDetails;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
    }
}
