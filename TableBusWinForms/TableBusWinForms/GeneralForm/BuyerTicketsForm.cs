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
    public partial class BuyerTicketsForm : Form
    {
        public BuyerTicketsForm(int IdTable, int IdAccount)
        {
            InitializeComponent();
            this.IdTable = IdTable;
            this.IdAccount = IdAccount;
        }

        private int IdTable { get; set; }
        private int IdAccount { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            var table = Controller.GetTable(IdTable);
            NameRouteTextBox.Text = table.Route.NameRoute;
            CityStartTextBox.Text = table.Route.City.CityName;
            CityEndTextBox.Text = table.Route.City1.CityName;
            TimeStartTextBox.Text = table.DateTimeStart.ToString("g");
            TimeEndTextBox.Text = table.DateTimeEnd.ToString("g");
            DistanceTextBox.Text = table.Route.Distance.ToString();
            TimeTravelTextBox.Text = ModerationController.ConvertDistanceTimeTravel(table.Route.Distance).ToString("T");
            PlacesTextBox.Text = Controller.GetAmountFreePlaces(IdTable).ToString();
            PriceTextBox.Text = table.Price.ToString();

            DateLabel.Text = table.DateTimeStart.ToString("d");
            BalanceLabel.Text = Controller.GetMoneyForUser(IdAccount).ToString();
        }
        
        private void BuyButtonClick(object sender, EventArgs e)
        {
            var table = Controller.GetTable(IdTable);
            try
            {
                if (Controller.GetMoneyForUser(IdAccount) < table.Price)
                    throw new Exception("У вас недостаточно денег!");
                if (!Controller.CheckFreeTableRecord(IdTable))
                    throw new Exception("Все билеты на этот рейс распроданы!");
                switch (Controller.BuyTicketForUser(IdAccount, IdTable))
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
            this.Close();
        }
    }
}
