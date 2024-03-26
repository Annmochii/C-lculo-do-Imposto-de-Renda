using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_Correção___POOII
{
    class Program
    {
        static void Main(string[] args)
        {
            PFisica PF1 = new PFisica("999999-99", "Anna", 800.00);
            PFisica PF2 = new PFisica("888888-88", "Cassio", 2600.00);
            PFisica PF3 = new PFisica("777777-77", "Eloisa", 1200.00);
            PFisica PF4 = new PFisica("666666-99", "Ana Laura", 1800.00);
            PFisica PF5 = new PFisica("555555-55", "Raquel", 2000.00);
            PJuridica PJ1 = new PJuridica("99999999", "Prinn", 3000.00);
            PJuridica PJ2 = new PJuridica("88888888", "Walt Disney", 86464500.00);
            PJuridica PJ3 = new PJuridica("77777777", "Netflix", 9786451.00);
            PJuridica PJ4 = new PJuridica("66666666", "EJUVV", 30000.00);
            PJuridica PJ5 = new PJuridica("55555555", "UVV", 456120.00);

            Dictionary<string, Contribuinte> Contribuintes = new Dictionary<string, Contribuinte>();
            Contribuintes.Add("Anna", PF1);
            Contribuintes.Add("Cassio", PF2);
            Contribuintes.Add("Eloisa", PF3);
            Contribuintes.Add("Ana Laura", PF4);
            Contribuintes.Add("Raquel", PF5);
            Contribuintes.Add("Prinn", PJ1);
            Contribuintes.Add("Walt Disney", PJ2);
            Contribuintes.Add("Netflix", PJ3);
            Contribuintes.Add("EJUVV", PJ4);
            Contribuintes.Add("UVV", PJ5);

            Controladoria cont = new Controladoria();

            foreach(KeyValuePair<string, Contribuinte> c in Contribuintes)
            {
                cont.gerenciaImpostos(c.Value);
                cont.exibirAtributos(c.Value);
            }

            Console.WriteLine("Total de Impostos das Pessoas Físicas: " + cont.TotalImpostosPFisica.ToString("C"));
            Console.WriteLine("Total de Impostos das Pessoas Jurídicas: " + cont.TotalImpostosPJuridica.ToString("C"));
            Console.WriteLine("Total de Impostos: " + cont.TotalDeImpostos.ToString("C"));
        }
    }
}
