using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AccessibleTourismApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PlacesView : ContentPage
    {
        public PlacesView()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            var tabbedPage = this.Parent as MainView;
            tabbedPage.NavigateTo("map");
        }
    }
}