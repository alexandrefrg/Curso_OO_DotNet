using System;
namespace cap4_exec_fix_3
{
    public class Aluno
    {
        private const double MEDIA = 60.0;
        public string Nome;
        public double Nota1, Nota2, Nota3;

        public double NotaFinal()
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= MEDIA)
                return true;
            else
                return false;
        }

        public double NotaRestante()
        {
            if (!Aprovado())
                return MEDIA - NotaFinal();
            return 0.0;
        }
    }
}
