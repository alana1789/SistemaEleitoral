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


    public partial class FormConsultaEleitor : Form
    {
        public FormConsultaEleitor()
        {
            InitializeComponent();
        }

        private void FormConsultaEleitor_Load_1(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTutulo("");
        }
        private void buttonBuscar_Click_1(object sender, EventArgs e)
        {
            EleitorBLL eleitorBLL = new EleitorBLL();

            if(radioButtonTitulo.Checked)
                bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTutulo(textBoxBuscar.Text);
            else if(radioButtonPorNome.Checked)
                bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorNome(textBoxBuscar.Text);
            else
                bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTutulo("");
        }

        private void buttonInserir_Click_1(object sender, EventArgs e)
        {
            using (FormCadastroEleitor frm = new FormCadastroEleitor())
            {
                frm.ShowDialog();
            }
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja mesmo excluir este eleitor?", "Atenção",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;
    
            EleitorBLL eleitorBLL = new EleitorBLL();


            eleitorBLL.Excluir(Convert.ToInt32(((DataRowView)bindingSourceEleitor.Current).Row["ID_ELEITOR"]));


            MessageBox.Show("Registro excluído com sucesso!");
        }

        private void buttonAlterar_Click(object sender, EventArgs e)
        {
            using (FormCadastroEleitor frm = new FormCadastroEleitor(Convert.ToInt32(((DataRowView)bindingSourceEleitor.Current).Row["ID_ELEITOR"])))
            {
                frm.ShowDialog();
            }
            buttonBuscar_Click_1(sender, e);
        }
    }
}

