using System;
using System.Windows.Forms;
using TableBusWinForms.Presenter;

namespace TableBusWinForms.AdminView.Moderation.City
{
    public partial class AddCityForm : Form
    {
        public AddCityForm()
        {
            InitializeComponent();
            AddCityPresenter = new AddCityPresenter(this);
        }
        public AddCityPresenter AddCityPresenter { get; set; }

        private void AddCityButtonClick(object sender, EventArgs e)
        {
            if (NameCityTextBox.Text != string.Empty)
            {
                AddCityPresenter.AddCityButtonClick();
            }
        }
    }
}
