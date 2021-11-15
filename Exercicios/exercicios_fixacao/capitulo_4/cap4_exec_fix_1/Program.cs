using System;

namespace cap4_exec_fix_1
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Retangulo r1 = new Retangulo();

            Console.WriteLine("Entre a largura e altura do retângulo:");
            r1.Largura = double.Parse(Console.ReadLine());
            r1.Altura = double.Parse(Console.ReadLine());

            Console.WriteLine("AREA = " + r1.Area().ToString("F2"));
            Console.WriteLine("PERÍMETRO = " + r1.Perimetro().ToString("F2"));
            Console.WriteLine("DIAGONAL = " + r1.Diagonal().ToString("F2"));

        }
    }
}
