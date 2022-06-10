using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC03_PracTest.Models;
using PDC03_PracTest.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_PracTest.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddAnimal : ContentPage
    {
        AnimalViewModel _viewModel;

        bool _isUpdate;
        int id;
        public AddAnimal()
        {
            InitializeComponent();
            _viewModel = new AnimalViewModel();
            _isUpdate = false;
        }

        public AddAnimal(AnimalModel obj)
        {
            InitializeComponent();
            _viewModel = new AnimalViewModel();
            if (obj != null)
            {
                id = obj.id;
                txtAnimalCode.Text = obj.AnimalCode;
                txtAnimalName.Text = obj.AnimalName;
                txtInitialIdentification.Text = obj.InitialIdentification;
                txtKingdom.Text = obj.Kingdom;
                txtClass.Text = obj.Class;
                txtFamily.Text = obj.Family;
                txtGenus.Text = obj.Genus;
                txtScientificName.Text = obj.ScientificName;
                txtTaxonomy.Text = obj.Taxonomy;
                txtCharacteristics.Text = obj.Characteristics;
                txtHabitat.Text = obj.Habitat;
                txtThreats.Text = obj.Threats;
                txtConservation.Text = obj.Conservation;
                _isUpdate = true;
            }
        }

        private async void btnSaveUpdate_Clicked(object sender, EventArgs e)
        {
            AnimalModel obj = new AnimalModel();
            obj.id = id;
            obj.AnimalCode = txtAnimalCode.Text;
            obj.AnimalName = txtAnimalName.Text;
            obj.InitialIdentification = txtInitialIdentification.Text;
            obj.Kingdom = txtKingdom.Text;
            obj.Class = txtClass.Text;
            obj.Family = txtFamily.Text;
            obj.Genus = txtGenus.Text;
            obj.ScientificName = txtScientificName.Text;
            obj.Taxonomy = txtTaxonomy.Text;
            obj.Characteristics = txtCharacteristics.Text;
            obj.Habitat = txtHabitat.Text;
            obj.Threats = txtThreats.Text;
            obj.Conservation = txtConservation.Text;

            if (_isUpdate)
            {
                obj.id = id;
                await _viewModel.UpdateAnimal(obj);
            }
            else
            {
                _viewModel.InsertAnimal(obj);
            }
            await this.Navigation.PopAsync();
        }

    }
}