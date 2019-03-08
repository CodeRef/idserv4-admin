using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocoASilverController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Silver")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Silver user web api 2 value1", "Silver web api 2 value2" };
        }
    }
}