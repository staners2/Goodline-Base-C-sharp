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
    public partial class SettingClient : Form
    {
        public SettingClient(DataGridView NewOrderGridViewer)
        {
            InitializeComponent();
            OrderGridViewer = NewOrderGridViewer;
        }

        public SqlConnection connect;
        public List<int> ListIdClient = new List<int> { };
        public int IdClient;
        public int IdRows;
        public DataGridView OrderGridViewer;

        private void AddClientButton_Click(object sender, EventArgs e)
        {
            AddClientForms Forms = new AddClientForms(ClientGridViewer);
            Forms.connect = this.connect;
            Forms.ShowDialog();
        }

        private void SettingClient_Load(object sender, EventArgs e)
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

        public List<int> UpdateClientListId()
        {
            ListIdClient.Clear();
            string SelectQuery = "SELECT * FROM [dbo].[CLIENT] WHERE [IsDelete] = 0";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                ListIdClient.Add(Convert.ToInt32(reader[0]));
            }

            reader.Close();
            return (ListIdClient);
        }

        private void ChangeClientButton_Click(object sender, EventArgs e) // Передать ID нажатой строки через список
        {
            if (ClientGridViewer.SelectedRows.Count == 1)
            {
                string Name = Convert.ToString(ClientGridViewer.Rows[IdRows].Cells[0].Value);
                string Surname = Convert.ToString(ClientGridViewer.Rows[IdRows].Cells[1].Value);
                string Patronymic = Convert.ToString(ClientGridViewer.Rows[IdRows].Cells[2].Value);
                string Number = Convert.ToString(ClientGridViewer.Rows[IdRows].Cells[3].Value);

                ChangeClientForms Forms = new ChangeClientForms(ClientGridViewer, IdClient,Name,Surname,Patronymic,Number,OrderGridViewer);
                Forms.connect = this.connect;
                Forms.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }

        }

        private void ClientGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateClientListId();
                IdRows = Convert.ToInt32(e.RowIndex);
                IdClient = ListIdClient[IdRows];
            }
        }

        private void DeleteClientButton_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить запись?";
            string caption = "Проверка";
            

            if (ClientGridViewer.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    string UpdateQuery = $"DELETE FROM [CLIENT] WHERE [id_client] = {IdClient}";

                    ClientGridViewer.Rows.Remove(ClientGridViewer.Rows[IdRows]);

                    SqlCommand command = new SqlCommand(UpdateQuery, connect);

                    int Count = command.ExecuteNonQuery();
                    // MessageBox.Show($"Записей удалено: {Count}");
                    ClientGridViewer.ClearSelection();

                }
                else
                {
                    MessageBox.Show("Действие прервано", "Ошибка");
                }
            }   
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }

        private void SettingClient_Shown(object sender, EventArgs e)
        {
            ClientGridViewer.ClearSelection();
        }
    }
}
