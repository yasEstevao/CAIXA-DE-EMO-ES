namespace CAIXA_DE_EMOÇÕES
{
    partial class NovaAba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NovaAba));
            this.comboBoxParteCorpo = new System.Windows.Forms.ComboBox();
            this.masculinoCheckBox = new System.Windows.Forms.CheckedListBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkedListBoxTiposTatuagem = new System.Windows.Forms.ComboBox();
            this.femininoCheckBox = new System.Windows.Forms.CheckedListBox();
            this.buttonBuscar = new System.Windows.Forms.Button();
            this.flowLayoutPanelImagens = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxParteCorpo
            // 
            this.comboBoxParteCorpo.Font = new System.Drawing.Font("Miriam Mono CLM", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.comboBoxParteCorpo.FormattingEnabled = true;
            this.comboBoxParteCorpo.Items.AddRange(new object[] {
            "Cabeça",
            "Pescoço",
            "Peito",
            "Ombro",
            "Braço",
            "Antibraço",
            "Mão",
            "Barriga",
            "Cintura",
            "Gluteos",
            "Coxa",
            "Joelho",
            "Canela",
            "Panturrilha",
            "Calcanhar",
            "Pé"});
            this.comboBoxParteCorpo.Location = new System.Drawing.Point(518, 379);
            this.comboBoxParteCorpo.Name = "comboBoxParteCorpo";
            this.comboBoxParteCorpo.Size = new System.Drawing.Size(574, 47);
            this.comboBoxParteCorpo.TabIndex = 0;
            this.comboBoxParteCorpo.Text = "Escolha uma parte do corpo";
            // 
            // masculinoCheckBox
            // 
            this.masculinoCheckBox.BackColor = System.Drawing.SystemColors.Window;
            this.masculinoCheckBox.Font = new System.Drawing.Font("Miriam Mono CLM", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.masculinoCheckBox.FormattingEnabled = true;
            this.masculinoCheckBox.Items.AddRange(new object[] {
            "Masculino"});
            this.masculinoCheckBox.Location = new System.Drawing.Point(656, 272);
            this.masculinoCheckBox.Name = "masculinoCheckBox";
            this.masculinoCheckBox.Size = new System.Drawing.Size(221, 42);
            this.masculinoCheckBox.TabIndex = 1;
            this.masculinoCheckBox.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-20, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1425, 722);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkedListBoxTiposTatuagem
            // 
            this.checkedListBoxTiposTatuagem.Font = new System.Drawing.Font("Miriam Mono CLM", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.checkedListBoxTiposTatuagem.FormattingEnabled = true;
            this.checkedListBoxTiposTatuagem.Items.AddRange(new object[] {
            "Tribal",
            "",
            "",
            "Geométrica",
            "",
            "",
            "Minimalista",
            "",
            "",
            "Old School (tradicional)",
            "",
            "",
            "New School",
            "",
            "",
            "Aquarela",
            "",
            "",
            "Pontilhismo",
            "",
            "",
            "Realista (preto e branco)",
            "",
            "",
            "Realista (colorida)",
            "",
            "",
            "Mandala",
            "",
            "",
            "Biomecânica",
            "",
            "",
            "Oriental (japonesa, chinesa)",
            "",
            "",
            "Celta/Viking",
            "",
            "",
            "Religiosa/Espiritual",
            "",
            "",
            "Cartoon/Geek/Anime",
            "",
            "",
            "Escritas/Caligrafia",
            "",
            "",
            "Abstrata",
            "",
            "",
            "Minimalista de Linha Contínua",
            "",
            "",
            "Natureza (flores, animais, folhas)",
            "",
            "",
            "Caveiras"});
            this.checkedListBoxTiposTatuagem.Location = new System.Drawing.Point(518, 450);
            this.checkedListBoxTiposTatuagem.Name = "checkedListBoxTiposTatuagem";
            this.checkedListBoxTiposTatuagem.Size = new System.Drawing.Size(574, 47);
            this.checkedListBoxTiposTatuagem.TabIndex = 3;
            this.checkedListBoxTiposTatuagem.Text = "Escolha seu tipo de tatoo";
            // 
            // femininoCheckBox
            // 
            this.femininoCheckBox.Font = new System.Drawing.Font("Miriam Mono CLM", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.femininoCheckBox.FormattingEnabled = true;
            this.femininoCheckBox.Items.AddRange(new object[] {
            "Feminino"});
            this.femininoCheckBox.Location = new System.Drawing.Point(656, 311);
            this.femininoCheckBox.Name = "femininoCheckBox";
            this.femininoCheckBox.Size = new System.Drawing.Size(221, 42);
            this.femininoCheckBox.TabIndex = 4;
            // 
            // buttonBuscar
            // 
            this.buttonBuscar.Font = new System.Drawing.Font("Miriam Mono CLM", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonBuscar.Location = new System.Drawing.Point(697, 521);
            this.buttonBuscar.Name = "buttonBuscar";
            this.buttonBuscar.Size = new System.Drawing.Size(136, 53);
            this.buttonBuscar.TabIndex = 5;
            this.buttonBuscar.Text = "Buscar";
            this.buttonBuscar.UseVisualStyleBackColor = true;
            this.buttonBuscar.Click += new System.EventHandler(this.buttonBuscar_Click);
            // 
            // flowLayoutPanelImagens
            // 
            this.flowLayoutPanelImagens.Location = new System.Drawing.Point(861, 551);
            this.flowLayoutPanelImagens.Name = "flowLayoutPanelImagens";
            this.flowLayoutPanelImagens.Size = new System.Drawing.Size(200, 121);
            this.flowLayoutPanelImagens.TabIndex = 6;
            // 
            // NovaAba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1243, 735);
            this.Controls.Add(this.flowLayoutPanelImagens);
            this.Controls.Add(this.buttonBuscar);
            this.Controls.Add(this.femininoCheckBox);
            this.Controls.Add(this.checkedListBoxTiposTatuagem);
            this.Controls.Add(this.masculinoCheckBox);
            this.Controls.Add(this.comboBoxParteCorpo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "NovaAba";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NovaAba";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxParteCorpo;
        private System.Windows.Forms.CheckedListBox masculinoCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox checkedListBoxTiposTatuagem;
        private System.Windows.Forms.CheckedListBox femininoCheckBox;
        private System.Windows.Forms.Button buttonBuscar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelImagens;
    }
}