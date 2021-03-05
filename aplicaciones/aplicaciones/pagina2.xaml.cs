using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace aplicaciones
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pagina2 : ContentPage
    {
        public pagina2()
        {
            InitializeComponent();
        }

      

        private void Button_Clicked(object sender, EventArgs e)
        {
            var Nume = (numero.Text);
            var Resul = Int32.Parse(Nume);
            Resul = Resul - 365;
            var cadena = Resul.ToString();

            sep.Text = cadena.Substring(0, 1);
            mes.Text = cadena.Substring(cadena.Length - 2, 2);
        }
    }
}