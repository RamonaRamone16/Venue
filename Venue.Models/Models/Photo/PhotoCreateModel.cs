using Microsoft.AspNetCore.Http;

namespace Venue.Models.Models.Photo
{
    public class PhotoCreateModel
    {
        public int PlaceId { get; set; }
        public IFormFileCollection Images { get; set; }
    }
}
