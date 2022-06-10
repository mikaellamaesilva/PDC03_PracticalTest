using MvvmHelpers;
using PDC03_PracTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDC03_PracTest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public string UserImage { get; set; }
        public string Trivia { get; set; }

        public string Wiki { get; set; }
        public string WeatherCondition { get; set; }
        public string WeatherIcon { get; set; }
        public string ChanceOfRain { get; set; }

        public ObservableRangeCollection<CountryLocationViewModel> CountryLocations { get; set; }

        public MainViewModel()
        {
            Trivia = "Did you Know";

            Wiki = "More than 1,000 rhinos killed each year between 2013 and 2017 in Africa.";
            WeatherCondition = "IConserve WIKI";
            WeatherIcon = "next";
            ChanceOfRain = "2";
            UserImage = "https://i.ibb.co/W65Mxgv/Account-Icon.png";



            var firstLocation = new CountryLocationViewModel
                (new CountryModel()
            {

                Name = "Ecuador",
                LatLong = "Total of 2,301 Endangered Species",
                LocationThumbnail = "https://i.ibb.co/0YCH01n/galapagos.jpg",
                MapThumbnail = "https://i.ibb.co/NCYZGvD/ecuador.jpg",
                Animal = new System.Collections.Generic.List<AnimalIconModel>()

                {

                    new AnimalIconModel() 
                    
                    {
                        Descript=" Spread Awareness Now.",
                        Image ="https://i.ibb.co/3YtpSvW/andeanforg.jpg"

                    },


                    new AnimalIconModel()

                    {
                        Descript=" ",
                        Image ="https://i.ibb.co/vQP91WM/andean.jpg"

                    },


                    new AnimalIconModel()

                    {
                        Descript=" ",
                        Image ="https://i.ibb.co/gFKcmjR/capuchin.jpg"

                    },

                     new AnimalIconModel()

                    {
                        Descript=" ",
                        Image ="https://i.ibb.co/GHPgZPJ/2.png"

                    },

                }

            

            });
 

            var secondLocation = new CountryLocationViewModel
            (new CountryModel()
            {

                Name = "USA",
                LatLong = "Total of 1,226 Endangered Species",
                LocationThumbnail = "https://i.ibb.co/pb6yjhy/yellowstone.jpg",
                MapThumbnail = "https://i.ibb.co/jLBgMvF/usamap.jpg",
                Animal = new System.Collections.Generic.List<AnimalIconModel>()

            {

                    new AnimalIconModel()

                    {
                        Descript="For a Better Future.",
                        Image ="https://i.ibb.co/qYCzz7D/piping.jpg"

                    },


                    new AnimalIconModel()

                    {
                       Descript=" ",
                        Image ="https://i.ibb.co/SKwBS49/dakota.jpg"

                    },


                    new AnimalIconModel()

                    {
                        Descript=" ",
                        Image ="https://i.ibb.co/j5NzWDg/red.jpg"

                    },

                         new AnimalIconModel()

                    {
                        Descript=" ",
                        Image ="https://i.ibb.co/Scn53Fx/gala.jpg"

                    },

                                 new AnimalIconModel()

                    {
                        Descript=" ",
                        Image ="https://i.ibb.co/3RJFTvh/1.png"

                    },



            }



            });

            var thirdLocation = new CountryLocationViewModel
               (new CountryModel()
               {

                   Name = "Indonesia",
                   LatLong = "Total of 1206 Endangered Species",
                   LocationThumbnail = "https://i.ibb.co/vjv4LCJ/indonesia.jpg",
                   MapThumbnail = "https://i.ibb.co/RhtR5BH/indomap.png",
                   Animal = new System.Collections.Generic.List<AnimalIconModel>()

               {

                    new AnimalIconModel()

                    {
                        Descript="For Wildlife.",
                        Image ="https://i.ibb.co/BBwk7vW/rhino.jpg"

                    },


                    new AnimalIconModel()

                    {
                        Descript=" ",
                        Image ="https://i.ibb.co/1J7g65F/tiger.jpg"

                    },


                    new AnimalIconModel()

                    {
                        Descript=" ",
                        Image ="https://i.ibb.co/899kpc0/tapir.jpg"

                    },

                       new AnimalIconModel()

                    {
                        Descript=" ",
                        Image ="https://i.ibb.co/GHPgZPJ/2.png"

                    },

               }



               });

            CountryLocations = new ObservableRangeCollection<CountryLocationViewModel>();
            CountryLocations.Add(firstLocation);
            CountryLocations.Add(secondLocation);
            CountryLocations.Add(thirdLocation);
        }

    }

}




