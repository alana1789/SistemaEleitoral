using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UITerminalWindows
{
    public partial class FormConsultaEleicão : Form
    {


        public FormConsultaEleicão()
        {
            InitializeComponent();
        }

        private void buttonInserir1_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleicao frm = new FormCadastroEleicao())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir1_Click(object sender, EventArgs e)
        {
            {
                if (MessageBox.Show("Você deseja mesmo excluir esta eleição?", "Atenção",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                    return;

                EleicaoBLL eleicaoBll = new EleicaoBLL();


                eleicaoBll.Excluir(Convert.ToInt32(((DataRowView)bindingSourceEleicao.Current).Row["ID_ELEICAO"]));


                MessageBox.Show("Registro excluído com sucesso!");
            }
        }

        private void buttonBuscar1_Click(object sender, EventArgs e)
        {
            EleicaoBLL eleicaoBll = new EleicaoBLL();
            bindingSourceEleicao.DataSource = eleicaoBll.Buscar(textBoxBuscar1.Text);
        }

        private void FormConsultaEleicão_Load(object sender, EventArgs e)
        {
            EleicaoBLL eleicaoBll = new EleicaoBLL();
            bindingSourceEleicao.DataSource = eleicaoBll.Buscar("");
        }
    }
}