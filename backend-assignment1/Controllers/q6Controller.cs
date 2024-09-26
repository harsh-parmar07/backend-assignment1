using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q6Controller : ControllerBase
    {
        [HttpGet(template: "hexagon")]
        public double hexagon(double side)
        {
            return (double)((double)(3 * Math.Sqrt(3) / 2) * (Math.Pow(side, 2)));
        }
    }
}
