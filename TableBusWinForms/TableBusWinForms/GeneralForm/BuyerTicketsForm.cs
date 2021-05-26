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

namespace TableBusWinForms.GeneralForm
{
    public partial class BuyerTicketsForm : Form
    {
        public void GenerateInterface()
        {
            this.PlacesTextBox = new System.Windows.Forms.TextBox();
            this.TravelTimeLabel = new System.Windows.Forms.Label();
            this.PriceTextBox = new System.Windows.Forms.TextBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.BuyButton = new System.Windows.Forms.Button();
            this.BalanceLabel = new System.Windows.Forms.Label();
            this.BalanceTitleLabel = new System.Windows.Forms.Label();
            this.DateLabel = new System.Windows.Forms.Label();
            this.DateTitleLabel = new System.Windows.Forms.Label();
            this.TimeTravelTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.FreePlacesLabel = new System.Windows.Forms.Label();
            this.TimeEndTextBox = new System.Windows.Forms.TextBox();
            this.TimeEndLabel = new System.Windows.Forms.Label();
            this.TimeStartTextBox = new System.Windows.Forms.TextBox();
            this.TimeStartLabel = new System.Windows.Forms.Label();
            this.CityEndTextBox = new System.Windows.Forms.TextBox();
            this.CityEndLabel = new System.Windows.Forms.Label();
            this.CityStartTextBox = new System.Windows.Forms.TextBox();
            this.CityStartLabel = new System.Windows.Forms.Label();
            this.NameRouteTextBox = new System.Windows.Forms.TextBox();
            this.NameRouteLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // PlacesTextBox
            // 
            this.PlacesTextBox.Enabled = false;
            this.PlacesTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PlacesTextBox.Location = new System.Drawing.Point(163, 229);
            this.PlacesTextBox.Name = "PlacesTextBox";
            this.PlacesTextBox.Size = new System.Drawing.Size(138, 26);
            this.PlacesTextBox.TabIndex = 47;
            // 
            // TravelTimeLabel
            // 
            this.TravelTimeLabel.AutoSize = true;
            this.TravelTimeLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TravelTimeLabel.Location = new System.Drawing.Point(51, 196);
            this.TravelTimeLabel.Name = "TravelTimeLabel";
            this.TravelTimeLabel.Size = new System.Drawing.Size(106, 22);
            this.TravelTimeLabel.TabIndex = 46;
            this.TravelTimeLabel.Text = "Время в пути";
            // 
            // PriceTextBox
            // 
            this.PriceTextBox.Enabled = false;
            this.PriceTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceTextBox.Location = new System.Drawing.Point(163, 252);
            this.PriceTextBox.Name = "PriceTextBox";
            this.PriceTextBox.Size = new System.Drawing.Size(138, 26);
            this.PriceTextBox.TabIndex = 45;
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceLabel.Location = new System.Drawing.Point(67, 169);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(87, 22);
            this.DistanceLabel.TabIndex = 44;
            this.DistanceLabel.Text = "Дистанция";
            // 
            // BuyButton
            // 
            this.BuyButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BuyButton.Location = new System.Drawing.Point(12, 293);
            this.BuyButton.Name = "BuyButton";
            this.BuyButton.Size = new System.Drawing.Size(456, 65);
            this.BuyButton.TabIndex = 43;
            this.BuyButton.Text = "Приобрести";
            this.BuyButton.UseVisualStyleBackColor = true;
            this.BuyButton.Click += new System.EventHandler(this.BuyButtonClick);
            // 
            // BalanceLabel
            // 
            this.BalanceLabel.AutoSize = true;
            this.BalanceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceLabel.Location = new System.Drawing.Point(375, 29);
            this.BalanceLabel.Name = "BalanceLabel";
            this.BalanceLabel.Size = new System.Drawing.Size(60, 22);
            this.BalanceLabel.TabIndex = 42;
            this.BalanceLabel.Text = "Баланс";
            // 
            // BalanceTitleLabel
            // 
            this.BalanceTitleLabel.AutoSize = true;
            this.BalanceTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BalanceTitleLabel.Location = new System.Drawing.Point(307, 29);
            this.BalanceTitleLabel.Name = "BalanceTitleLabel";
            this.BalanceTitleLabel.Size = new System.Drawing.Size(66, 22);
            this.BalanceTitleLabel.TabIndex = 41;
            this.BalanceTitleLabel.Text = "Баланс:";
            // 
            // DateLabel
            // 
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.Location = new System.Drawing.Point(370, -2);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(44, 22);
            this.DateLabel.TabIndex = 40;
            this.DateLabel.Text = "Дата";
            // 
            // DateTitleLabel
            // 
            this.DateTitleLabel.AutoSize = true;
            this.DateTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateTitleLabel.Location = new System.Drawing.Point(320, -2);
            this.DateTitleLabel.Name = "DateTitleLabel";
            this.DateTitleLabel.Size = new System.Drawing.Size(50, 22);
            this.DateTitleLabel.TabIndex = 39;
            this.DateTitleLabel.Text = "Дата:";
            // 
            // TimeTravelTextBox
            // 
            this.TimeTravelTextBox.Enabled = false;
            this.TimeTravelTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeTravelTextBox.Location = new System.Drawing.Point(163, 192);
            this.TimeTravelTextBox.Name = "TimeTravelTextBox";
            this.TimeTravelTextBox.Size = new System.Drawing.Size(138, 26);
            this.TimeTravelTextBox.TabIndex = 38;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.Location = new System.Drawing.Point(65, 255);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(87, 22);
            this.PriceLabel.TabIndex = 37;
            this.PriceLabel.Text = "Стоимость";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Enabled = false;
            this.DistanceTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistanceTextBox.Location = new System.Drawing.Point(163, 166);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(138, 26);
            this.DistanceTextBox.TabIndex = 36;
            // 
            // FreePlacesLabel
            // 
            this.FreePlacesLabel.AutoSize = true;
            this.FreePlacesLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FreePlacesLabel.Location = new System.Drawing.Point(22, 230);
            this.FreePlacesLabel.Name = "FreePlacesLabel";
            this.FreePlacesLabel.Size = new System.Drawing.Size(130, 22);
            this.FreePlacesLabel.TabIndex = 35;
            this.FreePlacesLabel.Text = "Свободных мест";
            // 
            // TimeEndTextBox
            // 
            this.TimeEndTextBox.Enabled = false;
            this.TimeEndTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeEndTextBox.Location = new System.Drawing.Point(163, 127);
            this.TimeEndTextBox.Name = "TimeEndTextBox";
            this.TimeEndTextBox.Size = new System.Drawing.Size(138, 26);
            this.TimeEndTextBox.TabIndex = 34;
            // 
            // TimeEndLabel
            // 
            this.TimeEndLabel.AutoSize = true;
            this.TimeEndLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeEndLabel.Location = new System.Drawing.Point(23, 130);
            this.TimeEndLabel.Name = "TimeEndLabel";
            this.TimeEndLabel.Size = new System.Drawing.Size(131, 22);
            this.TimeEndLabel.TabIndex = 33;
            this.TimeEndLabel.Text = "Время прибытия";
            // 
            // TimeStartTextBox
            // 
            this.TimeStartTextBox.Enabled = false;
            this.TimeStartTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStartTextBox.Location = new System.Drawing.Point(163, 101);
            this.TimeStartTextBox.Name = "TimeStartTextBox";
            this.TimeStartTextBox.Size = new System.Drawing.Size(138, 26);
            this.TimeStartTextBox.TabIndex = 32;
            // 
            // TimeStartLabel
            // 
            this.TimeStartLabel.AutoSize = true;
            this.TimeStartLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeStartLabel.Location = new System.Drawing.Point(33, 105);
            this.TimeStartLabel.Name = "TimeStartLabel";
            this.TimeStartLabel.Size = new System.Drawing.Size(121, 22);
            this.TimeStartLabel.TabIndex = 31;
            this.TimeStartLabel.Text = "Время отбытия";
            // 
            // CityEndTextBox
            // 
            this.CityEndTextBox.Enabled = false;
            this.CityEndTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityEndTextBox.Location = new System.Drawing.Point(163, 65);
            this.CityEndTextBox.Name = "CityEndTextBox";
            this.CityEndTextBox.Size = new System.Drawing.Size(138, 26);
            this.CityEndTextBox.TabIndex = 30;
            // 
            // CityEndLabel
            // 
            this.CityEndLabel.AutoSize = true;
            this.CityEndLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityEndLabel.Location = new System.Drawing.Point(49, 69);
            this.CityEndLabel.Name = "CityEndLabel";
            this.CityEndLabel.Size = new System.Drawing.Size(105, 22);
            this.CityEndLabel.TabIndex = 29;
            this.CityEndLabel.Text = "Куда (город)";
            // 
            // CityStartTextBox
            // 
            this.CityStartTextBox.Enabled = false;
            this.CityStartTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityStartTextBox.Location = new System.Drawing.Point(163, 39);
            this.CityStartTextBox.Name = "CityStartTextBox";
            this.CityStartTextBox.Size = new System.Drawing.Size(138, 26);
            this.CityStartTextBox.TabIndex = 28;
            // 
            // CityStartLabel
            // 
            this.CityStartLabel.AutoSize = true;
            this.CityStartLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityStartLabel.Location = new System.Drawing.Point(33, 42);
            this.CityStartLabel.Name = "CityStartLabel";
            this.CityStartLabel.Size = new System.Drawing.Size(121, 22);
            this.CityStartLabel.TabIndex = 27;
            this.CityStartLabel.Text = "Откуда (город)";
            // 
            // NameRouteTextBox
            // 
            this.NameRouteTextBox.Enabled = false;
            this.NameRouteTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRouteTextBox.Location = new System.Drawing.Point(163, 1);
            this.NameRouteTextBox.Name = "NameRouteTextBox";
            this.NameRouteTextBox.Size = new System.Drawing.Size(138, 26);
            this.NameRouteTextBox.TabIndex = 26;
            // 
            // NameRouteLabel
            // 
            this.NameRouteLabel.AutoSize = true;
            this.NameRouteLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameRouteLabel.Location = new System.Drawing.Point(3, 5);
            this.NameRouteLabel.Name = "NameRouteLabel";
            this.NameRouteLabel.Size = new System.Drawing.Size(154, 22);
            this.NameRouteLabel.TabIndex = 25;
            this.NameRouteLabel.Text = "Название маршрута";
            // 
            // BuyerTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 364);
            this.Controls.Add(this.PlacesTextBox);
            this.Controls.Add(this.TravelTimeLabel);
            this.Controls.Add(this.PriceTextBox);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.BuyButton);
            this.Controls.Add(this.BalanceLabel);
            this.Controls.Add(this.BalanceTitleLabel);
            this.Controls.Add(this.DateLabel);
            this.Controls.Add(this.DateTitleLabel);
            this.Controls.Add(this.TimeTravelTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.FreePlacesLabel);
            this.Controls.Add(this.TimeEndTextBox);
            this.Controls.Add(this.TimeEndLabel);
            this.Controls.Add(this.TimeStartTextBox);
            this.Controls.Add(this.TimeStartLabel);
            this.Controls.Add(this.CityEndTextBox);
            this.Controls.Add(this.CityEndLabel);
            this.Controls.Add(this.CityStartTextBox);
            this.Controls.Add(this.CityStartLabel);
            this.Controls.Add(this.NameRouteTextBox);
            this.Controls.Add(this.NameRouteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "BuyerTicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Приобрести билет на рейс";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public BuyerTicketsForm(int IdTable, int IdAccount)
        {
            InitializeComponent();
            GenerateInterface();

            this.IdTable = IdTable;
            this.IdAccount = IdAccount;
            BuyerTicketsPresenter = new BuyerTicketsPresenter(this);
        }

        public BuyerTicketsPresenter BuyerTicketsPresenter { get; set; }
        public int IdTable { get; set; }
        public int IdAccount { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuyerTicketsPresenter.FormLoad();
        }
        
        private void BuyButtonClick(object sender, EventArgs e)
        {
            BuyerTicketsPresenter.BuyButtonClick();
        }
    }
}
