using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CocoAController : ControllerBase
    {
        [HttpGet]
        [Authorize(Roles = "Standard")]
      //[Authorize]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "standard user web api 2 value1", "standard web api 2 value2" };
        }
        //[HttpGet]
        ////[Authorize(Roles = "Gold")]
        //public ActionResult<IEnumerable<string>> GetByGoldAccount()
        //{
        //    return new string[] { "Gold user web api 2 value1", "Gold web api 2 value2" };
        //}
    }
}