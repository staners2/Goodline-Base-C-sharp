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
    public partial class ChangeProductForms : Form
    {
        public ChangeProductForms(DataGridView NewProductGrid, int NewIdProduct, string Name, string Male_Female, string Price)
        {
            InitializeComponent();
            ProductGridViewer = NewProductGrid;
            IdProduct = NewIdProduct;

            textBox1.Text = Name;
            comboBox1.Text = Male_Female;
            textBox3.Text = Price;
        }

        public bool IsHaveDot = false;
        public int IsSymboleAfterDot = 3;
        public SqlConnection connect;
        public DataGridView ProductGridViewer;
        public int IdProduct;

        private void ChangeProduct_Click(object sender, EventArgs e)
        {
            // Regex regex = new Regex(@"\d(\d{5})?\.\d\d$", RegexOptions.IgnoreCase);    // ИЗМЕНИТЬ РЕГУЛЯРНОЕ ВЫРАЖЕНИЕ
            // bool CheckFieldPrice = regex.IsMatch(textBox3.Text);

            if (textBox1.Text != "" && (comboBox1.Text == "М" || comboBox1.Text == "Ж")) // && CheckFieldPrice
            {
                string NameProduct = textBox1.Text;
                string Male_Female = comboBox1.Text;
                string Price = textBox3.Text.Replace(",",".");

                string query = $"UPDATE [dbo].[PRODUCT] SET [name] = '{NameProduct}', [male_female] = '{Male_Female}', [price] = {Price} WHERE [id_product] = {IdProduct}";

                SqlCommand command = new SqlCommand(query, connect);
                int Count = command.ExecuteNonQuery();
                UpdateProductGrid();
                // MessageBox.Show($"Записей изменено: {Count}");
                Close();
                ProductGridViewer.ClearSelection();
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
