using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableBusWinForms.Models;

namespace TableBusWinForms
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                int IdAccount;
                bool IsAdmin = false;
                if (!Controller.CheckUserExists(textBox1.Text))
                {
                    IdAccount = await Task.Factory.StartNew(() => Controller.RegistrationUser(textBox1.Text)).Result;
                    IsAdmin = false;
                    this.Hide();
                }
                else
                {
                    User User = Controller.GetUser(textBox1.Text);
                    IdAccount = User.Id;
                    IsAdmin = User.IsAdmin == true ? true : false;
                }

                this.Hide();
                switch (IsAdmin)
                {
                    case true:
                    {
                        AdminView.ViewTableForm Form = new AdminView.ViewTableForm(IdAccount);
                        Form.ShowDialog();
                        break;
                    }

                    case false:
                    {
                        UserView.ViewTableForm Form = new UserView.ViewTableForm(IdAccount);
                        Form.ShowDialog();
                        break;
                    }
                }
            }
        }
    }
}
