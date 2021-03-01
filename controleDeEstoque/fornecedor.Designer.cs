
namespace controleDeEstoque
{
    partial class fornecedor
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
            this.tb_whats = new System.Windows.Forms.TextBox();
            this.tb_empresa = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_nome = new System.Windows.Forms.TextBox();
            this.bt_apagar = new System.Windows.Forms.Button();
            this.bt_alterar = new System.Windows.Forms.Button();
            this.bt_cadastrar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.bt_sair = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.bt_ver_todos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_whats
            // 
            this.tb_whats.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_whats.Location = new System.Drawing.Point(88, 189);
            this.tb_whats.Name = "tb_whats";
            this.tb_whats.Size = new System.Drawing.Size(268, 24);
            this.tb_whats.TabIndex = 3;
            // 
            // tb_empresa
            // 
            this.tb_empresa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_empresa.Location = new System.Drawing.Point(88, 88);
            this.tb_empresa.Name = "tb_empresa";
            this.tb_empresa.Size = new System.Drawing.Size(268, 24);
            this.tb_empresa.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(88, 138);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(268, 24);
            this.tb_email.TabIndex = 2;
            // 
            // tb_nome
            // 
            this.tb_nome.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_nome.Location = new System.Drawing.Point(88, 40);
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
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(27, 276);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(802, 150);
            this.dataGridView2.TabIndex = 9;
            this.dataGridView2.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView2_RowHeaderMouseClick);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "NOME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "EMPRESA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "EMAIL";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "WHATS";
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
            // fornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.bt_ver_todos);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_whats);
            this.Controls.Add(this.tb_empresa);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.tb_nome);
            this.Controls.Add(this.bt_apagar);
            this.Controls.Add(this.bt_alterar);
            this.Controls.Add(this.bt_cadastrar);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.dataGridView2);
            this.Name = "fornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CADASTRO DE FORNECEDOR";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.fornecedor_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_whats;
        private System.Windows.Forms.TextBox tb_empresa;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_nome;
        private System.Windows.Forms.Button bt_apagar;
        private System.Windows.Forms.Button bt_alterar;
        private System.Windows.Forms.Button bt_cadastrar;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button bt_ver_todos;
    }
}