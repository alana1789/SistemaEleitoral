using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class CandidatoBLL
    {
        public void Excluir(int _id_candidato)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Excluir(_id_candidato);
        }

        public void Alterar(Candidato _candidato)
        {
            CandidatoDAL _candidatoDAL = new CandidatoDAL();
            _candidatoDAL.Alterar(_candidato);
        }

        public DataTable BuscarPorNumero(string _numero)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            return candidatoDAL.BuscarPorNumero(_numero);
        }

        public void inserir(Candidato _candidato)
        {
            CandidatoDAL _candidatoDAL = new CandidatoDAL();
            _candidatoDAL.Inseir(_candidato);
        }

        public object BuscarPorNome(string _nome)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            return candidatoDAL.BuscarPorNome(_nome);
        }
        public object BuscarPorId(int _id)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            return candidatoDAL.BuscarPorId(_id);
        }
        
    }
}
