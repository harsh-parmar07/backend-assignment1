using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        /// <summary>
        /// Handles an HTTP GET request to calculate the area of a hexagon based on the user's input for the side length. 
        /// </summary>
        /// <param name="lenght">The side length should be provided as a double for more precise output, as the area is returned in decimal format.</param>
        /// <remarks>
        /// if we want output in decimals we should use double.
        /// </remarks>
        /// <returns>
        /// An HTTP get response as the area of hexagon.
        /// </returns>
        /// <example>
        /// GET http://localhost:xx/api/q6/hexagon?side=1   ->  2.598076211353316
        /// GET http://localhost:xx/api/q6/hexagon?side=1.5  ->  5.845671475544961
        /// GET http://localhost:xx/api/q6/hexagon?side=2  ->  10.392304845413264
        /// </example>
        [HttpGet(template: "hexagon")]
        public double hexagon(double lenght)
        {
            return (double)((double)(3 * Math.Sqrt(3) / 2) * (Math.Pow(lenght, 2)));
        }
    }
}
