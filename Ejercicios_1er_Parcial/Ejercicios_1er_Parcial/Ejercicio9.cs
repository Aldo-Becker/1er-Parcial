using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using POO;

namespace Ejercicios_1er_Parcial
{
    public partial class Ejercicio9 : Form
    {
        public Ejercicio9()
        {
            InitializeComponent();
        }

        Coche miCoche = null;
        //Lista de Objetos de la Clase Coche
        List<Coche> listaCoches = new List<Coche>();

        private void button1_Click(object sender, EventArgs e)
        {
            //Coche miCoche = new Coche();

            //Coche miCoche2 = new Coche("Toyota", "22R");
            string marca = MarcaTextBox.Text;
            string modelo = ModeloTextBox.Text;
            decimal precio = Convert.ToDecimal(PrecioTextBox.Text);
            int km = Convert.ToInt32(KilometrosTextBox.Text);

            //Tener un If Else en una Misma Linea
            //int km = KilometrosTextBox.Text == String.Empty ? 0 : Convert.ToInt32(KilometrosTextBox.Text);

            miCoche = new Coche();  

            miCoche.Marca = marca;
            miCoche.Modelo = modelo;
            miCoche.Precio = precio;
            miCoche.Kilometros = km;

            listaCoches.Add(miCoche);

            //para que se Vaya Agregando a la Lista
            CochesDataGridView.DataSource = null;
            CochesDataGridView.DataSource = listaCoches;

            LimpiarControles();
            MarcaTextBox.Focus();
            //MessageBox.Show($"Objeto Coche -> Marca: {miCoche.Marca}, Modelo: {miCoche.Modelo}");
        }

        //Procedimiento
        public void LimpiarControles()
        {
            //Distintas Maneras de Limpiar
            MarcaTextBox.Clear();
            ModeloTextBox.Text = String.Empty;
            PrecioTextBox.Text = "";
            KilometrosTextBox.Clear();
        }

        private void Ejercicio9_Load(object sender, EventArgs e)
        {
            MarcaTextBox.Focus();
        }
    }
}
