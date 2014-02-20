using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraDeImpostos
{
    public interface IBaseCalculo
    {
        double realizarCalculo(double salario);
    }
}
