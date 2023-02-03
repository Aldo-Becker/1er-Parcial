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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            //Esto Evita que se rompa el programa
            if (Número1TextBox.Text == "")
            {
                errorProvider1.SetError(Número1TextBox, "Ingrese un Valor");
                return;
            }
            if (Número2TextBox.Text == "")
            {
                errorProvider1.SetError(Número2TextBox, "Ingrese un Valor");
                return;
            }
            if (OperacionesComboBox.Text == "")
            {
                errorProvider1.SetError(OperacionesComboBox,"Seleccione Una Opción");
                return;
            }

            errorProvider1.Clear();

            decimal resultado = Ejecutar(Convert.ToDecimal(Número1TextBox.Text), Convert.ToDecimal(Número2TextBox.Text));

            ResultadoLabel.Text = Convert.ToString(resultado);

        }

        private decimal Ejecutar(decimal n1, decimal n2)
        {
            string operacion = OperacionesComboBox.Text;
            decimal resultado = 0;

            switch (operacion)
            {
                case "Suma":
                    resultado = n1 + n2;
                    break;
                case "Resta":
                    resultado = n1 - n2;
                    break;
                case "Multiplicación":
                    resultado = n1 * n2;
                    break;
                case "División":
                    resultado = n1 / n2;
                    break;
            }
            //if (operacion == "Suma")
            //{
            //    resultado = n1 + n2;
            //}
            //else if (operacion == "Resta")
            //{
            //    resultado = n1 - n2;
            //}
            //else if (operacion == "Multiplicación")
            //{
            //    resultado = n1 * n2;
            //}
            //else if (operacion == "División")
            //{
            //    resultado = n1 / n2;
            //}
            return resultado;
        }

        private void Ejercicio2_Load(object sender, EventArgs e)
        {

        }
        //private decimal Ejecutar2(decimal n1, decimal n2)
        //{
        //    string operacion = OperacionesComboBox.Text;
        //    decimal resultado = 0;
        //    if (operacion == "Suma")
        //        resultado = n1 + n2;
        //    else if (operacion == "Resta")
        //        resultado = n1 - n2;
        //    else if (operacion == "Multiplicación")
        //        resultado = n1 * n2;
        //    else if (operacion == "División")
        //        resultado = n1 / n2;
        //    return resultado;
        //}
    }
}
