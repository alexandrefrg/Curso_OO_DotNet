using System;

namespace exec_prop_4
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ');
            int start_time = int.Parse(input[0]);
            int end_time = int.Parse(input[1]);

            int duration;
            if(start_time < end_time)
            {
                duration = end_time - start_time;
            }
            else
            {
                duration = 24 - start_time + end_time;
            }

            Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
        }
    }
}
