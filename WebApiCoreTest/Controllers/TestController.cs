using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCoreTest.Controllers
{
    [ApiController]
    [Route("api/test")]
    public class TestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<string[]> GetNames()
        {
            string[] names = { "Morten, Merete, Louis" };
            return names;
        }
    }
}