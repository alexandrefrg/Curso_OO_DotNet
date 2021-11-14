using System;

namespace exec_cond_prop_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double input = double.Parse(Console.ReadLine());

            if (input < 0.0 || input > 100.0)
                Console.WriteLine("Fora de intervalo");
            else if (input <= 25.0)
                Console.WriteLine("Intervalo [0,25]");
            else if (input <= 50.0)
                Console.WriteLine("Intervalo (25,50]");
            else if (input <= 75.0)
                Console.WriteLine("Intervalo (50,75]");
            else
                Console.WriteLine("Intervalo (75,100]");
            
        }
    }
}
