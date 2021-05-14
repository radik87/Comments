using GuestBook.Models;
using GuestBook.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GuestBook.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : Controller
    {
        private readonly CommentService _commentService;

        public CommentController(CommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Json(await _commentService.Get());
        }

        [HttpPost]
        public async Task<IActionResult> Post(Comments comment)
        {
            return Json(await _commentService.Create(comment));
        }
    }
}
