namespace DateBase_V._2
{
    partial class SettingClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ChangeClientButton = new System.Windows.Forms.Button();
            this.DeleteClientButton = new System.Windows.Forms.Button();
            this.ClientGridViewer = new System.Windows.Forms.DataGridView();
            this.NameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SurnameClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatronymicClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddClientButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeClientButton
            // 
            this.ChangeClientButton.Location = new System.Drawing.Point(16, 221);
            this.ChangeClientButton.Name = "ChangeClientButton";
            this.ChangeClientButton.Size = new System.Drawing.Size(156, 69);
            this.ChangeClientButton.TabIndex = 12;
            this.ChangeClientButton.Text = "Изменить клиента";
            this.ChangeClientButton.UseVisualStyleBackColor = true;
            this.ChangeClientButton.Click += new System.EventHandler(this.ChangeClientButton_Click);
            // 
            // DeleteClientButton
            // 
            this.DeleteClientButton.Location = new System.Drawing.Point(16, 146);
            this.DeleteClientButton.Name = "DeleteClientButton";
            this.DeleteClientButton.Size = new System.Drawing.Size(156, 69);
            this.DeleteClientButton.TabIndex = 11;
            this.DeleteClientButton.Text = "Удалить клиента";
            this.DeleteClientButton.UseVisualStyleBackColor = true;
            this.DeleteClientButton.Click += new System.EventHandler(this.DeleteClientButton_Click);
            // 
            // ClientGridViewer
            // 
            this.ClientGridViewer.AllowUserToAddRows = false;
            this.ClientGridViewer.AllowUserToDeleteRows = false;
            this.ClientGridViewer.AllowUserToResizeColumns = false;
            this.ClientGridViewer.AllowUserToResizeRows = false;
            this.ClientGridViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ClientGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientGridViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameClient,
            this.SurnameClient,
            this.PatronymicClient,
            this.NumberClient});
            this.ClientGridViewer.Location = new System.Drawing.Point(178, 12);
            this.ClientGridViewer.MultiSelect = false;
            this.ClientGridViewer.Name = "ClientGridViewer";
            this.ClientGridViewer.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ClientGridViewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ClientGridViewer.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientGridViewer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ClientGridViewer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ClientGridViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ClientGridViewer.Size = new System.Drawing.Size(871, 434);
            this.ClientGridViewer.TabIndex = 10;
            this.ClientGridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientGridViewer_CellClick);
            // 
            // NameClient
            // 
            this.NameClient.HeaderText = "Имя";
            this.NameClient.Name = "NameClient";
            this.NameClient.ReadOnly = true;
            this.NameClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SurnameClient
            // 
            this.SurnameClient.HeaderText = "Фамилия";
            this.SurnameClient.Name = "SurnameClient";
            this.SurnameClient.ReadOnly = true;
            this.SurnameClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.SurnameClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PatronymicClient
            // 
            this.PatronymicClient.HeaderText = "Отчество";
            this.PatronymicClient.Name = "PatronymicClient";
            this.PatronymicClient.ReadOnly = true;
            this.PatronymicClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.PatronymicClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // NumberClient
            // 
            this.NumberClient.HeaderText = "Номер телефона";
            this.NumberClient.Name = "NumberClient";
            this.NumberClient.ReadOnly = true;
            this.NumberClient.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NumberClient.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddClientButton
            // 
            this.AddClientButton.Location = new System.Drawing.Point(12, 385);
            this.AddClientButton.Name = "AddClientButton";
            this.AddClientButton.Size = new System.Drawing.Size(156, 69);
            this.AddClientButton.TabIndex = 9;
            this.AddClientButton.Text = "Добавить клиента";
            this.AddClientButton.UseVisualStyleBackColor = true;
            this.AddClientButton.Visible = false;
            this.AddClientButton.Click += new System.EventHandler(this.AddClientButton_Click);
            // 
            // SettingClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 466);
            this.Controls.Add(this.ChangeClientButton);
            this.Controls.Add(this.DeleteClientButton);
            this.Controls.Add(this.ClientGridViewer);
            this.Controls.Add(this.AddClientButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingClient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки информации о клиенте";
            this.Load += new System.EventHandler(this.SettingClient_Load);
            this.Shown += new System.EventHandler(this.SettingClient_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ClientGridViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button ChangeClientButton;
        private System.Windows.Forms.Button DeleteClientButton;
        private System.Windows.Forms.DataGridView ClientGridViewer;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn SurnameClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatronymicClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberClient;
        private System.Windows.Forms.Button AddClientButton;
    }
}