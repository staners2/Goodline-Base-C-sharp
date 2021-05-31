using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateBase_V._2
{
    public partial class AddOrderForms : Form
    {
        public AddOrderForms(DataGridView NewOrderGridViewer)
        {
            InitializeComponent();
            OrderGridViewer = NewOrderGridViewer;
        }

        public SqlConnection connect;
        public DataGridView OrderGridViewer;
        public double SumPrice = 0;

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox1.MaskCompleted)
            {
                ProductListGridViewer.Rows.Clear();
                comboBox1.SelectedIndex = -1;
                comboBox2.SelectedIndex = -1;
                textBox5.Text = "";
                label4.Text = "";
                label7.Text = "";
                SumPrice = 0;
                panel1.Enabled = true;
                AddOrder.Enabled = false;
            }
            else
            {
                panel1.Enabled = false;
                AddOrder.Enabled = false;
            }
        }

        private void AddProductList_Click(object sender, EventArgs e)
        {

            if (comboBox1.Text != "" && comboBox2.Text != "" && textBox5.Text != "")
            {
                AddOrder.Enabled = true;

                string NameProduct = comboBox1.Text;
                string Male_Female = comboBox2.Text;
                string Price = label4.Text;
                string Amount = textBox5.Text;

                SumPrice = Convert.ToDouble(Price) * Convert.ToInt32(Amount) + SumPrice;
                label7.Text = Convert.ToString(SumPrice);
                ProductListGridViewer.Rows.Add(NameProduct, Male_Female, Price, Amount);

                /* string SelectQuery = $"INSERT INTO [dbo].[PRODUCT_LIST] VALUES ({IdProduct},{textBox2.Text},{Convert.ToInt32(textBox2.Text) * Convert.ToInt32(textBox1.Text)},{IdOrder})";
                SqlCommand command = new SqlCommand(SelectQuery, connect);
                int Count = command.ExecuteNonQuery(); */
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            string Name = textBox1.Text;
            string Surname = textBox2.Text;
            string Patronymic = textBox3.Text;
            string Number = maskedTextBox1.Text;
            string Data = DateTime.Today.ToString("yyyy-MM-dd");
            double price_position = 0;

            int id_client = AddClientAndReturnIdClient(Name,Surname,Patronymic,Number);
            int id_order = AddOrderAndReturnIdOrder(id_client);

            foreach (DataGridViewRow Row in ProductListGridViewer.Rows) 
            {
                string NameProduct = Convert.ToString(ProductListGridViewer.Rows[Row.Index].Cells[0].Value); 
                string Male_Female = Convert.ToString(ProductListGridViewer.Rows[Row.Index].Cells[1].Value);
                string Price = Convert.ToString(ProductListGridViewer.Rows[Row.Index].Cells[2].Value);
                string Amount = Convert.ToString(ProductListGridViewer.Rows[Row.Index].Cells[3].Value);

                int id_product = GetIdProduct(NameProduct, Male_Female, Price);
                double PricePosition = Convert.ToDouble(Price) * Convert.ToDouble(Amount);

                price_position = price_position + PricePosition; // Считать сумму заказа

                string InsertQuery =
                    $"INSERT INTO [dbo].[PRODUCT_LIST] ([id_product],[amount],[price_position],[id_order],[IsDelete]) VALUES ({id_product},{Amount},{PricePosition.ToString().Replace(",",".")},{id_order},0)";
                SqlCommand command = new SqlCommand(InsertQuery, connect);
                int Count = command.ExecuteNonQuery();
            }

            OrderGridViewer.Rows.Add(Name,Surname,Patronymic,Number, Data, String.Format("{0:C2}",price_position),"Готов");
            OrderGridViewer.ClearSelection();
            Close();
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            string SelectQuery = $"SELECT [male_female] FROM [dbo].[PRODUCT] WHERE [IsDelete]=0 AND [name] = '{comboBox1.Text}'";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();

            comboBox2.Items.Clear();
            while (reader.Read())
            {
                comboBox2.Items.Add(reader[0].ToString());
            }

            reader.Close();
        }

        private void comboBox1_Enter(object sender, EventArgs e)
        {
            string SelectQuery = "SELECT DISTINCT [name] FROM [dbo].[PRODUCT] WHERE [IsDelete]=0";
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
            label4.Text = "";
        }

        private void comboBox2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string SelectQuery = $"SELECT [price] FROM [dbo].[PRODUCT] WHERE [IsDelete]=0 AND [name] = '{comboBox1.Text}' AND [male_female] = '{comboBox2.Text}'";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();

            reader.Read();
            label4.Text = $"{Math.Round(Convert.ToDouble(reader[0]), 2)}";
            reader.Close();
        }

        public int AddClientAndReturnIdClient(string Name, string Surname, string Patronymic, string Number)
        {
            int IdClient = 0;
            string SelectQuery = $"SELECT [id_client] FROM [dbo].[CLIENT] WHERE [IsDelete]=0 AND [name_client]='{Name}' AND [surname_client]='{Surname}' AND [patronymic_client]='{Patronymic}' AND [number_client]='{Number}'";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            int Count = Convert.ToInt32(reader.HasRows);
            if (Count == 1)
            {
                reader.Read();
                IdClient = Convert.ToInt32(reader[0]);
                reader.Close();
                return (IdClient);
            }
            else
            {
                reader.Close();
                string InsertQuery = $"INSERT [dbo].[CLIENT] VALUES ('{textBox1.Text}','{textBox2.Text}','{textBox3.Text}','{maskedTextBox1.Text}',0)";
                command = new SqlCommand(InsertQuery, connect);
                Count = command.ExecuteNonQuery();

                SelectQuery = "SELECT MAX(id_client) FROM [dbo].[CLIENT]";
                command = new SqlCommand(SelectQuery, connect);
                reader = command.ExecuteReader();
                reader.Read();

                IdClient = Convert.ToInt32(reader[0]);
                reader.Close();
            }
            return (IdClient);
        }

        public int AddOrderAndReturnIdOrder(int id_client)
        {
            string Data = DateTime.Today.ToString("yyyy-MM-dd");

            string InsertQuery = $"INSERT [dbo].[ORDER] VALUES ('{id_client}','1','{Data}',0)";
            SqlCommand command = new SqlCommand(InsertQuery, connect);
            int Count = command.ExecuteNonQuery();

            string SelectQuery = "SELECT MAX(id_order) FROM [dbo].[ORDER]";
            command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            int IdOrder = Convert.ToInt32(reader[0]);   
            reader.Close();

            return (IdOrder);
        }

        public int GetIdProduct(string Name, string Male_Female, string Price)
        {
            string SelectQuery = $"SELECT [id_product] FROM [dbo].[PRODUCT] WHERE [IsDelete]=0 AND [name]='{Name}' AND [male_female]='{Male_Female}' AND [price]='{Price.Replace(",",".")}'";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();

            int IdProduct = Convert.ToInt32(reader[0]);
            reader.Close();

            return (IdProduct);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e) 
        {
            if (Char.IsLetter(e.KeyChar) || e.KeyChar == 8)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
