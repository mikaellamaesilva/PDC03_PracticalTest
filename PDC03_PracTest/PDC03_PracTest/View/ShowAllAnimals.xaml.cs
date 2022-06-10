using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC03_PracTest.Models;
using PDC03_PracTest.ViewModels;
using System.Collections.ObjectModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_PracTest.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowAllAnimals : ContentPage
    {
        AnimalViewModel viewModel;
        public ShowAllAnimals()
        {
            InitializeComponent();
            viewModel = new AnimalViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            showAnimalList();
        }

        private void showAnimalList()
        {
            var res = viewModel.GetAllAnimals().Result;
            listData.ItemsSource = res;

        }

        private void btnAddAnimal_Clicked(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new AddAnimal());
        }
        private async void listData_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem != null)
            {
                AnimalModel obj = (AnimalModel)e.SelectedItem;
                string res = await DisplayActionSheet("Operation", "Cancel", null, "Update", "Delete");

                switch (res)
                {
                    case "Update":
                        await this.Navigation.PushAsync(new AddAnimal(obj));
                        break;
                    case "Delete":
                        viewModel.DeleteAnimal(obj);
                        showAnimalList();
                        break;
                }
                listData.SelectedItem = null;
            }
        }
    }
}