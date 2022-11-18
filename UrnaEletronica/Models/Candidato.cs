namespace Models
{
	public class Candidato
	{
		private int numero;
		private string nome_candidato;
		private int id;


		public int Id
		{
			get { return id; }
			set { id = value; }
		}

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

        public object Nome { get; set; }

        public Candidato()
		{

		}
		public Candidato(int _numero, string _nome_candidato, int _id)
		{
			Numero = _numero;
			Nome_candidato = _nome_candidato;
			Id = _id;
		}
	}
}