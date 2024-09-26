using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q3Controller : ControllerBase
    {
        //GET localhost:xx/api/q3/cube -> "Cube"
        [HttpGet(template: "cube/{num}")]
        public int q3(int num)
        {
            int cube = num * num * num;
            return cube;
        }
    }
}
