using Models;
using DAL;
using System.Data;
using System.Security.Cryptography;

namespace BLL
{
    public class EleitorBLL
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Titulo { get; set; }
        public object Votou { get; set; }

        public void Inserir(Eleitor _eleitor)
        {
            if (_eleitor.Nome.Length <= 2)
                throw new Exception("O nome do eleitor deve ter mais de 2 caracteres.");

            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Inseir(_eleitor);
        }

        public void Excluir(int _id_eleitor) 
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            eleitorDAL.Excluir(_id_eleitor);
        }

        public void Alterar(Eleitor _eleitor)
        {
            EleitorDAL _eleitorDAL = new EleitorDAL();
            _eleitorDAL.Alterar(_eleitor);
        }

        public DataTable BuscarPorTutulo(string _titulo)
        {
            EleitorDAL eleitorDAL= new EleitorDAL();
            return eleitorDAL.BuscarPorTutulo(_titulo);
        }

        public void inserir(Eleitor _eleitor)
        {
            EleitorDAL _eleitorDAL = new EleitorDAL();
            _eleitorDAL.Inseir(_eleitor);
        }

        public DataTable BuscarPorNome (string _nome)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
             return eleitorDAL.BuscarPorNome (_nome);
        }

        public object BuscarPorId(int _id)
        {
            EleitorDAL eleitorDAL = new EleitorDAL();
            return eleitorDAL.BuscarPorId(_id);
        }

    }
}
