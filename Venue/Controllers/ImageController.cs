using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Venue.BL.Services;
using Venue.Models.Models.Photo;

namespace Venue.Controllers
{
    public class ImageController : Controller
    {
        private readonly PlaceService _service;

        public ImageController(PlaceService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Create(int placeId)
        {
            return PartialView(new PhotoCreateModel() { PlaceId = placeId });
        }

        [HttpPost]
        public async Task<IActionResult> Create(PhotoCreateModel model, int placeId)
        {
            await _service.CreatePhotos(model.Images, placeId);
            return RedirectToAction("Details", "Place", new { id = placeId });
        }
    }
}
