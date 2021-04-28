using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TableBusConsole.Models
{
    public class Table
    {
        public int Id { get; set; }
        public System.DateTime DateTimeStart { get; set; }
        public System.DateTime DateTimeEnd { get; set; }
        public int CurrentCountPassenger { get; set; }
        public int MaxCountPassenger { get; set; }
        public int Price { get; set; }
        public virtual Route Route { get; set; }

        public Table(DateTime DateTimeStart, DateTime DateTimeEnd,
            int MaxCountPassenger, int Price, int IdRoute)
        {
            switch (DataContext.Tables.Count != 0)
            {
                case true:
                    this.Id = DataContext.Tables.Last().Id + 1;
                    break;
                case false:
                    this.Id = 1;
                    break;
            }
            this.DateTimeStart = DateTimeStart;
            this.DateTimeEnd = DateTimeEnd;
            this.CurrentCountPassenger = 0;
            this.MaxCountPassenger = MaxCountPassenger;
            this.Price = Price;
            this.Route = DataContext.Routes.Find(x => x.Id == IdRoute);
        }

        // Конструктор без параметров
        public Table()
        {

        }

        public Table(int Id, DateTime DateTimeStart, DateTime DateTimeEnd, int CurrentCountPassenger,
            int MaxCountPassenger, int Price, int IdRoute)
        {
            this.Id = Id;
            this.DateTimeStart = DateTimeStart;
            this.DateTimeEnd = DateTimeEnd;
            this.CurrentCountPassenger = CurrentCountPassenger;
            this.MaxCountPassenger = MaxCountPassenger;
            this.Price = Price;
            this.Route = DataContext.Routes.Find(x => x.Id == IdRoute);
        }

        public Table(int Id, DateTime DateTimeStart, DateTime DateTimeEnd,
            int MaxCountPassenger, int Price, int IdRoute)
        {
            this.Id = Id;
            this.DateTimeStart = DateTimeStart;
            this.DateTimeEnd = DateTimeEnd;
            this.CurrentCountPassenger = 0;
            this.MaxCountPassenger = MaxCountPassenger;
            this.Price = Price;
            this.Route = DataContext.Routes.Find(x => x.Id == IdRoute);
        }

        public override string ToString()
        {
            return $"ID: {Id,5} | Время(отъезда): {DateTimeStart,11} | Время(прибытия): {DateTimeEnd,11} | Кол-во пассажиров: {CurrentCountPassenger,2} |" +
                   $"Максимальное кол-во: {MaxCountPassenger,2} | Стоимость: {Price,11} |" +
                   $"Маршрут: {Route.Id}";
        }
    }
}
