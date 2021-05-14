using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace GuestBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            return Ok();
        }
    }
}