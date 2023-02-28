using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contaBancariaV3.Classes.enums;

namespace contaBancariaV3.Classes
{
    // Esta é a classe ClienteService, que fornece serviços relacionados a clientes
    public class ClienteService
    {
         // Este método estático permite cadastrar um novo cliente e retorna a instância da classe Cliente correspondente.
        public static Cliente CadastrarCliente()
        {
            Console.WriteLine("\nInsira o nome de um novo cliente:");
            string nome = Console.ReadLine();

            Console.WriteLine("Insira a data de nascimento do cliente (dd/mm/aaaa):");
            DateTime nascimento = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Insira a profissão do cliente:");
            string profissao = Console.ReadLine();

            Console.WriteLine("Insira o estado civil do cliente:");
            string estadoCivil = Console.ReadLine();

            Console.WriteLine("Insira o tipo de pessoa (FISICA ou JURIDICA):");
            TipoPessoaEnum tipoPessoa = (TipoPessoaEnum)Enum.Parse(typeof(TipoPessoaEnum), Console.ReadLine(), true);

            // Cria um novo objeto Cliente com as informações fornecidas e o retorna
            return new Cliente(nome, nascimento, profissao, estadoCivil, tipoPessoa);
        }
    }
}