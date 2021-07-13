using System;
using System.Globalization;

namespace Produtinho {
    class Produto {
        private string _nome;
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() {//default constructor method

        }

        public Produto(string nome, double preco) : this() {//constructor using this to get stuff from the default constructor
            _nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco) {
            Quantidade = quantidade;
        }


        //using get set method to get and set values from the encapsulated stuff(the priavte variables)
        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 1) {
                    _nome = value;
                }
            }
        }

        public double ValorTotalEmEstoque() {
            double total = Quantidade * Preco;
            return total;
        }

        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }

        public override string ToString() {
            return _nome + ", $" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade + " unidades, Total: " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
