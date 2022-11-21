namespace Models
{
    public class Candidato
    {
        private string nome_candidato;
        private string numero;
        private int id;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Nome_candidato
        {
            get { return nome_candidato; }
            set { nome_candidato = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Candidato()
        {

        }

        public Candidato(string _numero, string _nome_candidato, int _id)
        {
            Numero = _numero;
            Nome_candidato = _nome_candidato;
            Id = _id;
        }
    }
}
