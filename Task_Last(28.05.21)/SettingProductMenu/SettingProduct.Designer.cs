namespace DateBase_V._2
{
    partial class SettingProduct
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
            this.ChangeProductButton = new System.Windows.Forms.Button();
            this.DeleteProductButton = new System.Windows.Forms.Button();
            this.ProductGridViewer = new System.Windows.Forms.DataGridView();
            this.AddProductButton = new System.Windows.Forms.Button();
            this.NameProduct = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Male_Female = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // ChangeProductButton
            // 
            this.ChangeProductButton.Location = new System.Drawing.Point(4, 264);
            this.ChangeProductButton.Name = "ChangeProductButton";
            this.ChangeProductButton.Size = new System.Drawing.Size(156, 69);
            this.ChangeProductButton.TabIndex = 7;
            this.ChangeProductButton.Text = "Изменить продукт";
            this.ChangeProductButton.UseVisualStyleBackColor = true;
            this.ChangeProductButton.Click += new System.EventHandler(this.ChangeProductButton_Click);
            // 
            // DeleteProductButton
            // 
            this.DeleteProductButton.Location = new System.Drawing.Point(4, 189);
            this.DeleteProductButton.Name = "DeleteProductButton";
            this.DeleteProductButton.Size = new System.Drawing.Size(156, 69);
            this.DeleteProductButton.TabIndex = 6;
            this.DeleteProductButton.Text = "Удалить продукт";
            this.DeleteProductButton.UseVisualStyleBackColor = true;
            this.DeleteProductButton.Click += new System.EventHandler(this.DeleteProductButton_Click);
            // 
            // ProductGridViewer
            // 
            this.ProductGridViewer.AllowUserToAddRows = false;
            this.ProductGridViewer.AllowUserToDeleteRows = false;
            this.ProductGridViewer.AllowUserToResizeColumns = false;
            this.ProductGridViewer.AllowUserToResizeRows = false;
            this.ProductGridViewer.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGridViewer.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ProductGridViewer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProductGridViewer.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NameProduct,
            this.Male_Female,
            this.Price});
            this.ProductGridViewer.Location = new System.Drawing.Point(166, 12);
            this.ProductGridViewer.MultiSelect = false;
            this.ProductGridViewer.Name = "ProductGridViewer";
            this.ProductGridViewer.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ProductGridViewer.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ProductGridViewer.RowHeadersVisible = false;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductGridViewer.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ProductGridViewer.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ProductGridViewer.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ProductGridViewer.Size = new System.Drawing.Size(871, 434);
            this.ProductGridViewer.TabIndex = 5;
            this.ProductGridViewer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ProductGridViewer_CellClick);
            // 
            // AddProductButton
            // 
            this.AddProductButton.Location = new System.Drawing.Point(4, 114);
            this.AddProductButton.Name = "AddProductButton";
            this.AddProductButton.Size = new System.Drawing.Size(156, 69);
            this.AddProductButton.TabIndex = 4;
            this.AddProductButton.Text = "Добавить продукт";
            this.AddProductButton.UseVisualStyleBackColor = true;
            this.AddProductButton.Click += new System.EventHandler(this.AddProductButton_Click);
            // 
            // NameProduct
            // 
            this.NameProduct.HeaderText = "Название:";
            this.NameProduct.Name = "NameProduct";
            this.NameProduct.ReadOnly = true;
            this.NameProduct.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.NameProduct.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Male_Female
            // 
            this.Male_Female.HeaderText = "Пол:";
            this.Male_Female.Name = "Male_Female";
            this.Male_Female.ReadOnly = true;
            this.Male_Female.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Male_Female.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Price
            // 
            this.Price.HeaderText = "Цена:";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            this.Price.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Price.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // SettingProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 462);
            this.Controls.Add(this.ChangeProductButton);
            this.Controls.Add(this.DeleteProductButton);
            this.Controls.Add(this.ProductGridViewer);
            this.Controls.Add(this.AddProductButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "SettingProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки товара";
            this.Load += new System.EventHandler(this.SettingProduct_Load);
            this.Shown += new System.EventHandler(this.SettingProduct_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.ProductGridViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ChangeProductButton;
        private System.Windows.Forms.Button DeleteProductButton;
        private System.Windows.Forms.DataGridView ProductGridViewer;
        private System.Windows.Forms.Button AddProductButton;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameProduct;
        private System.Windows.Forms.DataGridViewTextBoxColumn Male_Female;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
    }
}