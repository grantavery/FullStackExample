using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FullStackExample.Domain.Abstract;
using FullStackExample.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace FullStackExample.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloWorldController : Controller
    {
        private IHelloWorldService helloWorldService;

        public HelloWorldController(IHelloWorldService helloWorldService)
        {
            this.helloWorldService = helloWorldService;
        }

        [HttpGet]
        public async Task<HelloWorldModel> Get()
        {
            HelloWorldModel helloWorld = await helloWorldService.GetHelloWorld();

            return helloWorld;
        }
    }
}
