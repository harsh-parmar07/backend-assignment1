using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q4Controller : ControllerBase
    {
        /// <summary>
        /// An http post request to which will have text Who's There as an output.
        /// </summary>
        /// <returns>
        /// output will be  "Who's There".
        /// </returns>
        /// <example>
        ///POST : api/q4/knockknock -> "Who's there?"
        /// </example>
        [HttpPost(template: "knockknock")]
        public string knockknock()
        {
            return "Who's there?";
        }
    }
}
