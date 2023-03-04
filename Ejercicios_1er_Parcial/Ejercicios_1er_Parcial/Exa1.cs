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
    public partial class Exa1 : Form
    {
        public Exa1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(RecorrerNumeros(1));
        }
        private int RecorrerNumeros(int numeroInicio)
        {
            string nombre = "aldo", apellido, nombreCompleto;

            while (numeroInicio < 100)
            {
                listBox1.Items.Add(numeroInicio);
                if (numeroInicio % 3 == 0)
                {
                    listBox1.Items.Add($"{3},{nombre}");
                }
                if (numeroInicio % 5 == 0)
                {
                    listBox1.Items.Add("Becker");
                }
                if (numeroInicio % 3 == 0 && numeroInicio % 5 == 0)
                {
                    nombreCompleto = "ww";
                }
                numeroInicio++;
            }
            return numeroInicio; 
        }
    }
}
