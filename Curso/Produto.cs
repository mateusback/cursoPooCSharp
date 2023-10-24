using System;
using System.Globalization;


namespace Curso {
    internal class Produto {
        public String _nome;
        public double _preco;
        public int _quantidade;

        //Properties
        public String Nome{
            get { return _nome; }
            set { _nome = value; }
        }

        public double ValorTotalEmEstoque() {
            return _preco * _quantidade;
        }

        public void AdicionarProdutos(int quantidade) {
            _quantidade = _quantidade + quantidade;
        }

        public void RemoverProdutos(int quantidade) {
            _quantidade = _quantidade - quantidade;
        }

        public override string ToString() {
            return _nome
                + ", $ "
                + _preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + _quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);

        }
        /*
        public String GetNome(){
            return _nome;
        }
        public void SetNome(String nome){
            _nome = nome;
        }*/
    }
}
