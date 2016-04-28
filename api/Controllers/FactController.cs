using Microsoft.AspNet.Mvc;
using Chuck.Models;

namespace Chuck.Controllers
{
  [Route("[controller]")]
  public class FactController : Controller
  {    
    [HttpGet]
    public IActionResult Fact()
    {
      return new ObjectResult(new ChuckFact {
        Content="Chuck Norris can divide by zero."
      });
    }
  }
}
