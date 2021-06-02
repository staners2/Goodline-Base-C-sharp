using LibraryController;
using System;
using System.Windows.Forms;
using TableBusWinForms.GeneralForm;

namespace TableBusWinForms.Presenter
{
    public class BuyerTicketsPresenter
    {
        public BuyerTicketsForm View { get; set; }
        public BuyerTicketsPresenter(BuyerTicketsForm View)
        {
            this.View = View;
        }

        public void FormLoad()
        {
            var table = Controller.GetTable(View.IdTable);
            View.NameRouteTextBox.Text = table.Route.NameRoute;
            View.CityStartTextBox.Text = table.Route.City.CityName;
            View.CityEndTextBox.Text = table.Route.City1.CityName;
            View.TimeStartTextBox.Text = table.DateTimeStart.ToString("g");
            View.TimeEndTextBox.Text = table.DateTimeEnd.ToString("g");
            View.DistanceTextBox.Text = table.Route.Distance.ToString();
            View.TimeTravelTextBox.Text = ModerationController.ConvertDistanceTimeTravel(table.Route.Distance).ToString("T");
            View.PlacesTextBox.Text = Controller.GetAmountFreePlaces(View.IdTable).ToString();
            View.PriceTextBox.Text = table.Price.ToString();

            View.DateLabel.Text = table.DateTimeStart.ToString("d");
            View.BalanceLabel.Text = Controller.GetMoneyForUser(View.IdAccount).ToString();
        }

        public void BuyButtonClick()
        {
            var table = Controller.GetTable(View.IdTable);
            try
            {
                if (Controller.GetMoneyForUser(View.IdAccount) < table.Price)
                    throw new Exception("У вас недостаточно денег!");
                if (!Controller.CheckFreeTableRecord(View.IdTable))
                    throw new Exception("Все билеты на этот рейс распроданы!");
                switch (Controller.BuyTicketForUser(View.IdAccount, View.IdTable))
                {
                    case false:
                        throw new Exception("Произошла какая-то ошибка!");
                    case true:
                        MessageBox.Show($"Билет приобретен!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
