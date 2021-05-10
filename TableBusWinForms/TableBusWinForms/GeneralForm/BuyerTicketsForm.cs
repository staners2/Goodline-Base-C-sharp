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

namespace TableBusWinForms.GeneralForm
{
    public partial class BuyerTicketsForm : Form
    {
        public BuyerTicketsForm(int IdTable, int IdAccount)
        {
            InitializeComponent();
            this.IdTable = IdTable;
            this.IdAccount = IdAccount;
        }

        private int IdTable { get; set; }
        private int IdAccount { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            var table = Controller.GetTable(IdTable);
            textBox1.Text = table.Route.NameRoute;
            textBox2.Text = table.Route.City.CityName;
            textBox3.Text = table.Route.City1.CityName;
            textBox4.Text = table.DateTimeStart.ToString("g");
            textBox5.Text = table.DateTimeEnd.ToString("g");
            textBox6.Text = table.Route.Distance.ToString();
            textBox7.Text = ModerationController.ConvertDistanceTimeTravel(table.Route.Distance).ToString("T");
            textBox8.Text = Controller.GetAmountFreePlaces(IdTable).ToString();
            textBox9.Text = table.Price.ToString();

            label9.Text = table.DateTimeStart.ToString("d");
            label11.Text = Controller.GetMoneyForUser(IdAccount).ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var table = Controller.GetTable(IdTable);
            try
            {
                if (Controller.GetMoneyForUser(IdAccount) < table.Price)
                    throw new Exception("У вас недостаточно денег!");
                if (!Controller.CheckFreeTableRecord(IdTable))
                    throw new Exception("Все билеты на этот рейс распроданы!");
                switch (Controller.BuyTicketForUser(IdAccount, IdTable))
                {
                    case false:
                        throw new Exception("Произошла какая-то ошибка!");
                    default:
                        MessageBox.Show($"Билет приобретен!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }
    }
}
