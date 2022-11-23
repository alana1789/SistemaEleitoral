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
    public partial class FormCadastroEleicao : Form
    {
        private int id;

        public static DataRowView Current { get; internal set; }

        public FormCadastroEleicao(int _id = 0)
        {
            InitializeComponent();
            id = _id;
        }

        private void FormCadastroEleição_Load(object sender, EventArgs e)
        {
            if (id == 0)
            {
                Eleicao eleicao = new Eleicao();
                bindingSourceEleicao.DataSource = eleicao;
                bindingSourceEleicao.AddNew();
            }
            else
            {
                EleicaoBLL eleicaoBLL = new EleicaoBLL();
                bindingSourceEleicao.DataSource = eleicaoBLL.BuscarPorId(id);
            }
        }

        private void buttonSalvar2_Click(object sender, EventArgs e)
        {
            EleicaoBLL eleicaoBLL = new EleicaoBLL();
            if (id == 0)
            {
                bindingSourceEleicao.EndEdit();
                eleicaoBLL.Inserir((Eleicao)bindingSourceEleicao.Current);
                MessageBox.Show("Eleicao Cadastrada!");
            }
            else
            {
                Eleicao eleicao = new Eleicao();
                eleicao.Id = id;
                eleicao.Ano = textboxAno2.Text;
                eleicao.Turno = textBoxTurno2.Text;
                eleicaoBLL.Alterar(eleicao);
                MessageBox.Show("Eleicao alterada");
            }
            Close();
        }

        private void buttonCancelar2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
