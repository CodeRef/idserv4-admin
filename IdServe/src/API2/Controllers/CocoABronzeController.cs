using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocoABronzeController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Bronze")]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "bronze user web api 2 value1", "bronze web api 2 value2" };
        }
    }
}