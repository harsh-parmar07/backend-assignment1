using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q1Controller : ControllerBase
    {
        /// <summary>
        /// This code gets an HTTP get request and gives a message as an output
        /// </summary>
        /// <returns>
        /// Provides a message as "Welcome to 5125"
        /// </returns>
        /// <example>
        ///GET api/q1/welcome ->  Welcome to 5125
        /// </example>
        [HttpGet(template: "welcome")]
        public string welcome()
        {
            return "Welcome to 5125!";
        }
    }
}
