using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryController;
using LibraryController.Models;
using TableBusWinForms.GeneralForm;

namespace TableBusWinForms.Presenter
{
    public class PurchasedTicketPresenter
    {
        public PurchasedTicket View { get; set; }
        public PurchasedTicketPresenter(PurchasedTicket View)
        {
            this.View = View;
        }

        public void LoadForm()
        {
            Table table = Controller.GetTable(View.IdTable);
            View.NameRouteTextBox.Text = table.Route.NameRoute;
            View.CityStartTextBox.Text = table.Route.City.CityName;
            View.CityEndTextBox.Text = table.Route.City1.CityName;
            View.TimeStartTextBox.Text = table.DateTimeStart.ToString("g");
            View.TimeEndTextBox.Text = table.DateTimeEnd.ToString("g");
            View.DistanceTextBox.Text = table.Route.Distance.ToString();
            View.TimeTravelTextBox.Text = ModerationController.ConvertDistanceTimeTravel(table.Route.Distance).ToString("T");
            View.FreePlacesTextBox.Text = Controller.GetAmountFreePlaces(View.IdTable).ToString();
            View.PriceTextBox.Text = table.Price.ToString();

            View.DateLabel.Text = table.DateTimeStart.ToString("d");
        }

        public void CancelButtonClick()
        {
            var table = Controller.GetTable(View.IdTable);
            try
            {
                if (table.DateTimeStart < DateTime.Now)
                    throw new Exception("Отменить билет невозможно. Автобус уже в пути!");
                switch (Controller.ReturnTicket(View.IdRecordFlight))
                {
                    case false:
                        throw new Exception("Произошла какая-то ошибка!");
                    default:
                        MessageBox.Show($"Билет отменен! Деньги уже были отправлены", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            View.Close();
        }
    }
}
