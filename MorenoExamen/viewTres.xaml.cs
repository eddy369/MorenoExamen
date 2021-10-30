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
    public partial class viewTres : ContentPage
    {
        public viewTres(string usuario, string nombre, string resultado3)
        {
            InitializeComponent();
            //Envio de las cajas de texto
            txtUsuario.Text = usuario;
            txtNombre.Text = nombre;
            txtPagar.Text = resultado3;
        }
    }
}