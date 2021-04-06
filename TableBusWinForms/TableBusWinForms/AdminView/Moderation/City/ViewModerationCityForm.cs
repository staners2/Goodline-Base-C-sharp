using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableBusWinForms.AdminView.Moderation.City
{
    public partial class ViewModerationCityForm : Form
    {
        public ViewModerationCityForm()
        {
            InitializeComponent();
        }

        public void UpdateGrid()
        {
            dataGridView1.Rows.Clear();
            List<Models.City> cities = ModerationController.GetCities();
            foreach (var elem in cities)
            {
                dataGridView1.Rows.Add($"{elem.Id}", $"{elem.CityName}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddCityForm Form = new AddCityForm();
            Form.Closed += (s, ev) =>
            {
                UpdateGrid();
            };
            Form.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int IdCity = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdCity"].Value);
                ChangeCityForm Form = new ChangeCityForm(IdCity);
                Form.Closed += (s, ev) =>
                {
                    UpdateGrid();
                };
                Form.ShowDialog();
            }
            
        }

        private void ViewModerationCityForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
