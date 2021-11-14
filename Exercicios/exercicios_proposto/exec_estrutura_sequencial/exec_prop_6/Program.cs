using System;

namespace exec_prop_6
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            double input_a, input_b, input_c, triangulo, circulo, trapezio, quadrado, retangulo;
            String[] input;
            const double PI = 3.14159;

            input = Console.ReadLine().Split(' ');

            input_a = double.Parse(input[0]);
            input_b = double.Parse(input[1]);
            input_c = double.Parse(input[2]);

            triangulo = input_a * input_c / 2.0;
            circulo = PI * input_c * input_c;
            trapezio = (input_a + input_b) / 2.0 * input_c;
            quadrado = input_b * input_b;
            retangulo = input_a * input_b;

            Console.WriteLine($"TRIANGULO: {triangulo:F3}");
            Console.WriteLine($"CIRCULO: {circulo:F3}");
            Console.WriteLine($"TRAPEZIO: {trapezio:F3}");
            Console.WriteLine($"QUADRADO: {quadrado:F3}");
            Console.WriteLine($"RETANGULO: {retangulo:F3}");
        }
    }
}
