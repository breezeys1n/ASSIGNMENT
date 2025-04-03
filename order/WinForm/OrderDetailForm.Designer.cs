using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using order;

namespace WinForm
{
    partial class OrderDetailForm
    {
        private Button btnSave;
        private Button btnCancel;


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
            btnSave = new Button();
            btnCancel = new Button();
            lblProductId = new Label();
            lblProductName = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            txtProductId = new TextBox();
            txtProductName = new TextBox();
            numPrice = new NumericUpDown();
            numQuantity = new NumericUpDown();
            errorProvider = new ErrorProvider(components);
            panelMain = new Panel();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            panelMain.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Bottom;
            btnSave.Location = new Point(0, 363);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(678, 49);
            btnSave.TabIndex = 0;
            btnSave.Text = "Save";
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Bottom;
            btnCancel.Location = new Point(0, 412);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(678, 50);
            btnCancel.TabIndex = 1;
            btnCancel.Text = "Cancel";
            btnCancel.Click += btnCancel_Click;
            // 
            // lblProductId
            // 
            lblProductId.AutoSize = true;
            lblProductId.Location = new Point(73, 74);
            lblProductId.Margin = new Padding(6, 0, 6, 0);
            lblProductId.Name = "lblProductId";
            lblProductId.Size = new Size(106, 24);
            lblProductId.TabIndex = 0;
            lblProductId.Text = "Product ID:";
            // 
            // lblProductName
            // 
            lblProductName.AutoSize = true;
            lblProductName.Location = new Point(73, 148);
            lblProductName.Margin = new Padding(6, 0, 6, 0);
            lblProductName.Name = "lblProductName";
            lblProductName.Size = new Size(139, 24);
            lblProductName.TabIndex = 2;
            lblProductName.Text = "Product Name:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(73, 222);
            lblPrice.Margin = new Padding(6, 0, 6, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(56, 24);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Price:";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(73, 295);
            lblQuantity.Margin = new Padding(6, 0, 6, 0);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(90, 24);
            lblQuantity.TabIndex = 6;
            lblQuantity.Text = "Quantity:";
            // 
            // txtProductId
            // 
            txtProductId.Location = new Point(220, 74);
            txtProductId.Margin = new Padding(6);
            txtProductId.Name = "txtProductId";
            txtProductId.Size = new Size(363, 30);
            txtProductId.TabIndex = 1;
            // 
            // txtProductName
            // 
            txtProductName.Location = new Point(220, 148);
            txtProductName.Margin = new Padding(6);
            txtProductName.Name = "txtProductName";
            txtProductName.Size = new Size(363, 30);
            txtProductName.TabIndex = 3;
            // 
            // numPrice
            // 
            numPrice.DecimalPlaces = 2;
            numPrice.Location = new Point(220, 222);
            numPrice.Margin = new Padding(6);
            numPrice.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(220, 30);
            numPrice.TabIndex = 5;
            numPrice.TextAlign = HorizontalAlignment.Right;
            // 
            // numQuantity
            // 
            numQuantity.Location = new Point(220, 297);
            numQuantity.Margin = new Padding(6);
            numQuantity.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numQuantity.Name = "numQuantity";
            numQuantity.Size = new Size(220, 30);
            numQuantity.TabIndex = 7;
            numQuantity.TextAlign = HorizontalAlignment.Right;
            numQuantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // panelMain
            // 
            panelMain.Controls.Add(lblProductId);
            panelMain.Controls.Add(txtProductId);
            panelMain.Controls.Add(lblProductName);
            panelMain.Controls.Add(txtProductName);
            panelMain.Controls.Add(lblPrice);
            panelMain.Controls.Add(numPrice);
            panelMain.Controls.Add(lblQuantity);
            panelMain.Controls.Add(numQuantity);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Margin = new Padding(6);
            panelMain.Name = "panelMain";
            panelMain.Padding = new Padding(37);
            panelMain.Size = new Size(678, 462);
            panelMain.TabIndex = 10;
            // 
            // OrderDetailForm
            // 
            AutoScaleDimensions = new SizeF(11F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(678, 462);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "OrderDetailForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Order Detail";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)numQuantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            panelMain.ResumeLayout(false);
            panelMain.PerformLayout();
            ResumeLayout(false);
        }


        #endregion

        private TextBox txtProductId;
        private TextBox txtProductName;
        private NumericUpDown numPrice;
        private NumericUpDown numQuantity;
        private ErrorProvider errorProvider;
        private Panel panelMain;
        private Label lblProductId;
        private Label lblProductName;
        private Label lblPrice;
        private Label lblQuantity;
    }
}
