using System.Globalization;

namespace OO_Course.Entities
{
    class Pj : Contribuinte
    {
        public int NumeroFuncionarios { get; set; }

        public Pj()
        {

        }

        public Pj(string nome, double rendaAnual, int numeroFuncionarios)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            if(NumeroFuncionarios > 10)
            {
                return RendaAnual * (14.0 / 100.0);
            }
            else
            {
                return RendaAnual * (16.0 / 100.0);
            }
        }

        public override string ToString()
        {
            return Nome + " $ "
                + Imposto().ToString("F2", CultureInfo.InvariantCulture)
                ;
        }
    }
}
