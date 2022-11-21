using BLL;
using DAL;
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
    public partial class FormConsultaCandidato : Form
    {


        public FormConsultaCandidato()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            CandidatoBLL candidatoBll = new CandidatoBLL();
            bindingSourceCandidato.DataSource = candidatoBll.BuscarPorNumero(textBoxBuscar2.Text);
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
            CandidatoBLL candidatoBll = new CandidatoBLL();
            bindingSourceCandidato.DataSource = candidatoBll.BuscarPorNumero("");
        }

        private void buttonExcluir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você deseja mesmo excluir este candidato?", "Atenção",
                MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            CandidatoBLL candidatoBll = new CandidatoBLL();


            candidatoBll.Excluir(Convert.ToInt32(((DataRowView)bindingSourceCandidato.Current).Row["ID_CANDIDATO"]));


            MessageBox.Show("Registro excluído com sucesso!");
        }
    }
}
