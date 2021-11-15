using System;

namespace exec_for_prop_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int input = int.Parse(Console.ReadLine());

            if(input > 0 && input < 1000 )
            {
                for (int i = 1; i <= input; i++)
                {
                    if(i % 2 != 0)
                    {
                        Console.WriteLine(i);
                    }
                }
            }

        }
    }
}
