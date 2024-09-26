using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        [HttpPost(template: "squashfellows")]
        public string squashfellows([FromForm] int small, [FromForm] int large)
        {
            double smalltotal = small * 25.50;
            double largetotal = large * 40.50;
            double price = smalltotal + largetotal;
            double tax = Math.Round(price * 0.13, 2);
            double total = price + tax;
            var culture = new CultureInfo("en-CA");
            string sformat = smalltotal.ToString("C2", culture);
            string lformat = largetotal.ToString("C2", culture);
            string pformat = price.ToString("C2", culture);
            string tformat = tax.ToString("C2", culture);
            string totalformat = total.ToString("C2", culture);
            return $"{small} small @ 25.50 = {sformat}; {large} Large @ 45.50 = {lformat}; Subtotal = {pformat}; Tax = {tformat}; Total = {totalformat}";
        }
    }
}
