using MvvmHelpers;
using PDC03_PracTest.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PDC03_PracTest.ViewModels
{
    public class OnboardingViewModel : BaseViewModel 
    {

        private ObservableRangeCollection<OnboardingModel> items;


        public ObservableRangeCollection<OnboardingModel> Items
        {
            get => items;
            set => SetProperty(ref items, value);
        }


        public OnboardingViewModel()
        {
            // create our dummy onboarding items
            Items = new ObservableRangeCollection<OnboardingModel>
            {
              
                new OnboardingModel
                {
                    Title = "Spread Awareness Now.",
                    Content = "Species become endangered for two reasons: loss of habitat and genetic variation.  ",
                    Image  = "OnboardingImage2"
                },
                new OnboardingModel
                {
                    Title = "Have a Heart, Do Your Part.",
                    Content = " Healthy ecosystems depend on plant and animal species as their foundations.  ",
                    Image  = "OnboardingImage3"
                },

                   new OnboardingModel
                {
                    Title = "If Animals Are Lost, We Will Pay The Cost",
                    Content = " When a species becomes endangered, it is a sign that the ecosystem is slowly falling apart.",
                    Image  = "OnboardingImage4"
                },



            };


        }

    }
}