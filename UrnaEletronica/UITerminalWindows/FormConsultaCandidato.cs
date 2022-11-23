using BLL;
using System.Data;

namespace UITerminalWindows
{
    public partial class FormConsultaCandidato : Form
    {


        public FormConsultaCandidato()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            CandidatoBLL candidatoBLL = new CandidatoBLL();

            if (radioButtonNumero.Checked)
                bindingSourceCandidato.DataSource = candidatoBLL.BuscarPorNumero(textBoxBuscar2.Text);
            else if (radioButtonNome.Checked)
                bindingSourceCandidato.DataSource = candidatoBLL.BuscarPorNome(textBoxBuscar2.Text);
            else
                bindingSourceCandidato.DataSource = candidatoBLL.BuscarPorNumero("");
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroCandidato frm = new FormCadastroCandidato())
            {
                frm.ShowDialog();
            }
        }

        private void FormConsultaCandidato_Load(object sender, EventArgs e)
        {
            CandidatoBLL candidatoBLL = new CandidatoBLL();
            bindingSourceCandidato.DataSource = candidatoBLL.BuscarPorNumero("");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja mesmo excluir este candidato?", "Atenção",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            CandidatoBLL candidatoBLL = new CandidatoBLL();
            candidatoBLL.Excluir(Convert.ToInt32(((DataRowView)bindingSourceCandidato.Current).Row["Id"]));
            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroCandidato frm = new FormCadastroCandidato(Convert.ToInt32(((DataRowView)bindingSourceCandidato.Current).Row["ID_CANDIDATO"])))
            {
                frm.ShowDialog();
            }
        }

    }
}
