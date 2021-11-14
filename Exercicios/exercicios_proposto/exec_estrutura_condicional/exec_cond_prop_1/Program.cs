using System;

namespace exec_cond_prop_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int number;

            number = int.Parse(Console.ReadLine());
            if (number >= 0)
                Console.WriteLine("NAO NEGATIVO");
            else
                Console.WriteLine("NEGATIVO");
        }
    }
}
