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
    public partial class Exa2 : Form
    {
        public Exa2()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            string producto1 = Convert.ToString(Producto1TextBox.Text);
            string producto2 = Convert.ToString(Producto2TextBox.Text);
            double precio1 = Convert.ToDouble(Precio1TextBox.Text);
            double precio2 = Convert.ToDouble(Precio2TextBox.Text);

            double total = await DescuentoAsync(precio1,precio2);

            MessageBox.Show($"El Descuento Para el Cliente es del 15%\nPor lo Tanto el Total a Pagar Será de: {total}");
        }

        private async Task<double> DescuentoAsync(double p1, double p2)
        {
            double factura = await Task.Run(() =>
            {
                return (p1 + p2) * 0.15 ;
            });
            return factura;
        }
       

    }
}
