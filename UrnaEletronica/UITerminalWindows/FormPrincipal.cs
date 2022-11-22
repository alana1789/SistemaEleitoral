﻿using System;
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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void eleitorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaEleitor frm = new FormConsultaEleitor())
            {
                frm.ShowDialog();
            }
        }

        private void candidatoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaCandidato frm = new FormConsultaCandidato())
            {
                frm.ShowDialog();
            }
        }

        private void eleiçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FormConsultaEleiçãocs frm = new FormConsultaEleiçãocs())
            {
                frm.ShowDialog();
            }
        }
    }
}
