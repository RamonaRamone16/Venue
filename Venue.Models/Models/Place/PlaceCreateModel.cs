using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace Venue.Models.Models
{
    public class PlaceCreateModel
    {
        [Required(ErrorMessage = "Заполните поле")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Заполните поле")]
        public string Description { get; set; }
        public IFormFileCollection Images { get; set; }
    }
}
