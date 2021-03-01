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
    public partial class relatório : Form
    {
        public relatório()
        {
            InitializeComponent();
        }

        private void bt_sair_Click(object sender, EventArgs e)
        {
            Cl_variáveis_do_sistema.r_principal.Show();
            this.Hide();
        }

        private void relatório_FormClosing(object sender, FormClosingEventArgs e)
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

        private void bt_maior_menor_preço_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(
                Cl_conexão_banco.select_menor_preço() +
                Environment.NewLine +
                Cl_conexão_banco.select_maior_preço(),
                "RELATÓRIO"
                );
            */

            tb_resultado.Text = Cl_conexão_banco.select_menor_preço() +
                Environment.NewLine +
                Cl_conexão_banco.select_maior_preço();
        }

        private void bt_qt_produtos_por_representante_Click(object sender, EventArgs e)
        {
            Cl_conexão_banco.select_qtd_produto_por_representante();
            tb_resultado.Text = "NOME   QTD" + Environment.NewLine;
            for(int i = 0; i < Cl_variáveis_do_sistema.tt_representantes; i++)
            {
                tb_resultado.Text += Cl_variáveis_do_sistema.nome_representante_relatório[i] +
                    "   " +
                    Cl_variáveis_do_sistema.qtd_produtos_por_representante_relatório[i].ToString() +
                    "   " + Environment.NewLine;
            }
        }

        private void bt_valor_total_estq_Click(object sender, EventArgs e)
        {
            /*MessageBox.Show(
                Cl_conexão_banco.valor_total_estoque(),
                "RELATÓRIO"
                );
            */

            tb_resultado.Text = "VALOR TOTAL DO ESTOQUE" +
                Environment.NewLine +
                Cl_conexão_banco.valor_total_estoque();
        }
    }
}
