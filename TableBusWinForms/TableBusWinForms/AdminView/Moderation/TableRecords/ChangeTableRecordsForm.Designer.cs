
namespace TableBusWinForms.AdminView.Moderation.TableRecords
{
    partial class ChangeTableRecordsForm
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
            this.FreePlacesNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.PriceNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.DateEndLabel = new System.Windows.Forms.Label();
            this.DateEndPicker = new System.Windows.Forms.DateTimePicker();
            this.CountFreePlacesLabel = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.DataStartLabel = new System.Windows.Forms.Label();
            this.DateStartPicker = new System.Windows.Forms.DateTimePicker();
            this.CityEndTextBox = new System.Windows.Forms.TextBox();
            this.CityStartTextBox = new System.Windows.Forms.TextBox();
            this.NameRouteComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.TravelDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TravelTimeLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.CityEndLabel = new System.Windows.Forms.Label();
            this.CityStartLabel = new System.Windows.Forms.Label();
            this.NameRouteLabel = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.FreePlacesNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // FreePlacesNumericUpDown
            // 
            this.FreePlacesNumericUpDown.Location = new System.Drawing.Point(444, 108);
            this.FreePlacesNumericUpDown.Maximum = new decimal(new int[] {
            200,
            0,
            0,
            0});
            this.FreePlacesNumericUpDown.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.FreePlacesNumericUpDown.Name = "FreePlacesNumericUpDown";
            this.FreePlacesNumericUpDown.Size = new System.Drawing.Size(135, 20);
            this.FreePlacesNumericUpDown.TabIndex = 56;
            this.FreePlacesNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // PriceNumericUpDown
            // 
            this.PriceNumericUpDown.Location = new System.Drawing.Point(444, 72);
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
            this.PriceNumericUpDown.TabIndex = 55;
            this.PriceNumericUpDown.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // DateEndLabel
            // 
            this.DateEndLabel.AutoSize = true;
            this.DateEndLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DateEndLabel.Location = new System.Drawing.Point(319, 34);
            this.DateEndLabel.Name = "DateEndLabel";
            this.DateEndLabel.Size = new System.Drawing.Size(119, 22);
            this.DateEndLabel.TabIndex = 54;
            this.DateEndLabel.Text = "Дата прибытия";
            // 
            // DateEndPicker
            // 
            this.DateEndPicker.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.DateEndPicker.Enabled = false;
            this.DateEndPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateEndPicker.Location = new System.Drawing.Point(444, 36);
            this.DateEndPicker.Name = "DateEndPicker";
            this.DateEndPicker.Size = new System.Drawing.Size(135, 20);
            this.DateEndPicker.TabIndex = 53;
            // 
            // CountFreePlacesLabel
            // 
            this.CountFreePlacesLabel.AutoSize = true;
            this.CountFreePlacesLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountFreePlacesLabel.Location = new System.Drawing.Point(337, 106);
            this.CountFreePlacesLabel.Name = "CountFreePlacesLabel";
            this.CountFreePlacesLabel.Size = new System.Drawing.Size(101, 22);
            this.CountFreePlacesLabel.TabIndex = 52;
            this.CountFreePlacesLabel.Text = "Кол-во мест";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Enabled = false;
            this.DistanceTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceTextBox.Location = new System.Drawing.Point(169, 107);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(135, 26);
            this.DistanceTextBox.TabIndex = 51;
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PriceLabel.Location = new System.Drawing.Point(351, 70);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(87, 22);
            this.PriceLabel.TabIndex = 50;
            this.PriceLabel.Text = "Стоимость";
            // 
            // DataStartLabel
            // 
            this.DataStartLabel.AutoSize = true;
            this.DataStartLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataStartLabel.Location = new System.Drawing.Point(329, 8);
            this.DataStartLabel.Name = "DataStartLabel";
            this.DataStartLabel.Size = new System.Drawing.Size(109, 22);
            this.DataStartLabel.TabIndex = 49;
            this.DataStartLabel.Text = "Дата отбытия";
            // 
            // DateStartPicker
            // 
            this.DateStartPicker.CustomFormat = "yyyy.MM.dd HH:mm:ss";
            this.DateStartPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DateStartPicker.Location = new System.Drawing.Point(444, 10);
            this.DateStartPicker.Name = "DateStartPicker";
            this.DateStartPicker.Size = new System.Drawing.Size(135, 20);
            this.DateStartPicker.TabIndex = 48;
            this.DateStartPicker.ValueChanged += new System.EventHandler(this.DateStartPicker_ValueChanged);
            // 
            // CityEndTextBox
            // 
            this.CityEndTextBox.Enabled = false;
            this.CityEndTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityEndTextBox.Location = new System.Drawing.Point(169, 72);
            this.CityEndTextBox.Name = "CityEndTextBox";
            this.CityEndTextBox.Size = new System.Drawing.Size(135, 26);
            this.CityEndTextBox.TabIndex = 47;
            // 
            // CityStartTextBox
            // 
            this.CityStartTextBox.Enabled = false;
            this.CityStartTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityStartTextBox.Location = new System.Drawing.Point(169, 40);
            this.CityStartTextBox.Name = "CityStartTextBox";
            this.CityStartTextBox.Size = new System.Drawing.Size(135, 26);
            this.CityStartTextBox.TabIndex = 46;
            // 
            // NameRouteComboBox
            // 
            this.NameRouteComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.NameRouteComboBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRouteComboBox.FormattingEnabled = true;
            this.NameRouteComboBox.Location = new System.Drawing.Point(169, 8);
            this.NameRouteComboBox.MaxDropDownItems = 5;
            this.NameRouteComboBox.Name = "NameRouteComboBox";
            this.NameRouteComboBox.Size = new System.Drawing.Size(135, 26);
            this.NameRouteComboBox.TabIndex = 45;
            this.NameRouteComboBox.SelectionChangeCommitted += new System.EventHandler(this.RouteComboBox_SelectionChangeCommitted);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(13, 170);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(291, 51);
            this.ChangeButton.TabIndex = 44;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeButtonClick);
            // 
            // TravelDateTimePicker
            // 
            this.TravelDateTimePicker.CustomFormat = "HH:mm:ss";
            this.TravelDateTimePicker.Enabled = false;
            this.TravelDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TravelDateTimePicker.Location = new System.Drawing.Point(169, 144);
            this.TravelDateTimePicker.Name = "TravelDateTimePicker";
            this.TravelDateTimePicker.ShowUpDown = true;
            this.TravelDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.TravelDateTimePicker.TabIndex = 43;
            // 
            // TravelTimeLabel
            // 
            this.TravelTimeLabel.AutoSize = true;
            this.TravelTimeLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TravelTimeLabel.Location = new System.Drawing.Point(57, 142);
            this.TravelTimeLabel.Name = "TravelTimeLabel";
            this.TravelTimeLabel.Size = new System.Drawing.Size(106, 22);
            this.TravelTimeLabel.TabIndex = 42;
            this.TravelTimeLabel.Text = "Время в пути";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceLabel.Location = new System.Drawing.Point(70, 110);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(93, 22);
            this.DistanceLabel.TabIndex = 41;
            this.DistanceLabel.Text = "Расстояние";
            // 
            // CityEndLabel
            // 
            this.CityEndLabel.AutoSize = true;
            this.CityEndLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityEndLabel.Location = new System.Drawing.Point(58, 72);
            this.CityEndLabel.Name = "CityEndLabel";
            this.CityEndLabel.Size = new System.Drawing.Size(105, 22);
            this.CityEndLabel.TabIndex = 40;
            this.CityEndLabel.Text = "Куда (город)";
            // 
            // CityStartLabel
            // 
            this.CityStartLabel.AutoSize = true;
            this.CityStartLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityStartLabel.Location = new System.Drawing.Point(42, 40);
            this.CityStartLabel.Name = "CityStartLabel";
            this.CityStartLabel.Size = new System.Drawing.Size(121, 22);
            this.CityStartLabel.TabIndex = 39;
            this.CityStartLabel.Text = "Откуда (город)";
            // 
            // NameRouteLabel
            // 
            this.NameRouteLabel.AutoSize = true;
            this.NameRouteLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRouteLabel.Location = new System.Drawing.Point(9, 8);
            this.NameRouteLabel.Name = "NameRouteLabel";
            this.NameRouteLabel.Size = new System.Drawing.Size(154, 22);
            this.NameRouteLabel.TabIndex = 38;
            this.NameRouteLabel.Text = "Название маршрута";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(310, 170);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(269, 51);
            this.DeleteButton.TabIndex = 57;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButtonClick);
            // 
            // ChangeTableRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 228);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.FreePlacesNumericUpDown);
            this.Controls.Add(this.PriceNumericUpDown);
            this.Controls.Add(this.DateEndLabel);
            this.Controls.Add(this.DateEndPicker);
            this.Controls.Add(this.CountFreePlacesLabel);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.DataStartLabel);
            this.Controls.Add(this.DateStartPicker);
            this.Controls.Add(this.CityEndTextBox);
            this.Controls.Add(this.CityStartTextBox);
            this.Controls.Add(this.NameRouteComboBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.TravelDateTimePicker);
            this.Controls.Add(this.TravelTimeLabel);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.CityEndLabel);
            this.Controls.Add(this.CityStartLabel);
            this.Controls.Add(this.NameRouteLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeTableRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование информации о рейсе";
            this.Load += new System.EventHandler(this.ChangeTableRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FreePlacesNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PriceNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown FreePlacesNumericUpDown;
        private System.Windows.Forms.NumericUpDown PriceNumericUpDown;
        private System.Windows.Forms.Label DateEndLabel;
        private System.Windows.Forms.DateTimePicker DateEndPicker;
        private System.Windows.Forms.Label CountFreePlacesLabel;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label DataStartLabel;
        private System.Windows.Forms.DateTimePicker DateStartPicker;
        private System.Windows.Forms.TextBox CityEndTextBox;
        private System.Windows.Forms.TextBox CityStartTextBox;
        private System.Windows.Forms.ComboBox NameRouteComboBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.DateTimePicker TravelDateTimePicker;
        private System.Windows.Forms.Label TravelTimeLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label CityEndLabel;
        private System.Windows.Forms.Label CityStartLabel;
        private System.Windows.Forms.Label NameRouteLabel;
        private System.Windows.Forms.Button DeleteButton;
    }
}