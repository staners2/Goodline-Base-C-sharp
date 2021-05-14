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
        private string sCurrentNameRoute { get; set; }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty)
            {
                var route = ModerationController.GetRoute(sCurrentNameRoute);
                dateTimePicker3.Value = dateTimePicker2.Value.Add(route.TravelTime);
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var route = ModerationController.GetRoute(comboBox1.Text);
            if (sCurrentNameRoute != comboBox1.Text)
            {
                sCurrentNameRoute = comboBox1.Text;
                textBox1.Text = route.City.CityName;
                textBox2.Text = route.City1.CityName;
                textBox3.Text = route.Distance.ToString();
                dateTimePicker1.Value = new DateTime(2000, 1, 1, route.TravelTime.Hours, route.TravelTime.Minutes, route.TravelTime.Seconds);

                dateTimePicker2_ValueChanged(null, null);
            }
        }

        private void button2_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dateTimePicker2.Value < DateTime.Now)
                    throw new Exception("Планировать на прошедшие дни невозможно.");
                if (comboBox1.Text == string.Empty)
                    throw new Exception("Выберете маршрут");

                int RouteId = ModerationController.GetRoutes().Find(x => x.NameRoute == sCurrentNameRoute).Id;
                bool result = ModerationController.ChangeTableRecord(IdTable, RouteId, dateTimePicker2.Value, dateTimePicker3.Value,
                    Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
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

        private void ChangeTableRecordsForm_Load(object sender, EventArgs e)
        {
            var list = ModerationController.GetRoutes();
            foreach (var route in list)
            {
                comboBox1.Items.Add(route.NameRoute);
            }
            var table = ModerationController.GetTable(IdTable);
            comboBox1.SelectedItem = table.Route.NameRoute;
            sCurrentNameRoute = comboBox1.Text;
            textBox1.Text = table.Route.City.CityName;
            textBox2.Text = table.Route.City1.CityName;
            textBox3.Text = table.Route.Distance.ToString();
            dateTimePicker1.Value = DateTime.Parse(table.Route.TravelTime.ToString());
            dateTimePicker2.Value = table.DateTimeStart;
            dateTimePicker3.Value = table.DateTimeEnd;
            numericUpDown1.Value = Convert.ToDecimal(table.Price);
            numericUpDown2.Value = Convert.ToDecimal(table.MaxCountPassenger);
        }
    }
}
