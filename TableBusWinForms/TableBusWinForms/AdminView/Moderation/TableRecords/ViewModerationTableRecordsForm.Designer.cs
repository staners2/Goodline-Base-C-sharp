﻿
namespace TableBusWinForms.AdminView.Moderation.TableRecords
{
    partial class ViewModerationTableRecordsForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.IdRecordTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCountPassenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdRecordTable,
            this.NameRoute,
            this.CityStart,
            this.CityEnd,
            this.DateTimeStart,
            this.CurrentCountPassenger,
            this.Price});
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 3);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(956, 426);
            this.dataGridView1.TabIndex = 8;
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
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(12, 435);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(956, 49);
            this.button1.TabIndex = 14;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ViewModerationTableRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(978, 492);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewModerationTableRecordsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Модерация расписания";
            this.Load += new System.EventHandler(this.ViewModerationTableRecordsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdRecordTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameRoute;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CityEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentCountPassenger;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.Button button1;
    }
}