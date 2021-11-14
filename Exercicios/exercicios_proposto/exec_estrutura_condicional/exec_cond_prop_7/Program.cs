using System;

namespace exec_cond_prop_7
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            double input_x = double.Parse(input[0]);
            double input_y = double.Parse(input[1]);

            if (input_x == 0.0 && input_y == 0.0)
                Console.WriteLine("Origem");
            else if (input_y == 0.0)
                Console.WriteLine("Eixo X");
            else if (input_x == 0.0)
                Console.WriteLine("Eixo Y");
            else if (input_x > 0.0 && input_y > 0.0)
                Console.WriteLine("Q1");
            else if (input_x < 0.0 && input_y > 0.0)
                Console.WriteLine("Q2");
            else if (input_x < 0.0 && input_y < 0.0)
                Console.WriteLine("Q3");
            else
                Console.WriteLine("Q4");

        }
    }
}
