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
            EleitorBll eleitorBLL = new EleitorBll();
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTutulo("");
        }


        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            EleitorBll eleitorBLL = new EleitorBll();
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTutulo(textBoxBuscar.Text);
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
    
            EleitorBll eleitorBLL = new EleitorBll();


            eleitorBLL.Excluir(Convert.ToInt32(((DataRowView)bindingSourceEleitor.Current).Row["Id"]));


            MessageBox.Show("Registro excluído com sucesso!");
        }

    }
}
