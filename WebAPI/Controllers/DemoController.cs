using Microsoft.AspNetCore.Mvc;
using System;

namespace WebAPI.Controllers
{
    [ApiController]
    [Route("Demo")]

    public class DemoController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Welcome to docker world!";
        }
    }
}