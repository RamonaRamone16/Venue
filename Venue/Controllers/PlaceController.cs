using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Venue.BL.Services;
using Venue.DAL.Entities;
using Venue.Models.Models;

namespace Venue.Controllers
{
    public class PlaceController : Controller
    {
        private readonly PlaceService _service;
        private readonly UserManager<User> _userManager;

        public PlaceController(PlaceService service, UserManager<User> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult GetAll(SearchModel model)
        {
            model = _service.GetAll(model);
            return View("Index", model);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PlaceCreateModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            await _service.Create(model, user.Id);
            return RedirectToAction("GetAll");
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = await _service.GetById(id);
            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> GetPlace(int placeId)
        {
            var model = await _service.GetById(placeId);
            return PartialView("_Details", model);
        }

        [HttpPost]
        public async Task<IActionResult> AddRating(int placeId, int number)
        {
            var user = await _userManager.GetUserAsync(User);
            await _service.AddRating(placeId, user.Id, number);
            return RedirectToAction("Details", new { id = placeId });
        }
    }
}
