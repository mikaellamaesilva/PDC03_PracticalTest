using MvvmHelpers;
using PDC03_PracTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PDC03_PracTest.ViewModels
{
    public class CountryLocationViewModel : BaseViewModel
    {
        private CountryModel location;

        public CountryModel Location
        {
            get => location;
            set => location = value;
        }
        public string AnimalAtLocation
        {
            get
            {
                var peopleCount = location.Animal.Count;
                var first = location.Animal.FirstOrDefault();
                if (first == null)
                    return "It's just you";

                return $"{first.Descript}";

            }
        }


        public CountryLocationViewModel(CountryModel location)

        {

            this.Location = location;

        }

        
    }

}




 
 


