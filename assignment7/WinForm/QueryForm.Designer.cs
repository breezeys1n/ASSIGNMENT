using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm
{
    partial class QueryForm
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
            grpQueryType = new GroupBox();
            rbAmountRange = new RadioButton();
            rbProductName = new RadioButton();
            rbCustomerName = new RadioButton();
            rbOrderId = new RadioButton();
            txtQueryValue = new TextBox();
            lblQueryValue = new Label();
            numMinAmount = new NumericUpDown();
            numMaxAmount = new NumericUpDown();
            lblTo = new Label();
            btnQuery = new Button();
            btnCancel = new Button();
            panelQueryValue = new Panel();
            panelAmountRange = new Panel();
            panelButtons = new Panel();
            grpQueryType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numMinAmount).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numMaxAmount).BeginInit();
            panelQueryValue.SuspendLayout();
            panelAmountRange.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // grpQueryType
            // 
            grpQueryType.Controls.Add(rbAmountRange);
            grpQueryType.Controls.Add(rbProductName);
            grpQueryType.Controls.Add(rbCustomerName);
            grpQueryType.Controls.Add(rbOrderId);
            grpQueryType.Dock = DockStyle.Top;
            grpQueryType.Location = new Point(0, 0);
            grpQueryType.Margin = new Padding(6);
            grpQueryType.Name = "grpQueryType";
            grpQueryType.Padding = new Padding(6);
            grpQueryType.Size = new Size(733, 222);
            grpQueryType.TabIndex = 0;
            grpQueryType.TabStop = false;
            grpQueryType.Text = "Query By";
            // 
            // rbAmountRange
            // 
            rbAmountRange.AutoSize = true;
            rbAmountRange.Location = new Point(37, 166);
            rbAmountRange.Margin = new Padding(6);
            rbAmountRange.Name = "rbAmountRange";
            rbAmountRange.Size = new Size(165, 28);
            rbAmountRange.TabIndex = 3;
            rbAmountRange.TabStop = true;
            rbAmountRange.Text = "Amount Range";
            rbAmountRange.UseVisualStyleBackColor = true;
            rbAmountRange.CheckedChanged += rbAmountRange_CheckedChanged;
            // 
            // rbProductName
            // 
            rbProductName.AutoSize = true;
            rbProductName.Location = new Point(37, 120);
            rbProductName.Margin = new Padding(6);
            rbProductName.Name = "rbProductName";
            rbProductName.Size = new Size(160, 28);
            rbProductName.TabIndex = 2;
            rbProductName.TabStop = true;
            rbProductName.Text = "Product Name";
            rbProductName.UseVisualStyleBackColor = true;
            rbProductName.CheckedChanged += rbProductName_CheckedChanged;
            // 
            // rbCustomerName
            // 
            rbCustomerName.AutoSize = true;
            rbCustomerName.Location = new Point(37, 74);
            rbCustomerName.Margin = new Padding(6);
            rbCustomerName.Name = "rbCustomerName";
            rbCustomerName.Size = new Size(175, 28);
            rbCustomerName.TabIndex = 1;
            rbCustomerName.TabStop = true;
            rbCustomerName.Text = "Customer Name";
            rbCustomerName.UseVisualStyleBackColor = true;
            rbCustomerName.CheckedChanged += rbCustomerName_CheckedChanged;
            // 
            // rbOrderId
            // 
            rbOrderId.AutoSize = true;
            rbOrderId.Checked = true;
            rbOrderId.Location = new Point(37, 28);
            rbOrderId.Margin = new Padding(6);
            rbOrderId.Name = "rbOrderId";
            rbOrderId.Size = new Size(110, 28);
            rbOrderId.TabIndex = 0;
            rbOrderId.TabStop = true;
            rbOrderId.Text = "Order ID";
            rbOrderId.UseVisualStyleBackColor = true;
            rbOrderId.CheckedChanged += rbOrderId_CheckedChanged;
            // 
            // txtQueryValue
            // 
            txtQueryValue.Dock = DockStyle.Fill;
            txtQueryValue.Location = new Point(128, 18);
            txtQueryValue.Margin = new Padding(6);
            txtQueryValue.Name = "txtQueryValue";
            txtQueryValue.Size = new Size(605, 30);
            txtQueryValue.TabIndex = 1;
            // 
            // lblQueryValue
            // 
            lblQueryValue.Dock = DockStyle.Left;
            lblQueryValue.Location = new Point(0, 18);
            lblQueryValue.Margin = new Padding(6, 0, 6, 0);
            lblQueryValue.Name = "lblQueryValue";
            lblQueryValue.Size = new Size(128, 38);
            lblQueryValue.TabIndex = 0;
            lblQueryValue.Text = "Order ID:";
            lblQueryValue.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // numMinAmount
            // 
            numMinAmount.DecimalPlaces = 2;
            numMinAmount.Dock = DockStyle.Left;
            numMinAmount.Location = new Point(0, 18);
            numMinAmount.Margin = new Padding(6);
            numMinAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMinAmount.Name = "numMinAmount";
            numMinAmount.Size = new Size(220, 30);
            numMinAmount.TabIndex = 2;
            numMinAmount.TextAlign = HorizontalAlignment.Right;
            numMinAmount.ThousandsSeparator = true;
            // 
            // numMaxAmount
            // 
            numMaxAmount.DecimalPlaces = 2;
            numMaxAmount.Dock = DockStyle.Right;
            numMaxAmount.Location = new Point(513, 18);
            numMaxAmount.Margin = new Padding(6);
            numMaxAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numMaxAmount.Name = "numMaxAmount";
            numMaxAmount.Size = new Size(220, 30);
            numMaxAmount.TabIndex = 4;
            numMaxAmount.TextAlign = HorizontalAlignment.Right;
            numMaxAmount.ThousandsSeparator = true;
            numMaxAmount.Value = new decimal(new int[] { 1000, 0, 0, 0 });
            // 
            // lblTo
            // 
            lblTo.Dock = DockStyle.Fill;
            lblTo.Location = new Point(220, 18);
            lblTo.Margin = new Padding(6, 0, 6, 0);
            lblTo.Name = "lblTo";
            lblTo.Size = new Size(513, 38);
            lblTo.TabIndex = 3;
            lblTo.Text = "to";
            lblTo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnQuery
            // 
            btnQuery.DialogResult = DialogResult.OK;
            btnQuery.Location = new Point(367, 18);
            btnQuery.Margin = new Padding(6);
            btnQuery.Name = "btnQuery";
            btnQuery.Size = new Size(165, 55);
            btnQuery.TabIndex = 5;
            btnQuery.Text = "Query";
            btnQuery.UseVisualStyleBackColor = true;
            btnQuery.Click += btnQuery_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(550, 18);
            btnCancel.Margin = new Padding(6);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 55);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // panelQueryValue
            // 
            panelQueryValue.Controls.Add(txtQueryValue);
            panelQueryValue.Controls.Add(lblQueryValue);
            panelQueryValue.Dock = DockStyle.Top;
            panelQueryValue.Location = new Point(0, 222);
            panelQueryValue.Margin = new Padding(6);
            panelQueryValue.Name = "panelQueryValue";
            panelQueryValue.Padding = new Padding(0, 18, 0, 18);
            panelQueryValue.Size = new Size(733, 74);
            panelQueryValue.TabIndex = 1;
            // 
            // panelAmountRange
            // 
            panelAmountRange.Controls.Add(numMaxAmount);
            panelAmountRange.Controls.Add(lblTo);
            panelAmountRange.Controls.Add(numMinAmount);
            panelAmountRange.Dock = DockStyle.Top;
            panelAmountRange.Location = new Point(0, 296);
            panelAmountRange.Margin = new Padding(6);
            panelAmountRange.Name = "panelAmountRange";
            panelAmountRange.Padding = new Padding(0, 18, 0, 18);
            panelAmountRange.Size = new Size(733, 74);
            panelAmountRange.TabIndex = 2;
            panelAmountRange.Visible = false;
            // 
            // panelButtons
            // 
            panelButtons.Controls.Add(btnQuery);
            panelButtons.Controls.Add(btnCancel);
            panelButtons.Dock = DockStyle.Bottom;
            panelButtons.Location = new Point(0, 388);
            panelButtons.Margin = new Padding(6);
            panelButtons.Name = "panelButtons";
            panelButtons.Size = new Size(733, 92);
            panelButtons.TabIndex = 3;
            // 
            // QueryForm
            // 
            AcceptButton = btnQuery;
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(733, 480);
            Controls.Add(panelAmountRange);
            Controls.Add(panelQueryValue);
            Controls.Add(grpQueryType);
            Controls.Add(panelButtons);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "QueryForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Query Orders";
            grpQueryType.ResumeLayout(false);
            grpQueryType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numMinAmount).EndInit();
            ((System.ComponentModel.ISupportInitialize)numMaxAmount).EndInit();
            panelQueryValue.ResumeLayout(false);
            panelQueryValue.PerformLayout();
            panelAmountRange.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox grpQueryType;
        private RadioButton rbAmountRange;
        private RadioButton rbProductName;
        private RadioButton rbCustomerName;
        private RadioButton rbOrderId;
        private TextBox txtQueryValue;
        private Label lblQueryValue;
        private NumericUpDown numMinAmount;
        private NumericUpDown numMaxAmount;
        private Label lblTo;
        private Button btnQuery;
        private Button btnCancel;
        private Panel panelQueryValue;
        private Panel panelAmountRange;
        private Panel panelButtons;
    }
}
