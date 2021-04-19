using System;
using System.Collections.Generic;
using System.Text;

namespace Library.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        public City()
        { }

        public City(string CityName)
        {
            this.Id = DataBase.GetCityLastId() + 1;
            this.CityName = CityName;
        }

        public City(int Id, string CityName)
        {
            this.Id = Id;
            this.CityName = CityName;
        }

        public override string ToString()
        {
            return $"{Id}&{CityName}";
        }
    }
}
