using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q2Controller : ControllerBase
    {
        /// <summary>
        /// It gets a name from user and print Hi! and name after Hi
        /// </summary>
        /// <param name="name">
        /// name is the string for input from user
        /// </param>
        /// <returns>
        /// "Hi! {name}"
        /// </returns>
        /// <example>
        /// GET localhost:xx/api/q2/greeting?name=Gary -> "Hi Gary!"
        /// GET localhost:xx/api/q2/greeting?name=Harsh -> "Hi Harsh!"
        /// </example>
        [HttpGet(template: "greeting")]
        public string greeting(string name)
        {
            return $"Hi {name}!";
        }
    }
}
