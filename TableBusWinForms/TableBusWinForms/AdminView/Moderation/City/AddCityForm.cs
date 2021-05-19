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
