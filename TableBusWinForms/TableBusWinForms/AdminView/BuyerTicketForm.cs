using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableBusWinForms.AdminView
{
    public partial class BuyerTicketForm : Form
    {
        public BuyerTicketForm(int IdTable, int IdAccount)
        {
            InitializeComponent();
            this.IdTable = IdTable;
            this.IdAccount = IdAccount;
        }
        private int IdTable { get; set; }
        private int IdAccount { get; set; }
        private void BuyerTicketForm_Load(object sender, EventArgs e)
        {
            var table = Controller.GetTable(IdTable);
            textBox4.Text = table.Route.NameRoute;
            textBox1.Text = table.Route.City.CityName;
            textBox2.Text = table.Route.City1.CityName;
            textBox3.Text = table.Route.Distance.ToString();
            dateTimePicker1.Value = DateTime.Parse(table.Route.TravelTime.ToString());
            dateTimePicker2.Value = table.DateTimeStart;
            dateTimePicker3.Value = table.DateTimeEnd;
            numericUpDown1.Value = Convert.ToDecimal(table.Price);
            numericUpDown2.Value = Convert.ToDecimal(table.MaxCountPassenger);
        }
    }
}
