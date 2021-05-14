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
            try
            {
                if (textBox1.Text == string.Empty)
                    throw new Exception("Заполните все поля");
                if (ModerationController.IsHaveCity(textBox1.Text, IdCity))
                    throw new Exception("Город с таким названием уже существует");
                switch (ModerationController.ChangeCity(IdCity, textBox1.Text))
                {
                    case true:
                        this.Close();
                        break;
                    case false:
                        throw new Exception($"Произошла какая-то ошибка при изменении");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
