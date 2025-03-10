using ImageProcessingBackend.Data;
using Microsoft.AspNetCore.Mvc;

namespace ImageProcessingBackend.Controllers
{
    [Route("api/images")]
    [ApiController]
    public class ImageController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public ImageController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAllImages()
        {
            var images = _context.Images.ToList();
            return Ok(images);
        }
    }
}
