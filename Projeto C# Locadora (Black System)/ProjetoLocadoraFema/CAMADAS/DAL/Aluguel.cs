using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;


namespace ProjetoLocadoraFema.CAMADAS.DAL
{
    public class Aluguel
    {
        private string strCon = Conexao.getConexao();

        public void Insert(MODEL.Aluguel aluguel)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Contratos VALUES (@IDContrato, @IDCliente, @IDFilme, @DataCompra, @DataPrazo, @ValorCompra;)";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@IDContrato", aluguel.ID);
            cmd.Parameters.AddWithValue("@IDCliente", aluguel.Cliente);
            cmd.Parameters.AddWithValue("@IDFilme", aluguel.Filme);
            cmd.Parameters.AddWithValue("@DataCompra", aluguel.Compra);
            cmd.Parameters.AddWithValue("@DataPrazo", aluguel.Prazo);
            cmd.Parameters.AddWithValue("@ValorCompra", aluguel.Valor);
            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na inserção do registro.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public List<MODEL.Aluguel> Select()
        {
            List<MODEL.Aluguel> lstContratos = new List<MODEL.Aluguel>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Contratos;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Aluguel contratos = new MODEL.Aluguel();
                    contratos.ID = Convert.ToInt32(dados["ID"].ToString());
                    contratos.Cliente = Convert.ToInt32(dados["Cliente"].ToString());
                    contratos.Filme = Convert.ToInt32(dados["Filme"].ToString());
                    contratos.Compra = dados["Compra"].ToString();
                    contratos.Prazo = dados["Prazo"].ToString();
                    contratos.Valor = dados["Valor"].ToString();
                    lstContratos.Add(contratos);
                }
            }
            catch
            {
                Console.WriteLine("Erro na busca do registro");
            }
            finally
            {
                conexao.Close();
            }
            return lstContratos;
        }

        public void Delete(int IDContrato)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Contratos WHERE ID=@ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", IDContrato);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na exclusão do registro.");
            }
            finally
            {
                conexao.Close();
            }
        }
    }
}
