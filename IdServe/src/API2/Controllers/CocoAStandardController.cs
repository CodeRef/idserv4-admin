using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocoAStandardController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Standard")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "standard user web api 2 value1", "standard web api 2 value2" };
        }
    }
}