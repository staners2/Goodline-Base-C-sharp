namespace DateBase_V._2
{
    partial class OrderForms
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.AddOrder = new System.Windows.Forms.Button();
            this.OrderGridViewer = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ChangeOrderButton = new System.Windows.Forms.Button();
            this.DeleteOrderButton = new System.Windows.Forms.Button();
            this.SettingProductButton = new System.Windows.Forms.Button();
            this.SettingClientButton = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SortDateButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ReportingButton = new System.Windows.Forms.Button();
            this.OpenLogsButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // AddOrder
            // 
            this.AddOrder.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddOrder.Location = new System.Drawing.Point(12, 9);
            this.AddOrder.Name = "AddOrder";
            this.AddOrder.Size = new System.Drawing.Size(111, 49);
            this.AddOrder.TabIndex = 0;
            this.AddOrder.Text = "Добавить";
            this.AddOrder.UseVisualStyleBackColor = true;
            this.AddOrder.Click += new System.EventHandler(this.AddOrder_Click);
            // 
            // OrderGridViewer
            // 
            this.OrderGridViewer.AllowUserToAddRows = false;
            this.OrderGridViewer.AllowUserToDeleteRows = false;
            this.OrderGridViewer.AllowUserToResizeColumns = false;
            this.OrderGridViewer.AllowUserToResizeRows = false;
            this.OrderGridViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OrderGridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OrderGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrderGridViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column4,
            this.Column3,
            this.Column5,
            this.Column1});
            this.OrderGridViewer.Location = new System.Drawing.Point(129, 7);
            this.OrderGridViewer.MultiSelect = false;
            this.OrderGridViewer.Name = "OrderGridViewer";
            this.OrderGridViewer.ReadOnly = true;
            this.OrderGridViewer.RowHeadersVisible = false;
            this.OrderGridViewer.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.OrderGridViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.OrderGridViewer.Size = new System.Drawing.Size(1200, 533);
            this.OrderGridViewer.TabIndex = 1;
            this.OrderGridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrderGridViewer_CellClick);
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Имя";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Фамилия";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Отчество";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Номер телефона";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column9.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата заказа";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Стоимость заказа";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Готовность заказа";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Корзина покупок";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // ChangeOrderButton
            // 
            this.ChangeOrderButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChangeOrderButton.Location = new System.Drawing.Point(12, 64);
            this.ChangeOrderButton.Name = "ChangeOrderButton";
            this.ChangeOrderButton.Size = new System.Drawing.Size(111, 47);
            this.ChangeOrderButton.TabIndex = 2;
            this.ChangeOrderButton.Text = "Изменить";
            this.ChangeOrderButton.UseVisualStyleBackColor = true;
            this.ChangeOrderButton.Click += new System.EventHandler(this.ChangeOrderButton_Click);
            // 
            // DeleteOrderButton
            // 
            this.DeleteOrderButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteOrderButton.Location = new System.Drawing.Point(12, 117);
            this.DeleteOrderButton.Name = "DeleteOrderButton";
            this.DeleteOrderButton.Size = new System.Drawing.Size(111, 44);
            this.DeleteOrderButton.TabIndex = 3;
            this.DeleteOrderButton.Text = "Удалить";
            this.DeleteOrderButton.UseVisualStyleBackColor = true;
            this.DeleteOrderButton.Click += new System.EventHandler(this.DeleteOrderButton_Click);
            // 
            // SettingProductButton
            // 
            this.SettingProductButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingProductButton.Location = new System.Drawing.Point(12, 494);
            this.SettingProductButton.Name = "SettingProductButton";
            this.SettingProductButton.Size = new System.Drawing.Size(111, 46);
            this.SettingProductButton.TabIndex = 4;
            this.SettingProductButton.Text = "Настройки продукта";
            this.SettingProductButton.UseVisualStyleBackColor = true;
            this.SettingProductButton.Click += new System.EventHandler(this.SettingProductButton_Click);
            // 
            // SettingClientButton
            // 
            this.SettingClientButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SettingClientButton.Location = new System.Drawing.Point(12, 443);
            this.SettingClientButton.Name = "SettingClientButton";
            this.SettingClientButton.Size = new System.Drawing.Size(111, 45);
            this.SettingClientButton.TabIndex = 5;
            this.SettingClientButton.Text = "Настройки клиента";
            this.SettingClientButton.UseVisualStyleBackColor = true;
            this.SettingClientButton.Click += new System.EventHandler(this.SettingClientButton_Click);
            // 
            // SortDateButton
            // 
            this.SortDateButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SortDateButton.Location = new System.Drawing.Point(12, 167);
            this.SortDateButton.Name = "SortDateButton";
            this.SortDateButton.Size = new System.Drawing.Size(111, 49);
            this.SortDateButton.TabIndex = 6;
            this.SortDateButton.Text = "Сортировать по дате";
            this.SortDateButton.UseVisualStyleBackColor = true;
            this.SortDateButton.Click += new System.EventHandler(this.SortDateButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(49, 219);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "OFF";
            // 
            // ReportingButton
            // 
            this.ReportingButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportingButton.Location = new System.Drawing.Point(12, 392);
            this.ReportingButton.Name = "ReportingButton";
            this.ReportingButton.Size = new System.Drawing.Size(111, 45);
            this.ReportingButton.TabIndex = 8;
            this.ReportingButton.Text = "Отчетность";
            this.ReportingButton.UseVisualStyleBackColor = true;
            this.ReportingButton.Click += new System.EventHandler(this.ReportingButton_Click);
            // 
            // OpenLogsButton
            // 
            this.OpenLogsButton.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenLogsButton.Location = new System.Drawing.Point(12, 341);
            this.OpenLogsButton.Name = "OpenLogsButton";
            this.OpenLogsButton.Size = new System.Drawing.Size(111, 45);
            this.OpenLogsButton.TabIndex = 9;
            this.OpenLogsButton.Text = "Open Logs";
            this.OpenLogsButton.UseVisualStyleBackColor = true;
            this.OpenLogsButton.Click += new System.EventHandler(this.OpenLogsButton_Click);
            // 
            // OrderForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1335, 553);
            this.Controls.Add(this.OpenLogsButton);
            this.Controls.Add(this.ReportingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SortDateButton);
            this.Controls.Add(this.SettingClientButton);
            this.Controls.Add(this.SettingProductButton);
            this.Controls.Add(this.DeleteOrderButton);
            this.Controls.Add(this.ChangeOrderButton);
            this.Controls.Add(this.OrderGridViewer);
            this.Controls.Add(this.AddOrder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OrderForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Заказ товара";
            this.Load += new System.EventHandler(this.OrderForms_Load);
            this.Shown += new System.EventHandler(this.OrderForms_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.OrderGridViewer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddOrder;
        private System.Windows.Forms.DataGridView OrderGridViewer;
        private System.Windows.Forms.Button ChangeOrderButton;
        private System.Windows.Forms.Button DeleteOrderButton;
        private System.Windows.Forms.Button SettingProductButton;
        private System.Windows.Forms.Button SettingClientButton;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button SortDateButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewButtonColumn Column1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button ReportingButton;
        private System.Windows.Forms.Button OpenLogsButton;
    }
}

