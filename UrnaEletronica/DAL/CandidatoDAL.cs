using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class CandidatoDAL
    {
        public void Inseir(Candidato _candidato)
        {
            {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlCommand cmd = cn.CreateCommand();

                try
                {
                    cmd.CommandText = "INSERT INTO Candidato(Numero, Nome_candidato) VALUES(@Numero, @Nome_candidato)";
                    cmd.Parameters.AddWithValue("@Numero", _candidato.Numero);
                    cmd.Parameters.AddWithValue("@Nome", _candidato.Nome_candidato);
                    cmd.CommandType = CommandType.Text;

                    cn.Open();
                    cmd.ExecuteScalar();
                }
                finally
                {
                    cmd.Connection.Close();
                }
            }
        }
        public void Excluir(Candidato _candidato)
        {
            {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlCommand cmd = cn.CreateCommand();
                try
                {
                    cmd.CommandText = "DELETE FROM Candidato WHERE Id = @Id";
                    cmd.Parameters.AddWithValue("@Id", _candidato.Id);
                    cmd.CommandType = CommandType.Text;
                    cn.Open();
                    cmd.ExecuteNonQuery();
                }
                finally
                {
                    cn.Close();
                }
            }
        }
        public void Alterar(Candidato _candidato)
        {

        }
        public List<Candidato> Buscar(int _numero)
        {
            return new List<Candidato>();
        }

        public List<Candidato> Buscar(string _numero)
        {
            {

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                try
                {
                    da.SelectCommand = cn.CreateCommand();
                    da.SelectCommand.CommandText = "SELECT Id, nome_candidato, Numero FROM candidato WHERE Numero = @Numero";
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.SelectCommand.Parameters.AddWithValue("@Numero", _numero);
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
}
