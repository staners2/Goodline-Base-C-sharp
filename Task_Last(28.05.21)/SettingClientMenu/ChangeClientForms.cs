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
    public partial class ChangeClientForms : Form
    {
        public ChangeClientForms(DataGridView NewClientGridViewer, int NewIdClient, string Name, string Surname, string Patronymic, string Number, DataGridView NewOrderGridViewer)
        {
            InitializeComponent();
            ClientGridViewer = NewClientGridViewer;
            IdClient = NewIdClient;
            OrderGridViewer = NewOrderGridViewer;

            textBox1.Text = Name;
            textBox2.Text = Surname;
            textBox3.Text = Patronymic;
            maskedTextBox1.Text = Number;

            LastName = Name;
            LastSurname = Surname;
            LastPatronymic = Patronymic;
            LastNumber = Number;
        }

        public SqlConnection connect;
        public DataGridView ClientGridViewer;
        public int IdClient;
        public DataGridView OrderGridViewer;

        public string LastName;
        public string LastSurname;
        public string LastPatronymic;
        public string LastNumber;


        private void ChangeClientButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox1.MaskCompleted)
            {
                string NameClient = textBox1.Text;
                string SurnameClient = textBox2.Text;
                string PatronymicClient = textBox3.Text;
                string NumberClient = maskedTextBox1.Text;

                // ----------- ОБНОВЛЯЯ ТАБЛИЦУ ORDER -----

                for (int i = 0; i < OrderGridViewer.Rows.Count; i++)
                {
                    if (OrderGridViewer.Rows[i].Cells[0].Value.ToString() == LastName && OrderGridViewer.Rows[i].Cells[1].Value.ToString() == LastSurname && OrderGridViewer.Rows[i].Cells[2].Value.ToString() == LastPatronymic && OrderGridViewer.Rows[i].Cells[3].Value.ToString() == LastNumber)
                    {
                        OrderGridViewer.Rows[i].Cells[0].Value = NameClient;
                        OrderGridViewer.Rows[i].Cells[1].Value = SurnameClient;
                        OrderGridViewer.Rows[i].Cells[2].Value = PatronymicClient;
                        OrderGridViewer.Rows[i].Cells[3].Value = NumberClient;
                    }
                }

                // ----------------------------------------

                // Client_After_Update
                string query = $"UPDATE [dbo].[CLIENT] SET [name_client] = '{NameClient}', [surname_client] = '{SurnameClient}', [patronymic_client] = '{PatronymicClient}', [number_client] = '{NumberClient}', [IsDelete] = 0 WHERE [id_client] = {IdClient}";

                SqlCommand command = new SqlCommand(query, connect);
                int Count = command.ExecuteNonQuery();
                UpdateClientGridViewer();
                // MessageBox.Show($"Записей изменено: {Count}");
                Close();
                ClientGridViewer.ClearSelection();
            }
            else
            {
                MessageBox.Show("Заполните поля");
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

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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
