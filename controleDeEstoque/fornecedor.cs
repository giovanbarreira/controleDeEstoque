using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace controleDeEstoque
{
    public partial class fornecedor : Form
    {
        public fornecedor()
        {
            InitializeComponent();
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ler_caixas_de_texto())
                {
                    Cl_conexão_banco.insert_fornecedor();
                    limpa_texto();
                }
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }         
        }

        private void bt_alterar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ler_caixas_de_texto())
                {
                    Cl_conexão_banco.update_fornecedor();
                    limpa_texto();
                }
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
        }

        private void bt_apagar_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_variáveis_do_sistema.nome_fornecedor = tb_nome.Text;
                Cl_conexão_banco.delete_fornecedor();
                limpa_texto();
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
        }

        private void bt_ver_todos_Click(object sender, EventArgs e)
        {
            try
            {
                Cl_conexão_banco.select_fornecedor(tb_nome.Text);
                dataGridView2.DataSource = Cl_conexão_banco.dt;
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Cl_variáveis_do_sistema.r_principal.Show();
            this.Hide();
        }

        //LÊ AS 4 CAIXAS DE TEXTO E GARANTE QUE ELAS ESTEJAM PREENCHIDAS NO INSERT E NO UPDATE
        public bool ler_caixas_de_texto()
        {
            if (tb_nome.Text != "" & tb_empresa.Text != "" & tb_email.Text != "" & tb_whats.Text != "")
            {
                Cl_variáveis_do_sistema.nome_fornecedor = tb_nome.Text;
                Cl_variáveis_do_sistema.empresa_fornecedor = tb_empresa.Text;
                Cl_variáveis_do_sistema.email_fornecedor = tb_email.Text;
                Cl_variáveis_do_sistema.whats_fornecedor = tb_whats.Text;
                return true;
            }
            else
            {
                MessageBox.Show("Por Favor, preencher todos os campos.", "AVISO", MessageBoxButtons.OK);
                return false;
            }
        }

        //LIMPA AS TEXTBOXES DEPOIS DE CADASTRAR O DADO
        public void limpa_texto()
        {
            tb_nome.Text = "";
            tb_empresa.Text = "";
            tb_email.Text = "";
            tb_whats.Text = "";
        }

        //BLOQUEAR O BOTÃO DE SAIR ORIGINAL
        //EU PREFERI TRATAR O BOTÃO DE FECHAR NO LUGAR DE BLOQUEAR
        /*private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }*/

        private void fornecedor_FormClosing(object sender, FormClosingEventArgs e)
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

        private void dataGridView2_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_nome.Text = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_empresa.Text = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            tb_email.Text = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();
            tb_whats.Text = dataGridView2.Rows[e.RowIndex].Cells[4].Value.ToString();
        }
    }
}
