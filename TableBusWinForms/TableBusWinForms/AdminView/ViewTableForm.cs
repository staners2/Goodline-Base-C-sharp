using System;
using System.Windows.Forms;
using TableBusWinForms.AdminView.Moderation;
using TableBusWinForms.AdminView.Moderation.City;
using TableBusWinForms.AdminView.Moderation.Route;
using TableBusWinForms.AdminView.Moderation.TableRecords;

namespace TableBusWinForms.AdminView
{
    public partial class ViewTableForm : Form
    {
        public ViewTableForm(int IdAccount)
        {
            InitializeComponent();
            this.IdAccount = IdAccount;
        }

        private int IdAccount { get; set; }

        private void ViewTableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form AuthorizeForm = Application.OpenForms[0];
            AuthorizeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewModerationCityForm Form = new ViewModerationCityForm();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewModerationRouteForm Form = new ViewModerationRouteForm();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewModerationTableRecordsForm Form = new ViewModerationTableRecordsForm();
            Form.ShowDialog();
        }

        private void ViewTableForm_Load(object sender, EventArgs e)
        {
            var Cities = Controller.GetCities();
            foreach (var elem in Cities)
            {
                comboBox1.Items.Add(elem.CityName);
                comboBox2.Items.Add(elem.CityName);
            }

            //UpdateGrid();

        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty && comboBox2.Text != string.Empty &&
                comboBox1.Text != comboBox2.Text)
            {
                UpdateGrid();
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            if (comboBox1.Text != string.Empty && comboBox2.Text != string.Empty &&
                comboBox1.Text != comboBox2.Text)
            {
                UpdateGrid();
            }
        }

        private void UpdateGrid()
        {
            dataGridView1.Rows.Clear();
            var TableRecords = Controller.GetTableRecords(monthCalendar1.SelectionRange.Start, comboBox1.Text, comboBox2.Text);
            foreach (var elem in TableRecords)
            {
                dataGridView1.Rows.Add($"{elem.Id}", $"{elem.Route.NameRoute}", $"{elem.Route.City.CityName}",
                    $"{elem.Route.City1.CityName}", $"{elem.DateTimeStart}", $"{elem.MaxCountPassenger - elem.CurrentCountPassenger}",
                    $"{elem.Price}");
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int IdTable = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdRecordTable"].Value);
                BuyerTicketForm Form = new BuyerTicketForm(IdTable, IdAccount);
                Form.Closed += (s, ev) =>
                {
                    UpdateGrid();
                };
                Form.ShowDialog();
            }
        }
    }
}
