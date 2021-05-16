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
    public partial class AddCityForm : Form
    {
        public AddCityForm()
        {
            InitializeComponent();
        }

        private void AddCityButtonClick(object sender, EventArgs e)
        {
            if (NameCityTextBox.Text != string.Empty)
            {
                string NameCity = NameCityTextBox.Text;
                if (!ModerationController.IsHaveCity(NameCity))
                {
                    switch (ModerationController.AddCity(NameCity))
                    {
                        case true:
                            this.Close();
                            break;
                        default:
                            MessageBox.Show($"Произошла какая-то ошибка при добавлении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            break;
                    }
                }
                else
                {
                    MessageBox.Show($"Город с названием: {NameCity} уже существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
