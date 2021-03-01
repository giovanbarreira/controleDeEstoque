
namespace controleDeEstoque
{
    partial class relatório
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
            this.bt_valor_total_estq = new System.Windows.Forms.Button();
            this.bt_qt_produtos_por_representante = new System.Windows.Forms.Button();
            this.bt_maior_menor_preço = new System.Windows.Forms.Button();
            this.bt_sair = new System.Windows.Forms.Button();
            this.tb_resultado = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bt_ver_todos
            // 
            this.bt_ver_todos.Location = new System.Drawing.Point(728, 165);
            this.bt_ver_todos.Name = "bt_ver_todos";
            this.bt_ver_todos.Size = new System.Drawing.Size(101, 75);
            this.bt_ver_todos.TabIndex = 12;
            this.bt_ver_todos.Text = "VER TODOS";
            this.bt_ver_todos.UseVisualStyleBackColor = true;
            // 
            // bt_valor_total_estq
            // 
            this.bt_valor_total_estq.Location = new System.Drawing.Point(621, 165);
            this.bt_valor_total_estq.Name = "bt_valor_total_estq";
            this.bt_valor_total_estq.Size = new System.Drawing.Size(101, 75);
            this.bt_valor_total_estq.TabIndex = 11;
            this.bt_valor_total_estq.Text = "VALOR TT DO ESTOQUE";
            this.bt_valor_total_estq.UseVisualStyleBackColor = true;
            this.bt_valor_total_estq.Click += new System.EventHandler(this.bt_valor_total_estq_Click);
            // 
            // bt_qt_produtos_por_representante
            // 
            this.bt_qt_produtos_por_representante.Location = new System.Drawing.Point(514, 165);
            this.bt_qt_produtos_por_representante.Name = "bt_qt_produtos_por_representante";
            this.bt_qt_produtos_por_representante.Size = new System.Drawing.Size(101, 75);
            this.bt_qt_produtos_por_representante.TabIndex = 10;
            this.bt_qt_produtos_por_representante.Text = "QTD PRODUTOS POR REPRESENTANTE";
            this.bt_qt_produtos_por_representante.UseVisualStyleBackColor = true;
            this.bt_qt_produtos_por_representante.Click += new System.EventHandler(this.bt_qt_produtos_por_representante_Click);
            // 
            // bt_maior_menor_preço
            // 
            this.bt_maior_menor_preço.Location = new System.Drawing.Point(407, 165);
            this.bt_maior_menor_preço.Name = "bt_maior_menor_preço";
            this.bt_maior_menor_preço.Size = new System.Drawing.Size(101, 75);
            this.bt_maior_menor_preço.TabIndex = 9;
            this.bt_maior_menor_preço.Text = "MAIOR E MENOR PREÇO";
            this.bt_maior_menor_preço.UseVisualStyleBackColor = true;
            this.bt_maior_menor_preço.Click += new System.EventHandler(this.bt_maior_menor_preço_Click);
            // 
            // bt_sair
            // 
            this.bt_sair.Location = new System.Drawing.Point(728, 33);
            this.bt_sair.Name = "bt_sair";
            this.bt_sair.Size = new System.Drawing.Size(101, 75);
            this.bt_sair.TabIndex = 13;
            this.bt_sair.Text = "VOLTAR";
            this.bt_sair.UseVisualStyleBackColor = true;
            this.bt_sair.Click += new System.EventHandler(this.bt_sair_Click);
            // 
            // tb_resultado
            // 
            this.tb_resultado.Location = new System.Drawing.Point(12, 33);
            this.tb_resultado.Multiline = true;
            this.tb_resultado.Name = "tb_resultado";
            this.tb_resultado.Size = new System.Drawing.Size(351, 207);
            this.tb_resultado.TabIndex = 14;
            // 
            // relatório
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 450);
            this.Controls.Add(this.tb_resultado);
            this.Controls.Add(this.bt_ver_todos);
            this.Controls.Add(this.bt_valor_total_estq);
            this.Controls.Add(this.bt_qt_produtos_por_representante);
            this.Controls.Add(this.bt_maior_menor_preço);
            this.Controls.Add(this.bt_sair);
            this.Name = "relatório";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RELATÓRIO";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.relatório_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_ver_todos;
        private System.Windows.Forms.Button bt_valor_total_estq;
        private System.Windows.Forms.Button bt_qt_produtos_por_representante;
        private System.Windows.Forms.Button bt_maior_menor_preço;
        private System.Windows.Forms.Button bt_sair;
        private System.Windows.Forms.TextBox tb_resultado;
    }
}