using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace controleDeEstoque
{
    public partial class principal : Form
    {
        public principal()
        {
            InitializeComponent();
        }

        //ESTOQUE - ITEM DO MENU
        private void eSTOQUEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_variáveis_do_sistema.r_estoque.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Estamos terminando de construir seu formulário, tente novamente por favor ...", "Aviso ...");
            }
        }

        //FORNECEDOR - ITEM DO MENU
        private void fORNECEDORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_variáveis_do_sistema.r_fornecedor.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Estamos terminando de construir seu formulário, tente novamente por favor ...", "Aviso ...");
            }
        }

        //SAIR - ITEM DO MENU
        private void sAIRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult d = MessageBox.Show("Deseja realmente sair ?", "AVISO", MessageBoxButtons.YesNo);
            if (d == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else if (d == DialogResult.No)
            {

            }
        }

        private void principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Deseja realmente sair ?", "AVISO", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void rELATÓRIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_variáveis_do_sistema.r_relatório.Show();
                this.Hide();
            }
            catch
            {
                MessageBox.Show("Estamos terminando de construir seu formulário, tente novamente por favor ...", "Aviso ...");
            }
        }
    }
}
