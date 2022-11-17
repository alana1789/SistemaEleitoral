using DAL;
using Models;
using System.Data;

namespace BLL
{
    public class EleicaoBLL
    {

        public void Inserir(Eleicao _eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Inseir(_eleicao);
        }
        public void Excluir(Eleicao _eleicao)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Excluir(_eleicao);
        }
        public void Alterar(Eleicao _eleicao)
        {
            EleicaoDAL _eleicaoDAL = new EleicaoDAL();
            _eleicaoDAL.Alterar(_eleicao);
        }
        public DataTable Buscar(int _ano, int _turno)
        {
            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            return eleicaoDAL.Buscar(_ano, _turno);
        }

        public void inserir(Eleicao current)
        {
            throw new NotImplementedException();
        }
    }
}


