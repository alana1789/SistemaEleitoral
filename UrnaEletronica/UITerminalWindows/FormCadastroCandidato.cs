using BLL;
using Models;
namespace UITerminalWindows
{
    public partial class FormCadastroCandidato : Form
    {
        public FormCadastroCandidato()
        {
            InitializeComponent();
        }

        private void buttonSalvar1_Click(object sender, EventArgs e)
        {
            bindingSourceCandidato.EndEdit();
            CandidatoBLL candidatoBll = new CandidatoBll();

            candidatoBll.inserir((Candidato)bindingSourceCandidato.Current);

            MessageBox.Show("Candidato salvo");
            Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxTitulo_TextChanged(object sender, EventArgs e)
        {

        }

        private void textboxNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void CadastroCandidato_Load(object sender, EventArgs e)
        {

        }


        private void buttonCancelar1_Click(object sender, EventArgs e)
        {

        }
    }

}
