using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraDeImpostos
{
    public class RegraDeCalculo
    {
        private IBaseCalculo BaseCalculo;
        private FaixaSalarial FaixaSalarial;

        public RegraDeCalculo(IBaseCalculo baseCalculo, FaixaSalarial faixaSalarial)
        {
            BaseCalculo = baseCalculo;
            FaixaSalarial = faixaSalarial;
        }

        public bool estaNaFaixa(double salario)
        {
            return this.FaixaSalarial.estaNaFaixa(salario);
        }

        public double getImpostoTotal(double salario)
        {
            return this.BaseCalculo.realizarCalculo(salario);
        }
    }
}
