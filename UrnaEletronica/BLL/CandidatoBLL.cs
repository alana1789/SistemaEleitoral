using Models;
using DAL;
using System.Data;

namespace BLL
{
    public class CandidatoBLL
    {
        public void Inserir(Candidato _candidato)
        {
            if (_candidato.Nome.Length <= 2)
                throw new Exception("O nome do candidato deve ter mais de 2 caracteres.");

            CandidatoDAL candidatoDAL = new CandidatoDAL();
            candidatoDAL.Inseir(_candidato);
        }

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

        public DataTable Buscar(string _numero)
        {
            CandidatoDAL candidatoDAL = new CandidatoDAL();
            return candidatoDAL.Buscar(_numero);
        }

        public void inserir(Candidato _candidato)
        {
            CandidatoDAL _candidatoDAL = new CandidatoDAL();
            _candidatoDAL.Inseir(_candidato);
        }

    }
}
