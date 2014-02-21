using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraInterpreter
{
    public class Soma : IExpressao
    {
        public IExpressao e1 { get; set; }
        public IExpressao e2 { get; set; }

        public Soma(IExpressao e1, IExpressao e2)
        {
            this.e1 = e1;
            this.e2 = e2;
        }

        public int avalia()
        {
            int v1 = e1.avalia();
            int v2 = e2.avalia();

            return v1 + v2;
        }

        public void aceita(IVisitor visitor)
        {
            visitor.visitaSoma(this);
        }
    }
}
