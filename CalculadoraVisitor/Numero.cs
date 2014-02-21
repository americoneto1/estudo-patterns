using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraInterpreter
{
    public class Numero : IExpressao
    {
        public int numero { get; set; }

        public Numero(int numero)
        {
            this.numero = numero;
        }

        public int avalia()
        {
            return this.numero;
        }

        public void aceita(IVisitor visitor)
        {
            visitor.visitaNumero(this);
        }
    }
}
