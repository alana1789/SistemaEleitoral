using Models;
using System.Data.SqlClient;
using System.Data;

namespace DAL
{
    public class EleicaoDAL
    {
        public void Inseir(Eleicao _eleicao)
        {
            {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlCommand cmd = cn.CreateCommand();

                try
                {
                    cmd.CommandText = "INSERT INTO Eleicao(ano, turno) VALUES(@ano, @turno)";
                    cmd.Parameters.AddWithValue("@ano", _eleicao.Ano);
                    cmd.Parameters.AddWithValue("@turno", _eleicao.Turno);
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
        public void Excluir(Eleicao _eleicao)
        {
            {
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                SqlCommand cmd = cn.CreateCommand();
                try
                {
                    cmd.CommandText = "DELETE FROM Eleicao WHERE ID_ELEIÇÃO = @ID_ELEIÇÃO";
                    cmd.Parameters.AddWithValue("@ID_ELEIÇÃO", _eleicao.ID_ELEIÇÃO);
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
        public void Alterar(Eleicao _eleicao)
        {
     
        }
        public List<Eleicao> Buscar(int _ano, int _turno)
        {
            {

                SqlDataAdapter da = new SqlDataAdapter();
                DataTable dt = new DataTable();
                SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
                try
                {
                    da.SelectCommand = cn.CreateCommand();
                    da.SelectCommand.CommandText = "SELECT ID_ELEIÇÃO, ano, turno FROM eleição WHERE turno = @turno";
                    da.SelectCommand.CommandType = CommandType.Text;
                    da.SelectCommand.Parameters.AddWithValue("@Turno", _turno);
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

        public List<Eleicao> Buscar(string titulo)
        {
            throw new NotImplementedException();
        }
    }
}