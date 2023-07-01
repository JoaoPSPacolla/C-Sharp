
namespace Exeemplo2
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
            this.Fechar = new System.Windows.Forms.Button();
            this.Mensagem = new System.Windows.Forms.Button();
            this.Pergunta = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Fechar
            // 
            this.Fechar.Location = new System.Drawing.Point(382, 218);
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(75, 23);
            this.Fechar.TabIndex = 0;
            this.Fechar.Text = "Fechar";
            this.Fechar.UseVisualStyleBackColor = true;
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // Mensagem
            // 
            this.Mensagem.Location = new System.Drawing.Point(275, 218);
            this.Mensagem.Name = "Mensagem";
            this.Mensagem.Size = new System.Drawing.Size(75, 23);
            this.Mensagem.TabIndex = 1;
            this.Mensagem.Text = "Mensagem";
            this.Mensagem.UseVisualStyleBackColor = true;
            this.Mensagem.Click += new System.EventHandler(this.Mensagem_Click);
            // 
            // Pergunta
            // 
            this.Pergunta.Location = new System.Drawing.Point(275, 268);
            this.Pergunta.Name = "Pergunta";
            this.Pergunta.Size = new System.Drawing.Size(75, 23);
            this.Pergunta.TabIndex = 2;
            this.Pergunta.Text = "Pergunta";
            this.Pergunta.UseVisualStyleBackColor = true;
            this.Pergunta.Click += new System.EventHandler(this.Pergunta_Click);
            // 
            // TextBox
            // 
            this.TextBox.Location = new System.Drawing.Point(382, 268);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(75, 23);
            this.TextBox.TabIndex = 3;
            this.TextBox.Text = "TextBox";
            this.TextBox.UseVisualStyleBackColor = true;
            this.TextBox.Click += new System.EventHandler(this.TextBox_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(275, 179);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(182, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Pergunta);
            this.Controls.Add(this.Mensagem);
            this.Controls.Add(this.Fechar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Fechar;
        private System.Windows.Forms.Button Mensagem;
        private System.Windows.Forms.Button Pergunta;
        private System.Windows.Forms.Button TextBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

