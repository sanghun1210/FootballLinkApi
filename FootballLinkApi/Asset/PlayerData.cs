using FootballLinkApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FootballLinkApi.Asset
{
    public static class PlayerData
    {
        public static readonly Player[] Players = new Player[]
        {
            new Player{PlayerID=0, PlayerName="David De Gea", DateOfBirth=new DateTime(1990, 11, 7), Age=25, Height=192,
                        Position="Goalkeeper", ClubNumber=1, CityOfBirth="Spain, Madrid", ClubName="Man Utd"}, 
            new Player{PlayerID=1, PlayerName="Philip Anthony Jones", DateOfBirth=new DateTime(1992, 2, 21), Age=24, Height=185,
                        Position="Center-back", ClubNumber=4, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=2, PlayerName="Faustino Marcos Alberto Rojo", DateOfBirth=new DateTime(1990, 3, 20), Age=25, Height=187,
                        Position="Center-back", ClubNumber=5, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=3, PlayerName="Memphis Depay", DateOfBirth=new DateTime(1994, 2, 13), Age=22, Height=176,
                        Position="Winger", ClubNumber=7, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=4, PlayerName="Juan Manuel Mata García", DateOfBirth=new DateTime(1988, 4, 28), Age=24, Height=170,
                        Position="Attacking midfielder", ClubNumber=8, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=5, PlayerName="Anthony Martial", DateOfBirth=new DateTime(1995, 12, 5), Age=20, Height=181,
                        Position="Winger / Stiker", ClubNumber=9, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=6, PlayerName="	Wayne Mark Rooney", DateOfBirth=new DateTime(1985, 10, 24), Age=24, Height=176,
                        Position="Stiker", ClubNumber=10, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=7, PlayerName="	Adnan Januzaj", DateOfBirth=new DateTime(1992, 2, 21), Age=24, Height=185,
                        Position="Attacking midfielder / Winger", ClubNumber=11, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=8, PlayerName="Philip Anthony Jones", DateOfBirth=new DateTime(1992, 2, 21), Age=24, Height=185,
                        Position="Center-back", ClubNumber=4, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=9, PlayerName="	Christopher Lloyd Smalling", DateOfBirth=new DateTime(1989, 11, 22), Age=26, Height=194,
                        Position="Center-back", ClubNumber=12, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=10, PlayerName="Michael Carrick", DateOfBirth=new DateTime(1981, 7, 28), Age=34, Height=188,
                        Position="Holding midfielder / Defensive midfielder", ClubNumber=16, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=11, PlayerName="Daley Blind", DateOfBirth=new DateTime(1990, 3, 9), Age=26, Height=180,
                        Position="Center-back", ClubNumber=17, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=12, PlayerName="Philip Anthony Jones", DateOfBirth=new DateTime(1992, 2, 21), Age=24, Height=185,
                        Position="Winger", ClubNumber=18, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=13, PlayerName="Ashley Simon Young", DateOfBirth=new DateTime(1985, 7, 9), Age=30, Height=180,
                        Position="Winger", ClubNumber=4, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=14, PlayerName="Sergio Germán Romero", DateOfBirth=new DateTime(1987, 2, 22), Age=29, Height=192,
                        Position="Goalkeeper", ClubNumber=21, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=15, PlayerName="Ander Herrera Agüera", DateOfBirth=new DateTime(1989, 8, 14), Age=26, Height=182,
                        Position="Center-back", ClubNumber=21, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=16, PlayerName="Luke Paul Hoare Shaw", DateOfBirth=new DateTime(1995, 7, 12), Age=20, Height=185,
                        Position="Fullback", ClubNumber=23, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=17, PlayerName="Luis Antonio Valencia Mosquera", DateOfBirth=new DateTime(1985, 8, 4), Age=30, Height=181,
                        Position="Winger / Fullback", ClubNumber=25, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=18, PlayerName="Marouane Fellaini-Bakkioui", DateOfBirth=new DateTime(1987, 11, 22), Age=28, Height=194,
                        Position="Midfielder", ClubNumber=27, CityOfBirth="", ClubName="Man Utd"},
            new Player{PlayerID=19, PlayerName="Morgan Schneiderlin", DateOfBirth=new DateTime(1989, 11, 8), Age=26, Height=181,
                        Position="Holding midfielder / Defensive midfielder", ClubNumber=25, CityOfBirth="England, Preston", ClubName="Man Utd"},
            new Player{PlayerID=20, PlayerName="Guillermo Varela", DateOfBirth=new DateTime(1993, 3, 24), Age=22, Height=173,
                        Position="Fullback", ClubNumber=25, CityOfBirth="", ClubName="Man Utd"},


            new Player{PlayerID=21, PlayerName="Kasper Peter Schmeichel", DateOfBirth=new DateTime(1986, 11, 5), Age=29, Height=183,
                        Position="Goalkeeper", ClubNumber=1, CityOfBirth="", ClubName="Leicester"},
            new Player{PlayerID=20, PlayerName="Westley Nathan Morgan", DateOfBirth=new DateTime(1984, 1, 21), Age=32, Height=185,
                        Position="Center-back", ClubNumber=5, CityOfBirth="", ClubName="Leicester"},
            new Player{PlayerID=20, PlayerName="Guillermo Varela", DateOfBirth=new DateTime(1993, 3, 24), Age=22, Height=173,
                        Position="Fullback", ClubNumber=25, CityOfBirth="", ClubName="Leicester"},
            new Player{PlayerID=20, PlayerName="Guillermo Varela", DateOfBirth=new DateTime(1993, 3, 24), Age=22, Height=173,
                        Position="Fullback", ClubNumber=25, CityOfBirth="", ClubName="Leicester"},

        };
    }
}