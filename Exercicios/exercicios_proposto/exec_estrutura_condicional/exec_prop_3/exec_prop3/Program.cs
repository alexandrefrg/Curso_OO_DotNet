using System;

namespace exec_prop_3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int input_a, input_b;

            string[] input = Console.ReadLine().Split(' ');

            input_a = int.Parse(input[0]);
            input_b = int.Parse(input[1]);

            if (input_a % input_b == 0 || input_b % input_a == 0)
                Console.WriteLine("São Multiplus");
            else
                Console.WriteLine("Nao sao Multiplus");
        }
    }
}
