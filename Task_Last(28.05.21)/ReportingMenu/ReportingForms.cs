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
    public partial class ReportingForms : Form
    {
        public ReportingForms()
        {
            InitializeComponent();
        }

        public SqlConnection connect;
        private void ProductIsNotDemandButton_Click(object sender, EventArgs e)
        {
            // Товар проданный более недели назад
            GridViewer.Columns.Clear();
            GridViewer.Columns.Add("name_poduct","Название товара");
            GridViewer.Columns.Add("male_female", "Пол");
            GridViewer.Columns.Add("price_product", "Стоимость товара");

            string SelectQuery =
                "select distinct [PRODUCT].name,[PRODUCT].male_female,[PRODUCT].price " +
                "from[PRODUCT] " +
                "left join[PRODUCT_LIST] on[PRODUCT_LIST].id_product =[PRODUCT].id_product " + 
                "left join[ORDER] on[PRODUCT_LIST].id_order = [ORDER].id_order " +
                "where DATEDIFF(day, [ORDER].date, GETDATE()) > 7";

            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                GridViewer.Rows.Add(reader[0].ToString(), reader[1].ToString(), Math.Round(Convert.ToDouble(reader[2]), 2));
            }

            reader.Close();
        }

        private void BestSellingButton_Click(object sender, EventArgs e)
        {
            string IsSort = "";
            if (!checkBox1.Checked)
            {
                IsSort = "";
            }
            else
            {
                IsSort = "desc";
            }
            // Товар купленный в наибольшем кол-ве (Max 5 записей)
            GridViewer.Columns.Clear();
            GridViewer.Columns.Add("name_poduct", "Название товара");
            GridViewer.Columns.Add("male_female", "Пол");
            GridViewer.Columns.Add("amount", "Кол-во товара");
            GridViewer.Columns.Add("price", "Стоимость товара");

            string SelectQuery = 
                "select [PRODUCT].name,[PRODUCT].male_female,sum(amount) as amount,ROUND(price,2) as price "+
                "from [PRODUCT_LIST] "+
                "left join[PRODUCT] on[PRODUCT_LIST].id_product =[PRODUCT].id_product "+
                "group by [PRODUCT].name,[PRODUCT].male_female,[PRODUCT].price "+
                $"order by [amount] {IsSort}";

            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            int Count = 0;
            while (reader.Read() && Count < 5) // Count - ТОП 5 записей
            {
                GridViewer.Rows.Add(reader[0].ToString(),reader[1].ToString(),reader[2].ToString(), Math.Round(Convert.ToDouble(reader[3]), 2));
                Count++;
            }

            reader.Close();
        }

        private void PriceOrderButton_Click(object sender, EventArgs e)
        {
            // Общая стоимость всех сделанных заказов клиента
            GridViewer.Columns.Clear();
            GridViewer.Columns.Add("name", "Имя");
            GridViewer.Columns.Add("surname", "Фамилия");
            GridViewer.Columns.Add("patronymic", "Отчество");
            GridViewer.Columns.Add("price", "Сумма всех заказов");

            // VIEW ORDER INFO
            string SelectQuery = "execute ViewOrderInfo";
                /*"select name_client, surname_client, patronymic_client, SUM(price_position) " +
                "from PRODUCT_LIST,[ORDER] " +
                "left join[CLIENT] on[ORDER].id_client = [CLIENT].id_client " +
                "where [PRODUCT_LIST].id_order = [ORDER].id_order " + 
                "group by name_client,surname_client,patronymic_client";*/

            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read()) 
            {
                GridViewer.Rows.Add(reader[0].ToString(), reader[1].ToString(), reader[2].ToString(),Math.Round(Convert.ToDouble(reader[3]),2));
            }

            reader.Close();
        }

        private void NotSellingProductButton_Click(object sender, EventArgs e)
        {
            GridViewer.Columns.Clear();
            GridViewer.Columns.Add("name", "Имя");
            GridViewer.Columns.Add("male_female", "Пол");
            GridViewer.Columns.Add("price", "Стоимость товара");

            string SelectQuery =
                @"SELECT [PRODUCT].name,[PRODUCT].male_female,[PRODUCT].price
                FROM product
                EXCEPT 
                SELECT[PRODUCT].name,[PRODUCT].male_female,[PRODUCT].price
                FROM product_list 
                left join PRODUCT on[PRODUCT].id_product = [PRODUCT_LIST].id_product";

            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                GridViewer.Rows.Add(reader[0].ToString(), reader[1].ToString(), Math.Round(Convert.ToDouble(reader[2]), 2));
            }

            reader.Close();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            GridViewer.Columns.Clear();
            GridViewer.Columns.Add("name", "Имя");
            GridViewer.Columns.Add("male_female", "Пол");
            GridViewer.Columns.Add("price", "Стоимость товара");
            GridViewer.Columns.Add("date", "Дата");

            string Day = dateTimePicker1.Text[0].ToString() + dateTimePicker1.Text[1].ToString();
            string Month = dateTimePicker1.Text[3].ToString() + dateTimePicker1.Text[4].ToString();
            string Year = dateTimePicker1.Text[6].ToString() + dateTimePicker1.Text[7].ToString() + dateTimePicker1.Text[8].ToString() + dateTimePicker1.Text[9].ToString();
            string data = $"{Year}-{Month}-{Day}";

            // VIEW ORDER ON THIS DATE
            string SelectQuery = $"exec ViewOrdersOnThisDate '{data}'";

            /*string.Format(@"select distinct name, male_female, price, date 
            from PRODUCT,[ORDER],PRODUCT_LIST
            where [ORDER].id_order = [PRODUCT_LIST].id_order 
            AND date = '{0}'", data);*/

            SqlCommand command = new SqlCommand(SelectQuery, connect);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                GridViewer.Rows.Add(reader[0].ToString(), reader[1].ToString(),
                    Math.Round(Convert.ToDouble(reader[2]), 2),
                    Convert.ToDateTime(reader[3]).ToString("yyyy-MM-dd"));
            }
            reader.Close();
        }
    }
}
