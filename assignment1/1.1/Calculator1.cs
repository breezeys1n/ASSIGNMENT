namespace _1._1
{
    internal class Calculator1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数：");
            string str1= Console.ReadLine();
            Console.WriteLine("请输入第二个数：");
            string str2 = Console.ReadLine();
            Console.WriteLine("请输入运算符：");
            string op = Console.ReadLine();
            int flag = 1;
            double z=0;
            double x = double.Parse(str1);
            double y = double.Parse(str2);
            char Operator= op[0];
            switch(Operator)
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
            if(flag==0)
                Console.WriteLine("输入的运算符不符合规定");
            else
                Console.WriteLine($"{x}{Operator}{y}={z}");
        }
    }
}