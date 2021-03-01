using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace controleDeEstoque
{
    public partial class estoque : Form
    {
        public estoque()
        {
            InitializeComponent();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Cl_variáveis_do_sistema.r_principal.Show();
            this.Hide();
        }

        private void estoque_Load(object sender, EventArgs e)
        {
            Int32 número_de_fornecedores_cadastrados = Cl_conexão_banco.contar_fornecedor_form_estoque();
            Cl_variáveis_do_sistema.cód_fornecedor_q_vem_do_select = 
                new string[número_de_fornecedores_cadastrados];
            Cl_variáveis_do_sistema.nome_fornecedor_q_vem_do_select =
                new string[número_de_fornecedores_cadastrados];
            
            Cl_conexão_banco.select_fornecedor_form_estoque();

            for(int i = 0; i < número_de_fornecedores_cadastrados; i++)
            {
                this.cb_cód_fornecedor.Items.Add(Cl_variáveis_do_sistema.nome_fornecedor_q_vem_do_select[i]);
            }
        }

        private void bt_cadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (ler_caixas_de_texto())
                {
                    Cl_conexão_banco.insert_estoque();
                    limpa_texto();
                }
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
                Cl_conexão_banco.select_estoque(tb_nome.Text);
                
                dgv_todos_campos.DataSource = Cl_conexão_banco.dt;
                dgv_todos_campos.Columns[2].DefaultCellStyle.BackColor = Color.LightGreen;
                dgv_todos_campos.Columns[2].DefaultCellStyle.Format = "c"; //FORMATOU A COLUNA PARA MOEDA
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
                    Cl_conexão_banco.update_estoque();
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
                Cl_variáveis_do_sistema.nome_produto = tb_nome.Text;
                Cl_conexão_banco.delete_estoque();
                limpa_texto();
            }
            catch
            {
                MessageBox.Show("Algo deu errado!");
            }
        }

        //LÊ AS 4 CAIXAS DE TEXTO E GARANTE QUE ELAS ESTEJAM PREENCHIDAS NO INSERT E NO UPDATE
        public bool ler_caixas_de_texto()
        {
            if (tb_nome.Text != "" & tb_quantidade.Text != "" & tb_preço.Text != "" & cb_cód_fornecedor.Text != "")
            {
                Cl_variáveis_do_sistema.nome_produto = tb_nome.Text;
                Cl_variáveis_do_sistema.qtd_produto = tb_quantidade.Text;
                Cl_variáveis_do_sistema.preço_produto = tb_preço.Text;
                //PEGA O NOME DO FORNECEDOR NA COMBOBOX E TRANSFORMA NO CÓDIGO DO FORNECEDOR
                Cl_variáveis_do_sistema.cód_fornecedor = Cl_variáveis_do_sistema.cód_fornecedor_q_vem_do_select[
                    Array.IndexOf(Cl_variáveis_do_sistema.nome_fornecedor_q_vem_do_select, cb_cód_fornecedor.Text)];
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
            tb_quantidade.Text = "";
            tb_preço.Text = "";
            cb_cód_fornecedor.Text = "";
        }

        private void dgv_todos_campos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            tb_nome.Text = dgv_todos_campos.Rows[e.RowIndex].Cells[0].Value.ToString();
            tb_quantidade.Text = dgv_todos_campos.Rows[e.RowIndex].Cells[1].Value.ToString();
            tb_preço.Text = dgv_todos_campos.Rows[e.RowIndex].Cells[2].Value.ToString();
            cb_cód_fornecedor.Text = dgv_todos_campos.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void estoque_FormClosing(object sender, FormClosingEventArgs e)
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
    }
}
