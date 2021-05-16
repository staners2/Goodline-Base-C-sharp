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

namespace TableBusWinForms.AdminView.Moderation.Route
{
    public partial class ChangeRouteForm : Form
    {
        public ChangeRouteForm(int IdRoute)
        {
            InitializeComponent();
            this.IdRoute = IdRoute;
        }

        private int IdRoute { get; set; }

        private void ChangeRouteForm_Load(object sender, EventArgs e)
        {
            var Route = ModerationController.GetRoute(IdRoute);

            NameRouteTextBox.Text = Route.NameRoute;
            var Cities = ModerationController.GetCities();
            foreach (var elem in Cities)
            {
                CityStartComboBox.Items.Add(elem.CityName);
                CityEndComboBox.Items.Add(elem.CityName);
            }

            CityStartComboBox.SelectedItem = Route.City.CityName;
            CityEndComboBox.SelectedItem = Route.City1.CityName;

            DistanceTextBox.Text = Route.Distance.ToString();
            DateTime dt = new DateTime(2012, 01, 01);
            TimeSpan ts = Route.TravelTime;
            TravelDateTimePicker.Value = dt+ts;

        }

        private void ChangeRouteButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (NameRouteTextBox.Text == string.Empty || CityStartComboBox.Text == string.Empty || CityEndComboBox.Text == string.Empty)
                    throw new Exception("Заполните все поля");
                if (CityStartComboBox.Text == CityEndComboBox.Text)
                    throw new Exception("Город отбытия и город прибытия должны быть различными");
                if (ModerationController.IsHaveRoute(NameRouteTextBox.Text, IdRoute))
                    throw new Exception("Маршрут с таким названием уже существует");

                int CityStartId = ModerationController.GetCityId(CityStartComboBox.Text);
                int CityEndId = ModerationController.GetCityId(CityEndComboBox.Text);
                bool Result = ModerationController.ChangeRoute(IdRoute, NameRouteTextBox.Text, CityStartId, CityEndId,
                    Convert.ToDouble(DistanceTextBox.Text), TravelDateTimePicker.Value.TimeOfDay);
                switch (Result)
                {
                    case false:
                        throw new Exception("Произошла какая-то ошибка при изменении маршрута");
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

        private void DeleteRouteButtonClick(object sender, EventArgs e)
        {
            switch (ModerationController.RemoveRoute(IdRoute))
            {
                case false:
                    MessageBox.Show($"Произошла какая-то ошибка при изменении маршрута", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
                default:
                    this.Close();
                    break;
            }
        }

        private void CityComboBox_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (CityStartComboBox.Text != string.Empty && CityEndComboBox.Text != string.Empty && CityStartComboBox.Text != CityEndComboBox.Text)
            {
                double Distance = new Random().NextDouble() * (5000 - 50) + 50;
                DistanceTextBox.Text = Math.Round(Distance, 2).ToString();

                var TimeTravel = ModerationController.ConvertDistanceTimeTravel(Distance);
                TravelDateTimePicker.Value = TimeTravel;
            }
        }
    }
}
