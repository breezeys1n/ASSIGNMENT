namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool[] prime = new bool[101];
            prime[0] = false;
            prime[1] = false;
            for (int i=2;i<=100;i++)
            {
                prime[i] = true;
            }
            for (int i = 2; i <= 100; i++)
            {
                if(prime[i] == true)
                {
                    for (int j = 2*i; j <= 100; j+=i)
                    {
                        prime[j] = false;
                    }
                }
            }
            for(int i=0;i<=100;i++)
            {
                if (prime[i] == true)
                    Console.WriteLine(i);
            }
        }
    }
}