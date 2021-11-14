using System;

namespace exec_seq_prop_2
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double R;
            double A;
            double Pi = 3.14159;

            R = double.Parse(Console.ReadLine());
            A = Pi * R * R;

            Console.WriteLine($"A={A:F4}");
        }
    }
}
