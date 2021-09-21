using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLocadoraFema.CAMADAS.DAL
{
    public class Clientes
    {
        private string strCon = Conexao.getConexao();

        public List<MODEL.Clientes> Select()
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Clientes";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes cliente = new MODEL.Clientes();
                    cliente.ID = Convert.ToInt32(dados["ID"].ToString());
                    cliente.Nome = dados["Nome"].ToString();
                    cliente.CPF = dados["CPF"].ToString();
                    cliente.Endereco = dados["Endereco"].ToString();
                    cliente.Telefone = dados["Telefone"].ToString();
                    lstClientes.Add(cliente);
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
            return lstClientes;
        }


        public void Insert(MODEL.Clientes clientes)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "INSERT INTO Clientes VALUES (@ID_Cli, @Nome_Cli, @CPF_Cli, @Ender_Cli, @Tel_Cli);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID_Cli", clientes.ID);
            cmd.Parameters.AddWithValue("@Nome_Cli", clientes.Nome);
            cmd.Parameters.AddWithValue("@CPF_Cli", clientes.CPF);
            cmd.Parameters.AddWithValue("@Ender_Cli", clientes.Endereco);
            cmd.Parameters.AddWithValue("@Tel_Cli", clientes.Telefone);
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


        public void Update(MODEL.Clientes clientes)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "UPDATE Clientes SET ID=@ID, Nome=@Nome, CPF=@CPF, Endereco=@Endereco, Telefone=@Telefone";
            sql += " WHERE ID=@ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", clientes.ID);
            cmd.Parameters.AddWithValue("@Nome", clientes.Nome);
            cmd.Parameters.AddWithValue("@CPF", clientes.CPF);
            cmd.Parameters.AddWithValue("@Endereco", clientes.Endereco);
            cmd.Parameters.AddWithValue("@Telefone", clientes.Telefone);

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

        public void Delete(int ID_Cli)
        {
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "DELETE FROM Clientes WHERE ID=@ID;";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", ID_Cli);

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

        public List<MODEL.Clientes> SelectByID(int ID)
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Clientes WHERE ID=@ID";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@ID", ID);
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes DALClientes = new MODEL.Clientes();
                    DALClientes.ID = Convert.ToInt32(dados["ID"].ToString());
                    DALClientes.Nome = dados["Nome"].ToString();
                    DALClientes.CPF = dados["CPF"].ToString();
                    DALClientes.Endereco = dados["Endereco"].ToString();
                    DALClientes.Telefone = dados["Telefone"].ToString();
                    lstClientes.Add(DALClientes);
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
            return lstClientes;
        }

        public List<MODEL.Clientes> SelectByNome(String Nome)
        {
            List<MODEL.Clientes> lstClientes = new List<MODEL.Clientes>();
            SqlConnection conexao = new SqlConnection(strCon);
            string sql = "SELECT * FROM Clientes WHERE (Nome LIKE @Nome);";
            SqlCommand cmd = new SqlCommand(sql, conexao);
            cmd.Parameters.AddWithValue("@Nome", "%" + Nome + "%");
            try
            {
                conexao.Open();
                SqlDataReader dados = cmd.ExecuteReader(CommandBehavior.CloseConnection);
                while (dados.Read())
                {
                    MODEL.Clientes DALClientes = new MODEL.Clientes();
                    DALClientes.ID = Convert.ToInt32(dados["ID"].ToString());
                    DALClientes.CPF = dados["CPF"].ToString();
                    DALClientes.Nome = dados["Nome"].ToString();
                    DALClientes.Endereco = dados["Endereco"].ToString();
                    DALClientes.Telefone = dados["Telefone"].ToString();
                    lstClientes.Add(DALClientes);
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
            return lstClientes;
        }
    }
}
