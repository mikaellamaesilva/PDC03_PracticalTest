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
    public partial class OnboardingPage : ContentPage
    {
        public OnboardingPage()
        {
            InitializeComponent();

        }


        private async void Main_Clicked(object sender, EventArgs e)

        {

            await Navigation.PushAsync(new MainPage());

        }
        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            MyRadialGradient.RadiusX = width * 6;
        }

        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
              //MyRadialGradient.RadiusX = this.Width * e.NewValue;  

        }

        
    }
} 

