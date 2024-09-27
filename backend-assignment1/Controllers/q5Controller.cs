using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q5Controller : ControllerBase
    {
        /// <summary>
        /// An http post request to get the number from the user and retrive and gives from the body
        /// </summary>
        /// <param name="sec_num">the number input of secret number given by the user </param>
        /// <returns>
        /// an http response as "Shh... The number is {number}"
        /// </returns>
        /// <remarks>
        /// Heading: Content-Type: application/json
        /// </remarks>
        /// <example>
        ///POST localhost:xx/api/q5/secret -> "Shh.. the secret is number"
        ///POST localhost:xx/api/q5/secret -> "Shh.. the secret is 10" when -d "10"
        ///POST localhost:xx/api/q5/secret -> "Shh.. the secret is 0" when -d "0"
        ///POST localhost:xx/api/q5/secret -> "Shh.. the secret is -10" when -d "-10"
        [HttpPost(template: "secret")]
        public string q5([FromBody] int sec_num)
        {

            return $"Shh.. the secret is {sec_num}";
        }
    }
}
