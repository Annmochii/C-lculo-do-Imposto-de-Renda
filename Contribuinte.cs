using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EX01_Correção___POOII
{
    class Contribuinte
    {
        public string Nome { get; protected set; }
        public double RendaBruta { get; protected set; }

        public Contribuinte()
        {

        }

        public Contribuinte(string nome, double rendaBruta)
        {
            Nome = nome;
            RendaBruta = rendaBruta;
        }

        public virtual double calculaImposto()
        {
            return -1;
        }

        public virtual void imprimirCpfOuCnpj()
        {

        }
    }
}
