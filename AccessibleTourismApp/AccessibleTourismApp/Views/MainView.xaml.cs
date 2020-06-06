using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using NavigationPage = Xamarin.Forms.NavigationPage;
using TabbedPage = Xamarin.Forms.TabbedPage;

namespace AccessibleTourismApp.Views
{
    public partial class MainView : TabbedPage
    {
        public MainView()
        {
            InitializeComponent();
        }

        public void NavigateTo(string name)
        {
            switch (name)
            {
                case "places":
                    CurrentPage = Children[0];
                    break;
                case "map":
                    CurrentPage = Children[1];
                    break;
            }
        }
    }
}