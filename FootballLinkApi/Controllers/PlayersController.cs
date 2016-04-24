using FootballLinkApi.Asset;
using FootballLinkApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace FootballLinkApi.Controllers
{
    public class PlayersController : ApiController
    {
        
        // GET: api/Players
        public IEnumerable<Player> Get()
        {
            return PlayerData.Players;
        }

        // GET: api/Players/5
        public Player Get(int id)
        {
            return PlayerData.Players.First(e => e.PlayerID == id);
        }

        // POST: api/Players
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Players/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Players/5
        public void Delete(int id)
        {
        }
    }
}
