namespace Consumo
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDistanciaKm = new System.Windows.Forms.TextBox();
            this.txtConsumoLitros = new System.Windows.Forms.TextBox();
            this.btnLimparTela = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblConsumoAtual = new System.Windows.Forms.Label();
            this.btnLimparArquivo = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Distância em Km:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Consumo em Litros:";
            // 
            // txtDistanciaKm
            // 
            this.txtDistanciaKm.Location = new System.Drawing.Point(107, 19);
            this.txtDistanciaKm.Name = "txtDistanciaKm";
            this.txtDistanciaKm.Size = new System.Drawing.Size(108, 20);
            this.txtDistanciaKm.TabIndex = 5;
            this.txtDistanciaKm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDistanciaKm_KeyPress);
            // 
            // txtConsumoLitros
            // 
            this.txtConsumoLitros.Location = new System.Drawing.Point(117, 45);
            this.txtConsumoLitros.Name = "txtConsumoLitros";
            this.txtConsumoLitros.Size = new System.Drawing.Size(98, 20);
            this.txtConsumoLitros.TabIndex = 6;
            this.txtConsumoLitros.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConsumoLitros_KeyPress);
            // 
            // btnLimparTela
            // 
            this.btnLimparTela.Location = new System.Drawing.Point(118, 137);
            this.btnLimparTela.Name = "btnLimparTela";
            this.btnLimparTela.Size = new System.Drawing.Size(97, 23);
            this.btnLimparTela.TabIndex = 7;
            this.btnLimparTela.Text = "Limpar Tela";
            this.btnLimparTela.UseVisualStyleBackColor = true;
            this.btnLimparTela.Click += new System.EventHandler(this.btnLimparTela_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(15, 71);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(97, 23);
            this.btnCadastrar.TabIndex = 8;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblConsumoAtual
            // 
            this.lblConsumoAtual.AutoSize = true;
            this.lblConsumoAtual.Location = new System.Drawing.Point(20, 112);
            this.lblConsumoAtual.Name = "lblConsumoAtual";
            this.lblConsumoAtual.Size = new System.Drawing.Size(81, 13);
            this.lblConsumoAtual.TabIndex = 9;
            this.lblConsumoAtual.Text = "Consumo Atual:";
            // 
            // btnLimparArquivo
            // 
            this.btnLimparArquivo.Location = new System.Drawing.Point(15, 137);
            this.btnLimparArquivo.Name = "btnLimparArquivo";
            this.btnLimparArquivo.Size = new System.Drawing.Size(97, 23);
            this.btnLimparArquivo.TabIndex = 11;
            this.btnLimparArquivo.Text = "Limpar Arquivo";
            this.btnLimparArquivo.UseVisualStyleBackColor = true;
            this.btnLimparArquivo.Click += new System.EventHandler(this.btnLimparArquivo_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(118, 71);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(97, 23);
            this.btnFechar.TabIndex = 12;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 182);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnLimparArquivo);
            this.Controls.Add(this.lblConsumoAtual);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.btnLimparTela);
            this.Controls.Add(this.txtConsumoLitros);
            this.Controls.Add(this.txtDistanciaKm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Consumo";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDistanciaKm;
        private System.Windows.Forms.TextBox txtConsumoLitros;
        private System.Windows.Forms.Button btnLimparTela;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblConsumoAtual;
        private System.Windows.Forms.Button btnLimparArquivo;
        private System.Windows.Forms.Button btnFechar;
    }
}

