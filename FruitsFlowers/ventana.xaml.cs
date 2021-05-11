using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FruitsFlowers
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ventana : ContentPage
    {
        public ventana(string usuario, string clave)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }
    }
}