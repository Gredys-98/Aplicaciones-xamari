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
    public partial class pagina1 : ContentPage
    {
        public pagina1()
        {
            InitializeComponent();

        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            var x = (resultado.Text);
            x = x.Remove(x.Length - 1, 1);

            var numero = Int32.Parse(x);

            numero = numero - 4;

            numero2.Text = numero.ToString();
        }
    }
}