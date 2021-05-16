using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryController;

namespace TableBusWinForms.GeneralForm
{
    public partial class PurchasedTicket : Form
    {
        public PurchasedTicket(int IdTable, int IdRecordFlight)
        {
            InitializeComponent();
            this.IdTable = IdTable;
            this.IdRecordFlight = IdRecordFlight;
        }

        private int IdTable { get; set; }
        private int IdRecordFlight { get; set; }

        private void PurchasedTicket_Load(object sender, EventArgs e)
        {
            var table = Controller.GetTable(IdTable);
            NameRouteTextBox.Text = table.Route.NameRoute;
            CityStartTextBox.Text = table.Route.City.CityName;
            CityEndTextBox.Text = table.Route.City1.CityName;
            TimeStartTextBox.Text = table.DateTimeStart.ToString("g");
            TimeEndTextBox.Text = table.DateTimeEnd.ToString("g");
            DistanceTextBox.Text = table.Route.Distance.ToString();
            TimeTravelTextBox.Text = ModerationController.ConvertDistanceTimeTravel(table.Route.Distance).ToString("T");
            FreePlacesTextBox.Text = Controller.GetAmountFreePlaces(IdTable).ToString();
            PriceTextBox.Text = table.Price.ToString();

            DateLabel.Text = table.DateTimeStart.ToString("d");
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            var table = Controller.GetTable(IdTable);
            try
            {
                if (table.DateTimeStart < DateTime.Now)
                    throw new Exception("Отменить билет невозможно. Автобус уже в пути!");
                switch (Controller.ReturnTicket(IdRecordFlight))
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
            this.Close();
        }
    }
}
