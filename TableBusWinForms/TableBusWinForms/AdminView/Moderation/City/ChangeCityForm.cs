using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableBusWinForms.AdminView.Moderation.City
{
    public partial class ChangeCityForm : Form
    {
        public ChangeCityForm(int IdCity)
        {
            InitializeComponent();
            this.IdCity = IdCity;
        }

        private int IdCity { get; set; }

        private void ChangeCityForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = ModerationController.GetCity(IdCity).CityName;
        }

        // change
        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                switch (ModerationController.ChangeCity(IdCity, textBox1.Text))
                {
                    case true:
                        this.Close();
                        break;
                    default:
                        MessageBox.Show($"Произошла какая-то ошибка при изменении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
        }

        // delete
        private void button2_Click(object sender, EventArgs e)
        {
            switch (ModerationController.RemoveCity(IdCity))
            {
                case true:
                    this.Close();
                    break;
                default:
                    MessageBox.Show($"Произошла какая-то ошибка при удалении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
