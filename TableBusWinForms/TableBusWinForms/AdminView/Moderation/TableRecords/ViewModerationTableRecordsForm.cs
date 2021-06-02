using LibraryController;
using System;
using System.Windows.Forms;

namespace TableBusWinForms.AdminView.Moderation.TableRecords
{
    public partial class ViewModerationTableRecordsForm : Form
    {
        public ViewModerationTableRecordsForm()
        {
            InitializeComponent();
        }

        private void ViewModerationTableRecordsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void UpdateGrid()
        {
            DataGridView.Rows.Clear();
            var TableRecords = ModerationController.GetTableRecords();
            foreach (var elem in TableRecords)
            {
                DataGridView.Rows.Add($"{elem.Id}", $"{elem.Route.NameRoute}", $"{elem.Route.City.CityName}", 
                    $"{elem.Route.City1.CityName}", $"{elem.DateTimeStart}", $"{elem.MaxCountPassenger-elem.CurrentCountPassenger}",
                    $"{elem.Price}");
            }
        }

        private void AddRouteButtonClick(object sender, EventArgs e)
        {
            AddTableRecordsForm Form = new AddTableRecordsForm();
            Form.Closing += (s, ev) =>
            {
                UpdateGrid();
            };
            Form.ShowDialog();
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int IdTable = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["IdRecordTable"].Value);
                ChangeTableRecordsForm Form = new ChangeTableRecordsForm(IdTable);
                Form.Closed += (s, ev) =>
                {
                    UpdateGrid();
                };
                Form.ShowDialog();
            }
        }
    }
}
