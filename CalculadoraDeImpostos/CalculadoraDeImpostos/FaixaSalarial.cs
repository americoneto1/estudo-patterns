using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraDeImpostos
{
    public class FaixaSalarial
    {
        private double faixaInicial;
        private double faixaFinal;

        public FaixaSalarial(double faixaInicial, double faixaFinal)
        {
            this.faixaInicial = faixaInicial;
            this.faixaFinal = faixaFinal;
        }

        public FaixaSalarial(double faixaInicial)
        {
            this.faixaInicial = faixaInicial;
            this.faixaFinal = double.MaxValue;
        }

        public bool estaNaFaixa(double salario)
        {
            return (salario >= this.faixaInicial && salario <= this.faixaFinal);
        }
    }
}
