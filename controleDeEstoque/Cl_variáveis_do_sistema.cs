using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace controleDeEstoque
{
    class Cl_variáveis_do_sistema
    {
        //NÃO DEIXAR O USUÁRIO DIGITAR ASPAS SIMPLES POIS TRAVAM O INSERT EM QUALQUER FORM

        //DA PRÓXIMA VEZ UTILIZAR O NOME DO FORM ANTES DO NOME DA VARIÁVEL
        //PARA MELHORAR A ORGANIZAÇÃO

        //VERSÃO
        public static string versao = "Versão 0.1 \r\naluno@escola.com";

        //VARIÁVEIS DO FORM1 (LOGIN E SENHA)
        public static string nome_form1, senha_form1, nome_banco_form1, senha_banco_form1;

        //VARIÁVEIS DO FORM FORNECEDOR
        public static string nome_fornecedor, empresa_fornecedor, email_fornecedor, whats_fornecedor;

        //VARIÁVEIS DO FORM ESTOQUE
        public static string nome_produto, qtd_produto, preço_produto, cód_fornecedor;
        public static string[] cód_fornecedor_q_vem_do_select, nome_fornecedor_q_vem_do_select;

        //VARIÁVEIS DA FORM RELATÓRIO
        public static string[] nome_representante_relatório;
        public static Int32[] qtd_produtos_por_representante_relatório;
        public static Int32 tt_representantes;

        //CRIAÇÃO DE INSTÂNCIAS DOS FORMS PARA EVITAR OS ERROS DE CRIAÇÃO
        public static principal r_principal = new principal(); //form com acesso a todas as outras
        public static estoque r_estoque = new estoque(); //form para cadastrar produto, extra, etc...
        public static fornecedor r_fornecedor = new fornecedor(); //form para cadastrar fornecedor
        public static relatório r_relatório = new relatório(); //form para cadastrar fornecedor
    }
}
