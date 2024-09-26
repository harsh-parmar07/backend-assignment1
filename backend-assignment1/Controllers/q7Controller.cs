using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q7Controller : ControllerBase
    {
        [HttpGet(template: "timemachine")]
        public string timemachine(int days)
        {
            DateTime x = DateTime.Now;
            DateTime a = x.AddDays(days);
            return a.ToString("yyyy-MM-dd");
        }
    }
}
