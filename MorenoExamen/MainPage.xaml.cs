using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MorenoExamen
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            //almacenar los datos en variables
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            try
            {

                if (txtUsuario.Text == "estudiante2021" && txtContrasena.Text == "uisrael2021")
                {
                    //accion navegar a ventana dos
                    await Navigation.PushAsync(new viewDos(usuario));
                    //ALERTA O MENSAJE QUE SE VISUALIZA
                    DisplayAlert("BIENVENIDO", usuario, "OK");
                }

                else if (txtUsuario.Text != "estudiante2021")
                {
                    await Navigation.PushAsync(null);
                }
                else if (txtContrasena.Text != "uisrael2021")
                {
                    await Navigation.PushAsync(null);
                }

            }
            catch (Exception ex)
            {
                DisplayAlert("ERROR Usuario o Contrasena dato Incorrecto", ex.Message, "OK");
            }
        }
    }

}
