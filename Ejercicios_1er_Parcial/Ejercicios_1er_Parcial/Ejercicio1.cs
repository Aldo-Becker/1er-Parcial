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
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();
        }

        private void SumarButton_Click(object sender, EventArgs e)
        {
            decimal numero1 = Convert.ToDecimal(Número1TextBox.Text);
            decimal numero2 = Convert.ToDecimal(Número2TextBox.Text);

            //decimal resultado = numero1 + numero2;
            decimal resultado = Convert.ToDecimal(Número1TextBox.Text) + Convert.ToDecimal(Número2TextBox.Text);

            ResultadoLabel.Text = Convert.ToString(resultado);
            //MessageBox.Show($"La Suma es: {resultado}");

        }
    }
}
