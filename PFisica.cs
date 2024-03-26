using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_Correção___POOII
{
    class PFisica : Contribuinte
    {
        public string Cpf { get; private set; }

        public PFisica(string cpf, string nome, double rendaBruta)
        {
            this.Cpf = cpf;
            this.Nome = nome;
            this.RendaBruta = rendaBruta;
        }
        public override double calculaImposto()
        {
            if (this.RendaBruta < 0)
            {
                return -1;
            }
            else if (this.RendaBruta <= 1400)
            {
                return 0;
            }
            else if (this.RendaBruta <= 2100)
            {
                return 0.1f * this.RendaBruta;
            }
            else if (this.RendaBruta <= 2800)
            {
                return 0.15f * this.RendaBruta;
            }
            else if (this.RendaBruta <= 3600)
            {
                return 0.25f * this.RendaBruta;
            }
            else
            {
                return 0.3f * this.RendaBruta;
            }
        }

        public override void imprimirCpfOuCnpj()
        {
            Console.WriteLine("CPF: " + this.Cpf);
        }
    }
}
