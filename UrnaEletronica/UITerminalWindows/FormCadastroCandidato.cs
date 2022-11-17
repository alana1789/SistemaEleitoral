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


        private void CadastroCandidato_Load(object sender, EventArgs e)
        {
            Candidato candidato = new Candidato();
            bindingSourceCandidato.DataSource = candidato;
            bindingSourceCandidato.AddNew();
        }


        private void buttonCancelar1_Click(object sender, EventArgs e)
        {
            Close();
        }
        

    }


}