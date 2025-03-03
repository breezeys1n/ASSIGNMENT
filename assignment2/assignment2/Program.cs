using Microsoft.VisualBasic;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num=int.Parse(Console.ReadLine());
            for(int i=2;i<num;i++)
            {
                if (num % i == 0 && Mymath.Prime(i))
                    Console.WriteLine(i);
            }
        }
    }
    class Mymath
    {
        public static bool Prime(int n)
        {
            for(int i=2;i<n;i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}