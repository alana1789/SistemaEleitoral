namespace Models
{
    public class Eleicao
    {
        private string turno;
        private string ano;
        private int id_eleicao;


        public int Id
        {
            get { return id_eleicao; }
            set { id_eleicao = value; }
        }
        public string Turno
        {
            get { return turno; }
            set { turno = value; }
        }
        public string Ano
        {
            get { return ano; }
            set { ano = value; }
        }
        public Eleicao()
        {

        }
        public Eleicao(string _ano, string _turno, int _id)
        {
            Ano = _ano;
            Turno = _turno;
            Id = _id;
        }
    }
}
