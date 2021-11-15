using System;

namespace exec_for_prop_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input; i++)
            {
                string[] values = Console.ReadLine().Split(' ');

                double value_1 = double.Parse(values[0]);
                double value_2 = double.Parse(values[1]);
                double value_3 = double.Parse(values[2]);

                double average = (value_1 * 2.0 + value_2 * 3.0 + value_3 * 5.0) / 10.0;

                Console.WriteLine(average.ToString("F1"));
            }
        }
    }
}
