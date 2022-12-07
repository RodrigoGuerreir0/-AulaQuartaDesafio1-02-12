namespace Desafio1_02_12
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
            this.botao1 = new System.Windows.Forms.Button();
            this.botao2 = new System.Windows.Forms.Button();
            this.botao3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // botao1
            // 
            this.botao1.BackColor = System.Drawing.Color.Lime;
            this.botao1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.botao1.Location = new System.Drawing.Point(47, 88);
            this.botao1.Name = "botao1";
            this.botao1.Size = new System.Drawing.Size(138, 55);
            this.botao1.TabIndex = 0;
            this.botao1.Text = "Verde";
            this.botao1.UseVisualStyleBackColor = false;
            this.botao1.Click += new System.EventHandler(this.button1_Click);
            // 
            // botao2
            // 
            this.botao2.BackColor = System.Drawing.Color.Red;
            this.botao2.Location = new System.Drawing.Point(47, 205);
            this.botao2.Name = "botao2";
            this.botao2.Size = new System.Drawing.Size(138, 55);
            this.botao2.TabIndex = 1;
            this.botao2.Text = "Vermelho";
            this.botao2.UseVisualStyleBackColor = false;
            this.botao2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botao3
            // 
            this.botao3.BackColor = System.Drawing.Color.Yellow;
            this.botao3.Location = new System.Drawing.Point(47, 319);
            this.botao3.Name = "botao3";
            this.botao3.Size = new System.Drawing.Size(138, 55);
            this.botao3.TabIndex = 2;
            this.botao3.Text = "Amarelo";
            this.botao3.UseVisualStyleBackColor = false;
            this.botao3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(203, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "A cor é:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(203, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "A cor é:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 32);
            this.label3.TabIndex = 5;
            this.label3.Text = "A cor é:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.botao3);
            this.Controls.Add(this.botao2);
            this.Controls.Add(this.botao1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button botao1;
        private System.Windows.Forms.Button botao2;
        private System.Windows.Forms.Button botao3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

