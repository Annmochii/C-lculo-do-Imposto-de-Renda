using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_Correção___POOII
{
    class PJuridica : Contribuinte
    {
        public string Cnpj { get; private set; }

        public PJuridica(string cnpj, string nome, double rendaBruta)
        {
            this.Cnpj = cnpj;
            this.Nome = nome;
            this.RendaBruta = rendaBruta;
        }
        public override double calculaImposto()
        {
            return this.RendaBruta * 0.1;
        }

        public override void imprimirCpfOuCnpj()
        {
            Console.WriteLine("CPF: " + this.Cnpj);
        }
    }
}
