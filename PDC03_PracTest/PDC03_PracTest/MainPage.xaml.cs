using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace PDC03_PracTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

            private async void choose_Clicked(object sender, EventArgs e)

            {

                await Navigation.PushAsync(new ChoicePage());
            }

            private async void Contributions(object sender, EventArgs e)

            {

                await Navigation.PushAsync(new View.ShowAllAnimals());
            }
    }
    }

