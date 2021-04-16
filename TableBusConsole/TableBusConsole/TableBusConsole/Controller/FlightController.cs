using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TableBusConsole.Models;

namespace TableBusConsole
{
    public static class FlightController
    {
        public static void RecordFlight()
        {
            var Records = DataContext.Tables.Where(x => x.DateTimeStart > DateTime.Now && x.CurrentCountPassenger < x.MaxCountPassenger).ToList();
            TableController.ShowTables(Records);
            Console.WriteLine($"\n ЗАПИСАТЬСЯ НА РЕЙС\n");
            Console.WriteLine("Введите ID рейса, на который хотите записаться: ");
            Console.WriteLine($"Баланс составляет: {AccountController.User.Money}rub");
            int iNumberPick;
            do
            {

            } while (!int.TryParse(Console.ReadLine(), out iNumberPick));

            Table table = DataContext.Tables.Find(x => x.Id == iNumberPick && x.DateTimeStart > DateTime.Now && x.CurrentCountPassenger < x.MaxCountPassenger);
            if (table != null)
            {
                if (AccountController.User.Money >= table.Price)
                {
                    Console.WriteLine("Вы записались на рейс");
                    AccountController.User.Money -= table.Price;

                    table.CurrentCountPassenger++;

                    var flight = new RecordFlight(iNumberPick, AccountController.User.Id);
                    DataContext.RecordFlights.Add(flight);
                    Console.WriteLine($"Баланс составляет: {AccountController.User.Money}rub");
                }
                else
                {
                    Console.WriteLine("У вас недостаточно средств");
                    Console.WriteLine($"Баланс составляет: {AccountController.User.Money}rub");
                }
                
            }
            else
            {
                Console.WriteLine($"Рейс с ID: {iNumberPick} отсутствует");
            }
        }
        public static int GetRecordFlightThisAccount(int IdAccount)
        {
            List<Table> flights = DataContext.RecordFlights.Where(x => x.UserId == IdAccount).Select(x => x.Table).ToList();
            if (flights.Count != 0)
            {
                Console.WriteLine($"Всего заказанных рейсов: {flights.Count}");
                TableController.ShowTables(flights);
                return flights.Count;
            }
            else
            {
                Console.WriteLine($"Вы не заказывали рейс");
                return flights.Count;
            }
        }
    }
}
