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
            dataGridView1.Rows.Clear();
            var TableRecords = ModerationController.GetTableRecords();
            foreach (var elem in TableRecords)
            {
                dataGridView1.Rows.Add($"{elem.Id}", $"{elem.Route.NameRoute}", $"{elem.Route.City.CityName}", 
                    $"{elem.Route.City1.CityName}", $"{elem.DateTimeStart}", $"{elem.MaxCountPassenger-elem.CurrentCountPassenger}",
                    $"{elem.Price}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddTableRecordsForm Form = new AddTableRecordsForm();
            Form.Closing += (s, ev) =>
            {
                UpdateGrid();
            };
            Form.ShowDialog();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int IdTable = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdRecordTable"].Value);
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
