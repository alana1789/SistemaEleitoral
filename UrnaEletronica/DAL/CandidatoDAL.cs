using Models;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace DAL
{
    public class CandidatoDAL
    {
        public void Inseir(Candidato _candidato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();

            try
            {
                cmd.CommandText = "INSERT INTO Candidato(Numero, Nome_candidato) VALUES(@Numero, @Nome_candidato)";
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Parameters.AddWithValue("@Nome_candidato", _candidato.Nome_candidato);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.BeginExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public void Excluir(int _id_candidato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Candidato WHERE ID_CANDIDATO = @ID";
                cmd.Parameters.AddWithValue("@ID_CANDIDATO", _id_candidato);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(Candidato _candidato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Candidato WHERE ID_CANDIDATO = @ID_CANDIDATO";
                cmd.Parameters.AddWithValue("@ID_CANDIDATO", _candidato);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Candidato _candidato)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE Candidato SET Nome_candidato = @Nome_candidato, Numero = @Numero WHERE ID_CANDIDATO = @ID_CANDIDATO";
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Parameters.AddWithValue("@Nome_candidato", _candidato.Nome_candidato);
                cmd.Parameters.AddWithValue("@ID_CANDIDATO", _candidato.Id);

                cmd.CommandType = CommandType.Text;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
            }
        }

        public DataTable BuscarPorNumero(string _numero)
        {


            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT ID_CANDIDATO as Id, Nome_candidato, Numero FROM Candidato WHERE Numero LIKE @Numero";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Numero", "%" + _numero + "%");
                cn.Open();
                da.Fill(dt);
                return dt;

            }
            finally
            {
                cn.Close();
            }
        }
        public DataTable BuscarPorNome(string _nome_candidato)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT ID_CANDIDATO, Nome_candidato, Numero FROM Candidato WHERE Nome LIKE @Numero";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Numero", "%" + _nome_candidato + "%");
                cn.Open();
                da.Fill(dt);
                return dt;
                
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable BuscarPorId(int _id_candidato)
        {
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT ID_CANDIDATO, Numero FROM Candidato WHERE ID_CANDIDATO = @ID_CANDIDATO";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@ID_CANDIDATO", _id_candidato);
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


