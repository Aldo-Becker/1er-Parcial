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
    public partial class Ejercicio7 : Form
    {
        public Ejercicio7()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            //Matriz 3x3
            int[,] matriz1 = new int[3, 3] { {3, 6, 3}, {6, 9, 7}, {8, 9, 4} };
            
            //Genera Números Aleatorios
            Random random = new Random();

            //Tamaño Random
            //int valorFila = random.Next(1, 10);
            //int valorColumna = random.Next(1, 10);

            //Ingresar el Tamaño
            int valorFila = Convert.ToInt32(FilaTextBox.Text);
            int valorColumna = Convert.ToInt32(ColumnaTextBox.Text);

            //Matriz 3x4
            int[,] matriz2 = new int[valorFila, valorColumna];

            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    matriz2[fila, columna] = random.Next(1, 100);
                }
            }

            for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            {
                for (int columna = 0; columna < matriz2.GetLength(1); columna++)
                {
                    listBox1.Items.Add($"La Posición: [{fila}, {columna}] = {matriz2[fila, columna]}");
                }
            }

            //Cuando no se Sabe el Tamaño
            //for (int fila = 0; fila < matriz2.GetLength(0); fila++)
            //{
            //    for (int columna = 0; columna < matriz2.GetLength(1); columna++)
            //    {

            //    }
            //}

            //Para ver la Dimension que Tendrá la Matriz
            textBox1.Text = matriz2.GetLength(0).ToString() +"x"+ matriz2.GetLength(1).ToString();
        }
    }
}
