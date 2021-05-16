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

namespace TableBusWinForms.AdminView.Moderation.TableRecords
{
    public partial class ChangeTableRecordsForm : Form
    {
        public ChangeTableRecordsForm(int IdTable)
        {
            InitializeComponent();
            this.IdTable = IdTable;
        }

        private int IdTable { get; set; }
        private string CurrentNameRoute { get; set; }

        private void ChangeTableRecordsForm_Load(object sender, EventArgs e)
        {
            var list = ModerationController.GetRoutes();
            foreach (var route in list)
            {
                NameRouteComboBox.Items.Add(route.NameRoute);
            }
            var table = ModerationController.GetTable(IdTable);
            NameRouteComboBox.SelectedItem = table.Route.NameRoute;
            CurrentNameRoute = NameRouteComboBox.Text;
            CityStartTextBox.Text = table.Route.City.CityName;
            CityEndTextBox.Text = table.Route.City1.CityName;
            DistanceTextBox.Text = table.Route.Distance.ToString();
            TravelDateTimePicker.Value = DateTime.Parse(table.Route.TravelTime.ToString());
            DateStartPicker.Value = table.DateTimeStart;
            DateEndPicker.Value = table.DateTimeEnd;
            PriceNumericUpDown.Value = Convert.ToDecimal(table.Price);
            FreePlacesNumericUpDown.Value = Convert.ToDecimal(table.MaxCountPassenger);
        }

        private void ChangeButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (DateStartPicker.Value < DateTime.Now)
                    throw new Exception("Планировать на прошедшие дни невозможно.");
                if (NameRouteComboBox.Text == string.Empty)
                    throw new Exception("Выберете маршрут");

                int RouteId = ModerationController.GetRoutes().Find(x => x.NameRoute == CurrentNameRoute).Id;
                bool result = ModerationController.ChangeTableRecord(IdTable, RouteId, DateStartPicker.Value, DateEndPicker.Value,
                    Convert.ToInt32(PriceNumericUpDown.Value), Convert.ToInt32(FreePlacesNumericUpDown.Value));
                switch (result)
                {
                    case false:
                        throw new Exception("Произошла ошибка при изменении");
                    default:
                        this.Close();
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteButtonClick(object sender, EventArgs e)
        {
            switch (ModerationController.RemoveTableRecord(IdTable))
            {
                case false:
                    MessageBox.Show($"Произошла какая-то ошибка при удалении записи о рейсе", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void RouteComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var route = ModerationController.GetRoute(NameRouteComboBox.Text);
            if (CurrentNameRoute != NameRouteComboBox.Text)
            {
                CurrentNameRoute = NameRouteComboBox.Text;
                CityStartTextBox.Text = route.City.CityName;
                CityEndTextBox.Text = route.City1.CityName;
                DistanceTextBox.Text = route.Distance.ToString();
                TravelDateTimePicker.Value = new DateTime(2000, 1, 1, route.TravelTime.Hours, route.TravelTime.Minutes, route.TravelTime.Seconds);

                DateStartPicker_ValueChanged(null, null);
            }
        }

        private void DateStartPicker_ValueChanged(object sender, EventArgs e)
        {
            if (NameRouteComboBox.Text != string.Empty)
            {
                var route = ModerationController.GetRoute(CurrentNameRoute);
                DateEndPicker.Value = DateStartPicker.Value.Add(route.TravelTime);
            }
        }
    }
}
