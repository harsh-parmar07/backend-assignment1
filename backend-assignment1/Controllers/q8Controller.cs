using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace backend_assignment1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class q8Controller : ControllerBase
    {
        /// <summary>
        /// Handles an HTTP POST request to calculate the total price based on the number of small and large items from the form submission. 
        /// The total includes item price, tax, and the final price.
        /// </summary>
        /// <param name="small">An integer representing the quantity of small items submitted in the form.</param>
        /// <param name="large">An integer representing the quantity of large items submitted in the form.</param>
        /// <returns>
        /// A string detailing the item quantities, prices, tax, and the final total.
        /// </returns>
        /// <example>
        /// POST http://localhost:xx/api/q8/squashfellows  -> (when small as 1 and large as 1) 1 Small @ $25.50 = $25.50; 1 Large @ $40.50 = $40.50; Subtotal = $66.00; Tax = $8.58 HST; Total = $74.58
        /// POST http://localhost:xx/api/q8/squashfellows  -> (when small as 2 and large as 1) 2 small @ 25.50 = $51.00; 1 Large @ 45.50 = $40.50; Subtotal = $91.50; Tax = $11.90; Total = $103.40
        /// POST http://localhost:xx/api/q8/squashfellows  -> (when small as 100 and large as 100) 100 small @ 25.50 = $2,550.00; 100 Large @ 45.50 = $4,050.00; Subtotal = $6,600.00; Tax = $858.00; Total = $7,458.00
        /// </example>
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
