using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Produto
    {
        public string nome;
        protected string cor;
        private double peso;
        private double preco;

        public void verificarEstoque()
        {
            Console.WriteLine("Verificando estoque, acessando o método da classe produto");
        }

        protected void vender()
        {
            Console.WriteLine("Vendendo produto, acessando método vender da classe produto");
        }

        private void descartar()
        {
            Console.WriteLine("Descartando o produto, acessando o método da classe produto");
        }

        protected void alteraAtributosPrivados(double peso2, double preco)
        {
            peso = peso2;
            Console.WriteLine("Variável peso de escopo da classe: " + peso);
        }
    }
}