using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryController;
using LibraryController.Models;

namespace TableBusWinForms.GeneralForm
{
    public partial class ViewPurchasedTicketsForm : Form
    {
        public void GenerateInterface()

        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridView = new System.Windows.Forms.DataGridView();
            this.IdRecordFlight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdTable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameRoute = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CityEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentCountPassenger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).BeginInit();
            this.SuspendLayout();
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
            this.IdRecordFlight,
            this.IdTable,
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
            this.DataGridView.Location = new System.Drawing.Point(3, 1);
            this.DataGridView.MultiSelect = false;
            this.DataGridView.Name = "DataGridView";
            this.DataGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGridView.Size = new System.Drawing.Size(1177, 543);
            this.DataGridView.TabIndex = 8;
            this.DataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellDoubleClick);
            // 
            // IdRecordFlight
            // 
            this.IdRecordFlight.HeaderText = "Id записи";
            this.IdRecordFlight.Name = "IdRecordFlight";
            this.IdRecordFlight.Visible = false;
            // 
            // IdTable
            // 
            this.IdTable.HeaderText = "Id рейса";
            this.IdTable.Name = "IdTable";
            this.IdTable.Visible = false;
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
            // ViewPurchasedTicketsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 549);
            this.Controls.Add(this.DataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ViewPurchasedTicketsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Купленные билеты";
            this.Load += new System.EventHandler(this.ViePurchasedTicketsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView)).EndInit();
            this.ResumeLayout(false);
        }
        public ViewPurchasedTicketsForm(int IdAccount)
        {
            InitializeComponent();
            GenerateInterface();
            this.IdAccount = IdAccount;
        }

        private int IdAccount { get; set; }

        private void UpdateGrid()
        {
            List<RecordFlight> pListTables = Controller.GetFlightRecords(IdAccount);
            DataGridView.Rows.Clear();
            foreach (var elem in pListTables)
            {
                DataGridView.Rows.Add($"{elem.Id}", $"{elem.Table.Id}", $"{elem.Table.Route.NameRoute}", $"{elem.Table.Route.City.CityName}",
                    $"{elem.Table.Route.City1.CityName}", $"{elem.Table.DateTimeStart}", $"{elem.Table.MaxCountPassenger - elem.Table.CurrentCountPassenger}",
                    $"{elem.Table.Price}");
            }
        }

        private void ViePurchasedTicketsForm_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        private void DataGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int IdRecordFlight = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["IdRecordFlight"].Value);
                int IdTable = Convert.ToInt32(DataGridView.Rows[e.RowIndex].Cells["IdTable"].Value);
                PurchasedTicket Form = new PurchasedTicket(IdTable, IdRecordFlight);
                Form.Closing += (s, ev) =>
                {
                    UpdateGrid();
                };
                Form.ShowDialog();
            }
        }
    }
}
