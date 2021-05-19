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
using TableBusWinForms.Presenter;

namespace TableBusWinForms.AdminView.Moderation.City
{
    public partial class ChangeCityForm : Form
    {
        public ChangeCityForm(int IdCity)
        {
            InitializeComponent();
            this.IdCity = IdCity;
            ChangeCityPresenter = new ChangeCityPresenter(this);
        }

        public ChangeCityPresenter ChangeCityPresenter { get; set; }
        public int IdCity { get; set; }

        private void ChangeCityForm_Load(object sender, EventArgs e)
        {
            ChangeCityPresenter.FormLoad();
            /*NameCityTextBox.Text = ModerationController.GetCity(IdCity).CityName;*/
        }

        private void ChangeCityButtonClick(object sender, EventArgs e)
        {
            ChangeCityPresenter.ChangeCityClick();
        }

        private void DeleteCityButtonClick(object sender, EventArgs e)
        {
            ChangeCityPresenter.DeleteCityClick();
        }
    }
}
