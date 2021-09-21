using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;

namespace ProjetoLocadoraFema.CAMADAS.DAL
{
    public class Filmes
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Filmes> Select()
        {
            List<MODEL.Filmes> lstFilmes = new List<MODEL.Filmes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Filmes;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Filmes filmes = new MODEL.Filmes();
                    filmes.ID = Convert.ToInt32(dados["ID"].ToString());
                    filmes.Produtora = dados["Produtora"].ToString();
                    filmes.Nome = dados["Nome"].ToString();
                    filmes.Categoria = dados["Categoria"].ToString();
                    filmes.Data = dados["Data"].ToString();
                    filmes.Faixa = dados["Faixa"].ToString();
                    filmes.Valor = Convert.ToDouble(dados["Valor"]);
                    filmes.Quantidade = Convert.ToInt32(dados["Quantidade"].ToString());
                    lstFilmes.Add(filmes);
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
            return lstFilmes;
        }


        public List<MODEL.Filmes> SelectAtivos()
        {
            List<MODEL.Filmes> lstFilmes = new List<MODEL.Filmes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Filmes WHERE Quantidade>0;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Filmes filmes = new MODEL.Filmes();
                    filmes.ID = Convert.ToInt32(dados["ID"].ToString());
                    filmes.Produtora = dados["Produtora"].ToString();
                    filmes.Nome = dados["Nome"].ToString();
                    filmes.Categoria = dados["Categoria"].ToString();
                    filmes.Data = dados["Data"].ToString();
                    filmes.Faixa = dados["Faixa"].ToString();
                    filmes.Valor = Convert.ToDouble(dados["Valor"]);
                    filmes.Quantidade = Convert.ToInt32(dados["Quantidade"].ToString());
                    lstFilmes.Add(filmes);
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
            return lstFilmes;
        }

        public List<MODEL.Filmes> SelectDesativados()
        {
            List<MODEL.Filmes> lstFilmes = new List<MODEL.Filmes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Filmes WHERE Quantidade=0;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Filmes filmes = new MODEL.Filmes();
                    filmes.ID = Convert.ToInt32(dados["ID"].ToString());
                    filmes.Produtora = dados["Produtora"].ToString();
                    filmes.Nome = dados["Nome"].ToString();
                    filmes.Categoria = dados["Categoria"].ToString();
                    filmes.Data = dados["Data"].ToString();
                    filmes.Faixa = dados["Faixa"].ToString();
                    filmes.Valor = Convert.ToDouble(dados["Valor"]);
                    filmes.Quantidade = Convert.ToInt32(dados["Quantidade"].ToString());
                    lstFilmes.Add(filmes);
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
            return lstFilmes;
        }

        public void Insert(MODEL.Filmes filmes)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Filmes VALUES (@ID_Filme, @Produtora_Filme, @Nome_Filme, @Categoria_Filme, @Data_Filme, @Classificacao_Filme, @Preco_Filme, @Qtd_Filme);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID_Filme", filmes.ID);
            cmd.Parameters.AddWithValue("@Produtora_Filme", filmes.Produtora);
            cmd.Parameters.AddWithValue("@Nome_Filme", filmes.Nome);
            cmd.Parameters.AddWithValue("@Categoria_Filme", filmes.Categoria);
            cmd.Parameters.AddWithValue("@Data_Filme", filmes.Data);
            cmd.Parameters.AddWithValue("@Classificacao_Filme", filmes.Faixa);
            cmd.Parameters.AddWithValue("@Preco_Filme", filmes.Valor);
            cmd.Parameters.AddWithValue("@Qtd_Filme", filmes.Quantidade);

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


        public void Update(MODEL.Filmes filmes)
        {

            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Filmes SET Produtora=@Produtora, Nome=@Nome, Categoria=@Categoria, Data=@Data, Faixa=@Faixa, Valor=@Valor, Quantidade=@Quantidade ";
            sql += " WHERE ID=@ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", filmes.ID);
            cmd.Parameters.AddWithValue("@Produtora", filmes.Produtora);
            cmd.Parameters.AddWithValue("@Nome", filmes.Nome);
            cmd.Parameters.AddWithValue("@Categoria", filmes.Categoria);
            cmd.Parameters.AddWithValue("@Data", filmes.Data);
            cmd.Parameters.AddWithValue("@Faixa", filmes.Faixa);
            cmd.Parameters.AddWithValue("@Valor", filmes.Valor);
            cmd.Parameters.AddWithValue("@Quantidade", filmes.Quantidade);

