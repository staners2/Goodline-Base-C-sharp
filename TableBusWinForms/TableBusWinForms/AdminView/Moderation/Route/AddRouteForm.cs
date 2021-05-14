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
    public partial class AddRouteForm : Form
    {
        public AddRouteForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != string.Empty && comboBox1.Text != string.Empty && comboBox2.Text != string.Empty)
                {
                    if (comboBox1.Text != comboBox2.Text)
                    {
                        if (ModerationController.IsHaveRoute(textBox1.Text))
                        {
                            throw new Exception("Маршрут с таким названием уже существует");
                        }

                        int CityStartId = ModerationController.GetCityId(comboBox1.Text);
                        int CityEndId = ModerationController.GetCityId(comboBox2.Text);
                        bool Result = ModerationController.AddRoute(textBox1.Text, CityStartId, CityEndId,
                            Convert.ToDouble(textBox4.Text), dateTimePicker1.Value.TimeOfDay);
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
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void AddRouteForm_Load(object sender, EventArgs e)
        {
            var Cities = ModerationController.GetCities();
            foreach (var elem in Cities)
            {
                comboBox1.Items.Add(elem.CityName);
                comboBox2.Items.Add(elem.CityName);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty && comboBox2.Text != string.Empty && comboBox1.Text != comboBox2.Text)
            {
                double Distance = new Random().NextDouble() * (5000-50) + 50;
                textBox4.Text = Math.Round(Distance, 2).ToString();

                var TimeTravel = ModerationController.ConvertDistanceTimeTravel(Distance);
                dateTimePicker1.Value = TimeTravel;
            }
        }
    }
}
