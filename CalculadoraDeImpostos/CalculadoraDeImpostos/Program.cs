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

            while (true)
            {
                try
                {
                    Console.Write("Digite um valor para o salário: R$ ");
                    double salario = Convert.ToDouble(Console.ReadLine());
                    double imposto = c.calcularImposto(salario);
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
