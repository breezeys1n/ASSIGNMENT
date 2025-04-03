

namespace WinForm
{
    partial class MainForm
    {
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            dgvOrders = new DataGridView();
            orderIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalAmountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderBindingSource = new BindingSource(components);
            dgvOrderDetails = new DataGridView();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            detailsBindingSource = new BindingSource(components);
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            btnQuery = new Button();
            btnRefresh = new Button();
            splitContainer = new SplitContainer();
            lblOrders = new Label();
            lblOrderDetails = new Label();
            panelControls = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvOrders).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).BeginInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            panelControls.SuspendLayout();
            SuspendLayout();
            // 
            // dgvOrders
            // 
            dgvOrders.AllowUserToAddRows = false;
            dgvOrders.AllowUserToDeleteRows = false;
            dgvOrders.AutoGenerateColumns = false;
            dgvOrders.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Control;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvOrders.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvOrders.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrders.Columns.AddRange(new DataGridViewColumn[] { orderIdDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn, orderDateDataGridViewTextBoxColumn, totalAmountDataGridViewTextBoxColumn });
            dgvOrders.DataSource = orderBindingSource;
            dgvOrders.Dock = DockStyle.Fill;
            dgvOrders.Location = new Point(0, 74);
            dgvOrders.Margin = new Padding(6);
            dgvOrders.MultiSelect = false;
            dgvOrders.Name = "dgvOrders";
            dgvOrders.ReadOnly = true;
            dgvOrders.RowHeadersVisible = false;
            dgvOrders.RowHeadersWidth = 62;
            dgvOrders.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrders.Size = new Size(1437, 389);
            dgvOrders.TabIndex = 0;
            // 
            // orderIdDataGridViewTextBoxColumn
            // 
            orderIdDataGridViewTextBoxColumn.DataPropertyName = "OrderId";
            orderIdDataGridViewTextBoxColumn.HeaderText = "OrderId";
            orderIdDataGridViewTextBoxColumn.MinimumWidth = 8;
            orderIdDataGridViewTextBoxColumn.Name = "orderIdDataGridViewTextBoxColumn";
            orderIdDataGridViewTextBoxColumn.ReadOnly = true;
            orderIdDataGridViewTextBoxColumn.Width = 150;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "Customer";
            customerDataGridViewTextBoxColumn.MinimumWidth = 8;
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.ReadOnly = true;
            customerDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderDateDataGridViewTextBoxColumn
            // 
            orderDateDataGridViewTextBoxColumn.DataPropertyName = "OrderDate";
            orderDateDataGridViewTextBoxColumn.HeaderText = "OrderDate";
            orderDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            orderDateDataGridViewTextBoxColumn.Name = "orderDateDataGridViewTextBoxColumn";
            orderDateDataGridViewTextBoxColumn.ReadOnly = true;
            orderDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // totalAmountDataGridViewTextBoxColumn
            // 
            totalAmountDataGridViewTextBoxColumn.DataPropertyName = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.HeaderText = "TotalAmount";
            totalAmountDataGridViewTextBoxColumn.MinimumWidth = 8;
            totalAmountDataGridViewTextBoxColumn.Name = "totalAmountDataGridViewTextBoxColumn";
            totalAmountDataGridViewTextBoxColumn.ReadOnly = true;
            totalAmountDataGridViewTextBoxColumn.Width = 150;
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(order.Order);
            // 
            // dgvOrderDetails
            // 
            dgvOrderDetails.AllowUserToAddRows = false;
            dgvOrderDetails.AllowUserToDeleteRows = false;
            dgvOrderDetails.AutoGenerateColumns = false;
            dgvOrderDetails.BackgroundColor = SystemColors.Window;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgvOrderDetails.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvOrderDetails.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvOrderDetails.Columns.AddRange(new DataGridViewColumn[] { quantityDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, productDataGridViewTextBoxColumn });
            dgvOrderDetails.DataSource = detailsBindingSource;
            dgvOrderDetails.Dock = DockStyle.Fill;
            dgvOrderDetails.Location = new Point(0, 74);
            dgvOrderDetails.Margin = new Padding(6);
            dgvOrderDetails.Name = "dgvOrderDetails";
            dgvOrderDetails.ReadOnly = true;
            dgvOrderDetails.RowHeadersVisible = false;
            dgvOrderDetails.RowHeadersWidth = 62;
            dataGridViewCellStyle3.Format = "C2";
            dataGridViewCellStyle3.NullValue = null;
            dgvOrderDetails.RowsDefaultCellStyle = dataGridViewCellStyle3;
            dgvOrderDetails.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvOrderDetails.Size = new Size(1437, 370);
            dgvOrderDetails.TabIndex = 1;
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
            detailsBindingSource.DataMember = "Details";
            detailsBindingSource.DataSource = orderBindingSource;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.Location = new Point(887, 11);
            btnAdd.Margin = new Padding(6);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(165, 55);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEdit.Location = new Point(1063, 11);
            btnEdit.Margin = new Padding(6);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(165, 55);
            btnEdit.TabIndex = 3;
            btnEdit.Text = "Edit";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDelete.Location = new Point(1239, 11);
            btnDelete.Margin = new Padding(6);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(165, 55);
            btnDelete.TabIndex = 4;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnQuery
            // 
            btnQuery.Location = new Point(22, 11);
            btnQuery.Margin = new Padding(6);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(165, 55);
            btnQuery.TabIndex = 5;
            btnQuery.Text = "Query";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // btnRefresh
            // 
            btnRefresh.Location = new Point(198, 11);
            btnRefresh.Margin = new Padding(6);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(165, 55);
            btnRefresh.TabIndex = 6;
            btnRefresh.Text = "Refresh";
            btnRefresh.UseVisualStyleBackColor = true;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(0, 85);
            splitContainer.Margin = new Padding(6);
            splitContainer.Name = "splitContainer";
            splitContainer.Orientation = Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(dgvOrders);
            splitContainer.Panel1.Controls.Add(lblOrders);
            splitContainer.Panel1.Padding = new Padding(0, 37, 0, 0);
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(dgvOrderDetails);
            splitContainer.Panel2.Controls.Add(lblOrderDetails);
            splitContainer.Panel2.Padding = new Padding(0, 37, 0, 0);
            splitContainer.Size = new Size(1437, 914);
            splitContainer.SplitterDistance = 463;
            splitContainer.SplitterWidth = 7;
            splitContainer.TabIndex = 7;
            // 
            // lblOrders
            // 
            lblOrders.BackColor = SystemColors.Control;
            lblOrders.Dock = DockStyle.Top;
            lblOrders.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrders.Location = new Point(0, 37);
            lblOrders.Margin = new Padding(6, 0, 6, 0);
            lblOrders.Name = "lblOrders";
            lblOrders.Padding = new Padding(9, 0, 0, 0);
            lblOrders.Size = new Size(1437, 37);
            lblOrders.TabIndex = 2;
            lblOrders.Text = "Orders";
            lblOrders.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblOrderDetails
            // 
            lblOrderDetails.BackColor = SystemColors.Control;
            lblOrderDetails.Dock = DockStyle.Top;
            lblOrderDetails.Font = new Font("Microsoft Sans Serif", 8.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblOrderDetails.Location = new Point(0, 37);
            lblOrderDetails.Margin = new Padding(6, 0, 6, 0);
            lblOrderDetails.Name = "lblOrderDetails";
            lblOrderDetails.Padding = new Padding(9, 0, 0, 0);
            lblOrderDetails.Size = new Size(1437, 37);
            lblOrderDetails.TabIndex = 3;
            lblOrderDetails.Text = "Order Details";
            lblOrderDetails.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelControls
            // 
            panelControls.Controls.Add(btnQuery);
            panelControls.Controls.Add(btnRefresh);
            panelControls.Controls.Add(btnAdd);
            panelControls.Controls.Add(btnEdit);
            panelControls.Controls.Add(btnDelete);
            panelControls.Dock = DockStyle.Top;
            panelControls.Location = new Point(0, 0);
            panelControls.Margin = new Padding(6);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(1437, 85);
            panelControls.TabIndex = 8;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1437, 999);
            Controls.Add(splitContainer);
            Controls.Add(panelControls);
            Margin = new Padding(6);
            MinimumSize = new Size(1448, 1023);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Order Management System";
            ((System.ComponentModel.ISupportInitialize)dgvOrders).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvOrderDetails).EndInit();
            ((System.ComponentModel.ISupportInitialize)detailsBindingSource).EndInit();
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            panelControls.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvOrders;
        private DataGridView dgvOrderDetails;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Button btnQuery;
        private Button btnRefresh;
        private SplitContainer splitContainer;
        private Panel panelControls;
        private Label lblOrders;
        private Label lblOrderDetails;
        //private System.Windows.Forms.BindingSource orderBindingSource;
        private BindingSource detailsBindingSource;
        private DataGridViewTextBoxColumn orderIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalAmountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productDataGridViewTextBoxColumn;
    }
}