﻿using System;
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

        private async void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty)
            {
                int IdAccount;
                bool IsAdmin = false;
                if (!Controller.CheckUserExists(textBox1.Text))
                {
                    IdAccount = await Task.Factory.StartNew(() => Controller.RegistrationUser(textBox1.Text)).Result;
                    this.Hide();
                }
                else
                {
                    User User = Controller.GetUser(textBox1.Text);
                    IdAccount = User.Id;
                    IsAdmin = User.IsAdmin;
                }

                this.Hide();
                AdminView.ViewTableForm Form = new AdminView.ViewTableForm(IdAccount, textBox1.Text);
                switch (IsAdmin)
                {
                    case true:
                    {
                        Form.ShowDialog();
                        break;
                    }

                    case false:
                    {
                        var PanelAdmin = (Panel)Form.Controls.Find("panel1", false).First();
                        PanelAdmin.Visible = false;
                        Form.ShowDialog();
                        break;
                    }
                }
            }
        }
    }
}
