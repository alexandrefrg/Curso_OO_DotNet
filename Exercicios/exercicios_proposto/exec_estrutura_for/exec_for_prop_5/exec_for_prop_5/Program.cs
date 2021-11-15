using System;

namespace exec_for_prop_5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());
            int fat = 1;

            for (int i = 1; i <= input; i++)
            {
                fat *= i;
            }

            Console.WriteLine(fat);
        }
    }
}
