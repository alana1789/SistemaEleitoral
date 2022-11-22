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

        public void Excluir(int _id_eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE ID_ELEITOR = @ID_ELEITOR";
                cmd.Parameters.AddWithValue("@ID_ELEITOR", _id_eleitor);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(Eleitor _eleitor)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleitor WHERE ID_ELEITOR = @ID_ELEITOR";
                cmd.Parameters.AddWithValue("@ID_ELEITOR", _eleitor);
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
                cmd.CommandText = "UPDATE Eleitor SET Nome = @Nome, Titulo = @Titulo, Votou = @Votou WHERE ID_ELEITOR = @ID_ELEITOR";
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
                cmd.Parameters.AddWithValue("@Votou", _eleitor.Votou);
                cmd.Parameters.AddWithValue("@ID_ELEITOR", _eleitor.Id);

                cmd.CommandType = CommandType.Text;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
            }
        }

        public  DataTable BuscarPorTutulo(string _titulo)
        {


            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT ID_ELEITOR, Nome, Titulo, Votou FROM Eleitor WHERE Titulo LIKE @Titulo";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Titulo","%" + _titulo + "%");
                cn.Open();
                da.Fill(dt);
                return dt;

            }
            finally
            {
                cn.Close();
            }

        }

        public DataTable BuscarPorNome(string _nome)
        {


            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT ID_ELEITOR, Nome, Titulo, Votou FROM Eleitor WHERE Nome LIKE @Titulo";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Titulo", "%" + _nome + "%");
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
    
