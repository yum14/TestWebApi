using Microsoft.AspNetCore.Mvc;

namespace SampleWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public async Task<IActionResult> GetAsync()
        {
            return Ok("get����");
        }

        [HttpDelete]
        public async Task<IActionResult> DeleteAsync()
        {
            return Ok("delete����");
        }
    }
}