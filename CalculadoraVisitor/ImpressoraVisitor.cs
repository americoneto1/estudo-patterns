using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraInterpreter
{
    public class ImpressoraVisitor : IVisitor
    {
        public void visitaSoma(Soma soma)
        {
            Console.Write("(");
            soma.e1.aceita(this);
            Console.Write(" + ");
            soma.e2.aceita(this);
            Console.Write(")");
        }

        public void visitaSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.e1.aceita(this);
            Console.Write(" - ");
            subtracao.e2.aceita(this);
            Console.Write(")");
        }

        public void visitaMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.Write("(");
            multiplicacao.e1.aceita(this);
            Console.Write(" * ");
            multiplicacao.e2.aceita(this);
            Console.Write(")");
        }

        public void visitaDivisao(Divisao divisao)
        {
            Console.Write("(");
            divisao.e1.aceita(this);
            Console.Write(" / ");
            divisao.e2.aceita(this);
            Console.Write(")");
        }

        public void visitaNumero(Numero numero)
        {
            Console.Write(numero.numero);
        }
    }
}
