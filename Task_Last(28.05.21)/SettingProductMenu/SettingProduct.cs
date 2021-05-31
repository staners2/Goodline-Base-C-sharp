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
    public partial class SettingProduct : Form
    {
        public SettingProduct()
        {
            InitializeComponent();
        }

        public SqlConnection connect;
        public int IdProduct;
        public List<int> ListIdProduct = new List<int> { };
        public int IdRows;


        private void AddProductButton_Click(object sender, EventArgs e)
        {
            AddProductForms Forms = new AddProductForms(ProductGridViewer);
            Forms.connect = this.connect;
            Forms.ShowDialog();
        }

        private void ChangeProductButton_Click(object sender, EventArgs e)
        {
            if (ProductGridViewer.SelectedRows.Count == 1)
            {
                string Name = Convert.ToString(ProductGridViewer.Rows[IdRows].Cells[0].Value);
                string Male_Female = Convert.ToString(ProductGridViewer.Rows[IdRows].Cells[1].Value);
                string Price = Convert.ToString(ProductGridViewer.Rows[IdRows].Cells[2].Value).Replace(",",".");

                ChangeProductForms Forms = new ChangeProductForms(ProductGridViewer, IdProduct,Name,Male_Female,Price);
                Forms.connect = this.connect;
                Forms.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }

        private void DeleteProductButton_Click(object sender, EventArgs e)
        { 
            string message = "Вы точно хотите удалить запись?";
            string caption = "Проверка";

            if (ProductGridViewer.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Product_InsteadOf_Delete - TRIGGER
                    string UpdateQuery = $"DELETE FROM [PRODUCT] WHERE[id_product] = {IdProduct}";

                    ProductGridViewer.Rows.Remove(ProductGridViewer.Rows[IdRows]);

                    SqlCommand command = new SqlCommand(UpdateQuery, connect);

                    int Count = command.ExecuteNonQuery();
                    // MessageBox.Show($"Записей удалено: {Count}");
                    ProductGridViewer.ClearSelection();
                }
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
            
        }

        private void SettingProduct_Load(object sender, EventArgs e)
        {
            ProductGridViewer.Rows.Clear();
            string query = "SELECT * FROM [dbo].[PRODUCT] WHERE [IsDelete] = 0";
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ProductGridViewer.Rows.Add(reader[1], reader[2], Math.Round(Convert.ToDouble(reader[3]), 2));
            }

            reader.Close();
        }

        public List<int> UpdateProductListId()
        {
            ListIdProduct.Clear();
            string SelectQuery = "SELECT * FROM [dbo].[PRODUCT] WHERE [IsDelete] = 0";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListIdProduct.Add(Convert.ToInt32(reader[0]));
            }

            reader.Close();
            return (ListIdProduct);
        }

        private void ProductGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateProductListId();
                IdRows = Convert.ToInt32(e.RowIndex);
                IdProduct = ListIdProduct[IdRows];
            }
        }

        private void SettingProduct_Shown(object sender, EventArgs e)
        {
            ProductGridViewer.ClearSelection();
        }
    }
}
