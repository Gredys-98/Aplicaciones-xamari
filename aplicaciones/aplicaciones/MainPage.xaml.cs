using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace aplicaciones
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private  async void boton1_Clicked(object sender, EventArgs e)

        {
            await Navigation.PushModalAsync(new pagina1());

        }

        private  async void boton2_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new pagina2());
        }
    }
}
