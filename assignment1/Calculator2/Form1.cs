using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string num1 = textBox1.Text;
            string num2 = textBox2.Text;
            string op = textBox3.Text;
            int flag = 1;
            double z = 0;
            double x = double.Parse(num1);
            double y = double.Parse(num2);
            char Operator = op[0];
            switch (Operator)
            {
                case '+':
                    z = x + y;
                    break;
                case '-':
                    z = x - y;
                    break;
                case '/':
                    z = x / y;
                    break;
                case '*':
                    z = x * y;
                    break;
                default:
                    flag = 0;
                    break;
            }
            string str = z.ToString("F2");
            if (flag == 0)
                button2.Text = "输入的运算符不符合规定";
            else
                button2.Text = "结果：" + str;
        }
    }
}