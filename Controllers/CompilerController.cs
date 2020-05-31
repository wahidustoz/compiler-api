using System.Net.Mime;
using System;
using System.Net;
using compiler_api.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace compiler_api.Controllers
{
    [ApiController]
    public class CompilerController : ControllerBase
    {
        private readonly ILogger<CompilerController> logger;

        public CompilerController(ILogger<CompilerController> _logger)
        {
            logger = _logger;
        }

        [Route("{controller}/submit")]
        [HttpPost]
        public async ActionResult Submit([FromBody]Code code)
        {

            logger.LogInformation(System.Text.Json.JsonSerializer.Serialize(code, options: new System.Text.Json.JsonSerializerOptions(){ WriteIndented = true }));
            
            var content = code.Content;

            switch(code.LanguageCode.ToLower())
            {
                case "cpp":
                case "c++":
                {
                    var result = await Services.CompilerService.CPP.Compile(content);
                    break;
                }
            }

            return Ok(new {
                message = "Accepted",
                timestamp = DateTime.Now
            });
        }
        
    }
}