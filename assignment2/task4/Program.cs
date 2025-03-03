namespace task4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] arr1 = { { 1, 2, 3 ,4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            int[,] arr2 = { { 2, 2, 3, 4 }, { 5, 1, 2, 3 }, { 9, 5, 1, 2 } };
            output(arr1);
            output(arr2);

        }
        public static bool judge(int[,] arr)
        {
            arr.GetLength(1);
            for(int i=0;i< arr.GetLength(0);i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (!equal(arr, i, j))
                        return false;
                }
            }
            return true;
        }
        public static bool equal(int[,] arr,int x,int y)
        {
            int num = arr[x, y];
            while(x<arr.GetLength(0)&&y < arr.GetLength(1))
            {
                if (arr[x, y] != num)
                    return false;
                x++;y++;
            }
            return true;
        }
        public static void output(int[,] arr)
        {
            if (judge(arr))
                Console.WriteLine("true");
            else
                Console.WriteLine("false");
        }
    }
}