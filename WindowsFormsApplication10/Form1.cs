using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    string imagen = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(imagen);

                }
                }
                catch(Exception){
                MessageBox.Show("El Archivo Selecsionado No Es Tipo Imagen");


            }

        }

        private void btclear_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}