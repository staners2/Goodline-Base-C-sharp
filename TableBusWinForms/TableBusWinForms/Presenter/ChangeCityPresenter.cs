using LibraryController;
using System;
using System.Windows.Forms;
using TableBusWinForms.AdminView.Moderation.City;

namespace TableBusWinForms.Presenter
{
    public class ChangeCityPresenter
    {
        public ChangeCityForm View { get; set; }
        public ChangeCityPresenter(ChangeCityForm View)
        {
            this.View = View;
        }

        public void FormLoad()
        {
            View.NameCityTextBox.Text = ModerationController.GetCity(View.IdCity).CityName;
        }

        public void ChangeCityClick()
        {
            try
            {
                if (View.NameCityTextBox.Text == string.Empty)
                    throw new Exception("Заполните все поля");
                if (ModerationController.IsHaveCity(View.NameCityTextBox.Text, View.IdCity))
                    throw new Exception("Город с таким названием уже существует");
                switch (ModerationController.ChangeCity(View.IdCity, View.NameCityTextBox.Text))
                {
                    case true:
                        View.Close();
                        break;
                    case false:
                        throw new Exception($"Произошла какая-то ошибка при изменении");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeleteCityClick()
        {
            switch (ModerationController.RemoveCity(View.IdCity))
            {
                case true:
                    View.Close();
                    break;
                default:
                    MessageBox.Show($"Произошла какая-то ошибка при удалении", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }
        }
    }
}
