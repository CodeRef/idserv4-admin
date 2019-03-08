using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocoAGoldController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Gold")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "Gold user web api 2 value1", "Gold web api 2 value2" };
        }
    }
}