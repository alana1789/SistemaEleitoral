namespace Models
{
    public class Candidato
    {
		private int numero;
		private string nome_candidato;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		public string Nome_candidato
		{
			get { return nome_candidato; }
			set { nome_candidato = value; }
		}

        public object Id { get; set; }

		public Candidato(int _numero, string _nome_candidato)
		{
			Numero = _numero;
			Nome_candidato = _nome_candidato;
		}
	}
}