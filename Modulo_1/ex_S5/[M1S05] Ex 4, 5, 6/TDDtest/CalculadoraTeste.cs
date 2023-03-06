using System;
using TDD;
using Xunit;

namespace TDDtest
{
    public class CalculadoraTeste
    {
        // Teste para o método Soma da classe Calculadora
        [Theory]
        [InlineData(2, 3, 5)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, 3, 1)]
        [InlineData(2, -3, -1)]
        public void TestarSoma(int a, int b, int resultadoEsperado)
        {
            // realiza a operação 
            int resultado = Calculadora.Soma(a, b);

            // Assert verifica se o resultado é igual ao esperado
            Assert.Equal(resultadoEsperado, resultado);
        }
        
        // Teste para o método Subtracao da classe Calculadora
        [Theory]
        [InlineData(2, 3, -1)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, 3, -5)]
        [InlineData(2, -3, 5)]
        public void TestarSubtracao(int a, int b, int resultadoEsperado)
        {
            // realiza a operação 
            int resultado = Calculadora.Subtracao(a, b);

            // Assert verifica se o resultado é igual ao esperado
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Teste para o método Multiplicacao da classe Calculadora
        [Theory]
        [InlineData(2, 3, 6)]
        [InlineData(0, 0, 0)]
        [InlineData(-2, 3, -6)]
        [InlineData(2, -3, -6)]
        public void TestarMultiplicacao(int a, int b, int resultadoEsperado)
        {
            /// realiza a operação 
            int resultado = Calculadora.Multiplicacao(a, b);

            // Assert verifica se o resultado é igual ao esperado
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(6, 3, 2)]
        [InlineData(0, 1, 0)]
        [InlineData(-6, 3, -2)]
        [InlineData(6, -3, -2)]

        // Teste para o método Divisao da classe Calculadora
        public void TestarDivisao(int a, int b, int resultadoEsperado)
        {
            // realiza a operação 
            int resultado = Calculadora.Divisao(a, b);

            // Assert verifica se o resultado é igual ao esperado
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}
