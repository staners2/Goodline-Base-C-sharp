namespace DateBase_V._2
{
    partial class ProductListInfoForms
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
            this.ChangeProductList = new System.Windows.Forms.Button();
            this.DeleteProductList = new System.Windows.Forms.Button();
            this.ProductListGridViewer = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AddProductList = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeProductList
            // 
            this.ChangeProductList.Location = new System.Drawing.Point(16, 265);
            this.ChangeProductList.Name = "ChangeProductList";
            this.ChangeProductList.Size = new System.Drawing.Size(156, 69);
            this.ChangeProductList.TabIndex = 12;
            this.ChangeProductList.Text = "Изменить запись";
            this.ChangeProductList.UseVisualStyleBackColor = true;
            this.ChangeProductList.Click += new System.EventHandler(this.ChangeProductList_Click);
            // 
            // DeleteProductList
            // 
            this.DeleteProductList.Location = new System.Drawing.Point(16, 190);
            this.DeleteProductList.Name = "DeleteProductList";
            this.DeleteProductList.Size = new System.Drawing.Size(156, 69);
            this.DeleteProductList.TabIndex = 11;
            this.DeleteProductList.Text = "Удалить запись";
            this.DeleteProductList.UseVisualStyleBackColor = true;
            this.DeleteProductList.Click += new System.EventHandler(this.DeleteProductList_Click);
            // 
            // ProductListGridViewer
            // 
            this.ProductListGridViewer.AllowUserToAddRows = false;
            this.ProductListGridViewer.AllowUserToDeleteRows = false;
            this.ProductListGridViewer.AllowUserToResizeColumns = false;
            this.ProductListGridViewer.AllowUserToResizeRows = false;
            this.ProductListGridViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProductListGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductListGridViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.ProductListGridViewer.Location = new System.Drawing.Point(179, 12);
            this.ProductListGridViewer.MultiSelect = false;
            this.ProductListGridViewer.Name = "ProductListGridViewer";
            this.ProductListGridViewer.ReadOnly = true;
            this.ProductListGridViewer.RowHeadersVisible = false;
            this.ProductListGridViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductListGridViewer.Size = new System.Drawing.Size(871, 434);
            this.ProductListGridViewer.TabIndex = 10;
            this.ProductListGridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductListGridViewer_CellClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Название товара";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Пол";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Цена за 1 шт";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Кол-во ";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // AddProductList
            // 
            this.AddProductList.Location = new System.Drawing.Point(16, 115);
            this.AddProductList.Name = "AddProductList";
            this.AddProductList.Size = new System.Drawing.Size(156, 69);
            this.AddProductList.TabIndex = 9;
            this.AddProductList.Text = "Добавить запись";
            this.AddProductList.UseVisualStyleBackColor = true;
            this.AddProductList.Click += new System.EventHandler(this.AddProductList_Click);
            // 
            // ProductListInfoForms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 468);
            this.Controls.Add(this.ChangeProductList);
            this.Controls.Add(this.DeleteProductList);
            this.Controls.Add(this.ProductListGridViewer);
            this.Controls.Add(this.AddProductList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ProductListInfoForms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о заказе";
            this.Load += new System.EventHandler(this.ProductListInfoForms_Load);
            this.Shown += new System.EventHandler(this.ProductListInfoForms_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ProductListGridViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangeProductList;
        private System.Windows.Forms.Button DeleteProductList;
        private System.Windows.Forms.DataGridView ProductListGridViewer;
        private System.Windows.Forms.Button AddProductList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}