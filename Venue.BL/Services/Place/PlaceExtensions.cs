using System.Collections.Generic;
using System.Linq;
using Venue.DAL.Entities;

namespace Venue.BL.Services
{
    public static class PlaceExtensions
    {
        public static IEnumerable<Place> GetByName(this IEnumerable<Place> places, string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
                return places.Where(p => p.Name.Contains(name)).ToList();
            return places;
        }
    }
}
