using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        /// <summary>
        /// This provides the cube of any number given by the user
        /// </summary>
        /// <param name="num">here "num" is the number input by the user</param>
        /// <returns>
        /// An http response of the cube of the number entered by the user
        /// </returns>
        /// <example>
        ///GET localhost:xx/api/q3/cube -> "Cube"
        ///GET localhost:xx/api/q3/4 -> 64
        ///GET localhost:xx/api/q3/-4 -> -64
        /// </example>
        [HttpGet(template: "cube/{num}")]
        public int q3(int num)
        {
            int cube = num * num * num;
            return cube;
        }
    }
}
