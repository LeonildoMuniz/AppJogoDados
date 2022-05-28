using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppJogoDados
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PageJogo : ContentPage
    {
        public PageJogo()
        {
            InitializeComponent();
            Random r = new Random();
            int n = r.Next(1, 7);
            switch (n)
            {
                case 1:
                    valor_dado.Source = "img1";
                    break;

                case 2:
                    valor_dado.Source = "img2";
                    break;

                case 3:
                    valor_dado.Source = "img3";
                    break;

                case 4:
                    valor_dado.Source = "img4";
                    break;

                case 5:
                    valor_dado.Source = "img5";
                    break;

                case 6:
                    valor_dado.Source = "img6";
                    break;

            }
        }

        private async void btVoltar_ClickedAsync(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}