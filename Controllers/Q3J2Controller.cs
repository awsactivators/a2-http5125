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
      Dictionary<string, int> pepper = new Dictionary<string, int>
      {
        {"Poblano", 1500},
        {"Mirasol", 6000},
        {"Serrano", 15500},
        {"Cayenne", 40000},
        {"Thai", 75000},
        {"Habanero", 125000}
      };

      int totalSpiciness = 0;

      for (int i = 0; i < numPeppers; i++)
      {
        if (pepper.ContainsKey(peppers[i]))
        {
          totalSpiciness += pepper[peppers[i]];
        } 
        else
        {
          return BadRequest($"Unknown pepper: {peppers[i]}");
        }
      }

      return Ok(totalSpiciness);
      
    }
  }
}
