using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        
        // GET api/values/5
        [HttpGet("{id}")]
        public Task<string> Get(int id)
        {
            return Task.Run(() =>
            {
                return "hello world:" + id.ToString();
            });
        }
        
    }
}