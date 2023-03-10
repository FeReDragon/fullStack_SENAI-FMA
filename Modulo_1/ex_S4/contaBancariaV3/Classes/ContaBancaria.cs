using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contaBancariaV3.Classes;

namespace contaBancariaV3.Classes
{
      
    public class ContaBancaria
    {
        public int Numero { get; protected set; }
        public int Agencia { get; protected set; }
        public decimal Saldo { get; protected set; }
        public Cliente Cliente { get; protected set; }

        public ContaBancaria(int numero, int agencia, Cliente cliente)
        {
            Numero = numero;
            Agencia = agencia;
            // Opcional, visto que o tipo decimal já inicia em 0
            Saldo = 0;
            Cliente = cliente;
        }

        // Método virtual para transferir um valor para outra conta bancária
        public virtual void Transferir(ContaBancaria conta, decimal valor)
        {
            // valida se o valor a ser transferido é maior do que 0
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0!");
                return;
            }

            // valida se há saldo suficiente para realizar a transferência
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
                return;
            }

            Saldo = Saldo - valor;
            conta.Depositar(valor);

            Console.WriteLine($"Valor de R$ {valor} transferido com sucesso!");
        }

        // Método virtual para depositar um valor na conta bancária
        public virtual void Depositar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;
            }
            else
            {
                Saldo = Saldo + valor;
            }

            Console.WriteLine($"Valor de R$ {valor} depositado com sucesso!");
        }
        
        // Método virtual para sacar um valor da conta bancária
        public virtual void Sacar(decimal valor)
        {
            if (valor <= 0)
            {
                Console.WriteLine("O valor precisa ser maior do que 0");
                return;

            }
            else if (valor > Saldo)
            {
                Console.WriteLine("O valor é maior do que o saldo atual!");
                return;
            }
            else
            {
                Saldo = Saldo - valor;
            }

            Console.WriteLine($"Saque no valor de R$ {valor} realizado com sucesso!");
        }
        /// Método virtual para exibir o saldo da conta bancária
        public virtual void ExibirSaldo()
        {
            Console.WriteLine($"O saldo atual da conta é de R$ {Saldo}");
        }
    }
}