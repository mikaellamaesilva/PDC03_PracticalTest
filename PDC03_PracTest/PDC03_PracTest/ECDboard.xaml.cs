using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PDC03_PracTest.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PDC03_PracTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ECDboard : ContentPage
    {
        public ECDboard()
        {
            InitializeComponent();



        }
        private async void AndeanFrog(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/3YtpSvW/andeanforg.jpg";
            obj.AnimalCode = "AF1";
            obj.AnimalName = "Andean Frog";
            obj.InitialIdentification = "changes skin texture in minutes, appearing to mimic the texture it sits on";
            obj.Kingdom = "Animalia";
            obj.Class = "Amphibia";
            obj.Family = "Hemiphractidae";
            obj.Genus = "Gastrotheca";
            obj.ScientificName = "Gastrotheca riobambae";
            obj.Taxonomy = "amphibians";
            obj.Characteristics = "change skin texture to reflect its surroundings";
            obj.Habitat = "montane forests to the dry rocky hillsides, and from the agave plants to the corn fields";
            obj.Threats = "Habitat Loss";
            
            obj.Conservation = "Endangered";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }

        private async void AndeanBear(object sender, EventArgs e)

        {
            Animal obj = new Animal();
            obj.Image = "https://i.ibb.co/vQP91WM/andean.jpg";
            obj.AnimalCode = "AB1";
            obj.AnimalName = "Andean Bear";
            obj.InitialIdentification = "Andean short-faced bear";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia ";
            obj.Family = "Ursidae ";
            obj.Genus = "Tremarctos";
            obj.ScientificName = "Tremarctos Ornatus";
            obj.Taxonomy = "mammal";
            obj.Characteristics = " Short-faced";
            obj.Habitat = "South-Africa";
            obj.Threats = "Habitat Loss";

            obj.Conservation = "Endangered";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }


        private async void Capuchin(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/gFKcmjR/capuchin.jpg";
            obj.AnimalCode = "C1";
            obj.AnimalName = "Capuchin";
            obj.InitialIdentification = "organ grinder monkey";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia ";
            obj.Family = "Cebidae ";
            obj.Genus = "Cebus";
            obj.ScientificName = "Cebus capucinus";
                    obj.Taxonomy = "mammal";
            obj.Characteristics = "a hairy, prehensile tail, and a darkly colored body, arms, and legs, with a white face, throat, and chest, and a dark cap on the head.";
            obj.Habitat = "wet lowland forests on the Caribbean coast of Costa Rica and Panama and deciduous dry forest on the Pacific coast.";
            obj.Threats = "They have also become popular pets and attractions for street entertainment and are hunted for meat by local people.";

            obj.Conservation = "Endangered";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }

        private async void GiantOtter(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/c8GZHRm/giant-otter.jpg";
            obj.AnimalCode = "GO1";
            obj.AnimalName = "Giant Otter";
            obj.InitialIdentification = "Giant River Otter";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia ";
            obj.Family = "Cebidae ";
            obj.Genus = "Pteronura";
            obj.ScientificName = "Pteronura brasiliensis";
                    obj.Taxonomy = "mammal";
            obj.Characteristics = "he shortest fur of all otter species; it is typically chocolate brown, but may be reddish or fawn, and appears nearly black when wet.";
            obj.Habitat = "along the Amazon River and in the Pantanal.";
            obj.Threats = "Poaching";

            obj.Conservation = "Endangered";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }

        private async void ColombianWeasel(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/jwgLHVV/weasel.jpg";
            obj.AnimalCode = "CW1";
            obj.AnimalName = "Colombian Weasel";
            obj.InitialIdentification = "Don Felipe's weasel ";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia ";
            obj.Family = "Mustelidae";
            obj.Genus = "Neogale ";
            obj.ScientificName = "Neogale felipei ";
            obj.Taxonomy = "mammal";
            obj.Characteristics = "ark dorsal color with no variation, ventrally the weasel has a light orange color with gradual fading of color up to the head.";
            obj.Habitat = "departments of Huila and Cauca in Colombia.";
            obj.Threats = "Deforestation ";

            obj.Conservation = "Vulnerable";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }





    }
}
