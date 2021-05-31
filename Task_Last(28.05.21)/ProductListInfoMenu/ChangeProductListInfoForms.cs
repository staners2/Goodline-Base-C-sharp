using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBase_V._2
{
    public partial class ChangeProductListInfoForms : Form
    {
        public ChangeProductListInfoForms(DataGridView NewProductListGridViewer, int NewIdOrder, int NewIdProductList, string Name, string Male_Female, string Price, string Amount,DataGridView NewOrderGridViewer,int NewIdRowsOrder)
        {
            InitializeComponent();
            ProductListGridViewer = NewProductListGridViewer;
            IdProductList = NewIdProductList;
            IdOrder = NewIdOrder;

            textBox1.Text = Price;
            textBox2.Text = Amount;
             
            comboBox1.Items.Add(Name);
            comboBox1.SelectedIndex = comboBox1.FindString(Name);
            comboBox2.Items.Add(Male_Female);
            comboBox2.SelectedIndex = comboBox1.FindString(Name);

            OrderGridViewer = NewOrderGridViewer;
            IdRowsOrder = NewIdRowsOrder;
        }

        public DataGridView OrderGridViewer;
        public int IdRowsOrder;

        public SqlConnection connect;
        public DataGridView ProductListGridViewer;
        public int IdProduct;
        public int IdOrder;
        public int IdProductList;

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            string SelectQuery = "SELECT DISTINCT [name] FROM [dbo].[PRODUCT] WHERE [IsDelete] = 0";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();

            comboBox1.Items.Clear();
            while (reader.Read())
            {
                comboBox1.Items.Add(reader[0].ToString());
            }

            reader.Close();
            comboBox2.Enabled = true;
            comboBox2.SelectedIndex = -1;
            textBox1.Text = "";
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            string SelectQuery = $"SELECT [male_female] FROM [dbo].[PRODUCT] WHERE [IsDelete] = 0 AND [name] = '{comboBox1.Text}'";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();

            comboBox2.Items.Clear();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader[0].ToString());
            }

            reader.Close();
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string SelectQuery = $"SELECT [price],[id_product] FROM [dbo].[PRODUCT] WHERE [name] = '{comboBox1.Text}' AND [male_female] = '{comboBox2.Text}'";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            textBox1.Text = $"{Math.Round(Convert.ToDouble(reader[0]), 2)}";
            IdProduct = Convert.ToInt32(reader[1]);
            reader.Close();
        }

        private void ChangeProductListButton_Click(object sender, EventArgs e)
        {
                
            if (comboBox1.Text != "" && comboBox2.Text != "" && textBox2.Text != "")
            {
                int IdProduct = SearchIdProduct();
                var price_position = Convert.ToDouble(textBox2.Text) * Convert.ToDouble(textBox1.Text);
                string SelectQuery = $"UPDATE [PRODUCT_LIST] SET [id_product]={IdProduct},[amount]={textBox2.Text},[price_position]={price_position.ToString().Replace(",",".")},[id_order]={IdOrder},[IsDelete] = 0 WHERE [id_list]={IdProductList}";
                SqlCommand command = new SqlCommand(SelectQuery, connect);
                int Count = command.ExecuteNonQuery();
                Close();
                UpdateProductListGridViewer();
                ProductListGridViewer.ClearSelection();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        public void UpdateProductListGridViewer()
        {
            ProductListGridViewer.Rows.Clear();
            string SelectQuery = $"SELECT [name], [male_female], [price], [amount] FROM [PRODUCT_LIST], [PRODUCT] WHERE [PRODUCT_LIST].IsDelete = 0 AND id_order = '{IdOrder}' AND [PRODUCT].id_product = [PRODUCT_LIST].id_product";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();

            double Price = 0;
            while (reader.Read())
            {
                ProductListGridViewer.Rows.Add(reader[0], reader[1], Math.Round(Convert.ToDouble(reader[2]), 2), reader[3]);
                Price = Price + Convert.ToDouble(reader[2]) * Convert.ToDouble(reader[3]);
            }

            string PriceList = String.Format("{0:C2}", Price);
            OrderGridViewer.Rows[IdRowsOrder].Cells[5].Value = PriceList;

            reader.Close();
        }

        public int SearchIdProduct()
        {
            string SelectQuery = $"SELECT [id_product] FROM [PRODUCT] WHERE [name]='{comboBox1.Text}' AND [male_female]='{comboBox2.Text}' AND [price]={textBox1.Text.Replace(",",".")}";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int IdProduct = Convert.ToInt32(reader[0]);
            reader.Close();
            return (IdProduct);
        }
    }
}
