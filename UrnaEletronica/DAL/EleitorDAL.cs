using Models;
using System.Data;
using System.Data.SqlClient;

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
                cmd.CommandText = "INSERT INTO Eleitor(Titulo, Nome) VALUES(@Titulo, @Nome)";
                cmd.Parameters.AddWithValue("@Titulo", _eleitor.Titulo);
                cmd.Parameters.AddWithValue("@Nome", _eleitor.Nome);
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
           
        }
        public List<Eleitor> Buscar(string _titulo)
        {
            throw new NotImplementedException();
        }
    }
}