using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLinkApi.Models
{
    public class Player
    {
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string CityOfBirth { get; set; }
        public int Height { get; set; }
        public string Position { get; set; }
        public int ClubNumber { get; set; }
        public int Age { get; set; }
        public string Nationality { get; set; }
        public string ClubName { get; set; }

        public virtual Club Club { get; set; }
    }
}