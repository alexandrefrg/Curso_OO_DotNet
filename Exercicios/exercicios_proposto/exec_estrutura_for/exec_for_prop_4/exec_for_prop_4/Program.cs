using System;

namespace exec_for_prop_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                int value_1 = int.Parse(values[0]);
                int value_2 = int.Parse(values[1]);

                if (value_2 == 0.0)
                    Console.WriteLine("divisao impossivel");
                else
                    Console.WriteLine($"{(double)value_1 / value_2:F1}");
            }
        }
    }
}
