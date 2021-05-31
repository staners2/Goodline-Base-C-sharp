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
    public partial class OrderForms : Form
    {
        public OrderForms()
        {
            InitializeComponent();
            connect.Open();
        }

        public int IdOrder;
        public int IdRowsOrder;
        public int IdClient;
        public bool IsSort = false;

        SqlConnection connect = new SqlConnection("Data Source=laptop-32ao3tma;Initial Catalog=MAGAZINE;Integrated Security=True");
        public List<int> OrderList = new List<int>();

        // МЕТОД НЕ НУЖЕН БОЛЬШЕ
        /* public int GetIdOrder(int IndexRows) 
        {
            string sNameClient = Convert.ToString(OrderGridViewer.Rows[IndexRows].Cells[0].Value);
            string sSurnameClient = Convert.ToString(OrderGridViewer.Rows[IndexRows].Cells[1].Value);
            string sPatronymicClient = Convert.ToString(OrderGridViewer.Rows[IndexRows].Cells[2].Value);

            string SelectQuery = $"SELECT * FROM [dbo].[CLIENT] WHERE [name_client]='{sNameClient}' AND [surname_client]='{sSurnameClient}' AND [patronymic_client]='{sPatronymicClient}'";
            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            reader.Read();
            int IdClient = Convert.ToInt32(reader[0]);
            reader.Close();

            string sDate = Convert.ToString(OrderGridViewer.Rows[IndexRows].Cells[4].Value);
            string sRedy = Convert.ToString(OrderGridViewer.Rows[IndexRows].Cells[6].Value);

            SelectQuery = $"SELECT * FROM [dbo].[ORDER] WHERE [id_client]='{IdClient}' AND [is_redy]='{sRedy}' AND [date]='{sDate}'";
            command = new SqlCommand(SelectQuery, connect);
            reader = command.ExecuteReader();
            reader.Read();
            int IdOrder = Convert.ToInt32(reader[0]);
            reader.Close();

            return (IdOrder);
        } */

        private void SettingProductButton_Click(object sender, EventArgs e)
        {
            SettingProduct Forms = new SettingProduct();
            Forms.connect = this.connect;
            Forms.ShowDialog();
        }

        private void SettingClientButton_Click(object sender, EventArgs e)
        {
            SettingClient Forms = new SettingClient(OrderGridViewer);
            Forms.connect = this.connect;
            Forms.ShowDialog();
        }

        private void AddOrder_Click(object sender, EventArgs e)
        {
            AddOrderForms Forms = new AddOrderForms(OrderGridViewer);
            Forms.connect = this.connect;
            Forms.ShowDialog();
        }

        private void OrderForms_Load(object sender, EventArgs e)
        {
            UpdateListOrder();
            UpdateOrderGridViewer();
        }

        private void OrderForms_Shown(object sender, EventArgs e)
        {
            OrderGridViewer.ClearSelection();
        }

        private void ChangeOrderButton_Click(object sender, EventArgs e)
        {

            if (OrderGridViewer.SelectedRows.Count == 1)
            {
                ChangeOrderForms Forms = new ChangeOrderForms(OrderGridViewer, IdOrder, IdClient, IdRowsOrder);
                Forms.connect = this.connect;
                Forms.ShowDialog();
            }
            else
            {
                MessageBox.Show("Выберите строку");
            }
        }

        private void DeleteOrderButton_Click(object sender, EventArgs e)
        {
            string message = "Вы точно хотите удалить запись?";
            string caption = "Проверка";

            if (OrderGridViewer.SelectedRows.Count == 1)
            {
                DialogResult result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Order_InsteadOf_Delete - TRIGGER
                    string UpdateQuery = $"delete from [ORDER] WHERE [id_order] = {IdOrder}";

                    OrderGridViewer.Rows.Remove(OrderGridViewer.Rows[IdRowsOrder]);

                    SqlCommand command = new SqlCommand(UpdateQuery, connect);

                    int Count = command.ExecuteNonQuery();
                    OrderGridViewer.ClearSelection();
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

        public void UpdateListOrder()
        {
            if (IsSort)
            {
                string SelectQuery = $"SELECT [id_order] FROM [dbo].[ORDER] WHERE [IsDelete] = 0 ORDER BY [date] DESC";
                SqlCommand command = new SqlCommand(SelectQuery, connect);
                SqlDataReader reader = command.ExecuteReader();
                OrderList.Clear();
                while (reader.Read())
                {
                    OrderList.Add(Convert.ToInt32(reader[0]));  // Получаем список ID заказов
                }

                reader.Close();
            }
            else
            {
                string SelectQuery = $"SELECT [id_order] FROM [dbo].[ORDER] WHERE [IsDelete] = 0";
                SqlCommand command = new SqlCommand(SelectQuery, connect);
                SqlDataReader reader = command.ExecuteReader();
                OrderList.Clear();

                while (reader.Read())
                {
                    OrderList.Add(Convert.ToInt32(reader[0]));  // Получаем список ID заказов
                }

                reader.Close();
            }
            
        }

        public void UpdateOrderGridViewer()
        {
            OrderGridViewer.Rows.Clear();
            
            foreach (int IdOrder in OrderList)
            {
                // GET SUM ORDER
                string SelectQuery =
                    "declare @result MONEY " +
                    $"EXECUTE @result = GetSumOrder {IdOrder}, @price = @result OUTPUT " +
                    "SELECT @result";
                /*$"SELECT SUM([dbo].PRODUCT_LIST.price_position) as price_position FROM[dbo].PRODUCT_LIST WHERE [IsDelete] = 0 AND [id_order] = {IdOrder}";*/
                SqlCommand command = new SqlCommand(SelectQuery, connect);
                SqlDataReader reader = command.ExecuteReader();
                reader.Read();

                var price_position = String.Format("{0:C2}", reader[0]);
                reader.Close();

                SelectQuery = "SELECT DISTINCT [CLIENT].name_client, [CLIENT].surname_client, [CLIENT].patronymic_client, [CLIENT].number_client, [ORDER].date, [ORDER].is_redy"+
                " FROM[dbo].[ORDER], [dbo].[CLIENT], [dbo].PRODUCT_LIST, [dbo].PRODUCT" +
                $" WHERE([PRODUCT_LIST].id_order = [ORDER].id_order AND [ORDER].id_client = [CLIENT].id_client AND [ORDER].[id_order] = {IdOrder} AND [ORDER].IsDelete = 0 AND [PRODUCT_LIST].IsDelete = 0)";
                command = new SqlCommand(SelectQuery, connect);
                reader = command.ExecuteReader();
                reader.Read();

                string Name = Convert.ToString(reader[0]);
                string Surname = Convert.ToString(reader[1]);
                string Patronymic = Convert.ToString(reader[2]);
                string Number = Convert.ToString(reader[3]);
                string Date = Convert.ToDateTime(reader[4]).ToString("yyyy-MM-dd");
                // string IsRedy = Convert.ToString(reader[5]);
                string IsRedy = (Convert.ToBoolean(reader[5]) == true) ? "Готов" : "Не готов";   

                reader.Close();

                OrderGridViewer.Rows.Add(Name, Surname, Patronymic, Number, Date, price_position, IsRedy);
            }
        }

        private void OrderGridViewer_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                UpdateListOrder();
                IdRowsOrder = e.RowIndex;
                IdOrder = OrderList[IdRowsOrder];

                string Name = OrderGridViewer.Rows[e.RowIndex].Cells[0].Value.ToString();
                string Surname = OrderGridViewer.Rows[e.RowIndex].Cells[1].Value.ToString();
                string Patronymic = OrderGridViewer.Rows[e.RowIndex].Cells[2].Value.ToString();
                string Number = OrderGridViewer.Rows[e.RowIndex].Cells[3].Value.ToString();

                // FIND CLIENT ID
                string SelectQuery = "declare @id_ int "+
                    $"exec FindClientId '{Name}','{Surname}','{Patronymic}','{Number}', " +
                    "@id = @id_ output " +
                    "select @id_";
                   /* $"SELECT [id_client] FROM [dbo].CLIENT WHERE [name_client]='{Name}' AND [surname_client]='{Surname}' AND [patronymic_client]='{Patronymic}' AND [number_client]='{Number}'";*/
                SqlCommand command = new SqlCommand(SelectQuery, connect);
                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                IdClient = Convert.ToInt32(reader[0]);
                reader.Close();

                if (OrderGridViewer.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
                {
                    ProductListInfoForms Forms = new ProductListInfoForms(IdOrder, OrderGridViewer, IdRowsOrder);
                    Forms.connect = this.connect;
                    Forms.ShowDialog();
                }
            }
                
        }

        private void SortDateButton_Click(object sender, EventArgs e)
        {
            if (IsSort)
            {
                IsSort = false;
                label1.ForeColor = Color.Red;
                label1.Text = "OFF";
            }
            else
            {
                IsSort = true;
                label1.ForeColor = Color.ForestGreen;
                label1.Text = "ON";
            }

            UpdateListOrder();
            UpdateOrderGridViewer();
            OrderGridViewer.ClearSelection();
        }

        private void ReportingButton_Click(object sender, EventArgs e)
        {
            ReportingForms Forms = new ReportingForms();
            Forms.connect = this.connect;
            Forms.ShowDialog();
        }

        private void OpenLogsButton_Click(object sender, EventArgs e)
        {
            OpenLogsForms Forms = new OpenLogsForms();
            Forms.connect = this.connect;
            Forms.ShowDialog();
        }
    }
}
