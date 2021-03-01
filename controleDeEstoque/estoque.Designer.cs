
namespace controleDeEstoque
{
    partial class estoque
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bt_ver_todos = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_quantidade = new System.Windows.Forms.TextBox();
            this.tb_preço = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.bt_apagar = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.dgv_todos_campos = new System.Windows.Forms.DataGridView();
            this.cb_cód_fornecedor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todos_campos)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_ver_todos
            // 
            this.bt_ver_todos.Location = new System.Drawing.Point(728, 165);
            this.bt_ver_todos.Name = "bt_ver_todos";
            this.bt_ver_todos.Size = new System.Drawing.Size(101, 75);
            this.bt_ver_todos.TabIndex = 7;
            this.bt_ver_todos.Text = "VER TODOS";
            this.bt_ver_todos.UseVisualStyleBackColor = true;
            this.bt_ver_todos.Click += new System.EventHandler(this.bt_ver_todos_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "CÓD. FORNECEDOR";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "PREÇO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "QUANTIDADE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOME";
            // 
            // tb_quantidade
            // 
            this.tb_quantidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_quantidade.Location = new System.Drawing.Point(113, 88);
            this.tb_quantidade.Name = "tb_quantidade";
            this.tb_quantidade.Size = new System.Drawing.Size(268, 24);
            this.tb_quantidade.TabIndex = 1;
            // 
            // tb_preço
            // 
            this.tb_preço.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_preço.Location = new System.Drawing.Point(113, 138);
            this.tb_preço.Name = "tb_preço";
            this.tb_preço.Size = new System.Drawing.Size(268, 24);
            this.tb_preço.TabIndex = 2;
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(113, 40);
            this.tb_nome.Name = "tb_nome";
            this.tb_nome.Size = new System.Drawing.Size(268, 24);
            this.tb_nome.TabIndex = 0;
            // 
            // bt_apagar
            // 
            this.bt_apagar.Location = new System.Drawing.Point(621, 165);
            this.bt_apagar.Name = "bt_apagar";
            this.bt_apagar.Size = new System.Drawing.Size(101, 75);
            this.bt_apagar.TabIndex = 6;
            this.bt_apagar.Text = "APAGAR";
            this.bt_apagar.UseVisualStyleBackColor = true;
            this.bt_apagar.Click += new System.EventHandler(this.bt_apagar_Click);
            // 
            // bt_alterar
            // 
            this.bt_alterar.Location = new System.Drawing.Point(514, 165);
            this.bt_alterar.Name = "bt_alterar";
            this.bt_alterar.Size = new System.Drawing.Size(101, 75);
            this.bt_alterar.TabIndex = 5;
            this.bt_alterar.Text = "ALTERAR";
            this.bt_alterar.UseVisualStyleBackColor = true;
            this.bt_alterar.Click += new System.EventHandler(this.bt_alterar_Click);
            // 
            // bt_cadastrar
            // 
            this.bt_cadastrar.Location = new System.Drawing.Point(407, 165);
            this.bt_cadastrar.Name = "bt_cadastrar";
            this.bt_cadastrar.Size = new System.Drawing.Size(101, 75);
            this.bt_cadastrar.TabIndex = 4;
            this.bt_cadastrar.Text = "CADASTRAR";
            this.bt_cadastrar.UseVisualStyleBackColor = true;
            this.bt_cadastrar.Click += new System.EventHandler(this.bt_cadastrar_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(728, 33);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(101, 75);
            this.bt_sair.TabIndex = 8;
            this.bt_sair.Text = "VOLTAR";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // dgv_todos_campos
            // 
            this.dgv_todos_campos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_todos_campos.Location = new System.Drawing.Point(27, 276);
            this.dgv_todos_campos.Name = "dgv_todos_campos";
            this.dgv_todos_campos.Size = new System.Drawing.Size(802, 150);
            this.dgv_todos_campos.TabIndex = 9;
            this.dgv_todos_campos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgv_todos_campos_RowHeaderMouseClick);
            // 
            // cb_cód_fornecedor
            // 
            this.cb_cód_fornecedor.FormattingEnabled = true;
            this.cb_cód_fornecedor.Location = new System.Drawing.Point(169, 188);
            this.cb_cód_fornecedor.Name = "cb_cód_fornecedor";
            this.cb_cód_fornecedor.Size = new System.Drawing.Size(212, 21);
            this.cb_cód_fornecedor.TabIndex = 3;
            // 
            // estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.cb_cód_fornecedor);
            this.Controls.Add(this.bt_ver_todos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_quantidade);
            this.Controls.Add(this.tb_preço);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.bt_apagar);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.dgv_todos_campos);
            this.Name = "estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE ESTOQUE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.estoque_FormClosing);
            this.Load += new System.EventHandler(this.estoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_todos_campos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ver_todos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_quantidade;
        private System.Windows.Forms.TextBox tb_preço;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button bt_apagar;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.DataGridView dgv_todos_campos;
        private System.Windows.Forms.ComboBox cb_cód_fornecedor;
    }
}