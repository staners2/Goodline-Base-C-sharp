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

            textBox1.Text = Route.NameRoute;
            var Cities = ModerationController.GetCities();
            foreach (var elem in Cities)
            {
                comboBox1.Items.Add(elem.CityName);
                comboBox2.Items.Add(elem.CityName);
            }

            comboBox1.SelectedItem = Route.City.CityName;
            comboBox2.SelectedItem = Route.City1.CityName;

            textBox4.Text = Route.Distance.ToString();
            DateTime dt = new DateTime(2012, 01, 01);
            TimeSpan ts = Route.TravelTime;
            dateTimePicker1.Value = dt+ts;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty && comboBox1.Text != string.Empty && comboBox2.Text != string.Empty)
                    throw new Exception("Заполните все поля");
                if (comboBox1.Text != comboBox2.Text)
                    throw new Exception("Город отбытия и город прибытия должны быть различными");
                if (ModerationController.IsHaveRoute(textBox1.Text, IdRoute))
                    throw new Exception("Маршрут с таким названием уже существует");

                int CityStartId = ModerationController.GetCityId(comboBox1.Text);
                int CityEndId = ModerationController.GetCityId(comboBox2.Text);
                bool Result = ModerationController.ChangeRoute(IdRoute, textBox1.Text, CityStartId, CityEndId,
                    Convert.ToDouble(textBox4.Text), dateTimePicker1.Value.TimeOfDay);
                switch (Result)
                {
                    case false:
                        throw new Exception("Произошла какая-то ошибка при изменении маршрута");
                    default:
                        this.Close();
                        break;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty && comboBox2.Text != string.Empty && comboBox1.Text != comboBox2.Text)
            {
                double Distance = new Random().NextDouble() * (5000 - 50) + 50;
                textBox4.Text = Math.Round(Distance, 2).ToString();

                var TimeTravel = ModerationController.ConvertDistanceTimeTravel(Distance);
                dateTimePicker1.Value = TimeTravel;
            }
        }
    }
}
