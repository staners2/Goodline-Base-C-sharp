using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBase_V._2
{
    public partial class ProductListInfoForms : Form
    {
        public ProductListInfoForms(int ID, DataGridView NewOrderGridViewer, int NewIdRowsOrder)
        {
            InitializeComponent();
            this.IdOrder = ID;
            OrderGridViewer = NewOrderGridViewer;
            IdRowsOrder = NewIdRowsOrder;
        }

        public int IdOrder;
        public List<int> ListIdProductList = new List<int> { };
        public int IdRows;
        public int IdRowsOrder;
        public int IdProductList;
        public DataGridView OrderGridViewer;
        public SqlConnection connect;
        private void AddProductList_Click(object sender, EventArgs e)
        {
            AddProductListInfoForms Forms = new AddProductListInfoForms(ProductListGridViewer,IdOrder, IdProductList,OrderGridViewer,IdRowsOrder);
            Forms.connect = this.connect;
            Forms.ShowDialog();
        }

        public void UpdateProductListGridViewer()
        {
            
            ProductListGridViewer.Rows.Clear();
            string SelectQuery = $"SELECT [name], [male_female], [price], [amount] FROM [PRODUCT_LIST], [PRODUCT] WHERE [PRODUCT_LIST].IsDelete = 0 AND id_order = '{IdOrder}' AND [PRODUCT].id_product = [PRODUCT_LIST].id_product";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            double Price_Position = 0;

            while (reader.Read())   // Выводится
            {
                ProductListGridViewer.Rows.Add(reader[0], reader[1], Math.Round(Convert.ToDouble(reader[2]), 2), reader[3]);
                Price_Position = Price_Position + Convert.ToDouble(reader[2]) * Convert.ToDouble(reader[3]);
            }

            OrderGridViewer.Rows[IdRowsOrder].Cells[5].Value = String.Format("{0:C2}", Price_Position); // String.Format("{0:C2}", reader[0]);
            reader.Close();
        }

        private void ProductListInfoForms_Load(object sender, EventArgs e)
        {
            UpdateProductListGridViewer();
        }

        private void DeleteProductList_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить запись?";
            string caption = "Проверка";

            if (ProductListGridViewer.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string UpdateQuery = $"UPDATE [dbo].[PRODUCT_LIST] SET [IsDelete] = 1 WHERE [id_list] = {IdProductList}";

                    // ProductListGridViewer.Rows.Remove(ProductListGridViewer.Rows[IdRows]);
                    SqlCommand command = new SqlCommand(UpdateQuery, connect);

                    int Count = command.ExecuteNonQuery();
                    UpdateProductListGridViewer();
                    // MessageBox.Show($"Записей удалено: {Count}");
                    ProductListGridViewer.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }


        private void ChangeProductList_Click(object sender, EventArgs e)
        {
            if (ProductListGridViewer.SelectedRows.Count == 1)
            {
                string Name = Convert.ToString(ProductListGridViewer.Rows[IdRows].Cells[0].Value);
                string Male_Female = Convert.ToString(ProductListGridViewer.Rows[IdRows].Cells[1].Value);
                string Price = Convert.ToString(ProductListGridViewer.Rows[IdRows].Cells[2].Value);
                string Amount = Convert.ToString(ProductListGridViewer.Rows[IdRows].Cells[3].Value);

                ChangeProductListInfoForms Forms = new ChangeProductListInfoForms(ProductListGridViewer,IdOrder,IdProductList,Name,Male_Female,Price,Amount,OrderGridViewer,IdRowsOrder);
                Forms.connect = this.connect;
                Forms.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }

        private void ProductListInfoForms_Shown(object sender, EventArgs e)
        {
            ProductListGridViewer.ClearSelection();
        }

        private void ProductListGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateListProductListId();
                IdRows = Convert.ToInt32(e.RowIndex);
                IdProductList = ListIdProductList[IdRows];
            }
        }

        public List<int> UpdateListProductListId()
        {
            ListIdProductList.Clear();
            string SelectQuery = $"SELECT * FROM [dbo].[PRODUCT_LIST] WHERE [IsDelete] = 0 AND [id_order]={IdOrder}";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ListIdProductList.Add(Convert.ToInt32(reader[0]));
            }
            reader.Close();
            return (ListIdProductList);
        }

    }
}
