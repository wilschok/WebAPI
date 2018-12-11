using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LanguagesController : ControllerBase
    {
        // GET api/languages
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "C#", "Java", "Python", "Javascript" };
        }
    }
}