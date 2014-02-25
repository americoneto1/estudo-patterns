using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraInterpreter
{
    public interface IVisitor
    {
        void visitaSoma(Soma soma);
        void visitaSubtracao(Subtracao subtracao);
        void visitaMultiplicacao(Multiplicacao multiplicacao);
        void visitaDivisao(Divisao divisao);
        void visitaNumero(Numero numero);
    }
}
