using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        //POST localhost:xx/api/q5/secret -> "Shh.. the secret is number"
        [HttpPost(template: "secret")]
        public string q5([FromBody] int integer)
        {

            return $"Shh.. the secret is {integer}";
        }
    }
}
