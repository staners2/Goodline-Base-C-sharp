using LibraryController;
using System;
using System.Windows.Forms;

namespace TableBusWinForms.AdminView.Moderation.TableRecords
{
    public partial class AddTableRecordsForm : Form
    {
        public AddTableRecordsForm()
        {
            InitializeComponent();
        }

        private string CurrentNameRoute { get; set; }

        private void AddTableRecordsForm_Load(object sender, EventArgs e)
        {
            var Routes = ModerationController.GetRoutes();
            foreach (var elem in Routes)
            {
                NameRouteComboBox.Items.Add(elem.NameRoute);
            }

            CurrentNameRoute = NameRouteComboBox.Text;
        }

        private void AddTableRecordButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (DateStartPicker.Value < DateTime.Now)
                    throw new Exception("Планировать на прошедшие дни невозможно.");
                if (NameRouteComboBox.Text == string.Empty)
                    throw new Exception("Выберете маршрут");

                int RouteId = ModerationController.GetRoutes().Find(x => x.NameRoute == CurrentNameRoute).Id;
                bool result = ModerationController.AddTableRecord(RouteId, DateStartPicker.Value, DataEndPicker.Value,
                    Convert.ToInt32(PriceNumericUpDown.Value), Convert.ToInt32(CountFreePlacesNumericUpDown.Value));
                switch (result)
                {
                    case false:
                        throw new Exception("Произошла ошибка при добавлении");
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
                DataEndPicker.Value = DateStartPicker.Value.Add(route.TravelTime);
            }
        }
    }
}
