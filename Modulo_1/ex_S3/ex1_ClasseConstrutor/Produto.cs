using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex1_ClasseConstrutor;
    public class Produto // Classe representa o produto, com as propriedades Nome, Preço e Quantidade
    {
        public string Nome; // Propriedade Nome 
        public double Preco;// Propriedade Preço 
        public int Quantidade;// Propriedade Quantidade 

        // Construtor com argumentos, inicializa as propriedades Nome, Preço e Quantidade
        public Produto(string nome, double preco, int quantidade)
        {
            Nome = nome;
            Preco = preco;
            Quantidade = quantidade;
        }
        // Construtor padrão para inicializar as propriedades com default
        public Produto()
        {
            Nome = "Sem Nome";
            Preco = 0;
            Quantidade = 0;
        }
    }
