using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AccessibleTourismApp.Model;
using AccessibleTourismApp.Services;
using Tab = Xamarin.Forms.Tab;

namespace AccessibleTourismApp.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        public MainViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            
        }

    }
}
