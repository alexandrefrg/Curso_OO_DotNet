namespace exec_mem_est_prop_1
{
    public class ConversorDeMoeda
    {
        public static double Iof = 0.06;

        public static double DolarPraReal(double quantia, double cotacao)
        {
            return quantia * cotacao * (1 + Iof);
        }
    }
}
