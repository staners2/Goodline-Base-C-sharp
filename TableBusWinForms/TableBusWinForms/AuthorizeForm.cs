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

namespace TableBusWinForms
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void EnterButtonClick(object sender, EventArgs e)
        {
            if (LoginTextBox.Text != string.Empty)
            {
                int IdAccount;
                bool IsAdmin = false;
                if (!Controller.CheckUserExists(LoginTextBox.Text))
                {
                    IdAccount = Controller.RegistrationUser(LoginTextBox.Text);
                    this.Hide();
                }
                else
                {
                    User User = Controller.GetUser(LoginTextBox.Text);
                    IdAccount = User.Id;
                    IsAdmin = User.IsAdmin;
                }

                this.Hide();
                AdminView.ViewTableForm Form = new AdminView.ViewTableForm(IdAccount, LoginTextBox.Text);
                switch (IsAdmin)
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
                }
            }
        }
    }
}
