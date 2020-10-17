using Microsoft.AspNetCore.Http;

namespace Venue.Models.Models
{
    public class PlaceCreateModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public IFormFileCollection Images { get; set; }
    }
}
