using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AdPlatformController : ControllerBase
    {
        private readonly AdPlatformService _service;

        public AdPlatformController(AdPlatformService service)
        {
            _service = service;
        }

        [HttpPost("upload")]
        public async Task<IActionResult> Upload(IFormFile file)
        {
            if (file == null || file.Length == 0)
                return BadRequest("Файл не найден");

            var lines = new List<string>();
            using var reader = new StreamReader(file.OpenReadStream());
            while (!reader.EndOfStream)
                lines.Add(await reader.ReadLineAsync());

            _service.LoadFromFile(lines.ToArray());
            return Ok("Загружено");
        }

        [HttpGet("search")]
        public IActionResult Search([FromQuery] string location)
        {
            if (string.IsNullOrWhiteSpace(location))
                return BadRequest("Локация не указана");

            var result = _service.FindPlatforms(location);
            return Ok(result);
        }
    }
}
