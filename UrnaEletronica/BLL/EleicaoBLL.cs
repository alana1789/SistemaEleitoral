using DAL;
using Models;

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
        public List<Eleicao> Buscar(string _turno)
        {
            EleicaoDAL _eleicaoDAL = new EleicaoDAL();
            return _eleicaoDAL.Buscar(_turno);
        }

        public void inserir(Eleicao current)
        {
            throw new NotImplementedException();
        }
    }
}


