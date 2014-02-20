using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraDeImpostos
{
    public class Calculadora
    {
        public double calcularImposto(double salario, IList<RegraDeCalculo> regras)
        {
            foreach (var regra in regras)
            {
                if (salario >= regra.FaixaInicial && salario <= regra.FaixaFinal)
                {
                    return regra.BaseCalculo.realizarCalculo(salario);
                }
            }
            return salario;
        }
    }
}
