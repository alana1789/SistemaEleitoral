

using Models;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.CodeAnalysis;

namespace DAL
{
    public class EleicaoDAL
    {
        public void Inseir(Eleicao _eleicao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();

            try
            {
                cmd.CommandText = "INSERT INTO Eleicao(Ano, Turno) VALUES(@Ano, @Turno)";
                cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
                cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
                cmd.CommandType = CommandType.Text;

                cn.Open();
                cmd.BeginExecuteNonQuery();
            }
            finally
            {
                cmd.Connection.Close();
            }
        }

        public void Excluir(int _id_eleicao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleicao WHERE ID_ELEICAO = @ID";
                cmd.Parameters.AddWithValue("@ID", _id_eleicao);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }

        public void Excluir(Eleicao _eleicao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "DELETE FROM Eleicao WHERE ID_ELEICAO = @ID_ELEICAO";
                cmd.Parameters.AddWithValue("@ID_ELEICAO", _eleicao);
                cmd.CommandType = CommandType.Text;
                cn.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
                cn.Close();
            }
        }

        public void Alterar(Eleicao _eleicao)
        {
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            SqlCommand cmd = cn.CreateCommand();
            try
            {
                cmd.CommandText = "UPDATE Eleicao SET Ano = @Ano, Turno = @Turno WHERE ID_ELEICAO = @ID_ELEICAO";
                cmd.Parameters.AddWithValue("@Turno", _eleicao.Turno);
                cmd.Parameters.AddWithValue("@Ano", _eleicao.Ano);
                cmd.Parameters.AddWithValue("@ID_ELEICAO", _eleicao.Id);

                cmd.CommandType = CommandType.Text;
                cmd.Connection.Open();
                cmd.ExecuteNonQuery();
            }
            finally
            {
            }
        }

        public DataTable Buscar(string _ano)
        {


            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlConnection cn = new SqlConnection(Conexao.StringDeConexao);
            try
            {
                da.SelectCommand = cn.CreateCommand();
                da.SelectCommand.CommandText = "SELECT ID_ELEICAO as Id, Ano, Turno FROM Eleicao WHERE Ano LIKE @Ano";
                da.SelectCommand.CommandType = CommandType.Text;
                da.SelectCommand.Parameters.AddWithValue("@Ano", "%" + _ano + "%");
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

