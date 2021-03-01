
namespace controleDeEstoque
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.tb_senha = new System.Windows.Forms.TextBox();
            this.tb_usuário = new System.Windows.Forms.TextBox();
            this.bt_sair = new System.Windows.Forms.Button();
            this.bt_entrar = new System.Windows.Forms.Button();
            this.lb_usuário = new System.Windows.Forms.Label();
            this.lb_senha = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "label 2 - Versão";
            // 
            // tb_senha
            // 
            this.tb_senha.Location = new System.Drawing.Point(107, 95);
            this.tb_senha.Name = "tb_senha";
            this.tb_senha.PasswordChar = ' ';
            this.tb_senha.Size = new System.Drawing.Size(148, 20);
            this.tb_senha.TabIndex = 1;
            // 
            // tb_usuário
            // 
            this.tb_usuário.Location = new System.Drawing.Point(107, 27);
            this.tb_usuário.Name = "tb_usuário";
            this.tb_usuário.Size = new System.Drawing.Size(148, 20);
            this.tb_usuário.TabIndex = 0;
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(195, 146);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(93, 60);
            this.bt_sair.TabIndex = 3;
            this.bt_sair.Text = "SAIR";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // bt_entrar
            // 
            this.bt_entrar.Location = new System.Drawing.Point(42, 146);
            this.bt_entrar.Name = "bt_entrar";
            this.bt_entrar.Size = new System.Drawing.Size(93, 60);
            this.bt_entrar.TabIndex = 2;
            this.bt_entrar.Text = "ENTRAR";
            this.bt_entrar.UseVisualStyleBackColor = true;
            this.bt_entrar.Click += new System.EventHandler(this.bt_entrar_Click);
            // 
            // lb_usuário
            // 
            this.lb_usuário.AutoSize = true;
            this.lb_usuário.Location = new System.Drawing.Point(39, 30);
            this.lb_usuário.Name = "lb_usuário";
            this.lb_usuário.Size = new System.Drawing.Size(56, 13);
            this.lb_usuário.TabIndex = 4;
            this.lb_usuário.Text = "USUÁRIO";
            // 
            // lb_senha
            // 
            this.lb_senha.AutoSize = true;
            this.lb_senha.Location = new System.Drawing.Point(39, 98);
            this.lb_senha.Name = "lb_senha";
            this.lb_senha.Size = new System.Drawing.Size(44, 13);
            this.lb_senha.TabIndex = 5;
            this.lb_senha.Text = "SENHA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 293);
            this.Controls.Add(this.lb_senha);
            this.Controls.Add(this.lb_usuário);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_senha);
            this.Controls.Add(this.tb_usuário);
            this.Controls.Add(this.bt_sair);
            this.Controls.Add(this.bt_entrar);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CONTROLE DE ESTOQUE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_senha;
        private System.Windows.Forms.TextBox tb_usuário;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.Button bt_entrar;
        private System.Windows.Forms.Label lb_usuário;
        private System.Windows.Forms.Label lb_senha;
    }
}

