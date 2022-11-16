using Models;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace DAL
{
    public class EleitorDAL
    {
        public void Inseir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();

            try
            {
                cmd.CommandText = "INSERT INTO Eleitor(Titulo, Nome, Votou) VALUES(@Titulo, @Nome, @Votou)";
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Parameters.AddWithValue("@Votou", _eleitor.Votou);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteScalar();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }
        public void Excluir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Id", _eleitor.Id);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }
        public void Alterar(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE Eleitor SET Nome = @Nome, Titulo = @Titulo, Votou = @Votou WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Parameters.AddWithValue("@Votou", _eleitor.Votou);
                cmd.Parameters.AddWithValue("@Id", _eleitor.Id);

                cmd.CommandType = CommandType.Text;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
        }
        }

        private static DataTable BuscarPorTutulo(string _titulo)
        {


            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT Id, Nome, Titulo, Votou FROM Eleitor WHERE Titulo = @Titulo";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Titulo", _titulo);
                cn.Open();
                da.Fill(dt);
                return dt;

            }
            finally
            {
                cn.Close();
            }

        }
    }
}
    
