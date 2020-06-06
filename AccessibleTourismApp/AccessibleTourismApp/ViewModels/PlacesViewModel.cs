using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using AccessibleTourismApp.Model;
using MvvmHelpers;
using Prism.Navigation;

namespace AccessibleTourismApp.ViewModels
{
    public class PlacesViewModel : ViewModelBase
    {
        public ObservableRangeCollection<Place> Places { get; set; }
        public PlacesViewModel(INavigationService navigationService) : base(navigationService)
        {
            Places = new ObservableRangeCollection<Place>();
        }

        public override async void Initialize(INavigationParameters parameters)
        {
            base.Initialize(parameters);
            await LoadItems();
        }

        private async Task LoadItems()
        {
            var places = await Api.GetPlaces();
            Places.AddRange(places);
        }
    }
}