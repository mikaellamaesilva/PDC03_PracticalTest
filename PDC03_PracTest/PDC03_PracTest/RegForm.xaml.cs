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
    public partial class RegForm : ContentPage
    {
        public RegForm()
        {
            InitializeComponent();

        }
            private async void reg_Clicked(object sender, EventArgs e)

            {

                await Navigation.PushAsync(new OnboardingPage());

            }

            private async void SignInClicked(object sender, EventArgs e)

            {

                await Navigation.PushAsync(new LoginForm());
            }
        }

    }