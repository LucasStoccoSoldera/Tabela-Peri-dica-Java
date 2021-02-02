using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Periodic_Table_go
{
    public partial class Elemento : Form
    {

        public Elemento()
        {
            InitializeComponent();
        }

        public void pegadela(String nome, String numero, String massa, Int32 img)
        {

        }

        private void Elemento_Load(object sender, EventArgs e)
        {
            textBox1.Text =
            "Símbolo: " + distributiva.simbolo + Environment.NewLine +
            "Nome: " + distributiva.nome + Environment.NewLine +
            "Número Atômico: " + distributiva.numAtomico + Environment.NewLine +
            "Número de Massa: " + distributiva.numMassa;
            pictureBox1.Image = Image.FromFile(distributiva.endImagem);
            this.Text = distributiva.nome;
        }

      

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
