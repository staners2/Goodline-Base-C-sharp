using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TableBusConsole.Models
{
    public class Route
    {
        public int Id { get; set; }
        public string NameRoute { get; set; }
        public int CityStart { get; set; }
        public int CityEnd { get; set; }
        public double Distance { get; set; }
        public System.TimeSpan TravelTime { get; set; }

        public virtual City pCityStart { get; set; }
        public virtual City pCityEnd { get; set; }

        public override string ToString()
        {
            return $"ID: {Id,5} | Название: {NameRoute,10} | Город(отбытия): {CityStart,12} | Город(прибытия): {CityEnd,12} |" +
            $"Расстояние: {Distance,7}km | Время в пути: {TravelTime,11}";
        }

        // Конструктор без параметров
        public Route()
        {

        }

        public Route(string NameRoute, int CityStart, int CityEnd, double Distance,
            TimeSpan TravelTime)
        {

            int CurrentId = DataContext.Routes.Count + 1;
            this.Id = CurrentId;
            this.NameRoute = NameRoute;
            this.CityStart = CityStart;
            this.CityEnd = CityEnd;
            this.Distance = Distance;
            this.TravelTime = TravelTime;
            this.pCityStart = DataContext.Cities.Where(x => x.Id == CityStart).First();
            this.pCityEnd = DataContext.Cities.Where(x => x.Id == CityEnd).First();
        }

        public Route(int Id, string NameRoute, int CityStart, int CityEnd, double Distance,
            TimeSpan TravelTime)
        {
            this.Id = Id;
            this.NameRoute = NameRoute;
            this.CityStart = CityStart;
            this.CityEnd = CityEnd;
            this.Distance = Distance;
            this.TravelTime = TravelTime;
            this.pCityStart = DataContext.Cities.Where(x => x.Id == CityStart).First();
            this.pCityEnd = DataContext.Cities.Where(x => x.Id == CityEnd).First();
        }
    }
}
