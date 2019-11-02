namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество элементов");
            int N = Convert.ToInt32(Console.ReadLine());
            int[] Nums = new int[N];
            for (int i = 0; i < Nums.Length;)
            {
                Console.WriteLine("Введите элемент " + (i + 1));
                Nums[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            int Num = 0;

            Console.WriteLine("Введите количество максимальных значений элементов");
            int M = Convert.ToInt32(Console.ReadLine());
            int[] MaxNums = new int[M + 1];
            MaxNums[0] = 2147483647;

            for (int i = 1; i < MaxNums.Length; i++)
            {
                for (int j = 0; j < Nums.Length; j++)
                {
                    if (Num < Nums[j] && Nums[j] < MaxNums[i - 1])
                    { Num = Nums[j]; }
                }
                MaxNums[i] = Num;
                Num = 0;
            }


            // не обязательно
            Console.WriteLine();
            for (int i = 1; i < MaxNums.Length; i++)
            {
                Console.WriteLine(MaxNums[i]);
            }
        }

    }
}
