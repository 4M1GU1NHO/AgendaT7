namespace AgendaT7
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
            this.buttonAdCon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxNome = new System.Windows.Forms.TextBox();
            this.textBoxTelefone = new System.Windows.Forms.TextBox();
            this.textBoxSobrenome = new System.Windows.Forms.TextBox();
            this.listBoxContatos = new System.Windows.Forms.ListBox();
            this.buttonOrg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonAdCon
            // 
            this.buttonAdCon.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAdCon.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdCon.Location = new System.Drawing.Point(12, 244);
            this.buttonAdCon.Name = "buttonAdCon";
            this.buttonAdCon.Size = new System.Drawing.Size(170, 103);
            this.buttonAdCon.TabIndex = 1;
            this.buttonAdCon.Text = "Adicionar Contato";
            this.buttonAdCon.UseVisualStyleBackColor = false;
            this.buttonAdCon.Click += new System.EventHandler(this.buttonAdCon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(37, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefone:";
            // 
            // textBoxNome
            // 
            this.textBoxNome.Location = new System.Drawing.Point(138, 34);
            this.textBoxNome.Name = "textBoxNome";
            this.textBoxNome.Size = new System.Drawing.Size(187, 20);
            this.textBoxNome.TabIndex = 5;
            // 
            // textBoxTelefone
            // 
            this.textBoxTelefone.Location = new System.Drawing.Point(138, 153);
            this.textBoxTelefone.Name = "textBoxTelefone";
            this.textBoxTelefone.Size = new System.Drawing.Size(187, 20);
            this.textBoxTelefone.TabIndex = 6;
            // 
            // textBoxSobrenome
            // 
            this.textBoxSobrenome.Location = new System.Drawing.Point(138, 95);
            this.textBoxSobrenome.Name = "textBoxSobrenome";
            this.textBoxSobrenome.Size = new System.Drawing.Size(187, 20);
            this.textBoxSobrenome.TabIndex = 7;
            // 
            // listBoxContatos
            // 
            this.listBoxContatos.FormattingEnabled = true;
            this.listBoxContatos.Location = new System.Drawing.Point(402, 16);
            this.listBoxContatos.Name = "listBoxContatos";
            this.listBoxContatos.Size = new System.Drawing.Size(283, 355);
            this.listBoxContatos.TabIndex = 8;
            // 
            // buttonOrg
            // 
            this.buttonOrg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonOrg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonOrg.Location = new System.Drawing.Point(209, 244);
            this.buttonOrg.Name = "buttonOrg";
            this.buttonOrg.Size = new System.Drawing.Size(170, 103);
            this.buttonOrg.TabIndex = 9;
            this.buttonOrg.Text = "Organizar Contatos";
            this.buttonOrg.UseVisualStyleBackColor = false;
            this.buttonOrg.Click += new System.EventHandler(this.buttonOrg_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(716, 381);
            this.Controls.Add(this.buttonOrg);
            this.Controls.Add(this.listBoxContatos);
            this.Controls.Add(this.textBoxSobrenome);
            this.Controls.Add(this.textBoxTelefone);
            this.Controls.Add(this.textBoxNome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAdCon);
            this.Name = "Form1";
            this.Text = "Lista de Contatos";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonAdCon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxNome;
        private System.Windows.Forms.TextBox textBoxTelefone;
        private System.Windows.Forms.TextBox textBoxSobrenome;
        private System.Windows.Forms.ListBox listBoxContatos;
        private System.Windows.Forms.Button buttonOrg;
    }
}

