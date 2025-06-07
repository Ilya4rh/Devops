using Microsoft.AspNetCore.Mvc;

namespace DevopsAPI.Controllers;

[Route("api/math")]
public class MathController : ControllerBase
{
    [HttpPost("sum")]
    public IActionResult Sum([FromBody]NumRequest request)
    {
        var result = request.Number1 + request.Number2;

        return Ok(result);
    }
    
    [HttpPost("subtract")]
    public IActionResult Subtract([FromBody]NumRequest request)
    {
        var result = request.Number1 - request.Number2;

        return Ok(result);
    }
    
    [HttpPost("multiply")]
    public IActionResult Multiply([FromBody]NumRequest request)
    {
        var result = request.Number1 * request.Number2;

        return Ok(result);
    }
    
    [HttpPost("divide")]
    public IActionResult Divide([FromBody]NumRequest request)
    {
        if (request.Number2 == 0)
        {
            return BadRequest("На ноль делить нельзя");
        }
        
        var result = request.Number1 / request.Number2;

        return Ok(result);
    }
}