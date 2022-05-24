using Microsoft.AspNetCore.Mvc;
using webapi.Model;

namespace webapi.Controllers;

[ApiController]
[Route("[controller]")]
public class GenerateStringController : ControllerBase
{
    // [HttpGet, Route("get")]
    // public IActionResult Get([FromBody]Generate model)
    // {
    //     return Ok();
    // }


    [HttpGet, Route("psot")]
    public IActionResult Post([FromQuery]Generate model)
    {
        Random rand = new Random();
        
        int stringlen = model.Lengs;
        int randValue;
        string str = "";
        char letter;
        char upper;
        for (int i = 0; i < stringlen; i++)
        {   
            randValue = rand.Next(0, 26);
            
            letter = Convert.ToChar(randValue + 65);
            upper = Convert.ToChar(randValue + 97);

            str = upper + str + letter;
        }
        return Ok(str);
    }
}