            try
            {
                conexao.Open();
                cmd.ExecuteNonQuery();
            }
            catch
            {
                Console.WriteLine("Erro na atualização do registro.");
            }
            finally
            {
                conexao.Close();
            }
        }

        public void Delete(int ID_Filme)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Filmes WHERE ID=@ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", ID_Filme);

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



        public List<MODEL.Filmes> SelectByIDAtivos(int filmes)
        {
            List<MODEL.Filmes> lstFilmes = new List<MODEL.Filmes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Filmes WHERE ID=@ID AND Quantidade>0;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", filmes);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Filmes DALfilmes = new MODEL.Filmes();
                    DALfilmes.ID = Convert.ToInt32(dados["ID"].ToString());
                    DALfilmes.Produtora = dados["Produtora"].ToString();
                    DALfilmes.Nome = dados["Nome"].ToString();
                    DALfilmes.Categoria = dados["Categoria"].ToString();
                    DALfilmes.Data = dados["Data"].ToString();
                    DALfilmes.Faixa = dados["Faixa"].ToString();
                    DALfilmes.Valor = Convert.ToDouble(dados["Valor"]);
                    DALfilmes.Quantidade = Convert.ToInt32(dados["Quantidade"].ToString());
                    lstFilmes.Add(DALfilmes);
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
            return lstFilmes;
        }

        public List<MODEL.Filmes> SelectByNomeAtivos(String Nome)
        {
            List<MODEL.Filmes> lstFilmes = new List<MODEL.Filmes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Filmes WHERE (Nome LIKE @Nome) AND Quantidade>0;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", "%" + Nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Filmes DALfilmes = new MODEL.Filmes();
                    DALfilmes.ID = Convert.ToInt32(dados["ID"].ToString());
                    DALfilmes.Produtora = dados["Produtora"].ToString();
                    DALfilmes.Nome = dados["Nome"].ToString();
                    DALfilmes.Categoria = dados["Categoria"].ToString();
                    DALfilmes.Data = dados["Data"].ToString();
                    DALfilmes.Faixa = dados["Faixa"].ToString();
                    DALfilmes.Valor = Convert.ToDouble(dados["Valor"]);
                    DALfilmes.Quantidade = Convert.ToInt32(dados["Quantidade"].ToString());
                    lstFilmes.Add(DALfilmes);
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
            return lstFilmes;
        }

        public List<MODEL.Filmes> SelectByIDDesativados(int filmes)
        {
            List<MODEL.Filmes> lstFilmes = new List<MODEL.Filmes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Filmes WHERE ID=@ID AND Quantidade=0";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", filmes);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Filmes DALfilmes = new MODEL.Filmes();
                    DALfilmes.ID = Convert.ToInt32(dados["ID"].ToString());
                    DALfilmes.Produtora = dados["Produtora"].ToString();
                    DALfilmes.Nome = dados["Nome"].ToString();
                    DALfilmes.Categoria = dados["Categoria"].ToString();
                    DALfilmes.Data = dados["Data"].ToString();
                    DALfilmes.Faixa = dados["Faixa"].ToString();
                    DALfilmes.Valor = Convert.ToDouble(dados["Valor"]);
                    DALfilmes.Quantidade = Convert.ToInt32(dados["Quantidade"].ToString());
                    lstFilmes.Add(DALfilmes);
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
            return lstFilmes;
        }

        public List<MODEL.Filmes> SelectByNomeDesativados(String Nome)
        {
            List<MODEL.Filmes> lstFilmes = new List<MODEL.Filmes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Filmes WHERE (Nome LIKE @Nome) AND Quantidade=0;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", "%" + Nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Filmes DALfilmes = new MODEL.Filmes();
                    DALfilmes.ID = Convert.ToInt32(dados["ID"].ToString());
                    DALfilmes.Produtora = dados["Produtora"].ToString();
                    DALfilmes.Nome = dados["Nome"].ToString();
                    DALfilmes.Categoria = dados["Categoria"].ToString();
                    DALfilmes.Data = dados["Data"].ToString();
                    DALfilmes.Faixa = dados["Faixa"].ToString();
                    DALfilmes.Valor = Convert.ToDouble(dados["Valor"]);
                    DALfilmes.Quantidade = Convert.ToInt32(dados["Quantidade"].ToString());
                    lstFilmes.Add(DALfilmes);
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
            return lstFilmes;
        }
    }

}

