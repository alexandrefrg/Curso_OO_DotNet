using System;

namespace exec_for_prop_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                Console.WriteLine($"{i} {i*i} {i*i*i}");
            }
        }
    }
}
