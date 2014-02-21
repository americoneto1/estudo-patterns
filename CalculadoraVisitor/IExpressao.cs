using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraInterpreter
{
    public interface IExpressao
    {
        int avalia();
        void aceita(IVisitor visitor);
    }
}
