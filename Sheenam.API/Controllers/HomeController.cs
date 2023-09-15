using Microsoft.AspNetCore.Mvc;
using RESTFulSense.Controllers;

namespace Sheenam.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HomeController : RESTFulController
    {
        [HttpGet]
        public ActionResult Get() =>
            Ok("Ok");
    }
}
