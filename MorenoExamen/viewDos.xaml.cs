using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MorenoExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class viewDos : ContentPage
    {
        public viewDos(string usuario)
        {
            InitializeComponent();
            txtUsuario.Text = usuario;
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            try
            {
                //almaceno en variables los datos de las cajas de texto
                double montoInicial = Convert.ToDouble(txtCuotacero.Text);
                //operación
                double resultado1 = (1800 - montoInicial) / 3;
                double resultado2 = (resultado1 * 5) / 100;
                double suma = resultado1 + resultado2;
                double resultado3 = 1800 + (resultado2 * 3);
                //Convertir a string para visualizar en un Entry
                txtMensualidad.Text = Convert.ToString(suma);
                txtPagar.Text = Convert.ToString(resultado3);
            }
            catch
            {

            }

        }

        private async void btnGuardar_Clicked(object sender, EventArgs e)
        {
            try
            {
                //enviar los datos a viewTres
                string nombre = txtNombre.Text;
                string usuario = txtUsuario.Text;
                string resultado3 = txtPagar.Text;

                await Navigation.PushAsync(new viewTres(usuario, nombre, resultado3));
            }

            catch
            {
                //Capturo la excepcion
                DisplayAlert("Elemento", "Guardado con exito", "OK");
            }
        }

        private void txtCuotacero_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                double dato = Convert.ToDouble(txtCuotacero.Text);
                if (dato > 1800)
                {
                    DisplayAlert("Alerta", "No se permite cuota mayor a $1800", "OK");
                }
            }
            catch
            {

            }
        }
    }
}