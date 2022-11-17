using BLL;
using Models;

namespace UITerminalWindows
{
    public partial class FormCadastroEleitor : Form
    {
        public FormCadastroEleitor()
        {
            InitializeComponent();
        }
        private void buttonSalvar_Click_1(object sender, EventArgs e)
        {
            bindingSourceEleitor.EndEdit();
            EleitorBLL eleitorBll = new EleitorBll();

            eleitorBll.inserir((Eleitor)bindingSourceEleitor.Current);

            MessageBox.Show("Eleitor salvo");
            Close();
        }


        private void FormCadastroEleitor_Load(object sender, EventArgs e)
        {
            Eleitor eleitor = new Eleitor();
            bindingSourceEleitor.DataSource = eleitor;
            bindingSourceEleitor.AddNew();
        }


    }
}