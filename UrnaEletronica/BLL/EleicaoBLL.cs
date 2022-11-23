using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class EleicaoBLL
    {
        public int Id { get; set; }
        public string Ano { get; set; }
        public string Turno { get; set; }

        public void Excluir(int _id_eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Excluir(_id_eleicao);
        }

        public void Alterar(Eleicao _eleicao)
        {
            EleicaoDAL eleicaorDAL = new EleicaoDAL();
            eleicaorDAL.Alterar(_eleicao);
        }

        public DataTable Buscar(string _ano)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.Buscar(_ano);
        }

        public void inserir(Eleicao _eleicao)
        {
            EleicaoDAL eleicaorDAL = new EleicaoDAL();
            eleicaorDAL.Inseir(_eleicao);
        }

        public DataTable BuscarPorAno(string _ano)
        {
            EleicaoDAL eleicaorDAL = new EleicaoDAL();
            return eleicaorDAL.BuscarPorAno(_ano);
        }

        public DataTable BuscarPorTurno(string _turno)
        {
            EleicaoDAL eleicaorDAL = new EleicaoDAL();
            return eleicaorDAL.BuscarPorTurno(_turno);
        }

        public DataTable BuscarPorId(int _id)
        {
            EleicaoDAL eleicaorDAL = new EleicaoDAL();
            return eleicaorDAL.BuscarPorId(_id);
        }

        public void Inserir(Eleicao current)
        {
            throw new NotImplementedException();
        }
    }
}
