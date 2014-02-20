using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraDeImpostos
{
    public class CalculoAliquotaDesconto : IBaseCalculo
    {
        public double Aliquota { get; private set; }
        public double Desconto { get; private set; }

        public CalculoAliquotaDesconto(double aliquota, double desconto)
        {
            Aliquota = aliquota;
            Desconto = desconto;
        }

        public double realizarCalculo(double salario)
        {
            return salario * Aliquota - Desconto;
        }
    }
}
