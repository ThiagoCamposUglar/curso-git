using System;

namespace Produtinho {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Entre com os dados do produto: ");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();

            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine());

            Console.Write("Quantidade no estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            //Produto p1 = new Produto(nome, preco);

            //Produto p2 = new Produto();

            /*Produto p3 = new Produto {
                Nome = nome,
                Preco = preco,
                Quantidade = quantidade
             };*/

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a serem adicionados ao estoque:");
            int qte = int.Parse(Console.ReadLine());
            p.AdicionarProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine();
            Console.WriteLine("Digite a quantidade de produtos a serem removidos do estoque:");
            qte = int.Parse(Console.ReadLine());
            p.RemoverProdutos(qte);

            Console.WriteLine();
            Console.WriteLine("Dados do produto: " + p);
            Console.WriteLine("Git e github é muito brabo");
            Console.WriteLine("Salve Salve família");
            
        }
    }
}
