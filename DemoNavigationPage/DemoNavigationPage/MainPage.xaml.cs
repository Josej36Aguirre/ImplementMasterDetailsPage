using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DemoNavigationPage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnPagina1.Clicked += BtnPagina1_Clicked;

        }

        private async void BtnPagina1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Pagina2());
        }
    }
}
