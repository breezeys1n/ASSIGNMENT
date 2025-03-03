namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] stringNumbers = input.Split(' ');
            int[] arr = new int[stringNumbers.Length];
            for(int i=0;i< stringNumbers.Length;i++)
            {
                arr[i] = int.Parse(stringNumbers[i]);
            }
            Console.WriteLine(Mymath.sum(arr));
            Console.WriteLine(Mymath.average(arr));
            Console.WriteLine(Mymath.max(arr));
            Console.WriteLine(Mymath.min(arr));
        }
    }
    class Mymath
    {
        public static int sum(int[]arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
        public static int average(int[] arr)
        {
            return sum(arr)/arr.Length;
        }
        public static int max(int[] arr)
        {
            int max = -999999;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                    max = arr[i];
            }
            return max;
        }
        public static int min(int[] arr)
        {
            int min = 999999;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i]<min)
                    min = arr[i];
            }
            return min;
        }
    }
}