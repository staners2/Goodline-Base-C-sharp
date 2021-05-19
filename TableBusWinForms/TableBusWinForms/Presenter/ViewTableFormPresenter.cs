using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.History;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryController;
using LibraryController.Models;
using snake;
using TableBusWinForms.AdminView;
using TableBusWinForms.AdminView.Moderation.City;
using TableBusWinForms.AdminView.Moderation.Route;
using TableBusWinForms.AdminView.Moderation.TableRecords;
using TableBusWinForms.GeneralForm;

namespace TableBusWinForms.Presenter
{
    public class ViewTableFormPresenter
    {
        public ViewTableForm View { get; set; }

        public ViewTableFormPresenter(ViewTableForm View)
        {
            this.View = View;
        }

        public void LoadCities()
        {
            List<City> Cities = Controller.GetCities();
            foreach (var elem in Cities)
            {
                View.CityStartComboBox.Items.Add(elem.CityName);
                View.CityEndComboBox.Items.Add(elem.CityName);
            }
        }

        public void OpenGetMoneyForm()
        {
            var Form = new SnakeGameForm(View.IdAccount);
            Form.Closing += (s, ev) =>
            {
                View.MoneyLabel.Text = Controller.GetMoneyForUser(View.IdAccount).ToString();
            };
            Form.ShowDialog();
        }

        public void OpenModerationCities()
        {
            ViewModerationCityForm Form = new ViewModerationCityForm();
            Form.ShowDialog();
        }
        public void OpenModerationRoutes()
        {
            ViewModerationRouteForm Form = new ViewModerationRouteForm();
            Form.ShowDialog();
        }

        public void OpenModerationTableRecords()
        {
            ViewModerationTableRecordsForm Form = new ViewModerationTableRecordsForm();
            Form.ShowDialog();
        }

        public int GetMoneyForUser()
        {
            int Money = Controller.GetMoneyForUser(View.IdAccount);
            return Money;
        }
    }
}
