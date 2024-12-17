using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace Telegrama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcularPrecio_Click(object sender, EventArgs e)
        {
            string textoTelegrama;
            char tipoTelegrama = ' ';
            int numPalabras = 0;
            double coste;

         
            textoTelegrama = txtTelegrama.Text;

            
            if (chkUrgente.Checked)
            {
                tipoTelegrama = 'u';
            }
            else
            {
                
                tipoTelegrama = 'o';
            }

            
            String[] palabras = textoTelegrama.Split(' '); 
            numPalabras = palabras.Length;

            
            if (tipoTelegrama == 'o')
            {
                if (numPalabras <= 10)
                {
                    coste = 2.5;
                }
                else
                {
                    
                    coste = 2.5 + 0.5 * (numPalabras - 10);
                }
            }
            else if (tipoTelegrama == 'u')
            {
                
                if (numPalabras > 10)
                {
                    coste = 5 + 0.75 * (numPalabras - 10);
                }
                else
                {
                    
                    coste = 5;
                }
            }
            else
            {
                coste = 0; 
            }


            txtPrecio.Text = coste.ToString("F2") + " euros";
        }

        private void chkUrgente_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Suma(int a,int b)
        {

        }
    }
}
