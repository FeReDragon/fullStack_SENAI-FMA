using System;

namespace DivisaoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            double num1, num2, resultado = 0;

            try
            {
                Console.Write("Digite o primeiro número: ");
                num1 = Convert.ToDouble(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                num2 = Convert.ToDouble(Console.ReadLine());

                resultado = num1 / num2;

                Console.WriteLine("Resultado da divisão:" + resultado);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Erro: não é possível dividir por zero.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Erro: letras não podem ser informadas.");
            }
            catch (Exception)
            {
                Console.WriteLine("Erro: ocorreu um erro inesperado.");
            }
            finally
            {
                num1 = 0;
                num2 = 0;
            }
        }
    }
}