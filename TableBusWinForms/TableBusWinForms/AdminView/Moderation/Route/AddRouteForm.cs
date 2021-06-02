using LibraryController;
using System;
using System.Windows.Forms;

namespace TableBusWinForms.AdminView.Moderation.Route
{
    public partial class AddRouteForm : Form
    {
        public AddRouteForm()
        {
            InitializeComponent();
        }

        private void AddRouteForm_Load(object sender, EventArgs e)
        {
            var Cities = ModerationController.GetCities();
            foreach (var elem in Cities)
            {
                CityStartComboBox.Items.Add(elem.CityName);
                CityEndComboBox.Items.Add(elem.CityName);
            }
        }

        private void AddRouteButtonClick(object sender, EventArgs e)
        {
            try
            {
                if (NameRouteTextBox.Text != string.Empty && CityStartComboBox.Text != string.Empty && CityEndComboBox.Text != string.Empty)
                {
                    if (CityStartComboBox.Text != CityEndComboBox.Text)
                    {
                        if (ModerationController.IsHaveRoute(NameRouteTextBox.Text))
                        {
                            throw new Exception("Маршрут с таким названием уже существует");
                        }

                        int CityStartId = ModerationController.GetCityId(CityStartComboBox.Text);
                        int CityEndId = ModerationController.GetCityId(CityEndComboBox.Text);
                        bool Result = ModerationController.AddRoute(NameRouteTextBox.Text, CityStartId, CityEndId,
                            Convert.ToDouble(DistanceTextBox.Text), TravelDateTimePicker.Value.TimeOfDay);
                        switch (Result)
                        {
                            case false:
                                throw new Exception("Произошла какая-то ошибка при добавлении маршрута");
                            default:
                                this.Close();
                                break;
                        }
                    }
                    else
                    {
                        throw new Exception("Город отбытия и город прибытия должны быть различными");
                    }
                }
                else
                {
                    throw new Exception("Заполните все поля");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
