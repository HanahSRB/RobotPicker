using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Robot_Transport.Controllers
{
    [Route("api/robots/closest")]
    [ApiController]
    public class ClosestController : ControllerBase
    {

        private readonly ILogger<ClosestController> _logger;

        public ClosestController(ILogger<ClosestController> logger)
        {
            _logger = logger;
        }

        //client to make call to get list or bots
        private static readonly HttpClient client = new HttpClient();

        
        [HttpPost]
        public async Task<Response> PostAsync(Load load)
        {
            //get list of bots
            var streamTask = client.GetStreamAsync("https://60c8ed887dafc90017ffbd56.mockapi.io/robots");
            //Parse list of bots and store in Payload list
            var bots = await JsonSerializer.DeserializeAsync<List<Payload>>(await streamTask);
            //return robot to go to load
            return FindClosestRobot.FindClosetBot(load, bots);
        }

        


    }
}
