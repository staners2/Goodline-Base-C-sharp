
namespace TableBusWinForms.AdminView.Moderation.Route
{
    partial class AddRouteForm
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
            this.NameRouteLabel = new System.Windows.Forms.Label();
            this.NameRouteTextBox = new System.Windows.Forms.TextBox();
            this.CityStartLabel = new System.Windows.Forms.Label();
            this.CityEndLabel = new System.Windows.Forms.Label();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.TimeTravelLabel = new System.Windows.Forms.Label();
            this.TravelDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.AddButton = new System.Windows.Forms.Button();
            this.CityStartComboBox = new System.Windows.Forms.ComboBox();
            this.CityEndComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // NameRouteLabel
            // 
            this.NameRouteLabel.AutoSize = true;
            this.NameRouteLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRouteLabel.Location = new System.Drawing.Point(9, 16);
            this.NameRouteLabel.Name = "NameRouteLabel";
            this.NameRouteLabel.Size = new System.Drawing.Size(154, 22);
            this.NameRouteLabel.TabIndex = 3;
            this.NameRouteLabel.Text = "Название маршрута";
            // 
            // NameRouteTextBox
            // 
            this.NameRouteTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRouteTextBox.Location = new System.Drawing.Point(169, 12);
            this.NameRouteTextBox.Name = "NameRouteTextBox";
            this.NameRouteTextBox.Size = new System.Drawing.Size(135, 26);
            this.NameRouteTextBox.TabIndex = 2;
            // 
            // CityStartLabel
            // 
            this.CityStartLabel.AutoSize = true;
            this.CityStartLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityStartLabel.Location = new System.Drawing.Point(42, 48);
            this.CityStartLabel.Name = "CityStartLabel";
            this.CityStartLabel.Size = new System.Drawing.Size(121, 22);
            this.CityStartLabel.TabIndex = 5;
            this.CityStartLabel.Text = "Откуда (город)";
            // 
            // CityEndLabel
            // 
            this.CityEndLabel.AutoSize = true;
            this.CityEndLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityEndLabel.Location = new System.Drawing.Point(58, 80);
            this.CityEndLabel.Name = "CityEndLabel";
            this.CityEndLabel.Size = new System.Drawing.Size(105, 22);
            this.CityEndLabel.TabIndex = 7;
            this.CityEndLabel.Text = "Куда (город)";
            // 
            // DistanceLabel
            // 
            this.DistanceLabel.AutoSize = true;
            this.DistanceLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceLabel.Location = new System.Drawing.Point(70, 118);
            this.DistanceLabel.Name = "DistanceLabel";
            this.DistanceLabel.Size = new System.Drawing.Size(93, 22);
            this.DistanceLabel.TabIndex = 8;
            this.DistanceLabel.Text = "Расстояние";
            // 
            // DistanceTextBox
            // 
            this.DistanceTextBox.Enabled = false;
            this.DistanceTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceTextBox.Location = new System.Drawing.Point(169, 114);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(135, 26);
            this.DistanceTextBox.TabIndex = 9;
            // 
            // TimeTravelLabel
            // 
            this.TimeTravelLabel.AutoSize = true;
            this.TimeTravelLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TimeTravelLabel.Location = new System.Drawing.Point(57, 150);
            this.TimeTravelLabel.Name = "TimeTravelLabel";
            this.TimeTravelLabel.Size = new System.Drawing.Size(106, 22);
            this.TimeTravelLabel.TabIndex = 10;
            this.TimeTravelLabel.Text = "Время в пути";
            // 
            // TravelDateTimePicker
            // 
            this.TravelDateTimePicker.CustomFormat = "HH:mm:ss";
            this.TravelDateTimePicker.Enabled = false;
            this.TravelDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.TravelDateTimePicker.Location = new System.Drawing.Point(169, 152);
            this.TravelDateTimePicker.Name = "TravelDateTimePicker";
            this.TravelDateTimePicker.ShowUpDown = true;
            this.TravelDateTimePicker.Size = new System.Drawing.Size(135, 20);
            this.TravelDateTimePicker.TabIndex = 12;
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(13, 189);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(291, 32);
            this.AddButton.TabIndex = 13;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddRouteButtonClick);
            // 
            // CityStartComboBox
            // 
            this.CityStartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityStartComboBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityStartComboBox.FormattingEnabled = true;
            this.CityStartComboBox.Location = new System.Drawing.Point(169, 51);
            this.CityStartComboBox.MaxDropDownItems = 5;
            this.CityStartComboBox.Name = "CityStartComboBox";
            this.CityStartComboBox.Size = new System.Drawing.Size(135, 26);
            this.CityStartComboBox.TabIndex = 14;
            this.CityStartComboBox.SelectionChangeCommitted += new System.EventHandler(this.CityComboBox_SelectionChangeCommitted);
            // 
            // CityEndComboBox
            // 
            this.CityEndComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityEndComboBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityEndComboBox.FormattingEnabled = true;
            this.CityEndComboBox.Location = new System.Drawing.Point(169, 83);
            this.CityEndComboBox.MaxDropDownItems = 5;
            this.CityEndComboBox.Name = "CityEndComboBox";
            this.CityEndComboBox.Size = new System.Drawing.Size(135, 26);
            this.CityEndComboBox.TabIndex = 15;
            this.CityEndComboBox.SelectionChangeCommitted += new System.EventHandler(this.CityComboBox_SelectionChangeCommitted);
            // 
            // AddRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 234);
            this.Controls.Add(this.CityEndComboBox);
            this.Controls.Add(this.CityStartComboBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.TravelDateTimePicker);
            this.Controls.Add(this.TimeTravelLabel);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.CityEndLabel);
            this.Controls.Add(this.CityStartLabel);
            this.Controls.Add(this.NameRouteLabel);
            this.Controls.Add(this.NameRouteTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddRouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление маршрута";
            this.Load += new System.EventHandler(this.AddRouteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label NameRouteLabel;
        private System.Windows.Forms.TextBox NameRouteTextBox;
        private System.Windows.Forms.Label CityStartLabel;
        private System.Windows.Forms.Label CityEndLabel;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Label TimeTravelLabel;
        private System.Windows.Forms.DateTimePicker TravelDateTimePicker;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.ComboBox CityStartComboBox;
        private System.Windows.Forms.ComboBox CityEndComboBox;
    }
}