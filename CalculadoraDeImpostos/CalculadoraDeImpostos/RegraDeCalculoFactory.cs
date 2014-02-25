using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraDeImpostos
{
    public static class RegraDeCalculoFactory
    {
        public static IList<RegraDeCalculo> getRegras()
        {
            return RegraDeCalculoFactory.getRegrasAliquotaDesconto();
        }

        private static IList<RegraDeCalculo> getRegrasAliquotaDesconto()
        {
            List<RegraDeCalculo> regras = new List<RegraDeCalculo>();

            regras.Add(new RegraDeCalculo(new CalculoAliquotaDesconto(0.075, 0), new FaixaSalarial(0, 1500)));
            regras.Add(new RegraDeCalculo(new CalculoAliquotaDesconto(0.15, 17), new FaixaSalarial(1501, 2500)));
            regras.Add(new RegraDeCalculo(new CalculoAliquotaDesconto(0.275, 35), new FaixaSalarial(2500)));

            return regras;
        }
    }
}
