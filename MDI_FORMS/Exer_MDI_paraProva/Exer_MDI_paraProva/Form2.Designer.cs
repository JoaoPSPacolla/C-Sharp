namespace Exer_MDI_paraProva
{
    partial class Form2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label_etanol = new System.Windows.Forms.Label();
            this.label_gasolina = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_etanol = new System.Windows.Forms.RadioButton();
            this.btn_gasolina = new System.Windows.Forms.RadioButton();
            this.litro = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.text = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.calcula = new System.Windows.Forms.Button();
            this.limpa = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.limpa);
            this.groupBox1.Controls.Add(this.calcula);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.text);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.litro);
            this.groupBox1.Controls.Add(this.btn_gasolina);
            this.groupBox1.Controls.Add(this.btn_etanol);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label_gasolina);
            this.groupBox1.Controls.Add(this.label_etanol);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 269);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label_etanol
            // 
            this.label_etanol.AutoSize = true;
            this.label_etanol.Location = new System.Drawing.Point(16, 25);
            this.label_etanol.Name = "label_etanol";
            this.label_etanol.Size = new System.Drawing.Size(37, 13);
            this.label_etanol.TabIndex = 0;
            this.label_etanol.Text = "Etanol";
            // 
            // label_gasolina
            // 
            this.label_gasolina.AutoSize = true;
            this.label_gasolina.Location = new System.Drawing.Point(16, 59);
            this.label_gasolina.Name = "label_gasolina";
            this.label_gasolina.Size = new System.Drawing.Size(48, 13);
            this.label_gasolina.TabIndex = 1;
            this.label_gasolina.Text = "Gasolina";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(57, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(70, 59);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // btn_etanol
            // 
            this.btn_etanol.AutoSize = true;
            this.btn_etanol.Location = new System.Drawing.Point(19, 118);
            this.btn_etanol.Name = "btn_etanol";
            this.btn_etanol.Size = new System.Drawing.Size(55, 17);
            this.btn_etanol.TabIndex = 4;
            this.btn_etanol.TabStop = true;
            this.btn_etanol.Text = "Etanol";
            this.btn_etanol.UseVisualStyleBackColor = true;
            // 
            // btn_gasolina
            // 
            this.btn_gasolina.AutoSize = true;
            this.btn_gasolina.Location = new System.Drawing.Point(133, 118);
            this.btn_gasolina.Name = "btn_gasolina";
            this.btn_gasolina.Size = new System.Drawing.Size(66, 17);
            this.btn_gasolina.TabIndex = 5;
            this.btn_gasolina.TabStop = true;
            this.btn_gasolina.Text = "Gasolina";
            this.btn_gasolina.UseVisualStyleBackColor = true;
            // 
            // litro
            // 
            this.litro.AutoSize = true;
            this.litro.Location = new System.Drawing.Point(16, 169);
            this.litro.Name = "litro";
            this.litro.Size = new System.Drawing.Size(32, 13);
            this.litro.TabIndex = 6;
            this.litro.Text = "Litros";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(57, 166);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 7;
            // 
            // text
            // 
            this.text.AutoSize = true;
            this.text.Location = new System.Drawing.Point(16, 228);
            this.text.Name = "text";
            this.text.Size = new System.Drawing.Size(28, 13);
            this.text.TabIndex = 8;
            this.text.Text = "Text";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(13, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "0";
            // 
            // calcula
            // 
            this.calcula.Location = new System.Drawing.Point(178, 166);
            this.calcula.Name = "calcula";
            this.calcula.Size = new System.Drawing.Size(75, 23);
            this.calcula.TabIndex = 10;
            this.calcula.Text = "Calcular";
            this.calcula.UseVisualStyleBackColor = true;
            this.calcula.Click += new System.EventHandler(this.calcula_Click);
            // 
            // limpa
            // 
            this.limpa.Location = new System.Drawing.Point(178, 209);
            this.limpa.Name = "limpa";
            this.limpa.Size = new System.Drawing.Size(75, 23);
            this.limpa.TabIndex = 11;
            this.limpa.Text = "Limpar";
            this.limpa.UseVisualStyleBackColor = true;
            this.limpa.Click += new System.EventHandler(this.limpa_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(294, 292);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label litro;
        private System.Windows.Forms.RadioButton btn_gasolina;
        private System.Windows.Forms.RadioButton btn_etanol;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label_gasolina;
        private System.Windows.Forms.Label label_etanol;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label text;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button limpa;
        private System.Windows.Forms.Button calcula;
    }
}