namespace TabControl
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tb_novaAba = new System.Windows.Forms.TextBox();
            this.btn_novaAba = new System.Windows.Forms.Button();
            this.btn_removeAba = new System.Windows.Forms.Button();
            this.btn_posicionaTab = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 70);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 368);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 342);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Componentes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 342);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tb_novaAba
            // 
            this.tb_novaAba.Location = new System.Drawing.Point(16, 12);
            this.tb_novaAba.Name = "tb_novaAba";
            this.tb_novaAba.Size = new System.Drawing.Size(162, 20);
            this.tb_novaAba.TabIndex = 2;
            // 
            // btn_novaAba
            // 
            this.btn_novaAba.Location = new System.Drawing.Point(184, 12);
            this.btn_novaAba.Name = "btn_novaAba";
            this.btn_novaAba.Size = new System.Drawing.Size(137, 23);
            this.btn_novaAba.TabIndex = 3;
            this.btn_novaAba.Text = "Nova aba";
            this.btn_novaAba.UseVisualStyleBackColor = true;
            this.btn_novaAba.Click += new System.EventHandler(this.btn_novaAba_Click);
            // 
            // btn_removeAba
            // 
            this.btn_removeAba.Location = new System.Drawing.Point(327, 12);
            this.btn_removeAba.Name = "btn_removeAba";
            this.btn_removeAba.Size = new System.Drawing.Size(137, 23);
            this.btn_removeAba.TabIndex = 4;
            this.btn_removeAba.Text = "Remover aba atual";
            this.btn_removeAba.UseVisualStyleBackColor = true;
            this.btn_removeAba.Click += new System.EventHandler(this.btn_removeAba_Click);
            // 
            // btn_posicionaTab
            // 
            this.btn_posicionaTab.Location = new System.Drawing.Point(184, 41);
            this.btn_posicionaTab.Name = "btn_posicionaTab";
            this.btn_posicionaTab.Size = new System.Drawing.Size(137, 23);
            this.btn_posicionaTab.TabIndex = 5;
            this.btn_posicionaTab.Text = "Posicionar na aba";
            this.btn_posicionaTab.UseVisualStyleBackColor = true;
            this.btn_posicionaTab.Click += new System.EventHandler(this.btn_posicionaTab_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(16, 44);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 20);
            this.numericUpDown1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.btn_posicionaTab);
            this.Controls.Add(this.btn_removeAba);
            this.Controls.Add(this.btn_novaAba);
            this.Controls.Add(this.tb_novaAba);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tb_novaAba;
        private System.Windows.Forms.Button btn_novaAba;
        private System.Windows.Forms.Button btn_removeAba;
        private System.Windows.Forms.Button btn_posicionaTab;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

