using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculadoraDeImpostos
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculadora c = new Calculadora();
            List<RegraDeCalculo> regras = new List<RegraDeCalculo>();

            regras.Add(new RegraDeCalculo(new CalculoAliquotaDesconto(0.075, 0), 0, 1500));
            regras.Add(new RegraDeCalculo(new CalculoAliquotaDesconto(0.15, 17), 1501, 2500));
            regras.Add(new RegraDeCalculo(new CalculoAliquotaDesconto(0.275, 35), 2500));

            while (true)
            {
                try
                {
                    Console.Write("Digite um valor para o salário: R$ ");
                    double salario = Convert.ToDouble(Console.ReadLine());
                    double imposto = c.calcularImposto(salario, regras);
                    Console.WriteLine("Imposto de R$ " + imposto);
                }
                catch (Exception)
                {
                    Console.WriteLine("Valor incorreto");
                }
                Console.WriteLine("================");
            }
        }
    }
}
