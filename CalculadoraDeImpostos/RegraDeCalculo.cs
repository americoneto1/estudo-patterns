using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraDeImpostos
{
    public class RegraDeCalculo
    {
        public IBaseCalculo BaseCalculo { get; private set; }
        public int FaixaInicial { get; private set; }
        public int FaixaFinal { get; private set; }

        public RegraDeCalculo(IBaseCalculo baseCalculo, int faixaInicial, int faixaFinal)
        {
            BaseCalculo = baseCalculo;
            FaixaInicial = faixaInicial;
            FaixaFinal = faixaFinal;
        }

        public RegraDeCalculo(IBaseCalculo baseCalculo, int faixaInicial)
        {
            BaseCalculo = baseCalculo;
            FaixaInicial = faixaInicial;
            FaixaFinal = int.MaxValue;
        }
    }
}
