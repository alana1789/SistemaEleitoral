namespace Models
{
    public class Candidato
    {
		private int numero;
		private string nome;

		public int Numero
		{
			get { return numero; }
			set { numero = value; }
		}

		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		public Candidato(int _numero, string _nome)
		{
			Numero = _numero;
			Nome = _nome;
		}
	}
}