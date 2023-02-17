using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Coche
    {
        // Atributos
        private string marca;
        private string modelo;
        private decimal precio;

        // Propiedades
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public decimal Precio { get; set; }
        public int Kilometros { get; set; }

        //Otras Maneras de Crear Propiedades
        //1er Manera
        //public string Modelo
        //{
        //    get { return modelo; }
        //    set { modelo = value; }
        //}
        //2da Manera
        //public decimal Precio { get => precio; set => precio = value; }

        // Constructor
        public Coche() { }
        public Coche( string _marca, string _modelo) 
        { 
            Marca = _marca;
            Modelo = _modelo;   
        }

        public Coche(string marca, string modelo, decimal precio, int kilometros) : this(marca, modelo)
        {
            Precio = precio;
            Kilometros = kilometros;
        }

        //Metodos
        public string DevolverDatosBasicos()
        {
            return $"Marca: {Marca}, Modelo: {Modelo}, Precio: {Precio}";
        }


    }
}
