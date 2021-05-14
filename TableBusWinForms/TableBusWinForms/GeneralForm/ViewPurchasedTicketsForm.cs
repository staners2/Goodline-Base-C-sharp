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
using LibraryController.Models;

namespace TableBusWinForms.GeneralForm
{
    public partial class ViewPurchasedTicketsForm : Form
    {
        public ViewPurchasedTicketsForm(int IdAccount)
        {
            InitializeComponent();
            this.IdAccount = IdAccount;
        }

        private int IdAccount { get; set; }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int IdRecordFlight = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdRecordFlight"].Value);
                int IdTable = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["IdTable"].Value);
                PurchasedTicket Form = new PurchasedTicket(IdTable, IdRecordFlight);
                Form.Closing += (s, ev) =>
                {
                    UpdateGrid();
                };
                Form.ShowDialog();
            }
        }

        private void UpdateGrid()
        {
            List<RecordFlight> pListTables = Controller.GetFlightRecords(IdAccount);
            dataGridView1.Rows.Clear();
            foreach (var elem in pListTables)
            {
                dataGridView1.Rows.Add($"{elem.Id}", $"{elem.Table.Id}", $"{elem.Table.Route.NameRoute}", $"{elem.Table.Route.City.CityName}",
                    $"{elem.Table.Route.City1.CityName}", $"{elem.Table.DateTimeStart}", $"{elem.Table.MaxCountPassenger - elem.Table.CurrentCountPassenger}",
                    $"{elem.Table.Price}");
            }
        }

        private void ViePurchasedTicketsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }
    }
}
