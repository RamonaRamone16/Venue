using System.Collections.Generic;
using Venue.Models.Models.Place;

namespace Venue.Models.Models
{
    public class SearchModel 
    {
        public string Name { get; set; }
        public List<PlaceIndexModel> Places { get; set; }
    }
}
