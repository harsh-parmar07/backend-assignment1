using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace backend_assignment1.Controllers
{
    /// <summary>
    /// Handles an HTTP GET request to add the user-specified number of days to the current date.
    /// </summary>
    /// <param name="days">An integer representing the number of days to add to the current date.</param>
    /// <returns>
    /// A string representing the new date with the added number of days, formatted as "yyyy-MM-dd".
    /// </returns>
    /// <remarks>
    /// The "MM" in the date format represents the month (in uppercase).
    /// </remarks>
    /// <example>
    /// GET http://localhost:xx/api/q7/timemachine?days=1  -> tomorrow's date
    /// GET http://localhost:xx/api/q7/timemachine?days=0  -> Todays's date
    /// GET http://localhost:xx/api/q7/timemachine?days=-1 -> yesterday's date
    /// </example>
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
