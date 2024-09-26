using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        // GET localhost:xx/api/q2/greeting?name=Gary -> "Hi Gary!"
        // GET localhost:xx/api/q2/greeting?name=Harsh -> "Hi Harsh!"
        [HttpGet(template: "greeting")]
        public string greeting(string name)
        {
            return $"Hi {name}!";
        }
    }
}
