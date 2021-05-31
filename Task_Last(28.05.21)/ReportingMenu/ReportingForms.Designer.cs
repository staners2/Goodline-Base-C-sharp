namespace DateBase_V._2
{
    partial class ReportingForms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GridViewer = new System.Windows.Forms.DataGridView();
            this.ProductIsNotDemandButton = new System.Windows.Forms.Button();
            this.BestSellingButton = new System.Windows.Forms.Button();
            this.PriceOrderButton = new System.Windows.Forms.Button();
            this.NotSellingProductButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.GridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // GridViewer
            // 
            this.GridViewer.AllowUserToAddRows = false;
            this.GridViewer.AllowUserToDeleteRows = false;
            this.GridViewer.AllowUserToResizeColumns = false;
            this.GridViewer.AllowUserToResizeRows = false;
            this.GridViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.GridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridViewer.Enabled = false;
            this.GridViewer.Location = new System.Drawing.Point(189, 12);
            this.GridViewer.MultiSelect = false;
            this.GridViewer.Name = "GridViewer";
            this.GridViewer.ReadOnly = true;
            this.GridViewer.RowHeadersVisible = false;
            this.GridViewer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.GridViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.GridViewer.Size = new System.Drawing.Size(999, 533);
            this.GridViewer.TabIndex = 2;
            // 
            // ProductIsNotDemandButton
            // 
            this.ProductIsNotDemandButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductIsNotDemandButton.Location = new System.Drawing.Point(12, 27);
            this.ProductIsNotDemandButton.Name = "ProductIsNotDemandButton";
            this.ProductIsNotDemandButton.Size = new System.Drawing.Size(154, 70);
            this.ProductIsNotDemandButton.TabIndex = 9;
            this.ProductIsNotDemandButton.Text = "Товар не покупавшийся более 7 дней";
            this.ProductIsNotDemandButton.UseVisualStyleBackColor = true;
            this.ProductIsNotDemandButton.Click += new System.EventHandler(this.ProductIsNotDemandButton_Click);
            // 
            // BestSellingButton
            // 
            this.BestSellingButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BestSellingButton.Location = new System.Drawing.Point(12, 103);
            this.BestSellingButton.Name = "BestSellingButton";
            this.BestSellingButton.Size = new System.Drawing.Size(154, 70);
            this.BestSellingButton.TabIndex = 10;
            this.BestSellingButton.Text = "Наиболее продаваемый товар";
            this.BestSellingButton.UseVisualStyleBackColor = true;
            this.BestSellingButton.Click += new System.EventHandler(this.BestSellingButton_Click);
            // 
            // PriceOrderButton
            // 
            this.PriceOrderButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceOrderButton.Location = new System.Drawing.Point(12, 212);
            this.PriceOrderButton.Name = "PriceOrderButton";
            this.PriceOrderButton.Size = new System.Drawing.Size(154, 70);
            this.PriceOrderButton.TabIndex = 11;
            this.PriceOrderButton.Text = "Сумма всех покупок клиентов";
            this.PriceOrderButton.UseVisualStyleBackColor = true;
            this.PriceOrderButton.Click += new System.EventHandler(this.PriceOrderButton_Click);
            // 
            // NotSellingProductButton
            // 
            this.NotSellingProductButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotSellingProductButton.Location = new System.Drawing.Point(12, 288);
            this.NotSellingProductButton.Name = "NotSellingProductButton";
            this.NotSellingProductButton.Size = new System.Drawing.Size(154, 70);
            this.NotSellingProductButton.TabIndex = 20;
            this.NotSellingProductButton.Text = "Не купленный ни разу товар";
            this.NotSellingProductButton.UseVisualStyleBackColor = true;
            this.NotSellingProductButton.Click += new System.EventHandler(this.NotSellingProductButton_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(8, 399);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 60);
            this.label1.TabIndex = 21;
            this.label1.Text = "Поиск товара по дате продажи";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(6, 462);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(171, 35);
            this.dateTimePicker1.TabIndex = 46;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.Location = new System.Drawing.Point(13, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(157, 26);
            this.checkBox1.TabIndex = 47;
            this.checkBox1.Text = "По возрастанию";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // ReportingForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 569);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NotSellingProductButton);
            this.Controls.Add(this.PriceOrderButton);
            this.Controls.Add(this.BestSellingButton);
            this.Controls.Add(this.ProductIsNotDemandButton);
            this.Controls.Add(this.GridViewer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ReportingForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчетность";
            ((System.ComponentModel.ISupportInitialize)(this.GridViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView GridViewer;
        private System.Windows.Forms.Button ProductIsNotDemandButton;
        private System.Windows.Forms.Button BestSellingButton;
        private System.Windows.Forms.Button PriceOrderButton;
        private System.Windows.Forms.Button NotSellingProductButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}