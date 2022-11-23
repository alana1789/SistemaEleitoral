using BLL;
using Models;
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
    public partial class FormConsultaEleição : Form
    {
        public FormConsultaEleição()
        {
            InitializeComponent();
        }

        private void FormConsultaEleição_Load(object sender, EventArgs e)
        {
            EleicaoBLL eleicaoBLL = new EleicaoBLL();
            bindingSourceEleicao.DataSource = eleicaoBLL.BuscarPorAno("");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EleicaoBLL eleicaoBLL = new EleicaoBLL();

            if (radioButtonTitulo.Checked)
                bindingSourceEleicao.DataSource = eleicaoBLL.BuscarPorAno(textBoxBuscar.Text);
            else if (radioButtonPorNome.Checked)
                bindingSourceEleicao.DataSource = eleicaoBLL.BuscarPorTurno(textBoxBuscar.Text);
            else
                bindingSourceEleicao.DataSource = eleicaoBLL.BuscarPorAno("");
        }

        private void buttonInserir_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleicao frm = new FormCadastroEleicao())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja mesmo excluir esta eleição?", "Atenção",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            EleicaoBLL eleicaoBLL = new EleicaoBLL();


            eleicaoBLL.Excluir(Convert.ToInt32(((DataRowView)bindingSourceEleicao.Current).Row["ID_ELEICAO"]));


            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleicao frm = new FormCadastroEleicao(Convert.ToInt32(((DataRowView)FormCadastroEleicao.Current).Row["ID_ELEICAO"])))
            {
                frm.ShowDialog();
            }
        }
    }
}
