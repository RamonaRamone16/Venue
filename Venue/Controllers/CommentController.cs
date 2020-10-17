using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Venue.BL.Services;
using Venue.DAL.Entities;
using Venue.Models.Models.Comment;

namespace Venue.Controllers
{
    public class CommentController : Controller
    {
        private readonly CommentService _service;
        private readonly UserManager<User> _userManager;

        public CommentController(CommentService service, UserManager<User> userManager)
        {
            _service = service;
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll(int placeId)
        {
            var models = await _service.GetAll(placeId);
            return PartialView("_AllComments", models);
        }

        [HttpPost]
        public async Task<IActionResult> Create(CommentCreateModel model)
        {
            var user = await _userManager.GetUserAsync(User);
            await _service.Create(model, user.Id);
            return NoContent();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return NoContent();
        }
    }
}
