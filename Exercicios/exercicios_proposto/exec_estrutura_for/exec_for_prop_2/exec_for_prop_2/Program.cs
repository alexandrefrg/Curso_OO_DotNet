using System;

namespace exec_for_prop_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int value_in = 0;
            int value_out = 0;

            int input_n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input_n; i++)
            {
                int input_value = int.Parse(Console.ReadLine());

                if (input_value >= 10 && input_value <= 20)
                    value_in++;
                else
                    value_out++;
            }

            Console.WriteLine($"{value_in} in");
            Console.WriteLine($"{value_out} out");
        }
    }
}
