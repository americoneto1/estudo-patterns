using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalculadoraInterpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            IExpressao principal = new Multiplicacao(new Soma(
                                                        new Divisao(new Numero(20), new Numero(10)),
                                                        new Subtracao(new Numero(5), new Numero(3))), 
                                                     new Numero(2));

            Console.WriteLine(principal.avalia());            

            IVisitor impressora = new ImpressoraVisitor();
            principal.aceita(impressora);

            Console.Read();
        }
    }
}
