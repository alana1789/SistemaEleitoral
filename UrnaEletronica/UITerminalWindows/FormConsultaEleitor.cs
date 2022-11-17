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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormConsultaEleitor_Load(object sender, EventArgs e)
        {
           EleitorBll eleitorBLL = new EleitorBll();
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTitulo("");
        }

        private void textBoxBuscar_TextChanged(object sender, EventArgs e)
        {
            EleitorBll eleitorBLL = new EleitorBll();
            bindingSourceEleitor.DataSource = eleitorBLL.BuscarPorTitulo(textBoxBuscar.Text);
        }
    }
}
