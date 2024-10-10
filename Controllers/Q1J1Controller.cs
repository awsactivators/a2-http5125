using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a2_http5125.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  
  public class Q1J1Controller : ControllerBase
  {
    /// <summary>
    /// Calculate final score after packages are delivered with/without collisions
    /// </summary>
    /// <param name="delivered">Number of packages delivered</param>
    /// <param name="collisions">Number of collisions</param>
    /// <returns>Final score</returns>
    /// <example>
    /// POST: localhost:5026/api/Q1J1/delivedroid (Content-Type: application/x-www-form-urlencoded)
    /// Body: delivered=5&collisions=2
    /// Output: 730
    /// </example>
    [HttpPost(template: "delivedroid")]
    [Consumes("application/x-www-form-urlencoded")]
    public int Delivedroid([FromForm] int delivered, [FromForm] int collisions)
    {
      int finalScore = (delivered * 50) - (collisions * 10);
      if (delivered > collisions)
      {
        finalScore += 500;
      }
      return finalScore;
    }
  }
}

