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
    public partial class IndoDBoard : ContentPage
    {
        public IndoDBoard()
        {
            InitializeComponent();
        }

        private async void BaweanDeer(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/fFsyDR3/deer.jpg";
            obj.AnimalCode = "BD1";
            obj.AnimalName = "Bawean Deer";
            obj.InitialIdentification = "Indian hog deer";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia";
            obj.Family = "Cervidae";
            obj.Genus = "Axis ";
            obj.ScientificName = "Axis kuhlii ";
             obj.Taxonomy = "Mammal";
            obj.Characteristics = " medium-brown in color, with hairs banded with yellow giving the coat a grizzled appearance at close range.";
            obj.Habitat = "woodlands and upland forests";
            obj.Threats = "climate change";

            obj.Conservation = "Endangered";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }
        private async void SumatranTiger(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/1J7g65F/tiger.jpg";
            obj.AnimalCode = "PP1";
            obj.AnimalName = " Sumatran Tiger";
            obj.InitialIdentification = "smallest of all living tigers";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia";
            obj.Family = "Mustelidae";
            obj.Genus = "Neogale";
            obj.ScientificName = "Panthera Tigris Sumatrae";
                    obj.Taxonomy = "Mammal";
            obj.Characteristics = " a thick dark orange coat with thick black stripes that fade as they are closer to the edges; It has the darkest fur and with more density of lines compared to the other tigers.";
            obj.Habitat = "Sunda Islands";
            obj.Threats = "Habitat loss and poaching ";

            obj.Conservation = "Critical Endangered";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }

        private async void SulawesiForestTurtle(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/1J7g65F/tiger.jpg";
            obj.AnimalCode = "SFT1";
            obj.AnimalName = " Sulawesi Forest Turtle";
            obj.InitialIdentification = "smallest of all living tigers";
            obj.Kingdom = "Animalia";
            obj.Class = "Reptilia";
            obj.Family = "Geoemydidae";
            obj.Genus = "Leucocephalon";
            obj.ScientificName = "Leucocephalon yuwonoi";
            obj.Taxonomy = "Reptile";
            obj.Characteristics = "males have a white-yellow head while females have a brown head making them sexually dimorphic.";
            obj.Habitat = "cool mountain streams in the forests of northern Sulawesi";
            obj.Threats = "illegal exportation for the pet trade";

            obj.Conservation = "Critical Endangered";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }

        private async void SumatranRhino(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/BBwk7vW/rhino.jpg";
            obj.AnimalCode = "SR1";
            obj.AnimalName = "Sumatran Rhino";
            obj.InitialIdentification = "Asian two-horned rhinoceros";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia";
            obj.Family = "Rhinocerotidae";
            obj.Genus = "Dicerorhinus";
            obj.ScientificName = "Dicerorhinus sumatrensis";
            obj.Taxonomy = "Mammal";
            obj.Characteristics = "covered with long hair and are more closely related to the extinct woolly rhinos than any of the other rhino species alive today.";
            obj.Habitat = "Southwest China, particularly in Sichuan";
            obj.Threats = "habitat loss and fragmentation";

            obj.Conservation = "Endangered";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }

        private async void Tapir(object sender, EventArgs e)

        {
            Animal obj = new Animal();

            obj.Image = "https://i.ibb.co/899kpc0/tapir.jpg";
            obj.AnimalCode = "T1";
            obj.AnimalName = "Tapir";
            obj.InitialIdentification = "similar in shape to a pig";
            obj.Kingdom = "Animalia";
            obj.Class = "Mammalia";
            obj.Family = " Tapiridae";
            obj.Genus = " Tapirus";
            obj.ScientificName = "Tapirus indicus";
            obj.Taxonomy = "Mammal";
            obj.Characteristics = "oval, white-tipped ears, rounded, protruding rumps with stubby tails, and splayed, hooved toes, with four toes on the front feet and three on the hind feet, which help them to walk on muddy and soft ground.";
            obj.Habitat = "Tropical lowland swamp, montane and hill forests, prefers dense, primary forests.";
            obj.Threats = "habitat loss and fragmentation";

            obj.Conservation = "Vulnerable";

            var infoPage = new InfoPage();
            infoPage.BindingContext = obj;
            await Navigation.PushAsync(infoPage);
        }



    }
}