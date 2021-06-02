using LibraryController;
using System;
using System.Windows.Forms;

namespace TableBusWinForms.AdminView.Moderation.Route
{
    public partial class ViewModerationRouteForm : Form
    {
        public ViewModerationRouteForm()
        {
            InitializeComponent();
        }

        private void UpdateGrid()
        {
            DataGridView.Rows.Clear();
            var Routes = ModerationController.GetRoutes();
            foreach (var elem in Routes)
            {
                DataGridView.Rows.Add(
                    $"{elem.Id}", $"{elem.NameRoute}", $"{elem.City.CityName}",
                    $"{elem.City1.CityName}", $"{elem.Distance}", $"{elem.TravelTime}");
            }
        }

        private void ViewModerationRouteForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void AddRouteButtonClick(object sender, EventArgs e)
        {
            AddRouteForm Form = new AddRouteForm();
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
                int IdRoute = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["IdRoute"].Value);
                ChangeRouteForm Form = new ChangeRouteForm(IdRoute);
                Form.Closed += (s, ev) =>
                {
                    UpdateGrid();
                };
                Form.ShowDialog();
            }
        }
    }
}
