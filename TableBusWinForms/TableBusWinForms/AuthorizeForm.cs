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
using LibraryController.Models;
using TableBusWinForms.Presenter;

namespace TableBusWinForms
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizePresenter AuthorizePresenter;
        public AuthorizeForm()
        {
            InitializeComponent();
            AuthorizePresenter = new AuthorizePresenter(this);
        }

        private void EnterButtonClick(object sender, EventArgs e)
        {

            if (LoginTextBox.Text != string.Empty)
            {
                AuthorizePresenter.EnterAccount();
                /*User pUser;
                if (!Controller.CheckUserExists(LoginTextBox.Text))
                    pUser = Controller.RegistrationUser(LoginTextBox.Text);
                pUser = Controller.GetUser(LoginTextBox.Text);
                this.Hide();*/

                /*User pUser = AuthorizePresenter.EnterAccount(LoginTextBox.Text);
                AdminView.ViewTableForm Form = new AdminView.ViewTableForm(pUser.Id, LoginTextBox.Text);
                switch (pUser.IsAdmin)
                {
                    case true:
                    {
                        Form.Text += " (Администратор)";
                        Form.ShowDialog();
                        break;
                    }

                    case false:
                    {
                        var PanelAdmin = (Panel)Form.Controls.Find("panel1", false).First();
                        PanelAdmin.Visible = false;
                        Form.Text += " (Пользователь)";
                        Form.ShowDialog();
                        break;
                    }
                }*/
            }
        }
    }
}
