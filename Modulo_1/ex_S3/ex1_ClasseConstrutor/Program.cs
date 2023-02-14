using ex1_ClasseConstrutor;
class Program
    {
        static void Main(string[] args)
        {
            Produto produto1 = new Produto("Notebook", 2000, 10); // construtor com argumentos
            Produto produto2 = new Produto(); //construtor padrão

            Console.WriteLine("\nProduto 1: \nNome: " + produto1.Nome + "\nPreço: " + produto1.Preco + "\nQuantidade: " + produto1.Quantidade);
            Console.WriteLine("\nProduto 2: \nNome: " + produto2.Nome + "\nPreço: " + produto2.Preco + "\nQuantidade: " + produto2.Quantidade);
            
            Console.ReadLine();
        }
    }
