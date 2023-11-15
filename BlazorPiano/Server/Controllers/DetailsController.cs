using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorPiano.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailsController : ControllerBase
    {
        private readonly IDetailsServices _detailsServices;

        public DetailsController(IDetailsServices detailsServices)
        {
            _detailsServices = detailsServices;
        }
        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Details>>>> GetDetails()
        {
            var result = await _detailsServices.GetDetails();
            return Ok(result);
        }
    }
}
