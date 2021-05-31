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
    public partial class AddClientForms : Form
    {
        public AddClientForms(DataGridView NewClientGridViewer)
        {
            InitializeComponent();
            ClientGridViewer = NewClientGridViewer;
        }

        public SqlConnection connect;
        public DataGridView ClientGridViewer;

        private void AddProduct_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && (textBox2.Text != "") && textBox3.Text != "" && textBox4.Text != "")
            {
                string NameClient = textBox1.Text;
                string SurnameClient = textBox2.Text;
                string PatronymicClient = textBox3.Text;
                string NumberClient = textBox4.Text;

                string InsertQuery = $"INSERT INTO [dbo].[CLIENT] ([name_client],[surname_client],[patronymic_client], [number_client], [IsDelete]) VALUES ('{NameClient}','{SurnameClient}','{PatronymicClient}','{NumberClient}',0)";
                SqlCommand command = new SqlCommand(InsertQuery, connect);

                int Count = command.ExecuteNonQuery();
                UpdateClientGridViewer();
                // MessageBox.Show($"Добавленных строк: {Count}");
                Close();
                ClientGridViewer.ClearSelection();
            }
            else
            {
                MessageBox.Show("Заполните все поля");
            }
        }

        public void UpdateClientGridViewer()
        {
            ClientGridViewer.Rows.Clear();
            string query = "SELECT * FROM [dbo].[CLIENT] WHERE [IsDelete] = 0";
            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ClientGridViewer.Rows.Add(reader[1], reader[2], reader[3], reader[4]);
            }

            reader.Close();
        }
    }
}
