namespace CAIXA_DE_EMOÇÕES
{
    partial class FmlLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FmlLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.NomeCompleto = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.Endereco = new System.Windows.Forms.TextBox();
            this.Telefone = new System.Windows.Forms.MaskedTextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.continuar = new System.Windows.Forms.Button();
            this.senha = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(806, 295);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(346, 410);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-19, -30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1218, 682);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.Location = new System.Drawing.Point(396, 167);
            this.NomeCompleto.Multiline = true;
            this.NomeCompleto.Name = "NomeCompleto";
            this.NomeCompleto.Size = new System.Drawing.Size(366, 51);
            this.NomeCompleto.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(396, 268);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(366, 51);
            this.Email.TabIndex = 3;
            // 
            // Endereco
            // 
            this.Endereco.Location = new System.Drawing.Point(396, 458);
            this.Endereco.Multiline = true;
            this.Endereco.Name = "Endereco";
            this.Endereco.Size = new System.Drawing.Size(366, 51);
            this.Endereco.TabIndex = 4;
            // 
            // Telefone
            // 
            this.Telefone.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Telefone.Location = new System.Drawing.Point(404, 370);
            this.Telefone.Mask = "(00) 0000-00000";
            this.Telefone.Name = "Telefone";
            this.Telefone.Size = new System.Drawing.Size(199, 42);
            this.Telefone.TabIndex = 5;
            this.Telefone.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.telefone_MaskInputRejected);
            // 
            // CPF
            // 
            this.CPF.Font = new System.Drawing.Font("Microsoft YaHei UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPF.Location = new System.Drawing.Point(396, 557);
            this.CPF.Mask = "000,000,000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(207, 42);
            this.CPF.TabIndex = 6;
            // 
            // continuar
            // 
            this.continuar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.continuar.Location = new System.Drawing.Point(951, 370);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(190, 107);
            this.continuar.TabIndex = 7;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // senha
            // 
            this.senha.Location = new System.Drawing.Point(851, 199);
            this.senha.Multiline = true;
            this.senha.Name = "senha";
            this.senha.Size = new System.Drawing.Size(220, 40);
            this.senha.TabIndex = 8;
            // 
            // FmlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 628);
            this.Controls.Add(this.senha);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.Telefone);
            this.Controls.Add(this.Endereco);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.NomeCompleto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FmlLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FmlLogin";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox NomeCompleto;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox Endereco;
        private System.Windows.Forms.MaskedTextBox Telefone;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.Button continuar;
        private System.Windows.Forms.TextBox senha;
    }
}