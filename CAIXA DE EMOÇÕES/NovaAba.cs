using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAIXA_DE_EMOÇÕES
{
    public partial class NovaAba : Form
    {
        private void NovaAba_Load(object sender, EventArgs e)
        {
            // Partes do corpo
            comboBoxParteCorpo.Items.AddRange(new string[]
            {
        "Cabeça", "Pescoço", "Peito", "Ombro", "Braço", "Antibraço",
        "Mão", "Barriga", "Cintura", "Gluteos", "Coxa", "Joelho",
        "Canela", "Panturrilha", "Calcanhar", "Pé"
            });

            // Estilos de tatuagem
            checkedListBoxTiposTatuagem.Items.AddRange(new string[]
            {
        "Tribal", "Geométrica", "Minimalista", "Old School (tradicional)", "New School",
        "Aquarela", "Pontilhismo", "Realista (preto e branco)", "Realista (colorida)", "Mandala",
        "Biomecânica", "Oriental (japonesa, chinesa)", "Celta/Viking", "Religiosa/Espiritual",
        "Cartoon/Geek/Anime", "Escritas/Caligrafia", "Abstrata", "Minimalista de Linha Contínua",
        "Natureza (flores, animais, folhas)", "Caveiras"
            });
          
            // Partes do corpo
            comboBoxParteCorpo.Items.AddRange(new string[]
            {
        "Cabeça", "Pescoço", "Peito", "Ombro", "Braço", "Antibraço",
        "Mão", "Barriga", "Cintura", "Gluteos", "Coxa", "Joelho",
        "Canela", "Panturrilha", "Calcanhar", "Pé"
            });

            // Estilos de tatuagem
            checkedListBoxTiposTatuagem.Items.AddRange(new string[]
            {
        "Tribal", "Geométrica", "Minimalista", "Old School (tradicional)", "New School",
        "Aquarela", "Pontilhismo", "Realista (preto e branco)", "Realista (colorida)", "Mandala",
        "Biomecânica", "Oriental (japonesa, chinesa)", "Celta/Viking", "Religiosa/Espiritual",
        "Cartoon/Geek/Anime", "Escritas/Caligrafia", "Abstrata", "Minimalista de Linha Contínua",
        "Natureza (flores, animais, folhas)", "Caveiras"
            });
        }

        


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            {
            }
        }
    }
}