using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TDD
{
    public static class ValidadorDeNumeros
    {
        // metodo para verificação de numero primo.
        public static bool EhNumeroPrimo(int numero)
        {
            if (numero <= 1) 
                return false;
            if (numero == 2 || numero == 3) 
                return true;
            if (numero % 2 == 0 || numero % 3 == 0) 
                return false;

            int divisor = 5;
            while (Math.Pow(divisor, 2) <= numero)
            {
                if (numero % divisor == 0 || numero % (divisor + 2) == 0)
                    return false;
                divisor += 6;
            }

            return true;
        }
        // metodo para validação de para ou impar.
        public static bool ParOuImpar(int numero) => numero % 2 == 0;
         // metodo para validação de divisor.
        public static bool EhDivisivelPor(int numero, int divisor) => numero % divisor == 0;
    }
}