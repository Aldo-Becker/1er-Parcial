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
    public partial class Ejercicio4 : Form
    {
        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechaDateTimePicker.Value;

            DíaTextBox.Text = fecha.Day.ToString();
            MesTextBox.Text = fecha.Month.ToString("MMMM");
            AñoTextBox.Text = fecha.Year.ToString();
            SemanaTextBox.Text = fecha.ToString("dddd");

            int numeroDias = Convert.ToInt32(DíaTextBox.Text);
            DateTime fechaActual = DateTime.Now;

            CitaTextBox.Text = fechaActual.AddDays(numeroDias).ToShortDateString();

            int diasResta = Convert.ToInt32(DiasRestaTextBox.Text);

            NuevaFechaTextBox.Text = fechaActual.AddDays(-diasResta).ToLongDateString();

            MessageBox.Show($" La Edad es: {DevolverEdad(fecha)}");
        }

        private int DevolverEdad(DateTime fechaNacimiento)
        {
            DateTime fechaActual = DateTime.Now;

            int edad = 0;

            if (fechaNacimiento >= fechaActual)
            {
                return 0;
            }
            else
            {
                edad = fechaActual.Year - fechaNacimiento.Year;
                if (fechaNacimiento.Month > fechaActual.Month)
                {
                    --edad;
                    //edad = edad - 1;
                    //edad -= 1;
                }
                return edad;
            }

        }
    }
}
