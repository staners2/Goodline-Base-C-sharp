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
        public void GenerateInterface()
        {
            this.LoginTextBox = new System.Windows.Forms.TextBox();
            this.EnterButton = new System.Windows.Forms.Button();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTextBox.Location = new System.Drawing.Point(78, 17);
            this.LoginTextBox.Name = "LoginTextBox";
            this.LoginTextBox.Size = new System.Drawing.Size(198, 30);
            this.LoginTextBox.TabIndex = 0;
            // 
            // EnterButton
            // 
            this.EnterButton.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnterButton.Location = new System.Drawing.Point(12, 58);
            this.EnterButton.Name = "EnterButton";
            this.EnterButton.Size = new System.Drawing.Size(264, 47);
            this.EnterButton.TabIndex = 1;
            this.EnterButton.Text = "Войти";
            this.EnterButton.UseVisualStyleBackColor = true;
            this.EnterButton.Click += new System.EventHandler(this.EnterButtonClick);
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(7, 23);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(65, 24);
            this.LoginLabel.TabIndex = 2;
            this.LoginLabel.Text = "Логин";
            // 
            // AuthorizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 114);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.EnterButton);
            this.Controls.Add(this.LoginTextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AuthorizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public AuthorizePresenter AuthorizePresenter;
        public AuthorizeForm()
        {
            InitializeComponent();
            GenerateInterface();

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
