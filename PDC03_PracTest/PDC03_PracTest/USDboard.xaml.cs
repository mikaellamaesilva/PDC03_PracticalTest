using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using PDC03_PracTest.Models;
namespace PDC03_PracTest
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class USDboard : ContentPage
    {
        public USDboard()
        {
            InitializeComponent();
        }

        private async void GalaposTurtle(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/Scn53Fx/gala.jpg";
            obj.AnimalCode = "GT1";
            obj.AnimalName = "GalaposTurtle";
            obj.InitialIdentification = "Giant Tortoises of the Galápagos";
            obj.Kingdom = "Animalia";
            obj.Class = "Reptilia";
            obj.Family = "Testudinidae";
            obj.Genus = "Chelonoidis";
            obj.ScientificName = "Chelonoidis niger";
            obj.Taxonomy = "Reptile ";
            obj.Characteristics = "a large bony shell of a dull brown, light green or grey color. The plates of the shell are fused with the internal skeleton, providing the tortoise with a rigid protective structure.";
            obj.Habitat = "Ecuadorian coast, namely, Isabela, Pinzon, Espanola, San Cristobal, Santa Cruz, and Santiago.";
            obj.Threats = "predation and habitat destruction ";

            obj.Conservation = "Critically Endangered ";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }
        private async void AmericanRedWolf(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/j5NzWDg/red.jpg";
            obj.AnimalCode = "ARW1";
            obj.AnimalName = "American Red Wolf";
            obj.InitialIdentification = "Coywolf";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia ";
            obj.Family = "Mustelidae ";
            obj.Genus = "Canidae ";
            obj.ScientificName = "Pteronura brasiliensis ";
                    obj.Taxonomy = "Mammal ";
            obj.Characteristics = "Its fur is generally tawny to grayish in color, with light markings around the lips and eyes. intermediate in size between the coyote and gray wolf. ";
            obj.Habitat = "Northeastern North Carolina.";
            obj.Threats = "Poaching";

            obj.Conservation = "Endangered ";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }
        private async void NorthAtlanticWhale(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/rsV1t3z/north.jpg ";
            obj.AnimalCode = "NAW1";
            obj.AnimalName = "North Atlantic Whale ";
            obj.InitialIdentification = "unique pattern of 'callosities' on their heads";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia";
            obj.Family = "Balaenidae";
            obj.Genus = "Eubalaena";
            obj.ScientificName = "Eubalaena glacialis";
                    obj.Taxonomy = "Mammal ";
            obj.Characteristics = "a large head, which makes up a quarter of its total body length, narrow tail stock in comparison to its wide fluke and v-shaped blowhole which produces a heart-shaped blow.";
            obj.Habitat = "Western North Atlantic Ocean";
            obj.Threats = "ship collisions, entanglement in fishing nets, and separation from calving areas because of shipping traffic";

            obj.Conservation = "Critically Endangered ";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }

        private async void NorthDakota(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/rsV1t3z/north.jpg ";
            obj.AnimalCode = "ND1";
            obj.AnimalName = "North Dakota ";
            obj.InitialIdentification = "Nokota horse";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia";
            obj.Family = "Balaenidae";
            obj.Genus = "Eubalaena";
            obj.ScientificName = "Equus ferus caballus";
            obj.Taxonomy = "Mammal ";
            obj.Characteristics = "Angular frame, often blue.";
            obj.Habitat = "North Dakota";
            obj.Threats = "climate change";

            obj.Conservation = "Endangered ";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }

        private async void PipingPlover(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/qYCzz7D/piping.jpg";
            obj.AnimalCode = "PP1";
            obj.AnimalName = "Piping Plover ";
            obj.InitialIdentification = "sandy grayish brown birds";
            obj.Kingdom = "Animalia";
            obj.Class = "Aves ";
            obj.Family = "Charadriidae ";
            obj.Genus = "Charadrius ";
            obj.ScientificName = "Eubalaena glacialis";
            obj.Taxonomy = "Birds";
            obj.Characteristics = "small sand-colored, sparrow-sized shorebird.";
            obj.Habitat = "along coastal sand and gravel beaches in North America ";
            obj.Threats = "climate change";

            obj.Conservation = "Near Threatened";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }







    }
}