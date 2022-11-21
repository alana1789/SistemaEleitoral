using BLL;
using Models;

namespace UITerminalWindows
{
    public partial class FormCadastroEleicao : Form
    {
        public FormCadastroEleicao()
        {
            InitializeComponent();
        }

        private void buttonSalvar3_Click(object sender, EventArgs e)
        {
            bindingSourceEleicao.EndEdit();
            EleicaoBLL eleicaoBll = new EleicaoBLL();

            eleicaoBll.inserir((Eleicao)bindingSourceEleicao.Current);

            MessageBox.Show("Eleição salva");
            Close();
        }

        private void buttonCancelar3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormCadastroEleicao_Load(object sender, EventArgs e)
        {
            Eleicao eleicao = new Eleicao();
            bindingSourceEleicao.DataSource = eleicao;
            bindingSourceEleicao.AddNew();
        }
    }
}


