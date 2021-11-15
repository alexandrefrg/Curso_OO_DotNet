using System;

namespace exec_for_prop_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                if (input % i == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
