using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicios_1er_Parcial
{
    public partial class Ejercicio5 : Form
    {
        public Ejercicio5()
        {
            InitializeComponent();
        }

        private void HornearButton_Click(object sender, EventArgs e)
        {
            HornearPizza();
            MessageBox.Show("Mensaje Normal");
        }

        private void HornearPizza()
        {
            Thread.Sleep(10000);
        }

        //Task para Asincronos
        private Task HornearPizzaAsync()
        {
            return Task.Delay(10000);
        }

        private void HornearAzincronoButton_Click(object sender, EventArgs e)
        {
            HornearPizzaAsync();
            MessageBox.Show("Mensaje Asincrono");
        }

        private async void CalcularButton_Click(object sender, EventArgs e)
        {
            decimal num1 = Convert.ToDecimal(Número1TextBox.Text);
            decimal num2 = Convert.ToDecimal(Número2TextBox.Text);

            decimal total = await SumarAsync(num1, num2);

            MessageBox.Show($"La Suma Total es: {total}");
        }

        private async Task<decimal> SumarAsync(decimal n1, decimal n2)
        {
            decimal suma = await Task.Run(() =>
            {
                return n1 + n2;

            });
            return suma;
        }
    }
}
