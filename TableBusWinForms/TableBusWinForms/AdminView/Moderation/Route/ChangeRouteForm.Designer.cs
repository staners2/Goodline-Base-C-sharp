
namespace TableBusWinForms.AdminView.Moderation.Route
{
    partial class ChangeRouteForm
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
            this.CityEndComboBox = new System.Windows.Forms.ComboBox();
            this.CityStartComboBox = new System.Windows.Forms.ComboBox();
            this.ChangeButton = new System.Windows.Forms.Button();
            this.TravelDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TimeTravelLabel = new System.Windows.Forms.Label();
            this.DistanceTextBox = new System.Windows.Forms.TextBox();
            this.DistanceLabel = new System.Windows.Forms.Label();
            this.CityEndLabel = new System.Windows.Forms.Label();
            this.CityStartLabel = new System.Windows.Forms.Label();
            this.NameRouteLabel = new System.Windows.Forms.Label();
            this.NameRouteTextBox = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CityEndComboBox
            // 
            this.CityEndComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityEndComboBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityEndComboBox.FormattingEnabled = true;
            this.CityEndComboBox.Location = new System.Drawing.Point(168, 76);
            this.CityEndComboBox.MaxDropDownItems = 5;
            this.CityEndComboBox.Name = "CityEndComboBox";
            this.CityEndComboBox.Size = new System.Drawing.Size(135, 26);
            this.CityEndComboBox.TabIndex = 26;
            this.CityEndComboBox.SelectionChangeCommitted += new System.EventHandler(this.CityComboBox_SelectionChangeCommitted);
            // 
            // CityStartComboBox
            // 
            this.CityStartComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CityStartComboBox.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CityStartComboBox.FormattingEnabled = true;
            this.CityStartComboBox.Location = new System.Drawing.Point(168, 44);
            this.CityStartComboBox.MaxDropDownItems = 5;
            this.CityStartComboBox.Name = "CityStartComboBox";
            this.CityStartComboBox.Size = new System.Drawing.Size(135, 26);
            this.CityStartComboBox.TabIndex = 25;
            this.CityStartComboBox.SelectionChangeCommitted += new System.EventHandler(this.CityComboBox_SelectionChangeCommitted);
            // 
            // ChangeButton
            // 
            this.ChangeButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeButton.Location = new System.Drawing.Point(12, 182);
            this.ChangeButton.Name = "ChangeButton";
            this.ChangeButton.Size = new System.Drawing.Size(150, 32);
            this.ChangeButton.TabIndex = 24;
            this.ChangeButton.Text = "Изменить";
            this.ChangeButton.UseVisualStyleBackColor = true;
            this.ChangeButton.Click += new System.EventHandler(this.ChangeRouteButtonClick);
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
            // DistanceTextBox
            // 
            this.DistanceTextBox.Enabled = false;
            this.DistanceTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DistanceTextBox.Location = new System.Drawing.Point(168, 107);
            this.DistanceTextBox.Name = "DistanceTextBox";
            this.DistanceTextBox.Size = new System.Drawing.Size(135, 26);
            this.DistanceTextBox.TabIndex = 21;
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
            // NameRouteTextBox
            // 
            this.NameRouteTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameRouteTextBox.Location = new System.Drawing.Point(168, 5);
            this.NameRouteTextBox.Name = "NameRouteTextBox";
            this.NameRouteTextBox.Size = new System.Drawing.Size(135, 26);
            this.NameRouteTextBox.TabIndex = 16;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteButton.Location = new System.Drawing.Point(168, 182);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(135, 32);
            this.DeleteButton.TabIndex = 27;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteRouteButtonClick);
            // 
            // ChangeRouteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 224);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CityEndComboBox);
            this.Controls.Add(this.CityStartComboBox);
            this.Controls.Add(this.ChangeButton);
            this.Controls.Add(this.TravelDateTimePicker);
            this.Controls.Add(this.TimeTravelLabel);
            this.Controls.Add(this.DistanceTextBox);
            this.Controls.Add(this.DistanceLabel);
            this.Controls.Add(this.CityEndLabel);
            this.Controls.Add(this.CityStartLabel);
            this.Controls.Add(this.NameRouteLabel);
            this.Controls.Add(this.NameRouteTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ChangeRouteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Изменение маршрута";
            this.Load += new System.EventHandler(this.ChangeRouteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CityEndComboBox;
        private System.Windows.Forms.ComboBox CityStartComboBox;
        private System.Windows.Forms.Button ChangeButton;
        private System.Windows.Forms.DateTimePicker TravelDateTimePicker;
        private System.Windows.Forms.Label TimeTravelLabel;
        private System.Windows.Forms.TextBox DistanceTextBox;
        private System.Windows.Forms.Label DistanceLabel;
        private System.Windows.Forms.Label CityEndLabel;
        private System.Windows.Forms.Label CityStartLabel;
        private System.Windows.Forms.Label NameRouteLabel;
        private System.Windows.Forms.TextBox NameRouteTextBox;
        private System.Windows.Forms.Button DeleteButton;
    }
}