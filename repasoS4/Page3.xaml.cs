using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace repasoS4
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page3 : ContentPage
    {
        public Page3(String usuario, double dato, string alumno)
        {
            InitializeComponent();
            lblUusario.Text = "USUARIO CONECTADO: "+ usuario;
            txtDato.Text = dato.ToString();
            txtAlumno.Text = alumno;
        }
    }
}