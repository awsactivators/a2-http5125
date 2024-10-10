// Question from: https://cemc.uwaterloo.ca/sites/default/files/documents/2022/2022CCCJrProblemSet.html

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a2_http5125.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Q4J2Controller : ControllerBase
    {
    /// <summary>
    /// Determine how many players have a star rating greater than 0 and if the team is a gold team
    /// </summary>
    /// <param name="numPlayers">Number of players</param>
    /// <param name="pointsAndFouls">A list of alternating points and fouls for each player</param>
    /// <returns>Number of players with rating greater than 0 and gold team status</returns>
    /// <example>
    /// POST: localhost:5169/api/Q4J1/calculatestars/ (Content-Type: application/x-www-form-urlencoded)
    /// Body:      numPlayers=3&pointsAndFouls=12&pointsAndFouls=4&pointsAndFouls=10&pointsAndFouls=3&pointsAndFouls=9&pointsAndFouls=1
    /// Output: 3+
    /// </example>
    [HttpPost(template: "stars")]
    [Consumes("application/x-www-form-urlencoded")]
    public IActionResult CalculateStars([FromForm] int numPlayers, [FromForm] List<int> pointsAndFouls)
    {
      int positiveRatingCount = 0;
      bool isGoldTeam = true;

      for (int i = 0; i < numPlayers; i++)
      {
        int points = pointsAndFouls[i * 2];  
        int fouls = pointsAndFouls[i * 2 + 1]; 

        int starRating = points - fouls;

        if (starRating > 0)
        {
          positiveRatingCount++;
        }
        else
        {
          isGoldTeam = false; 
        }
      }

      string result = positiveRatingCount.ToString();
      if (isGoldTeam)
      {
        result += "+";
      }

      return Content(result);
    }
  }
}