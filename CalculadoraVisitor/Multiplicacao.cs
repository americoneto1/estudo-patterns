using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraInterpreter
{
    public class Multiplicacao : IExpressao
    {
        public IExpressao e1 { get; set; }
        public IExpressao e2 { get; set; }

        public Multiplicacao(IExpressao e1, IExpressao e2)
        {
            this.e1 = e1;
            this.e2 = e2;
        }

        public int avalia()
        {
            return e1.avalia() * e2.avalia();
        }

        public void aceita(IVisitor visitor)
        {
            visitor.visitaMultiplicacao(this);
        }
    }
}
