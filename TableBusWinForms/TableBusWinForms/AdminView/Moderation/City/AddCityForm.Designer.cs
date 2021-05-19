
namespace TableBusWinForms.AdminView.Moderation.City
{
    partial class AddCityForm
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
            this.NameCityTextBox = new System.Windows.Forms.TextBox();
            this.NameCityLabel = new System.Windows.Forms.Label();
            this.AddButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameCityTextBox
            // 
            this.NameCityTextBox.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCityTextBox.Location = new System.Drawing.Point(151, 9);
            this.NameCityTextBox.Name = "NameCityTextBox";
            this.NameCityTextBox.Size = new System.Drawing.Size(135, 26);
            this.NameCityTextBox.TabIndex = 0;
            // 
            // NameCityLabel
            // 
            this.NameCityLabel.AutoSize = true;
            this.NameCityLabel.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameCityLabel.Location = new System.Drawing.Point(12, 9);
            this.NameCityLabel.Name = "NameCityLabel";
            this.NameCityLabel.Size = new System.Drawing.Size(133, 22);
            this.NameCityLabel.TabIndex = 1;
            this.NameCityLabel.Text = "Название города";
            // 
            // AddButton
            // 
            this.AddButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddButton.Location = new System.Drawing.Point(15, 41);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(271, 32);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddCityButtonClick);
            // 
            // AddCityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 81);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.NameCityLabel);
            this.Controls.Add(this.NameCityTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "AddCityForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление города";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameCityLabel;
        public System.Windows.Forms.TextBox NameCityTextBox;
        public System.Windows.Forms.Button AddButton;
    }
}