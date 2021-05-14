using System;
using System.Collections.Generic;
using System.Windows.Forms;
using LibraryController;
using LibraryController.Models;
using snake;
using TableBusWinForms.AdminView.Moderation.City;
using TableBusWinForms.AdminView.Moderation.Route;
using TableBusWinForms.AdminView.Moderation.TableRecords;
using TableBusWinForms.GeneralForm;

namespace TableBusWinForms.AdminView
{
    public partial class ViewTableForm : Form
    {
        public ViewTableForm(int IdAccount, string Login)
        {
            InitializeComponent();
            this.IdAccount = IdAccount;
            label2.Text = Login;
            label4.Text = Controller.GetMoneyForUser(IdAccount).ToString();
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
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
           UpdateGrid(Controller.GetTableRecords(monthCalendar1.SelectionRange.Start));
        }

        private void UpdateGrid(List<Table> pListTables)
        {
            dataGridView1.Rows.Clear();
            label4.Text = Controller.GetMoneyForUser(IdAccount).ToString();
            foreach (var elem in pListTables)
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
                if (DateTime.Parse(dataGridView1.Rows[e.RowIndex].Cells["DateTimeStart"].Value.ToString()) < DateTime.Now)
                {
                    MessageBox.Show($"Приобрести билет невозможно. Автобус уже в пути!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int IdTable = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdRecordTable"].Value);
                BuyerTicketsForm Form = new BuyerTicketsForm(IdTable, IdAccount);
                Form.Closing += (s, ev) =>
                {
                    if (comboBox1.Text != string.Empty && comboBox2.Text != string.Empty)
                    {
                        button5_Click(null, null);
                    }
                    else
                    {
                        monthCalendar1_DateChanged(null, null);
                    }
                };
                Form.ShowDialog();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != string.Empty && comboBox2.Text != string.Empty)
            {
                UpdateGrid(Controller.GetTableRecords(monthCalendar1.SelectionStart, comboBox1.Text, comboBox2.Text));
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var Form = new ViewPurchasedTicketsForm(IdAccount);
            Form.Closing += (s, ev) =>
            {
                if (comboBox1.Text != string.Empty && comboBox2.Text != string.Empty)
                {
                    button5_Click(null, null);
                }
                else
                {
                    monthCalendar1_DateChanged(null, null);
                }
            };
            Form.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var Form = new SnakeGameForm(IdAccount);
            Form.Closing += (s, ev) =>
            {
                label4.Text = Controller.GetMoneyForUser(IdAccount).ToString();
            };
            Form.ShowDialog();
        }
    }
}
