namespace Models
{
	public class Eleicao
    {
		private int ano;
		private int turno;
		private List<Candidato> candidatos;
		private List<Eleitor> eleitores;
		private int id_eleicao;
		
		public int Ano
		{
			get { return ano; }
			set { ano = value; }
		}
		public int Turno
		{
			get { return turno; }
			set { turno = value; }
		}
		public List<Candidato> Candidatos
		{
			get { return candidatos; }
			set { candidatos = value; }
		}
		public List<Eleitor> Eleitores
		{
			get { return eleitores; }
			set { eleitores = value; }
		}


		public int Id_Eleicao
		{
			get { return id_eleicao; }
			set { id_eleicao = value; }
		}

	}
}