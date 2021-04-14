using System;
using System.Collections.Generic;
using System.Text;

namespace TableBusConsole.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        public City(string CityName)
        {
            int CurrentId = DataContext.Cities.Count + 1;
            this.Id = CurrentId;
            this.CityName = CityName;
        }

        public override string ToString()
        {
            return $"ID: {Id,4} | Name: {CityName,12}";
        }
    }
}
