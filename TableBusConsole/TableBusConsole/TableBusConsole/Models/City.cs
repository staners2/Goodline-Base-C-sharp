using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableBusConsole.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }

        public City(string CityName)
        {
            switch (DataContext.Cities.Count != 0)
            {
                case true:
                    this.Id = DataContext.Cities.Last().Id + 1;
                    break;
                case false:
                    this.Id = 1;
                    break;
            }
            this.CityName = CityName;
        }

        public override string ToString()
        {
            return $"ID: {Id,4} | Name: {CityName,12}";
        }

        // Конструктор без параметров
        public City()
        {

        }
        public City(int Id, string sName)
        {
            this.Id = Id;
            this.CityName = sName;
        }
    }
}
