using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableBusWinForms.AdminView.Moderation.TableRecords
{
    public partial class AddTableRecordsForm : Form
    {
        public AddTableRecordsForm()
        {
            InitializeComponent();
        }

        private string sCurrentNameRoute { get; set; }

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

        private void AddTableRecordsForm_Load(object sender, EventArgs e)
        {
            List<Models.Route> Routes = ModerationController.GetRoutes();
            foreach (var elem in Routes)
            {
                comboBox1.Items.Add(elem.NameRoute);
            }

            sCurrentNameRoute = comboBox1.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dateTimePicker2.Value > DateTime.Now && comboBox1.Text != string.Empty)
            {
                int RouteId = ModerationController.GetRoutes().Find(x => x.NameRoute == sCurrentNameRoute).Id;
                bool result = ModerationController.AddTableRecord(RouteId, dateTimePicker2.Value, dateTimePicker3.Value,
                    Convert.ToInt32(numericUpDown1.Value), Convert.ToInt32(numericUpDown2.Value));
                switch (result)
                {
                    case false:
                        MessageBox.Show($"Произошла ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    default:
                        this.Close();
                        break;
                }
            }
            else
            {
                MessageBox.Show($"Планировать на прошедшие дни запрещено", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty)
            {
                var route = ModerationController.GetRoute(sCurrentNameRoute);
                dateTimePicker3.Value = dateTimePicker2.Value.Add(route.TravelTime);
            }
        }
    }
}
