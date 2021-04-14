using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Text;
using TableBusConsole.Models;

namespace TableBusConsole
{
    public static class DataContext
    {
        public static List<City> Cities { get; set; } = new List<City>();
        public static List<Route> Routes { get; set; } = new List<Route>();
        public static List<Table> Tables { get; set; } = new List<Table>();
        public static List<User> Users { get; set; } = new List<User>();
        public static List<RecordFlight> RecordFlights { get; set; } = new List<RecordFlight>();
    }
}
