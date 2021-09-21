using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFema.CAMADAS.MODEL
{
    public class Filmes
    {
        private int ID_Filme;
        private String Produtora_Filme;
        private String Nome_Filme;
        private String Categoria_Filme;
        private String Data_Filme;
        private String Classificacao_Filme;
        private Double Preco_Filme;
        private int Qtd_Filme;

        public int ID { get => ID_Filme; set => ID_Filme = value; }
        public string Produtora { get => Produtora_Filme; set => Produtora_Filme = value; }
        public string Nome { get => Nome_Filme; set => Nome_Filme = value; }
        public string Categoria { get => Categoria_Filme; set => Categoria_Filme = value; }
        public string Data { get => Data_Filme; set => Data_Filme = value; }
        public string Faixa { get => Classificacao_Filme; set => Classificacao_Filme = value; }
        public double Valor { get => Preco_Filme; set => Preco_Filme = value; }
        public int Quantidade { get => Qtd_Filme; set => Qtd_Filme = value; }
    }
}
