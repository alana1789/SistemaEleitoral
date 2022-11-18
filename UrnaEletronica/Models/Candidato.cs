namespace Models
{
    public class Candidato
    {
        private string nome;
        private string numero;
        private int id_candidato;


        public int Id
        {
            get { return id_candidato; }
            set { id_candidato = value; }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }
        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public Candidato()
        {

        }

        public Candidato(string _numero, string _nome, int _id)
        {
            Numero = _numero;
            Nome = _nome;
            Id = _id;
        }
    }
}
