using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TAREA1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnrestar_Clicked(object sender, EventArgs e)
        {
            double num1, num2, resta, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            resta = num1 - num2;
            total = resta;

            DisplayAlert("la resta de los numeros es", total.ToString(), "ok");

            //txtnumero1.Text = "";
            //txtnumero2.Text = "";

            return;

        }
        
        private void btnsumar_Clicked(object sender, EventArgs e)
        {
 

            double num1, num2, suma, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            suma = num1 + num2;
            total = suma;
            DisplayAlert("la suma de los numeros es", total.ToString(), "ok");

                //txtnumero1.Text = "";
                //txtnumero2.Text =


             return;

        }

      
        private void btnMultipliacion_Clicked(object sender, EventArgs e)
        {
            double num1, num2, resta, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            resta = num1 * num2;
            total = resta;
            DisplayAlert("la Multiplicacion de los numeros es", total.ToString(), "ok");

            //txtnumero1.Text = "";
            //txtnumero2.Text = "";
        }

        private void btndivision_Clicked(object sender, EventArgs e)
        {
            double num1, num2, divicion, total;
            num1 = double.Parse(txtnumero1.Text);
            num2 = double.Parse(txtnumero2.Text);

            divicion = num1 / num2;
            total = divicion;

            if (num2 == 0)
            { DisplayAlert("no se pude dividir entre cero", "  ", "ok"); }

            else { DisplayAlert("la divicion de los numeros es", total.ToString(), "ok"); };

            //txtnumero1.Text = "";
            //txtnumero2.Text = "";
        }

        private void btnlimpiar_Clicked(object sender, EventArgs e)
        {
            txtnumero1.Text = "";
            txtnumero2.Text = "";
        }
    }
}
