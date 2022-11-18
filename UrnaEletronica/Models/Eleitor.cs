namespace Models
{
	public class Eleitor
    {
		private string nome;
		private string titulo;
		private bool votou;
		private int id_eleitor;


		public int Id
		{
			get { return id_eleitor; }
			set { id_eleitor = value; }
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
		
		public Eleitor()
		{

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
