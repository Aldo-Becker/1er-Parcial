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
    public partial class Exa3 : Form
    {
        public Exa3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //InteresMensual(1);
            Enero(1);
            Febrero(2);
            Marzo(3);
            Abril(4);
            Mayo(5);
            Junio(6);
            Julio(7);
            Agosto(8);
            Septiembre(9);
            Octubre(10);
            Noviembre(11);
            Diciembre(12);
        }

        private double Enero(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 1;
            if (mes == 1)
            {
                listBox1.Items.Add($"En el Mes de Enero, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Febrero(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 2;
            if (mes == 2)
            {
                listBox1.Items.Add($"En el Mes de Febrero, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Marzo(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 3;
            if (mes == 3)
            {
                listBox1.Items.Add($"En el Mes de Marzo, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Abril(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 4;
            if (mes == 4)
            {
                listBox1.Items.Add($"En el Mes de Abril, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Mayo(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 5;
            if (mes == 5)
            {
                listBox1.Items.Add($"En el Mes de Mayo, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Junio(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 6;
            if (mes == 6)
            {
                listBox1.Items.Add($"En el Mes de Junio, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Julio(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 7;
            if (mes == 7)
            {
                listBox1.Items.Add($"En el Mes de Julio, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Agosto(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 8;
            if (mes == 8)
            {
                listBox1.Items.Add($"En el Mes de Agosto, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Septiembre(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 8;
            if (mes == 1)
            {
                listBox1.Items.Add($"En el Mes de Septiembre, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Octubre(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 9;
            if (mes == 10)
            {
                listBox1.Items.Add($"En el Mes de Octubre, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Noviembre(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 11;
            if (mes == 11)
            {
                listBox1.Items.Add($"En el Mes de Noviembre, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }
        private double Diciembre(int mes)
        {
            double capital = 200000;
            double tasa = 0.015;
            double interes = capital * tasa * 12;
            if (mes == 12)
            {
                listBox1.Items.Add($"En el Mes de Diciembre, La Ganancia por Interes Será de: {interes}");
            }
            return interes;
        }

        //private double InteresMensual(int mes)
        //{
        //    double capital = 200000;
        //    double tasa = 0.015;
        //    double interes;
        //    while (mes <= 12)
        //    {
        //        listBox1.Items.Add(mes);
        //        switch (mes)
        //        {
        //            case 1:
        //                interes = capital * tasa * 1;
        //                listBox1.Items.Add($"Para el Mes de Enero, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 2:
        //                interes = capital * tasa * 2;
        //                listBox1.Items.Add($"Para el Mes de Febrero, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 3:
        //                interes = capital * tasa * 3;
        //                listBox1.Items.Add($"Para el Mes de Marzo, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 4:
        //                interes = capital * tasa * 4;
        //                listBox1.Items.Add($"Para el Mes de Abril, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 5:
        //                interes = capital * tasa * 5;
        //                listBox1.Items.Add($"Para el Mes de Mayo, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 6:
        //                interes = capital * tasa * 6;
        //                listBox1.Items.Add($"Para el Mes de Junio, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 7:
        //                interes = capital * tasa * 7;
        //                listBox1.Items.Add($"Para el Mes de Julio, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 8:
        //                interes = capital * tasa * 8;
        //                listBox1.Items.Add($"Para el Mes de Agosto, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 9:
        //                interes = capital * tasa * 9;
        //                listBox1.Items.Add($"Para el Mes de Septiembre, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 10:
        //                interes = capital * tasa * 10;
        //                listBox1.Items.Add($"Para el Mes de Octubre, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 11:
        //                interes = capital * tasa * 11;
        //                listBox1.Items.Add($"Para el Mes de Noviembre, La Ganancia de Interes Será de: {interes}");
        //                break;
        //            case 12:
        //                interes = capital * tasa * 12;
        //                listBox1.Items.Add($"Para el Mes de Diciembre, La Ganancia de Interes Será de: {interes}");
        //                break;
        //        }
        //        mes++;
        //    }
        //    return mes;
        //}
    }
}

        
