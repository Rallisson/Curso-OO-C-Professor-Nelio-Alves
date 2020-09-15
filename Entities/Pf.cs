using System.Globalization;

namespace OO_Course.Entities
{
    class Pf : Contribuinte
    {
        public double GastoSaude { get; set; }

        public Pf()
        {

        }
        
        public Pf(string nome, double rendaAnual, double gastoSaude)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
            GastoSaude = gastoSaude;
        }

        public override double Imposto()
        {
            if(RendaAnual < 20000.0)
            {
                return RendaAnual * (15.0 / 100.0) - GastoSaude * (50.0 / 100.0);
            }
            else
            {
                return RendaAnual * (25.0 / 100.0) - GastoSaude * (50.0 / 100.0);
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
