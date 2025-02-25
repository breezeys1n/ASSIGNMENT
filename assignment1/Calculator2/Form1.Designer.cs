namespace Calculator2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            textBox3 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(87, 44);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(479, 23);
            textBox1.TabIndex = 0;
            textBox1.Text = "请在此输入第一个数";
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(87, 104);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(479, 23);
            textBox2.TabIndex = 1;
            textBox2.Text = "请在此输入第二个数";
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.Location = new Point(618, 278);
            button1.Name = "button1";
            button1.Size = new Size(118, 45);
            button1.TabIndex = 2;
            button1.Text = "确定";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(87, 175);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(98, 23);
            textBox3.TabIndex = 3;
            textBox3.Text = "请输入运算符";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // button2
            // 
            button2.Location = new Point(87, 278);
            button2.Name = "button2";
            button2.Size = new Size(167, 23);
            button2.TabIndex = 5;
            button2.Text = "结果：";
            button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private TextBox textBox3;
        private Button button2;
    }
}