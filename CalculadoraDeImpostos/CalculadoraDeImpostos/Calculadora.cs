using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraDeImpostos
{
    public class Calculadora
    {
        public double calcularImposto(double salario)
        {
            IList<RegraDeCalculo> regras = RegraDeCalculoFactory.getRegras();
            RegraDeCalculo regra = regras.Where(r => r.estaNaFaixa(salario)).FirstOrDefault();
            
            if (regra != null)
            {
                return regra.getImpostoTotal(salario);
            }
            return salario;
        }
    }
}
