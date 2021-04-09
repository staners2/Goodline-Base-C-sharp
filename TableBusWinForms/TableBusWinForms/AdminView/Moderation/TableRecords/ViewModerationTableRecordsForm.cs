using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        }

        private void UpdateGrid()
        {
            var TableRecords = ModerationController.GetTableRecords();
            foreach (var elem in TableRecords)
            {
                dataGridView1.Rows.Add($"{elem.Id}", $"{elem.Route.NameRoute}", $"{elem.Route.City.CityName}", 
                    $"{elem.Route.City1.CityName}", $"{elem.DateTimeStart}", $"{elem.MaxCountPassenger-elem.CurrentCountPassenger}",
                    $"{elem.Price}");
            }
        }
    }
}
