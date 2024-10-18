// https://cemc.uwaterloo.ca/sites/default/files/documents/2021/2021CCCJrProblemSet.html

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace a2_http5125.Controllers
{
  [ApiController]
  [Route("api/[controller]")]
  public class Q5J3Controller : ControllerBase
  {
    /// <summary>
    /// Decodes instructions for finding the secret formula based on given input.
    /// </summary>
    /// <param name="instructions">A list of 5 digit coded instructions</param>
    /// <returns>List of decoded instructions indicating direction and steps</returns>
    /// <example>
    /// POST: localhost:5169/api/Q5J3/decodeinstructions (Content-Type: application/x-www-form-urlencoded)
    /// Body: instructions=57234&instructions=00907&instructions=34100&instructions=99999
    /// Output: right 234, right 907, left 100
    /// </example>
    [HttpPost(template: "decodeinstructions")]
    [Consumes("application/x-www-form-urlencoded")]
    public IActionResult DecodeInstructions([FromForm] List<string> instructions)
    {
      List<string> directions = new List<string>();
      List<string> steps = new List<string>();
      string previousDirection = "";
      int counter = 0;

      foreach (var instruction in instructions)
      {
        if (instruction == "99999")
        {
          break;
        }

        steps.Add(instruction.Substring(2));
        string check = instruction.Substring(0, 2);
        int sum = int.Parse(check[0].ToString()) + int.Parse(check[1].ToString());

        if (sum == 0)
        {
          directions.Add(previousDirection);
        }
        else if (sum % 2 == 0)
        {
          directions.Add("right");
          previousDirection = "right";
        }
        else
        {
          directions.Add("left");
          previousDirection = "left";
        }

        counter++;
      }

      List<string> result = new List<string>();
      for (int i = 0; i < counter; i++)
      {
        result.Add($"{directions[i]} {steps[i]}");
      }

      return Ok(string.Join(", ", result));
    }
  }
}
