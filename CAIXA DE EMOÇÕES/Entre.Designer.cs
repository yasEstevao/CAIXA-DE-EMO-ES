namespace CAIXA_DE_EMOÇÕES
{
    partial class Entre
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Entre));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Email = new System.Windows.Forms.TextBox();
            this.NomeCompleto = new System.Windows.Forms.TextBox();
            this.Senha = new System.Windows.Forms.TextBox();
            this.Entrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-11, -12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1454, 706);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(443, 174);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(399, 57);
            this.Email.TabIndex = 1;
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.Location = new System.Drawing.Point(443, 285);
            this.NomeCompleto.Multiline = true;
            this.NomeCompleto.Name = "NomeCompleto";
            this.NomeCompleto.Size = new System.Drawing.Size(399, 57);
            this.NomeCompleto.TabIndex = 2;
            // 
            // Senha
            // 
            this.Senha.Location = new System.Drawing.Point(443, 416);
            this.Senha.Multiline = true;
            this.Senha.Name = "Senha";
            this.Senha.Size = new System.Drawing.Size(399, 57);
            this.Senha.TabIndex = 3;
            // 
            // Entrar
            // 
            this.Entrar.Location = new System.Drawing.Point(989, 535);
            this.Entrar.Name = "Entrar";
            this.Entrar.Size = new System.Drawing.Size(153, 72);
            this.Entrar.TabIndex = 4;
            this.Entrar.Text = "Entrar";
            this.Entrar.UseVisualStyleBackColor = true;
            this.Entrar.Click += new System.EventHandler(this.Entrar_Click);
            // 
            // Entre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1173, 639);
            this.Controls.Add(this.Entrar);
            this.Controls.Add(this.Senha);
            this.Controls.Add(this.NomeCompleto);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Entre";
            this.Text = "Entre";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox Email;
        private System.Windows.Forms.TextBox NomeCompleto;
        private System.Windows.Forms.TextBox Senha;
        private System.Windows.Forms.Button Entrar;
    }
}