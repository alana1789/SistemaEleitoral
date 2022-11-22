using BLL;
using Models;
namespace UITerminalWindows
{
    public partial class FormCadastroCandidato : Form
    {
        private int id;

        public FormCadastroCandidato(int _id = 0)
        {
            InitializeComponent();
            id = _id;

        }

        private void buttonSalvar1_Click(object sender, EventArgs e)
        {
            {
                CandidatoBLL candidatoBLL = new CandidatoBLL();
                if (id == 0)
                {
                    bindingSourceCandidato.EndEdit();
                    candidatoBLL.inserir((Candidato)bindingSourceCandidato.Current);
                    MessageBox.Show("Candidato Cadastrado!");
                }
                else
                {
                    Candidato candidato = new Candidato();
                    candidato.Id = id;
                    candidato.Nome = textboxNome1.Text;
                    candidato.Numero = textBoxNumero1.Text;
                    candidatoBLL.Alterar(candidato);
                    MessageBox.Show("Candidato alterado");
                }
                Close();
            }

        }
    }
}