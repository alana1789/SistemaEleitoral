using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class EleicaoBLL
    {
        private object _eleicaoDAL;

        public void Inserir(Eleicao _eleicao)
        {

            EleicaoDAL eleicaoDAL = new EleicaoDAL();
            eleicaoDAL.Inseir(_eleicao);
        }

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
    }
}
