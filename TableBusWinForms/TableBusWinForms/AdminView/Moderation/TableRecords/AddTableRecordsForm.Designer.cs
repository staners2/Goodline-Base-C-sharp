
namespace TableBusWinForms.AdminView.Moderation.TableRecords
{
    partial class AddTableRecordsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NameRouteComboBox = new System.Windows.Forms.ComboBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.TravelDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeTravelLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.CityEndLabel = new System.Windows.Forms.Label();
            this.CityStartLabel = new System.Windows.Forms.Label();
            this.NameRouteLabel = new System.Windows.Forms.Label();
            this.CityStartTextBox = new System.Windows.Forms.TextBox();
            this.CityEndTextBox = new System.Windows.Forms.TextBox();
            this.DateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.DateStartLabel = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.FreePlacesLabel = new System.Windows.Forms.Label();
            this.DateEndLabel = new System.Windows.Forms.Label();
            this.DataEndPicker = new System.Windows.Forms.DateTimePicker();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.CountFreePlacesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountFreePlacesNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // NameRouteComboBox
            // 
            this.NameRouteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameRouteComboBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRouteComboBox.FormattingEnabled = true;
            this.NameRouteComboBox.Location = new System.Drawing.Point(168, 9);
            this.NameRouteComboBox.MaxDropDownItems = 5;
            this.NameRouteComboBox.Name = "NameRouteComboBox";
            this.NameRouteComboBox.Size = new System.Drawing.Size(135, 26);
            this.NameRouteComboBox.TabIndex = 25;
            this.NameRouteComboBox.SelectionChangeCommitted += new System.EventHandler(this.RouteComboBox_SelectionChangeCommitted);
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(12, 171);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(566, 51);
            this.AddButton.TabIndex = 24;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddTableRecordButtonClick);
            // 
            // TravelDateTimePicker
            // 
            this.TravelDateTimePicker.CustomFormat = "HH:mm:ss";
            this.TravelDateTimePicker.Enabled = false;
            this.TravelDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TravelDateTimePicker.Location = new System.Drawing.Point(168, 145);
            this.TravelDateTimePicker.Name = "TravelDateTimePicker";
            this.TravelDateTimePicker.ShowUpDown = true;
            this.TravelDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.TravelDateTimePicker.TabIndex = 23;
            // 
            // TimeTravelLabel
            // 
            this.TimeTravelLabel.AutoSize = true;
            this.TimeTravelLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeTravelLabel.Location = new System.Drawing.Point(56, 143);
            this.TimeTravelLabel.Name = "TimeTravelLabel";
            this.TimeTravelLabel.Size = new System.Drawing.Size(106, 22);
            this.TimeTravelLabel.TabIndex = 22;
            this.TimeTravelLabel.Text = "Время в пути";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceLabel.Location = new System.Drawing.Point(69, 111);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(93, 22);
            this.DistanceLabel.TabIndex = 20;
            this.DistanceLabel.Text = "Расстояние";
            // 
            // CityEndLabel
            // 
            this.CityEndLabel.AutoSize = true;
            this.CityEndLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityEndLabel.Location = new System.Drawing.Point(57, 73);
            this.CityEndLabel.Name = "CityEndLabel";
            this.CityEndLabel.Size = new System.Drawing.Size(105, 22);
            this.CityEndLabel.TabIndex = 19;
            this.CityEndLabel.Text = "Куда (город)";
            // 
            // CityStartLabel
            // 
            this.CityStartLabel.AutoSize = true;
            this.CityStartLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityStartLabel.Location = new System.Drawing.Point(41, 41);
            this.CityStartLabel.Name = "CityStartLabel";
            this.CityStartLabel.Size = new System.Drawing.Size(121, 22);
            this.CityStartLabel.TabIndex = 18;
            this.CityStartLabel.Text = "Откуда (город)";
            // 
            // NameRouteLabel
            // 
            this.NameRouteLabel.AutoSize = true;
            this.NameRouteLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRouteLabel.Location = new System.Drawing.Point(8, 9);
            this.NameRouteLabel.Name = "NameRouteLabel";
            this.NameRouteLabel.Size = new System.Drawing.Size(154, 22);
            this.NameRouteLabel.TabIndex = 17;
            this.NameRouteLabel.Text = "Название маршрута";
            // 
            // CityStartTextBox
            // 
            this.CityStartTextBox.Enabled = false;
            this.CityStartTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityStartTextBox.Location = new System.Drawing.Point(168, 41);
            this.CityStartTextBox.Name = "CityStartTextBox";
            this.CityStartTextBox.Size = new System.Drawing.Size(135, 26);
            this.CityStartTextBox.TabIndex = 26;
            // 
            // CityEndTextBox
            // 
            this.CityEndTextBox.Enabled = false;
            this.CityEndTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityEndTextBox.Location = new System.Drawing.Point(168, 73);
            this.CityEndTextBox.Name = "CityEndTextBox";
            this.CityEndTextBox.Size = new System.Drawing.Size(135, 26);
            this.CityEndTextBox.TabIndex = 27;
            // 
            // DateStartPicker
            // 
            this.DateStartPicker.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.DateStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStartPicker.Location = new System.Drawing.Point(443, 11);
            this.DateStartPicker.Name = "DateStartPicker";
            this.DateStartPicker.Size = new System.Drawing.Size(135, 20);
            this.DateStartPicker.TabIndex = 28;
            this.DateStartPicker.ValueChanged += new System.EventHandler(this.DateStartPicker_ValueChanged);
            // 
            // DateStartLabel
            // 
            this.DateStartLabel.AutoSize = true;
            this.DateStartLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateStartLabel.Location = new System.Drawing.Point(328, 9);
            this.DateStartLabel.Name = "DateStartLabel";
            this.DateStartLabel.Size = new System.Drawing.Size(109, 22);
            this.DateStartLabel.TabIndex = 29;
            this.DateStartLabel.Text = "Дата отбытия";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Enabled = false;
            this.DistanceTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceTextBox.Location = new System.Drawing.Point(168, 108);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(135, 26);
            this.DistanceTextBox.TabIndex = 31;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(350, 71);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(87, 22);
            this.PriceLabel.TabIndex = 30;
            this.PriceLabel.Text = "Стоимость";
            // 
            // FreePlacesLabel
            // 
            this.FreePlacesLabel.AutoSize = true;
            this.FreePlacesLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FreePlacesLabel.Location = new System.Drawing.Point(336, 107);
            this.FreePlacesLabel.Name = "FreePlacesLabel";
            this.FreePlacesLabel.Size = new System.Drawing.Size(101, 22);
            this.FreePlacesLabel.TabIndex = 33;
            this.FreePlacesLabel.Text = "Кол-во мест";
            // 
            // DateEndLabel
            // 
            this.DateEndLabel.AutoSize = true;
            this.DateEndLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateEndLabel.Location = new System.Drawing.Point(318, 35);
            this.DateEndLabel.Name = "DateEndLabel";
            this.DateEndLabel.Size = new System.Drawing.Size(119, 22);
            this.DateEndLabel.TabIndex = 35;
            this.DateEndLabel.Text = "Дата прибытия";
            // 
            // DataEndPicker
            // 
            this.DataEndPicker.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.DataEndPicker.Enabled = false;
            this.DataEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DataEndPicker.Location = new System.Drawing.Point(443, 37);
            this.DataEndPicker.Name = "DataEndPicker";
            this.DataEndPicker.Size = new System.Drawing.Size(135, 20);
            this.DataEndPicker.TabIndex = 34;
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.Location = new System.Drawing.Point(443, 73);
            this.PriceNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.PriceNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.PriceNumericUpDown.Name = "PriceNumericUpDown";
            this.PriceNumericUpDown.Size = new System.Drawing.Size(135, 20);
            this.PriceNumericUpDown.TabIndex = 36;
            this.PriceNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // CountFreePlacesNumericUpDown
            // 
            this.CountFreePlacesNumericUpDown.Location = new System.Drawing.Point(443, 109);
            this.CountFreePlacesNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.CountFreePlacesNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.CountFreePlacesNumericUpDown.Name = "CountFreePlacesNumericUpDown";
            this.CountFreePlacesNumericUpDown.Size = new System.Drawing.Size(135, 20);
            this.CountFreePlacesNumericUpDown.TabIndex = 37;
            this.CountFreePlacesNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // AddTableRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 234);
            this.Controls.Add(this.CountFreePlacesNumericUpDown);
            this.Controls.Add(this.PriceNumericUpDown);
            this.Controls.Add(this.DateEndLabel);
            this.Controls.Add(this.DataEndPicker);
            this.Controls.Add(this.FreePlacesLabel);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DateStartLabel);
            this.Controls.Add(this.DateStartPicker);
            this.Controls.Add(this.CityEndTextBox);
            this.Controls.Add(this.CityStartTextBox);
            this.Controls.Add(this.NameRouteComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TravelDateTimePicker);
            this.Controls.Add(this.TimeTravelLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.CityEndLabel);
            this.Controls.Add(this.CityStartLabel);
            this.Controls.Add(this.NameRouteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddTableRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление рейса";
            this.Load += new System.EventHandler(this.AddTableRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CountFreePlacesNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox NameRouteComboBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.DateTimePicker TravelDateTimePicker;
        private System.Windows.Forms.Label TimeTravelLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label CityEndLabel;
        private System.Windows.Forms.Label CityStartLabel;
        private System.Windows.Forms.Label NameRouteLabel;
        private System.Windows.Forms.TextBox CityStartTextBox;
        private System.Windows.Forms.TextBox CityEndTextBox;
        private System.Windows.Forms.DateTimePicker DateStartPicker;
        private System.Windows.Forms.Label DateStartLabel;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label FreePlacesLabel;
        private System.Windows.Forms.Label DateEndLabel;
        private System.Windows.Forms.DateTimePicker DataEndPicker;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.NumericUpDown CountFreePlacesNumericUpDown;
    }
}