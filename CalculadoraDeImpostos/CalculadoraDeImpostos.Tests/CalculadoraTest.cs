using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDeImpostos.Tests
{
    [TestClass]
    public class CalculadoraTest
    {
        private Calculadora calculadora;

        [TestInitialize]
        public void init()
        {
            calculadora = new Calculadora();
        }

        [TestMethod]
        public void deveEstarNaPrimeiraFaixa()
        {
            var salario = 1000;
            var imposto = calculadora.calcularImposto(salario);
            Assert.AreEqual(75, imposto, 0.00001);
        }

        [TestMethod]
        public void deveEstarNaSegundaFaixa()
        {
            var salario = 2000;
            var imposto = calculadora.calcularImposto(salario);
            Assert.AreEqual(283, imposto, 0.00001);
        }

        [TestMethod]
        public void deveEstarNaTerceiraFaixa()
        {
            var salario = 3000;
            var imposto = calculadora.calcularImposto(salario);
            Assert.AreEqual(790, imposto, 0.00001);
        }
    }
}
