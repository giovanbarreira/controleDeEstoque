using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace controleDeEstoque
{
    class Cl_conexão_banco
    {
        /*static string conexao =
            @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=C:\Users\giova\Documents\estoque.accdb;
            Jet OLEDB:Database Password=aluno";*/

        static string conexao =
            @"Provider=Microsoft.ACE.OLEDB.12.0;
            Data Source=estoque.accdb;
            Jet OLEDB:Database Password=aluno";

        static System.Data.OleDb.OleDbConnection conex;
        static OleDbCommand comando;
        static string sql;
        static IDataReader reader;

        //USADO NO SELECT
        public static OleDbDataAdapter da;
        public static DataTable dt;

        //LOGIN E SENHA - FORM1  ********************************************************************
        public static void select_form1()
        {
            sql = "SELECT * from tbl_usuário where nome= '" + Cl_variáveis_do_sistema.nome_form1 + "'";
            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.ExecuteNonQuery();
            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cl_variáveis_do_sistema.nome_banco_form1 = reader.GetString(0);
                Cl_variáveis_do_sistema.senha_banco_form1 = reader.GetString(1);
            }
            conex.Close();
        }


        //FORM FORNECEDOR ****************************************************************************
        public static void insert_fornecedor()
        {
            sql = "INSERT INTO [tbl_fornecedor] (nome,empresa,email,whats) " +
                "VALUES ('" +
                Cl_variáveis_do_sistema.nome_fornecedor + "', '" +
                Cl_variáveis_do_sistema.empresa_fornecedor + "', '" +
                Cl_variáveis_do_sistema.email_fornecedor + "', '" +
                Cl_variáveis_do_sistema.whats_fornecedor + "')";
            
            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.ExecuteNonQuery();
            conex.Close();
            MessageBox.Show("Informação cadastrada com sucesso !", "AVISO");
        }

        public static void update_fornecedor()
        {
            sql = "UPDATE tbl_fornecedor SET empresa = '" + Cl_variáveis_do_sistema.empresa_fornecedor + 
                "', email = '" + Cl_variáveis_do_sistema.email_fornecedor + 
                "', whats = '" + Cl_variáveis_do_sistema.whats_fornecedor + 
                "' WHERE nome = '" + Cl_variáveis_do_sistema.nome_fornecedor + "'";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.ExecuteNonQuery();
            conex.Close();
            MessageBox.Show("Informação atualizada com sucesso !", "AVISO");
        }

        public static void delete_fornecedor()
        {
            sql = "DELETE FROM tbl_fornecedor WHERE NOME = '" + Cl_variáveis_do_sistema.nome_fornecedor + "'";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.ExecuteNonQuery();
            conex.Close();
            MessageBox.Show("Informação apagada com sucesso !", "AVISO");
        }

        public static void select_fornecedor(string nome_fornecedor)
        {
            sql = "SELECT * FROM tbl_fornecedor WHERE NOME LIKE '" + nome_fornecedor + "%'";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.CommandType = CommandType.Text;

            //comando.ExecuteNonQuery();
            //conex.Close();
            //MessageBox.Show("Informação apagada com sucesso !", "AVISO");

            da = new OleDbDataAdapter(comando);

            //cria um objeto datatable
            dt = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(dt);

            conex.Close();
        }


        //FORM ESTOQUE ****************************************************************************
        public static void insert_estoque()
        {
            sql = "INSERT INTO [tbl_estoque] (nome,quantidade,preço,Cód_fornecedor) " +
                "VALUES ('" +
                Cl_variáveis_do_sistema.nome_produto + "', '" +
                Cl_variáveis_do_sistema.qtd_produto + "', '" +
                Cl_variáveis_do_sistema.preço_produto + "', '" +
                Cl_variáveis_do_sistema.cód_fornecedor + "')";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.ExecuteNonQuery();
            conex.Close();
            MessageBox.Show("Informação cadastrada com sucesso !", "AVISO");
        }

        public static void update_estoque()
        {
            sql = "UPDATE tbl_estoque SET quantidade = '" + Cl_variáveis_do_sistema.qtd_produto +
                "', preço = '" + Cl_variáveis_do_sistema.preço_produto +
                "', Cód_fornecedor = '" + Cl_variáveis_do_sistema.cód_fornecedor +
                "' WHERE nome = '" + Cl_variáveis_do_sistema.nome_produto + "'";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.ExecuteNonQuery();
            conex.Close();
            MessageBox.Show("Informação atualizada com sucesso !", "AVISO");
        }

        public static void delete_estoque()
        {
            sql = "DELETE FROM tbl_estoque WHERE NOME = '" + Cl_variáveis_do_sistema.nome_produto + "'";
            MessageBox.Show(Cl_variáveis_do_sistema.nome_produto);
            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.ExecuteNonQuery();
            conex.Close();
            MessageBox.Show("Informação apagada com sucesso !", "AVISO");
        }

        public static void select_estoque(string nome_produto)
        {
            //sql = "SELECT * FROM tbl_estoque WHERE NOME LIKE '" + nome_produto + "%'";
            /*sql = "SELECT " +
                "tbl_estoque.nome, tbl_estoque.quantidade, tbl_estoque.preço, tbl_fornecedor.nome " +
                "FROM tbl_estoque " +
                "INNER JOIN tbl_fornecedor ON tbl_estoque.Cód_fornecedor = tbl_fornecedor.Código";
            */
            sql = "SELECT " +
                "tbl_estoque.nome AS NOME, " +
                "tbl_estoque.quantidade AS QUANTIDADE, " +
                "tbl_estoque.preço AS PREÇO, " +
                "tbl_fornecedor.nome AS REPRESENTANTE " +
                "FROM tbl_estoque " +
                "INNER JOIN tbl_fornecedor ON tbl_estoque.Cód_fornecedor = tbl_fornecedor.Código";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.CommandType = CommandType.Text;

            //comando.ExecuteNonQuery();
            //conex.Close();
            //MessageBox.Show("Informação apagada com sucesso !", "AVISO");

            da = new OleDbDataAdapter(comando);

            //cria um objeto datatable
            dt = new DataTable();

            //preenche o datatable via dataadapter
            da.Fill(dt);

            conex.Close();
        }

        //ESTE SELECT PREENCHE A COMBOBOX DO FORM ESTOQUE
        public static void select_fornecedor_form_estoque()
        {
            Int32 Cód_fornecedor = 0;
            string nome_fornecedor = "";
            Int32 cont = 0;

            sql = "SELECT * FROM tbl_fornecedor";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                Cód_fornecedor = reader.GetInt32(0);
                nome_fornecedor = reader.GetString(1);
                Cl_variáveis_do_sistema.cód_fornecedor_q_vem_do_select[cont] = Cód_fornecedor.ToString();
                Cl_variáveis_do_sistema.nome_fornecedor_q_vem_do_select[cont] = nome_fornecedor;
                cont++;
            }

            conex.Close();
            //MessageBox.Show("Informação apagada com sucesso !", "AVISO");

        }

        public static Int32 contar_fornecedor_form_estoque()
        {
            Int32 temp = 0;
            sql = "SELECT COUNT(nome) FROM tbl_fornecedor";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

            IDataReader reader = comando.ExecuteReader();
            while (reader.Read())
            {
                temp = reader.GetInt32(0);
            }

            conex.Close();
            return temp;
        }


        //FORM RELATÓRIO ****************************************************************************
        public static string select_menor_preço()
        {
            string preço_mínimo = "";
            sql = "SELECT " +
                "tbl_estoque.Código AS CÓDIGO, " +
                "tbl_estoque.nome AS NOME, " +
                "tbl_estoque.quantidade AS QUANTIDADE, " +
                "tbl_estoque.preço AS PREÇO, " +
                "tbl_fornecedor.nome AS REPRESENTANTE " +
                "FROM tbl_estoque " +
                "INNER JOIN tbl_fornecedor ON tbl_estoque.Cód_fornecedor = tbl_fornecedor.Código " +
                "WHERE preço = (SELECT MIN(preço) FROM tbl_estoque)";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                preço_mínimo = "PREÇO MÍNIMO: " + Environment.NewLine +
                    "Código: " + reader.GetValue(0) + Environment.NewLine +
                    "Nome: " + reader.GetString(1) + Environment.NewLine +
                    "Quantidade: " + reader.GetValue(2) + Environment.NewLine +
                    "Preço: R$ " + String.Format("{0:.00}", reader.GetValue(3)) + Environment.NewLine +
                    "Representante: " + reader.GetString(4) + Environment.NewLine; 
            }
            
            conex.Close();
            return preço_mínimo;
        }

        public static string select_maior_preço()
        {
            string preço_máximo = "";
            sql = "SELECT " +
                "tbl_estoque.Código AS CÓDIGO, " +
                "tbl_estoque.nome AS NOME, " +
                "tbl_estoque.quantidade AS QUANTIDADE, " +
                "tbl_estoque.preço AS PREÇO, " +
                "tbl_fornecedor.nome AS REPRESENTANTE " +
                "FROM tbl_estoque " +
                "INNER JOIN tbl_fornecedor ON tbl_estoque.Cód_fornecedor = tbl_fornecedor.Código " +
                "WHERE preço = (SELECT MAX(preço) FROM tbl_estoque)";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                preço_máximo = "PREÇO MÁXIMO: " + Environment.NewLine +
                    "Código: " + reader.GetInt32(0).ToString() + Environment.NewLine +
                    "Nome: " + reader.GetString(1) + Environment.NewLine +
                    "Quantidade: " + reader.GetString(2) + Environment.NewLine +
                    "Preço: R$ " + String.Format("{0:.00}", reader.GetValue(3)) + Environment.NewLine +
                    "Representante: " + reader.GetString(4) + Environment.NewLine;
            }

            conex.Close();
            return preço_máximo;
        }

        public static void select_qtd_produto_por_representante()
        {
            Cl_variáveis_do_sistema.tt_representantes = 0;
            Int32 cont = 0;

            sql = "SELECT COUNT(nome) FROM tbl_fornecedor";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

            reader = comando.ExecuteReader();

            
            while (reader.Read())
            {
                Cl_variáveis_do_sistema.tt_representantes = reader.GetInt32(0);
            }

            conex.Close();
            Cl_variáveis_do_sistema.qtd_produtos_por_representante_relatório = new Int32[Cl_variáveis_do_sistema.tt_representantes];
            Cl_variáveis_do_sistema.nome_representante_relatório = new string[Cl_variáveis_do_sistema.tt_representantes];

            sql = "SELECT " +
                "COUNT(tbl_estoque.nome) AS QTD, " +
                "tbl_fornecedor.nome AS REPRESENTANTE " +
                "FROM tbl_estoque " +
                "INNER JOIN tbl_fornecedor ON tbl_estoque.Cód_fornecedor = tbl_fornecedor.Código " +
                "GROUP BY tbl_fornecedor.nome";
            
            /*sql = "SELECT " +
                "COUNT(nome) AS QTD " +
                "FROM tbl_estoque " +
                "GROUP BY Cód_fornecedor";*/

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

            reader = comando.ExecuteReader();

            while (reader.Read())
            {
                Cl_variáveis_do_sistema.qtd_produtos_por_representante_relatório[cont] =
                    reader.GetInt32(0);
                Cl_variáveis_do_sistema.nome_representante_relatório[cont] = 
                    reader.GetString(1);
                cont++;
            }

            conex.Close();
        }

        public static string valor_total_estoque()
        {
            string valor_estoque = "";
            sql = "SELECT SUM(quantidade * preço) FROM tbl_estoque;";

            conex = new System.Data.OleDb.OleDbConnection(conexao);
            conex.Open();
            comando = new OleDbCommand(sql, conex);
            comando.CommandType = CommandType.Text;

            comando.ExecuteNonQuery();

            reader = comando.ExecuteReader();
            while (reader.Read())
            {
                valor_estoque = "R$ " + String.Format("{0:.00}", reader.GetValue(0));
            }

            conex.Close();
            return valor_estoque;
        }
    }
}
