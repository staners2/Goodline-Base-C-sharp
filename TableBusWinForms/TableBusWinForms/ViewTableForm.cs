using LibraryController;
using LibraryController.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using TableBusWinForms.GeneralForm;
using TableBusWinForms.Presenter;

namespace TableBusWinForms.AdminView
{
    public partial class ViewTableForm : Form
    {
        public void GenerateInterface()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.MoneyLabel = new System.Windows.Forms.Label();
            this.MoneyTitleLabel = new System.Windows.Forms.Label();
            this.LoginLabel = new System.Windows.Forms.Label();
            this.MonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.ViewBuyerTicketsButton = new System.Windows.Forms.Button();
            this.LoginTitleLabel = new System.Windows.Forms.Label();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.IdRecordTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCountPassenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ModerationTableButton = new System.Windows.Forms.Button();
            this.ModerationRouteButton = new System.Windows.Forms.Button();
            this.ModerationCitiesButton = new System.Windows.Forms.Button();
            this.CityStartComboBox = new System.Windows.Forms.ComboBox();
            this.CityEndComboBox = new System.Windows.Forms.ComboBox();
            this.CityStartLabel = new System.Windows.Forms.Label();
            this.CityEndLabel = new System.Windows.Forms.Label();
            this.SearchButton = new System.Windows.Forms.Button();
            this.GetMoneyButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MoneyLabel
            // 
            this.MoneyLabel.AutoSize = true;
            this.MoneyLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyLabel.Location = new System.Drawing.Point(65, 31);
            this.MoneyLabel.Name = "MoneyLabel";
            this.MoneyLabel.Size = new System.Drawing.Size(57, 22);
            this.MoneyLabel.TabIndex = 13;
            this.MoneyLabel.Text = "money";
            // 
            // MoneyTitleLabel
            // 
            this.MoneyTitleLabel.AutoSize = true;
            this.MoneyTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MoneyTitleLabel.Location = new System.Drawing.Point(11, 31);
            this.MoneyTitleLabel.Name = "MoneyTitleLabel";
            this.MoneyTitleLabel.Size = new System.Drawing.Size(66, 22);
            this.MoneyTitleLabel.TabIndex = 12;
            this.MoneyTitleLabel.Text = "Money: ";
            // 
            // LoginLabel
            // 
            this.LoginLabel.AutoSize = true;
            this.LoginLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginLabel.Location = new System.Drawing.Point(56, 9);
            this.LoginLabel.Name = "LoginLabel";
            this.LoginLabel.Size = new System.Drawing.Size(44, 22);
            this.LoginLabel.TabIndex = 11;
            this.LoginLabel.Text = "login";
            // 
            // MonthCalendar
            // 
            this.MonthCalendar.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MonthCalendar.Location = new System.Drawing.Point(13, 276);
            this.MonthCalendar.MaxSelectionCount = 1;
            this.MonthCalendar.Name = "MonthCalendar";
            this.MonthCalendar.TabIndex = 10;
            this.MonthCalendar.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.MonthCalendar_DateChanged);
            // 
            // ViewBuyerTicketsButton
            // 
            this.ViewBuyerTicketsButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ViewBuyerTicketsButton.Location = new System.Drawing.Point(13, 221);
            this.ViewBuyerTicketsButton.Name = "ViewBuyerTicketsButton";
            this.ViewBuyerTicketsButton.Size = new System.Drawing.Size(164, 57);
            this.ViewBuyerTicketsButton.TabIndex = 9;
            this.ViewBuyerTicketsButton.Text = "Просмотр заказанных билетов";
            this.ViewBuyerTicketsButton.UseVisualStyleBackColor = true;
            this.ViewBuyerTicketsButton.Click += new System.EventHandler(this.ViewBuyerTicketsButtonClick);
            // 
            // LoginTitleLabel
            // 
            this.LoginTitleLabel.AutoSize = true;
            this.LoginTitleLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginTitleLabel.Location = new System.Drawing.Point(11, 9);
            this.LoginTitleLabel.Name = "LoginTitleLabel";
            this.LoginTitleLabel.Size = new System.Drawing.Size(59, 22);
            this.LoginTitleLabel.TabIndex = 8;
            this.LoginTitleLabel.Text = "Login: ";
            // 
            // DataGridView
            // 
            this.DataGridView.AllowUserToAddRows = false;
            this.DataGridView.AllowUserToDeleteRows = false;
            this.DataGridView.AllowUserToResizeColumns = false;
            this.DataGridView.AllowUserToResizeRows = false;
            this.DataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRecordTable,
            this.NameRoute,
            this.CityStart,
            this.CityEnd,
            this.DateTimeStart,
            this.CurrentCountPassenger,
            this.Price});
            this.DataGridView.Cursor = System.Windows.Forms.Cursors.Hand;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView.EnableHeadersVisualStyles = false;
            this.DataGridView.Location = new System.Drawing.Point(187, 12);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(1177, 543);
            this.DataGridView.TabIndex = 7;
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellDoubleClick);
            // 
            // IdRecordTable
            // 
            this.IdRecordTable.HeaderText = "Id записи";
            this.IdRecordTable.Name = "IdRecordTable";
            this.IdRecordTable.Visible = false;
            // 
            // NameRoute
            // 
            this.NameRoute.HeaderText = "Название маршрута";
            this.NameRoute.Name = "NameRoute";
            this.NameRoute.ReadOnly = true;
            this.NameRoute.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameRoute.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CityStart
            // 
            this.CityStart.HeaderText = "Откуда (город)";
            this.CityStart.Name = "CityStart";
            this.CityStart.ReadOnly = true;
            this.CityStart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CityStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CityEnd
            // 
            this.CityEnd.HeaderText = "Куда (город)";
            this.CityEnd.Name = "CityEnd";
            this.CityEnd.ReadOnly = true;
            this.CityEnd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CityEnd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // DateTimeStart
            // 
            this.DateTimeStart.HeaderText = "Время отбытия";
            this.DateTimeStart.Name = "DateTimeStart";
            this.DateTimeStart.ReadOnly = true;
            this.DateTimeStart.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.DateTimeStart.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // CurrentCountPassenger
            // 
            this.CurrentCountPassenger.HeaderText = "Свободных мест";
            this.CurrentCountPassenger.Name = "CurrentCountPassenger";
            this.CurrentCountPassenger.ReadOnly = true;
            this.CurrentCountPassenger.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CurrentCountPassenger.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.HeaderText = "Стоимость";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ModerationTableButton);
            this.panel1.Controls.Add(this.ModerationRouteButton);
            this.panel1.Controls.Add(this.ModerationCitiesButton);
            this.panel1.Location = new System.Drawing.Point(13, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(163, 137);
            this.panel1.TabIndex = 14;
            // 
            // ModerationTableButton
            // 
            this.ModerationTableButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModerationTableButton.Location = new System.Drawing.Point(-1, 79);
            this.ModerationTableButton.Name = "ModerationTableButton";
            this.ModerationTableButton.Size = new System.Drawing.Size(165, 58);
            this.ModerationTableButton.TabIndex = 2;
            this.ModerationTableButton.Text = "Модерация расписания";
            this.ModerationTableButton.UseVisualStyleBackColor = true;
            this.ModerationTableButton.Click += new System.EventHandler(this.ModerationTableButtonClick);
            // 
            // ModerationRouteButton
            // 
            this.ModerationRouteButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModerationRouteButton.Location = new System.Drawing.Point(-1, 36);
            this.ModerationRouteButton.Name = "ModerationRouteButton";
            this.ModerationRouteButton.Size = new System.Drawing.Size(165, 44);
            this.ModerationRouteButton.TabIndex = 1;
            this.ModerationRouteButton.Text = "Модерация путей";
            this.ModerationRouteButton.UseVisualStyleBackColor = true;
            this.ModerationRouteButton.Click += new System.EventHandler(this.ModerationRoutesButtonClick);
            // 
            // ModerationCitiesButton
            // 
            this.ModerationCitiesButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ModerationCitiesButton.Location = new System.Drawing.Point(-1, 0);
            this.ModerationCitiesButton.Name = "ModerationCitiesButton";
            this.ModerationCitiesButton.Size = new System.Drawing.Size(165, 37);
            this.ModerationCitiesButton.TabIndex = 0;
            this.ModerationCitiesButton.Text = "Модерация городов";
            this.ModerationCitiesButton.UseVisualStyleBackColor = true;
            this.ModerationCitiesButton.Click += new System.EventHandler(this.ModerationCitiesButtonClick);
            // 
            // CityStartComboBox
            // 
            this.CityStartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityStartComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityStartComboBox.FormattingEnabled = true;
            this.CityStartComboBox.Location = new System.Drawing.Point(12, 465);
            this.CityStartComboBox.Name = "CityStartComboBox";
            this.CityStartComboBox.Size = new System.Drawing.Size(163, 30);
            this.CityStartComboBox.TabIndex = 15;
            // 
            // CityEndComboBox
            // 
            this.CityEndComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityEndComboBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityEndComboBox.FormattingEnabled = true;
            this.CityEndComboBox.Location = new System.Drawing.Point(11, 524);
            this.CityEndComboBox.Name = "CityEndComboBox";
            this.CityEndComboBox.Size = new System.Drawing.Size(164, 30);
            this.CityEndComboBox.TabIndex = 16;
            // 
            // CityStartLabel
            // 
            this.CityStartLabel.AutoSize = true;
            this.CityStartLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityStartLabel.Location = new System.Drawing.Point(8, 440);
            this.CityStartLabel.Name = "CityStartLabel";
            this.CityStartLabel.Size = new System.Drawing.Size(61, 22);
            this.CityStartLabel.TabIndex = 17;
            this.CityStartLabel.Text = "Откуда";
            // 
            // CityEndLabel
            // 
            this.CityEndLabel.AutoSize = true;
            this.CityEndLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityEndLabel.Location = new System.Drawing.Point(11, 498);
            this.CityEndLabel.Name = "CityEndLabel";
            this.CityEndLabel.Size = new System.Drawing.Size(45, 22);
            this.CityEndLabel.TabIndex = 18;
            this.CityEndLabel.Text = "Куда";
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SearchButton.Location = new System.Drawing.Point(12, 559);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(164, 53);
            this.SearchButton.TabIndex = 19;
            this.SearchButton.Text = "Поиск";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButtonClick);
            // 
            // GetMoneyButton
            // 
            this.GetMoneyButton.Image = global::TableBusWinForms.Properties.Resources.star_active;
            this.GetMoneyButton.Location = new System.Drawing.Point(187, 559);
            this.GetMoneyButton.Name = "GetMoneyButton";
            this.GetMoneyButton.Size = new System.Drawing.Size(1177, 53);
            this.GetMoneyButton.TabIndex = 20;
            this.GetMoneyButton.UseVisualStyleBackColor = true;
            this.GetMoneyButton.Click += new System.EventHandler(this.GetMoneyButtonClick);
            // 
            // ViewTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1376, 617);
            this.Controls.Add(this.GetMoneyButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.CityEndLabel);
            this.Controls.Add(this.CityStartLabel);
            this.Controls.Add(this.CityEndComboBox);
            this.Controls.Add(this.CityStartComboBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MoneyLabel);
            this.Controls.Add(this.MoneyTitleLabel);
            this.Controls.Add(this.LoginLabel);
            this.Controls.Add(this.MonthCalendar);
            this.Controls.Add(this.ViewBuyerTicketsButton);
            this.Controls.Add(this.LoginTitleLabel);
            this.Controls.Add(this.DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "ViewTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр расписания";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ViewTableForm_FormClosing);
            this.Load += new System.EventHandler(this.ViewTableForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        public ViewTableFormPresenter ViewTableFormPresenter;
        public ViewTableForm(int IdAccount, string Login)
        {
            InitializeComponent();
            GenerateInterface();

            ViewTableFormPresenter = new ViewTableFormPresenter(this);
            this.IdAccount = IdAccount;
            LoginLabel.Text = Login;
            MoneyLabel.Text = Controller.GetMoneyForUser(IdAccount).ToString();

            PictureBox Image = new PictureBox(){Image = Properties.Resources.user_icon, Size = new Size(90, 45), Location = new Point(30,60), SizeMode = PictureBoxSizeMode.StretchImage};
            Controls.Add(Image);
        }

        public int IdAccount { get; set; }

        private void ViewTableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form AuthorizeForm = Application.OpenForms[0];
            AuthorizeForm.Show();
        }

        private void ViewTableForm_Load(object sender, EventArgs e)
        {
            ViewTableFormPresenter.LoadCities();
        }

        private void UpdateGrid(List<Table> pListTables)
        {
            DataGridView.Rows.Clear();
            MoneyLabel.Text = ViewTableFormPresenter.GetMoneyForUser().ToString();
            foreach (var elem in pListTables)
            {
                DataGridView.Rows.Add($"{elem.Id}", $"{elem.Route.NameRoute}", $"{elem.Route.City.CityName}",
                    $"{elem.Route.City1.CityName}", $"{elem.DateTimeStart}", $"{elem.MaxCountPassenger - elem.CurrentCountPassenger}",
                    $"{elem.Price}");
            }
        }

        private void GetMoneyButtonClick(object sender, EventArgs e)
        {
            ViewTableFormPresenter.OpenGetMoneyForm();
        }

        private void SearchButtonClick(object sender, EventArgs e)
        {
            if (CityStartComboBox.Text != string.Empty && CityEndComboBox.Text != string.Empty)
            {
                UpdateGrid(Controller.GetTableRecords(CityStartComboBox.Text, CityEndComboBox.Text));
            }
        }

        private void ModerationCitiesButtonClick(object sender, EventArgs e)
        {
            ViewTableFormPresenter.OpenModerationCities();
        }

        private void ModerationRoutesButtonClick(object sender, EventArgs e)
        {
            ViewTableFormPresenter.OpenModerationRoutes();
        }

        private void ModerationTableButtonClick(object sender, EventArgs e)
        {
            ViewTableFormPresenter.OpenModerationTableRecords();
        }

        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateGrid(Controller.GetTableRecords(MonthCalendar.SelectionRange.Start));
        }

        private void ViewBuyerTicketsButtonClick(object sender, EventArgs e)
        {
            var Form = new ViewPurchasedTicketsForm(IdAccount);
            Form.Closing += (s, ev) =>
            {
                if (CityStartComboBox.Text != string.Empty && CityEndComboBox.Text != string.Empty)
                {
                    SearchButtonClick(null, null);
                }
                else
                {
                    MonthCalendar_DateChanged(null, null);
                }
            };
            Form.ShowDialog();
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (DateTime.Parse(DataGridView.Rows[e.RowIndex].Cells["DateTimeStart"].Value.ToString()) < DateTime.Now)
                {
                    MessageBox.Show($"Приобрести билет невозможно. Автобус уже в пути!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int IdTable = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["IdRecordTable"].Value);
                BuyerTicketsForm Form = new BuyerTicketsForm(IdTable, IdAccount);
                Form.Closing += (s, ev) =>
                {
                    if (CityStartComboBox.Text != string.Empty && CityEndComboBox.Text != string.Empty)
                    {
                        SearchButtonClick(null, null);
                    }
                    else
                    {
                        MonthCalendar_DateChanged(null, null);
                    }
                };
                Form.ShowDialog();
            }
        }
    }
}
