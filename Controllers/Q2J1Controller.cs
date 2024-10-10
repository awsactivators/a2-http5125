// Question from: https://cemc.uwaterloo.ca/sites/default/files/documents/2022/2022CCCJrProblemSet.html

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a2_http5125.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class Q2J1Controller : ControllerBase
  {
    /// <summary>
    /// Determine how many cupcakes are left after distributing to students
    /// </summary>
    /// <param name="regularBoxes">Number of regular boxes (8 cupcakes each)</param>
    /// <param name="smallBoxes">Number of small boxes (3 cupcakes each)</param>
    /// <returns>Leftover cupcakes</returns>
    /// <example>
    /// GET: localhost:5026/api/Q2J1/calculateleftover?regularBoxes=2&smallBoxes=5
    /// Output: 3
    /// </example>
    [HttpGet(template: "calculateleftover")]
    public IActionResult CalculateLeftovers(int regularBoxes, int smallBoxes)
    {
      int students = 28;

      int totalCupcakes = (regularBoxes * 8) + (smallBoxes * 3);

      if (totalCupcakes < students)
      {
        return BadRequest("Error: The total number of cupcakes must be at least 28.");
      }

      int leftoverCupcakes = totalCupcakes - students;

      return Ok(leftoverCupcakes);
    }
  }
}
