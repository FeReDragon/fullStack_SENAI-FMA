using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using TDD;

namespace TDDTest
{
    public class ValidadorDeNumerosTest
    {
        // Teste para validar se o método EhNumeroPrimo retorna o resultado esperado
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, true)]
        [InlineData(4, false)]
        [InlineData(5, true)]
        [InlineData(6, false)]
        [InlineData(7, true)]
        [InlineData(8, false)]
        [InlineData(9, false)]
        [InlineData(10, false)]
        [InlineData(11, true)]
        public void TestarEhNumeroPrimo(int numero, bool resultadoEsperado)
        {
            // Chama o método a ser testado
            bool resultado = ValidadorDeNumeros.EhNumeroPrimo(numero);

            // Assert verifica se o resultado do método é o esperado
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Teste para validar se o método ParOuImpar retorna o resultado esperado
        [Theory]
        [InlineData(2, true)]
        [InlineData(3, false)]
        [InlineData(4, true)]
        [InlineData(5, false)]
        [InlineData(6, true)]
        [InlineData(7, false)]
        public void TestarParOuImpar(int numero, bool resultadoEsperado)
        {
            //  Chama o método a ser testado
            bool resultado = ValidadorDeNumeros.ParOuImpar(numero);

            // Assert Verifica se o resultado do método é o esperado
            Assert.Equal(resultadoEsperado, resultado);
        }

        // Teste para validar se o método EhDivisivelPor retorna o resultado esperado
        [Theory]
        [InlineData(15, 3, true)]
        [InlineData(15, 5, true)]
        [InlineData(15, 7, false)]
        [InlineData(12, 4, true)]
        [InlineData(12, 5, false)]
        public void TestarEhDivisivelPor(int numero, int divisor, bool resultadoEsperado)
        {
            //Chama o método a ser testado
            bool resultado = ValidadorDeNumeros.EhDivisivelPor(numero, divisor);

            // Assert verifica se o resultado do método é o esperado
            Assert.Equal(resultadoEsperado, resultado);
        }
    }
}