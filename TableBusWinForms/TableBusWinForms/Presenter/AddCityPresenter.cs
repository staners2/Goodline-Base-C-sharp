using LibraryController;
using System.Windows.Forms;
using TableBusWinForms.AdminView.Moderation.City;

namespace TableBusWinForms.Presenter
{
    public class AddCityPresenter
    {
        public AddCityForm View { get; set; }
        public AddCityPresenter(AddCityForm View)
        {
            this.View = View;
        }

        public void AddCityButtonClick()
        {
            string NameCity = View.NameCityTextBox.Text;
            if (!ModerationController.IsHaveCity(NameCity))
            {
                switch (ModerationController.AddCity(NameCity))
                {
                    case true:
                        View.Close();
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
