using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string NameRoute { get; set; }
        public int CityStart { get; set; }
        public int CityEnd { get; set; }
        public TimeSpan TravelTime { get; set; }

        public virtual City pCityStart { get; set; }
        public virtual City pCityEnd { get; set; }

        public Route()
        { }

        public Route(string NameRoute, int CityStart, int CityEnd, TimeSpan TravelTime)
        {
            Id = DataBase.GetRouteLastId() + 1;
            this.NameRoute = NameRoute;
            this.CityStart = CityStart;
            this.CityEnd = CityEnd;
            this.TravelTime = TravelTime;

            pCityStart = DataBase.GetCity(CityStart);
            pCityEnd = DataBase.GetCity(CityEnd);
        }

        public Route(int Id, string NameRoute, int CityStart, int CityEnd, TimeSpan TravelTime)
        {
            this.Id = Id;
            this.NameRoute = NameRoute;
            this.CityStart = CityStart;
            this.CityEnd = CityEnd;
            this.TravelTime = TravelTime;

            pCityStart = DataBase.GetCity(CityStart);
            pCityEnd = DataBase.GetCity(CityEnd);
        }

        public override string ToString()
        {
            return $"{Id}&{NameRoute}&{CityStart}&{CityEnd}&{TravelTime}";
        }
    }
}
