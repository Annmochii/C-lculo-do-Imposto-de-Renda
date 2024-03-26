using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_Correção___POOII
{
    class Controladoria
    {
        public double TotalDeImpostos { get; private set; }
        public double TotalImpostosPFisica { get; private set; }
        public double TotalImpostosPJuridica { get; private set; }

        public void gerenciaImpostos(Contribuinte contribuinte)
        {
            if (contribuinte is PFisica)
            {
                this.TotalImpostosPFisica += contribuinte.calculaImposto();
            }
            else
            {
                this.TotalImpostosPJuridica += contribuinte.calculaImposto();
            }

            totalizaImpostos();
        }

        public void totalizaImpostos()
        {
            TotalDeImpostos = TotalImpostosPFisica + TotalImpostosPJuridica;
        }

        public void exibirAtributos(Contribuinte contribuinte)
        {
            Console.WriteLine("------ Dados do Contribuinte ------");
            Console.WriteLine("Nome: " + contribuinte.Nome);
            Console.WriteLine("Renda Bruta: " + contribuinte.RendaBruta);
            Console.WriteLine("Impostos: " + contribuinte.calculaImposto().ToString("C"));
            contribuinte.imprimirCpfOuCnpj();
            Console.WriteLine("-----------------------------------");
        }
    }
}
