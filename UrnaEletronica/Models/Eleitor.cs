namespace Models
{
	public class Eleitor
    {
		private string nome;
		private string titulo;
		private bool votou;
		private int id;


		public int Id
		{
			get { return id; }
			set { id = value; }
		}
		public string Nome
		{
			get { return nome; }
			set { nome = value; }
		}
		public string Titulo
		{
			get { return titulo; }
			set { titulo = value; }
		}
		public bool Votou
		{
			get { return votou; }
			set { votou = value; }
		}
		public Eleitor(string _titulo, string _nome, int _id)
		{
			Titulo = _titulo;
			Nome = _nome;
			Id = _id;
			Votou = false;
		}
	}
}
