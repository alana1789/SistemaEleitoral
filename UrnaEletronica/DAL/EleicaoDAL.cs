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
                    cmd.Parameters.AddWithValue("@ID_ELEIÇÃO", _eleicao.Id_Eleicao);
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
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE Eleicao SET Ano = @Ano, Turno = @Turno WHERE Id = @Id";
                cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
                cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
                cmd.Parameters.AddWithValue("@Id", _eleicao.Id_Eleicao);

                cmd.CommandType = CommandType.Text;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }

        public DataTable Buscar(int _ano, int _turno)
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
    }
}