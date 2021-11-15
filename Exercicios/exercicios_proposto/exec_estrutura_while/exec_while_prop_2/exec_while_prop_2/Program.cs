using System;

namespace exec_while_prop_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');

            int input_x = int.Parse(input[0]);
            int input_y = int.Parse(input[1]);

            while(input_x != 0 && input_y != 0)
            {
                if(input_x > 0 && input_y > 0)
                    Console.WriteLine("primeiro");
                else if(input_x < 0 && input_y > 0)
                    Console.WriteLine("segundo");
                else if(input_x < 0 && input_y < 0)
                    Console.WriteLine("terceiro");
                else
                    Console.WriteLine("quarto");

                input = Console.ReadLine().Split(' ');
                input_x = int.Parse(input[0]);
                input_y = int.Parse(input[1]);
            }
        }
    }
}
