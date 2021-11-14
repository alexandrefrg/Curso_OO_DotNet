using System;

namespace exec_cond_prop_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;

            number = int.Parse(Console.ReadLine());

            if(number % 2 == 0)
                Console.WriteLine("PAR");
            else
                Console.WriteLine("IMPAR");
        }
    }
}
