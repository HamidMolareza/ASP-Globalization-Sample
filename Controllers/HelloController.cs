using Globalization.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace Globalization.Controllers;

[ApiController]
[Route("[controller]")]
public class HelloController(IStringLocalizer<HelloController> localizer) : ControllerBase {
    [HttpGet]
    public ActionResult SayHello([FromQuery] FullName fullName) {
        // If the localized value of "Hello" isn't found, then the indexer key is returned, that is, the string "Hello".
        var message = $"{localizer["Hello"]} {fullName}!";
        // You can leave the default language literal strings in the app and wrap them in the localizer, so that you can focus on developing the app. You develop an app with your default language and prepare it for the localization step without first creating a default resource file.
        
        return Ok(new {
            Message = message,
            DateTime = DateTime.Now.ToLongDateString()
        });
    }
}