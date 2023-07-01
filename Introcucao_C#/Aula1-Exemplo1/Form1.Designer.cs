
namespace Aula1_Exemplo1
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
            this.button1 = new System.Windows.Forms.Button();
            this.lindao = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Coral;
            this.button1.Location = new System.Drawing.Point(185, 356);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(403, 62);
            this.button1.TabIndex = 0;
            this.button1.Text = "SIM";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lindao
            // 
            this.lindao.BackColor = System.Drawing.Color.Fuchsia;
            this.lindao.Font = new System.Drawing.Font("Comic Sans MS", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lindao.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lindao.Location = new System.Drawing.Point(15, 12);
            this.lindao.Name = "lindao";
            this.lindao.Size = new System.Drawing.Size(738, 312);
            this.lindao.TabIndex = 1;
            this.lindao.Text = "JHKVKFJDSAVKGUHA";
            this.lindao.UseWaitCursor = true;
            this.lindao.Click += new System.EventHandler(this.label1_Click);
            this.lindao.DoubleClick += new System.EventHandler(this.label1_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(761, 447);
            this.Controls.Add(this.lindao);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lindao;
    }
}

