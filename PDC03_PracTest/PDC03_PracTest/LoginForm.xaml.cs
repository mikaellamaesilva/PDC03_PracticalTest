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
    public partial class LoginForm : ContentPage
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private async void login_Clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new OnboardingPage());

        }

        private async void SignUpClicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new RegForm());
        }
    }

}
    
