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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //BOTÃO SAIR
        private void bt_sair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_entrar_Click(object sender, EventArgs e)
        {
            Cl_variáveis_do_sistema.nome_form1 = tb_usuário.Text;
            Cl_variáveis_do_sistema.senha_form1 = tb_senha.Text;
            //PEGAR DO BANCO DE DADOS O NOME E A SENHA a partir do nome digitado na textbox1 E SENHA NA TEXTBOX2
            try
            {
                Cl_conexão_banco.select_form1();
            }
            catch
            {
                MessageBox.Show("O usuário não existe.");
            }

            //TESTAR SE O NOME/SENHA DIGITADOS COINCIDEM COM O BANCO
            if (Cl_variáveis_do_sistema.nome_form1 == Cl_variáveis_do_sistema.nome_banco_form1 & 
                Cl_variáveis_do_sistema.senha_form1 == Cl_variáveis_do_sistema.senha_banco_form1)
            {
                Cl_variáveis_do_sistema.r_principal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //VERSÃO
            label2.Text = Cl_variáveis_do_sistema.versao;

            //VERIFICAR A EXISTÊNCIA DA PASTA 'RELATÓRIOS' E CRIAR SE FALSO
            if (!System.IO.Directory.Exists("Relatórios")) System.IO.Directory.CreateDirectory("Relatórios");
            

            /*try
            {
                System.IO.Directory.Exists("Relatórios");
                endereço = System.IO.File.ReadAllText("endereço.txt");
            }
            catch
            {
                endereço = Microsoft.VisualBasic.Interaction.InputBox(
                    "ENDEREÇO DA PASTA COM PALAVRAS:" +
                    Environment.NewLine + "(PODE DEIXAR EM BRANCO SE QUISER)");

                //SE O USUARIO DIGITAR O ENDEREÇO VAZIO
                if (endereço == "" || endereço == " ")
                    endereço = "palavras";

                endereço = endereço + "\\";

                //CRIA NOVA PASTA PARA RECEBER AS PALAVRAS CADASTRADAS
                System.IO.Directory.CreateDirectory(endereço);
                System.IO.File.WriteAllText("endereço.txt", endereço);
                button1.Enabled = false;
            }
            */
        }
    }
}
/*
* Conteúdo para estudar SQL no access.
* https://docs.microsoft.com/pt-br/office/vba/access/concepts/structured-query-language/create-and-delete-tables-and-indexes-using-access-sql#create-and-delete-tables
*/