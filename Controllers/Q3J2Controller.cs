using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a2_http5125.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class Q3J2Controller : ControllerBase
  {
    /// <summary>
    /// Calculate the total spiciness of Ron chili
    /// </summary>
    /// <param name="numPeppers">Number of peppers</param>
    /// <param name="peppers">List of pepper names</param>
    /// <returns>Total spiciness in Scolville Heat Units</returns>
    /// <example>
    /// POST: localhost:5169/api/Q3J2/calculatespiciness/ (Content-Type: application/x-www-form-urlencoded)
    /// Body: numPeppers=3&peppers=Thai&peppers=Cayenne&peppers=Serrano
    /// Output: 130500
    /// </example>
    [HttpPost(template: "calculatespiciness")]
    [Consumes("application/x-www-form-urlencoded")]

    public IActionResult CalculateSpiciness([FromForm] int numPeppers, [FromForm] List<string> peppers)
    {
      int totalSpiciness = 0;
      
        foreach (var pepper in peppers)
        {
          if (pepper == "Poblano")
          {
            totalSpiciness += 1500;
          }
          else if (pepper == "Mirasol")
          {
            totalSpiciness += 6000;
          }
          else if (pepper == "Serrano")
          {
            totalSpiciness += 15500;
          }
          else if (pepper == "Cayenne")
          {
            totalSpiciness += 40000;
          }
          else if (pepper == "Thai")
          {
            totalSpiciness += 75000;
          }
          else if (pepper == "Habanero")
          {
            totalSpiciness += 125000;
          }
          else
          {
            return BadRequest($"Unknown pepper: {pepper}");
          }
      }

      return Ok(totalSpiciness);
      
    }
  }
}
