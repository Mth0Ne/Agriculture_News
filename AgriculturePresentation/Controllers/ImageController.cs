using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace AgriculturePresentation.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService _ımageService;

        public ImageController(IImageService ımageService)
        {
            _ımageService = ımageService;
        }

        public IActionResult Index()
        {
            var values = _ımageService.GetListAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult AddService()
        {

        }
        [HttpPost]
        public IActionResult AddService()
        {

        }
    }
}
