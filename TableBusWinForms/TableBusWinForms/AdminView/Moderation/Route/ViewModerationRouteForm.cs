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
    public partial class ViewModerationRouteForm : Form
    {
        public ViewModerationRouteForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int IdRoute = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdRoute"].Value);
                ChangeRouteForm Form = new ChangeRouteForm(IdRoute);
                Form.Closed += (s, ev) =>
                {
                    UpdateGrid();
                };
                Form.ShowDialog();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRouteForm Form = new AddRouteForm();
            Form.Closed += (s, ev) =>
            {
                UpdateGrid();
            };
            Form.ShowDialog();

        }

        private void UpdateGrid()
        {
            dataGridView1.Rows.Clear();
            var Routes = ModerationController.GetRoutes();
            foreach (var elem in Routes)
            {
                dataGridView1.Rows.Add(
                    $"{elem.Id}", $"{elem.NameRoute}", $"{elem.City.CityName}",
                    $"{elem.City1.CityName}", $"{elem.Distance}", $"{elem.TravelTime}");
            }
        }

        private void ViewModerationRouteForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
