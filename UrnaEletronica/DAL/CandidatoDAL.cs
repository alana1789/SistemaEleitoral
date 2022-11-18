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
                cmd.CommandText = "INSERT INTO Candidato(Numero, Nome) VALUES(@Numero, @Nome)";
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Parameters.AddWithValue("@Nome", _candidato.Nome);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.ExecuteScalar();
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
                cmd.CommandText = "DELETE FROM Candidato WHERE ID_CANDIDATO = @ID_CANDIDATO";
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
                cmd.CommandText = "UPDATE Candidato SET Nome = @Nome, Numero = @Numero WHERE ID_CANDIDATO = @ID_CANDIDATO ";
                cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                cmd.Parameters.AddWithValue("@Nome", _candidato.Nome);
                cmd.Parameters.AddWithValue("@ID_CANDIDATO", _candidato.Id);

                cmd.CommandType = CommandType.Text;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
            }
        }

        public DataTable Busca(string _numero)
        {


            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT ID_CANDIDATO, Nome, Numero FROM Candidato WHERE Numero LIKE @Numero";
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

        public DataTable Buscar(string numero)
        {
            throw new NotImplementedException();
        }
    }
}

