using LibraryController;
using System;
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
            DataGridView.Rows.Clear();
            var cities = ModerationController.GetCities();
            foreach (var elem in cities)
            {
                DataGridView.Rows.Add($"{elem.Id}", $"{elem.CityName}");
            }
        }

        private void ViewModerationCityForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void AddCityButtonClick(object sender, EventArgs e)
        {
            AddCityForm Form = new AddCityForm();
            Form.Closed += (s, ev) =>
            {
                UpdateGrid();
            };
            Form.ShowDialog();
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int IdCity = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["IdCity"].Value);
                ChangeCityForm Form = new ChangeCityForm(IdCity);
                Form.Closed += (s, ev) =>
                {
                    UpdateGrid();
                };
                Form.ShowDialog();
            }
        }
    }
}
