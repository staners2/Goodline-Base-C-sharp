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
            LoginLabel.Text = Login;
            MoneyLabel.Text = Controller.GetMoneyForUser(IdAccount).ToString();
        }

        private int IdAccount { get; set; }

        private void ViewTableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form AuthorizeForm = Application.OpenForms[0];
            AuthorizeForm.Show();
        }

        private void ViewTableForm_Load(object sender, EventArgs e)
        {
            var Cities = Controller.GetCities();
            foreach (var elem in Cities)
            {
                CityStartComboBox.Items.Add(elem.CityName);
                CityEndComboBox.Items.Add(elem.CityName);
            }
        }

        private void UpdateGrid(List<Table> pListTables)
        {
            DataGridView.Rows.Clear();
            MoneyLabel.Text = Controller.GetMoneyForUser(IdAccount).ToString();
            foreach (var elem in pListTables)
            {
                DataGridView.Rows.Add($"{elem.Id}", $"{elem.Route.NameRoute}", $"{elem.Route.City.CityName}",
                    $"{elem.Route.City1.CityName}", $"{elem.DateTimeStart}", $"{elem.MaxCountPassenger - elem.CurrentCountPassenger}",
                    $"{elem.Price}");
            }
        }

        private void GetMoneyButtonClick(object sender, EventArgs e)
        {
            var Form = new SnakeGameForm(IdAccount);
            Form.Closing += (s, ev) =>
            {
                MoneyLabel.Text = Controller.GetMoneyForUser(IdAccount).ToString();
            };
            Form.ShowDialog();
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            if (CityStartComboBox.Text != string.Empty && CityEndComboBox.Text != string.Empty)
            {
                UpdateGrid(Controller.GetTableRecords(MonthCalendar.SelectionStart, CityStartComboBox.Text, CityEndComboBox.Text));
            }
        }

        private void ModerationCitiesButtonClick(object sender, EventArgs e)
        {
            ViewModerationCityForm Form = new ViewModerationCityForm();
            Form.ShowDialog();
        }

        private void ModerationRoutesButtonClick(object sender, EventArgs e)
        {
            ViewModerationRouteForm Form = new ViewModerationRouteForm();
            Form.ShowDialog();
        }

        private void ModerationTableButtonClick(object sender, EventArgs e)
        {
            ViewModerationTableRecordsForm Form = new ViewModerationTableRecordsForm();
            Form.ShowDialog();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateGrid(Controller.GetTableRecords(MonthCalendar.SelectionRange.Start));
        }

        private void ViewBuyerTicketsButtonClick(object sender, EventArgs e)
        {
            var Form = new ViewPurchasedTicketsForm(IdAccount);
            Form.Closing += (s, ev) =>
            {
                if (CityStartComboBox.Text != string.Empty && CityEndComboBox.Text != string.Empty)
                {
                    SearchButtonClick(null, null);
                }
                else
                {
                    MonthCalendar_DateChanged(null, null);
                }
            };
            Form.ShowDialog();
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DateTime.Parse(DataGridView.Rows[e.RowIndex].Cells["DateTimeStart"].Value.ToString()) < DateTime.Now)
                {
                    MessageBox.Show($"Приобрести билет невозможно. Автобус уже в пути!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int IdTable = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["IdRecordTable"].Value);
                BuyerTicketsForm Form = new BuyerTicketsForm(IdTable, IdAccount);
                Form.Closing += (s, ev) =>
                {
                    if (CityStartComboBox.Text != string.Empty && CityEndComboBox.Text != string.Empty)
                    {
                        SearchButtonClick(null, null);
                    }
                    else
                    {
                        MonthCalendar_DateChanged(null, null);
                    }
                };
                Form.ShowDialog();
            }
        }
    }
}
