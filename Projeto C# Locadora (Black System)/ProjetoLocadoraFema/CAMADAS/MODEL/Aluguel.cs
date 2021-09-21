using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFema.CAMADAS.MODEL
{
    public class Aluguel
    {
        private int IDContrato;
        private int IDCliente;
        private int IDFilme;
        private String DataCompra;
        private String DataPrazo;
        private String ValorCompra;

        public int ID { get => IDContrato; set => IDContrato = value; }
        public int Cliente { get => IDCliente; set => IDCliente = value; }
        public int Filme { get => IDFilme; set => IDFilme = value; }
        public string Compra { get => DataCompra; set => DataCompra = value; }
        public string Prazo { get => DataPrazo; set => DataPrazo = value; }
        public string Valor { get => ValorCompra; set => ValorCompra = value; }
    }
}
