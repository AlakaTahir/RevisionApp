using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RevisionApp.Model;
using RevisionApp.Service;

namespace RevisionApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisplayController : ControllerBase
    {
        private readonly IDisplayService _displayService;

        public DisplayController(IDisplayService displayService)
        {
            _displayService = displayService;
        }

        [HttpPost]
        public IActionResult DisplayName(NameCollectorModel model)
        {
            var result = _displayService.DisplayName(model);
            return Ok(result);
        }
    }
}
