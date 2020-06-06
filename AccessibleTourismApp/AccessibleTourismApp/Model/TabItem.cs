using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using AccessibleTourismApp.Annotations;

namespace AccessibleTourismApp.Model
{
    public class TabItem : INotifyPropertyChanged
    {
        public string Id { get; set; }
        public bool Selected { get; set; }
        public string Title { get; set; }
        public IList<Place> Items { get; set; }
        public bool Map { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
