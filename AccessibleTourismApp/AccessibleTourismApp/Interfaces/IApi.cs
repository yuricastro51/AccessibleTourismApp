using System.Collections.Generic;
using System.Threading.Tasks;
using AccessibleTourismApp.Model;

namespace AccessibleTourismApp.Interfaces
{
    public interface IApi
    {
        Task<IList<Place>> GetPlaces();
    }
}