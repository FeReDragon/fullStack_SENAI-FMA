using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using contaBancariaV3.Classes.enums;

namespace contaBancariaV3.Classes
{
    public class Cliente //// Esta é a classe Cliente, que representa um cliente da conta bancária
    {
    
        public string Nome { get; private set; }
        public DateTime Nascimento { get; private set; }
        public string Profissao { get; private set; }
        public string EstadoCivil { get; private set; }
        public TipoPessoaEnum TipoPessoa { get; private set; }

        // Construtor da classe Cliente
        public Cliente(string nome, DateTime nascimento, string profissao, string estadoCivil, TipoPessoaEnum tipoPessoa)
        {
            Nome = nome;
            Nascimento = nascimento;
            Profissao = profissao;
            EstadoCivil = estadoCivil;
            TipoPessoa = tipoPessoa;
        }
    }
}