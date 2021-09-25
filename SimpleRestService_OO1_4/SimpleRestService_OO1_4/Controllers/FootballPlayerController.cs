using Microsoft.AspNetCore.Mvc;
using SimpleRestService_OO1_4.Managers;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace SimpleRestService_OO1_4.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootballPlayerController : ControllerBase
    {
        private readonly ManageFootballPlayers mgr = new ManageFootballPlayers();

        // GET: api/<ValuesController>
        [HttpGet]
        public IEnumerable<FootballPlayer> Get()
        {
            return mgr.Get();
        }

        // GET api/<ValuesController>/5
        [HttpGet("{id}")]
        public FootballPlayer Get(int id)
        {
            return mgr.Get(id);
        }

        // POST api/<ValuesController>
        [HttpPost]
        public bool Post([FromBody] FootballPlayer newPlayer)
        {
            mgr.Create(newPlayer);
            return true;
        }

        // PUT api/<ValuesController>/5
        [HttpPut("{id}")]
        public bool Put(int id, [FromBody] FootballPlayer player)
        {
            mgr.Update(id, player);
            return true;
        }

        // DELETE api/<ValuesController>/5
        [HttpDelete("{id}")]
        public FootballPlayer Delete(int id)
        {
            FootballPlayer fP = mgr.Get(id);
            mgr.Delete(id);
            return fP;
        }
    }
}
