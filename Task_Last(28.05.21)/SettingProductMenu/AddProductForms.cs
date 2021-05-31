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
    public partial class AddProductForms : Form
    {
        public AddProductForms(DataGridView NewProductGrid)
        {
            InitializeComponent();
            ProductGridViewer = NewProductGrid;
        }

        public SqlConnection connect;
        public DataGridView ProductGridViewer;
        public bool IsHaveDot = false;
        public int IsSymboleAfterDot = 0;

        private void AddProduct_Click(object sender, EventArgs e) // "\d(\d{5})?\.\d\d$"
        {
            if (textBox1.Text != "" && (comboBox1.Text != "") && textBox3.Text != "")
            {
                if (!CheckProductIsMatch())
                {
                    string NameProduct = textBox1.Text;
                    string Male_Female = comboBox1.Text;
                    string Price = textBox3.Text.Replace(",", ".");

                    // Product_Insert_Update
                    string query =
                        $"INSERT INTO [dbo].[PRODUCT] ([name],[male_female],[price],[IsDelete]) VALUES ('{NameProduct}','{Male_Female}',{Price},0)";
                    SqlCommand command = new SqlCommand(query, connect);

                    int Count = command.ExecuteNonQuery();
                    UpdateProductGrid();
                    // MessageBox.Show($"Добавленных строк: {Count}");
                    Close();
                    ProductGridViewer.ClearSelection();
                }
                else
                {
                    MessageBox.Show("Товар с такими характеристиками уже имеется в базе");
                }
            }
            else
            {
                MessageBox.Show("Вы заполнили не все поля или же не правильно записали цену. Формат ввода: 56.XX");
            }
        }

        public void UpdateProductGrid()
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

        public bool CheckProductIsMatch()
        {
            string query =
                $"SELECT * FROM [dbo].[PRODUCT] WHERE [name]='{textBox1.Text}' AND [male_female]='{comboBox1.Text}' AND [IsDelete] = 0"; // AND [price]={textBox3.Text.Replace(",",".")}
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();

            if (Convert.ToInt32(reader.HasRows) == 1)
            {
                reader.Close();
                return (true);
            }
            else
            {
                reader.Close();
                return (false);
            }

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e) // IsSymboleAfterDot++; | IsSymboleAfterDot >= 2;
        {
            var key = e.KeyChar;

            if (Char.IsDigit(key) || e.KeyChar == 46 || e.KeyChar == 44 || e.KeyChar == 8)
            {
                if (IsHaveDot && IsSymboleAfterDot >= 3 && e.KeyChar != 8)
                {
                    e.Handled = true;
                }
                else if (e.KeyChar == 8 && IsHaveDot)
                {
                    IsSymboleAfterDot--;
                }

                else if ((e.KeyChar == 46 || e.KeyChar == 44) && IsHaveDot)
                {
                    e.Handled = true;
                }
                else
                {
                    IsSymboleAfterDot++;
                }
            }
            else
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text.Length == 1 && (textBox3.Text.Contains(",") || textBox3.Text.Contains(".")))
            {
                textBox3.Text = "";
            }

            if (textBox3.Text.Contains(".") || (textBox3.Text.Contains(",")))
            {
                IsHaveDot = true;
            }
            else
            {
                IsHaveDot = false;
                IsSymboleAfterDot = 0;
            }
        }
    }
}
