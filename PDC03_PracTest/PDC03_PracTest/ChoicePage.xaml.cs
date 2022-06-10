using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_PracTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ChoicePage : ContentPage
    {
        public ChoicePage()
        {
            InitializeComponent();
        }
        private async void EcuadorDashboard(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new ECDboard());

        }

        private async void USDashboard(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new USDboard());

        }

        private async void IndoDashboard(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new IndoDBoard());
        }
    }
}