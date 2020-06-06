using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace AccessibleTourismApp.Model
{
    public class Place
    {
        public string Id { get; set; } = Guid.NewGuid().ToString();
        public string Image { get; set; }
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public string Address { get; set; }
        public List<string> Images { get; set; }
    }
}