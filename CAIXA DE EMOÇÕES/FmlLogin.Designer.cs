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
            this.endereco = new System.Windows.Forms.TextBox();
            this.telefone = new System.Windows.Forms.MaskedTextBox();
            this.CPF = new System.Windows.Forms.MaskedTextBox();
            this.continuar = new System.Windows.Forms.Button();
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
            this.pictureBox2.Location = new System.Drawing.Point(-13, -30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1218, 682);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // NomeCompleto
            // 
            this.NomeCompleto.Location = new System.Drawing.Point(408, 169);
            this.NomeCompleto.Multiline = true;
            this.NomeCompleto.Name = "NomeCompleto";
            this.NomeCompleto.Size = new System.Drawing.Size(366, 51);
            this.NomeCompleto.TabIndex = 2;
            // 
            // Email
            // 
            this.Email.Location = new System.Drawing.Point(408, 271);
            this.Email.Multiline = true;
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(366, 51);
            this.Email.TabIndex = 3;
            // 
            // endereco
            // 
            this.endereco.Location = new System.Drawing.Point(408, 456);
            this.endereco.Multiline = true;
            this.endereco.Name = "endereco";
            this.endereco.Size = new System.Drawing.Size(366, 51);
            this.endereco.TabIndex = 4;
            // 
            // telefone
            // 
            this.telefone.Location = new System.Drawing.Point(480, 371);
            this.telefone.Mask = "(00) 0000-00000";
            this.telefone.Name = "telefone";
            this.telefone.Size = new System.Drawing.Size(100, 20);
            this.telefone.TabIndex = 5;
            // 
            // CPF
            // 
            this.CPF.Location = new System.Drawing.Point(458, 583);
            this.CPF.Mask = "000,000,000-00";
            this.CPF.Name = "CPF";
            this.CPF.Size = new System.Drawing.Size(100, 20);
            this.CPF.TabIndex = 6;
            // 
            // continuar
            // 
            this.continuar.Location = new System.Drawing.Point(946, 367);
            this.continuar.Name = "continuar";
            this.continuar.Size = new System.Drawing.Size(156, 107);
            this.continuar.TabIndex = 7;
            this.continuar.Text = "Continuar";
            this.continuar.UseVisualStyleBackColor = true;
            this.continuar.Click += new System.EventHandler(this.continuar_Click);
            // 
            // FmlLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 615);
            this.Controls.Add(this.continuar);
            this.Controls.Add(this.CPF);
            this.Controls.Add(this.telefone);
            this.Controls.Add(this.endereco);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.NomeCompleto);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FmlLogin";
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
        private System.Windows.Forms.TextBox endereco;
        private System.Windows.Forms.MaskedTextBox telefone;
        private System.Windows.Forms.MaskedTextBox CPF;
        private System.Windows.Forms.Button continuar;
    }
}