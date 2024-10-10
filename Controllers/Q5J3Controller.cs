// Question from https://cemc.uwaterloo.ca/sites/default/files/documents/2023/2023CCCJrProblemSet.html

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a2_http5125.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class Q5J3Controller : ControllerBase
  {
    /// <summary>
    /// Determine the best day to schedule an event
    /// </summary>
    /// <param name="numPeople">Number of people interested in attending</param>
    /// <param name="availability">List of people's availability (Y or . for each of the 5 days)</param>
    /// <returns>Best day for the event</returns>
    /// <example>
    /// POST: localhost:5169/api/Q5J1/scheduleevent/ (Content-Type: application/x-www-form-urlencoded)
    /// Body: numPeople=3&availability=YY.Y.&availability=...Y.&availability=.YYY.
    /// Output: 4
    /// </example>
    [HttpPost(template: "scheduleevent")]
    [Consumes("application/x-www-form-urlencoded")]
    public IActionResult ScheduleEvent([FromForm] int numPeople, [FromForm] List<string> availability)
    {
      int[] dayAvailability = new int[5];

      foreach (var personAvailability in availability)
      {
        for (int i = 0; i < 5; i++)
        {
          if (personAvailability[i] == 'Y')
          {
            dayAvailability[i]++; 
          }
        }
      }

      int maxAvailability = dayAvailability.Max();

      List<int> bestDays = new List<int>();
      for (int i = 0; i < 5; i++)
      {
        if (dayAvailability[i] == maxAvailability)
        {
          bestDays.Add(i + 1); 
        }
      }

      return Ok(string.Join(",", bestDays));
    }
  }
}
