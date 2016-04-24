using FootballLinkApi.Asset;
using FootballLinkApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace FootballLinkApi.Controllers
{
    public class ClubFilter
    {
        public int Rank { get; set; }
        public string ClubName { get; set; } 
    }

    public class ClubsController : ApiController
    { 
        //// GET: api/Clubs
        //public IEnumerable<Club> Get()
        //{
        //    return ClubData.Clubs.OrderBy(c => c.ClubRank);
        //}

        //// GET: api/Clubs/5
        //public Club GetById(int id)
        //{
        //    return ClubData.Clubs.First(e => e.ClubID == id);
        //}

        //public Club GetByClubRank(int rank)
        //{
        //    var club = ClubData.Clubs.FirstOrDefault(e => e.ClubRank == rank);

        //    if(club == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return club;
        //}

        //public Club GetByClubName(string name)
        //{
        //    var club = ClubData.Clubs.FirstOrDefault(e => 
        //    e.ClubName.Equals(name, StringComparison.OrdinalIgnoreCase));

        //    if(club == null)
        //    {
        //        throw new HttpResponseException(HttpStatusCode.NotFound);
        //    }
        //    return club;
        //}


        ////public IEnumerable<Club> GetByFilter([FromUri]ClubFilter filter)
        ////{
        ////    return ClubData.Clubs.Where(e => e.ClubRank == filter.Rank && e.ClubName == filter.ClubName);
        ////}

        //// POST: api/Clubs
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT: api/Clubs/5
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE: api/Clubs/5
        //public void Delete(int id)
        //{
        //}
    }
}
