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
        public FormCadastroEleicao()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            bindingSourceEleicao.EndEdit();
            EleicaoBLL eleicaoBll = new EleicaoBll();

            eleicaoBll.inserir((Eleicao)bindingSourceEleicao.Current);

            Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}


