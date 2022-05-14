using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANAGRAMAS_PRUEBA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            String palabra = txtPalabra1.Text;
            String palabra2 = txtPalabra2.Text;

            var resultado = SonAnagramas(palabra.ToLower(), palabra2.ToLower());


            if (resultado == true)
            {
                MessageBox.Show("SON ANAGRAMA", "PRUEBA DE MENSAJE DESDE LA APP", MessageBoxButtons.OK);
            }
            else {
                MessageBox.Show("NO SON ANAGRAMA", "PRUEBA DE MENSAJE DESDE LA APP", MessageBoxButtons.OK);
            }
        }

        public static bool SonAnagramas(string palabra, string palabra2)
        {
            if (palabra.Length != palabra2.Length) return false;
            for (int i = 0; i < palabra.Length; i++)
            {
                bool igualdad = false;
                for (int j = 0; j < palabra2.Length; j++)
                {
                    if (palabra[i] == palabra2[j])
                    {
                        palabra2 = palabra2.Remove(j, 1);
                        igualdad = true;
                        break;
                    }
                }
                if (!igualdad) return false;
            }
            return palabra2.Length == 0;
        }
    }
}
