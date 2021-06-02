using System;
using System.Windows.Forms;
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
