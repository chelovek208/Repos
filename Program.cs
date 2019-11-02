using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int First, Second;
            int[] Array = new int[5];

            for (int i = 0; i < Array.Length;)
            {
                Array[i] = Convert.ToInt32(Console.ReadLine());
                i++;
            }
            First = Array[0];
            Second = -2147483648;
            for (int i = 0; i < Array.Length;)
            {
                if (First < Array[i])
                {
                    Second = First;
                    First = Array[i];
                }
                i++;
            }
            Console.WriteLine("First - " + First + " Second - " + Second);
        }

    }
}
