using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_1er_Parcial
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            string cadena = CadenaTextBox.Text;

            //Muestra la Cantidad de Letras que Tiene el Texto Ingresado
            LongitudTextBox.Text = cadena.Length.ToString();

            //Muestra la Primera Letra Ingresada
            PrimerCaracterTextBox.Text = cadena.Substring(0,1);

            //Muestra la Ultima Letra Ingresada
            UltimoCaracterTextBox.Text = cadena.Substring(cadena.Length -1, 1);

            //Monstrara Todo el Texto en Mayuscula
            MayusculasTextBox.Text = cadena.ToUpper();

            //Mostrara Todo el Texto en Minuscula
            MinusculasTextBox.Text = cadena.ToLower();

            //Reemplazara las letras ingresadas (la Primera será reemplazada por la Segunda)
            ReemplazarTextBox.Text = cadena.Replace(" ","");

            //ReemplazarTextBox.Text = cadena.ToUpper().Replace(" ", "").ToLower();

        }
    }
}
