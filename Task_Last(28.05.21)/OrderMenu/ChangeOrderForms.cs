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
    public partial class ChangeOrderForms : Form
    {
        public ChangeOrderForms(DataGridView NewOrderGridViewer, int NewIdOrder, int NewIdClient, int NewIdRowsOrder)
        {
            InitializeComponent();
            OrderGridViewer = NewOrderGridViewer;
            IdOrder = NewIdOrder;
            IdClient = NewIdClient;
            IdRowsOrder = NewIdRowsOrder;

            textBox1.Text = OrderGridViewer.Rows[IdRowsOrder].Cells[0].Value.ToString();
            textBox2.Text = OrderGridViewer.Rows[IdRowsOrder].Cells[1].Value.ToString();
            textBox3.Text = OrderGridViewer.Rows[IdRowsOrder].Cells[2].Value.ToString();
            maskedTextBox1.Text = OrderGridViewer.Rows[IdRowsOrder].Cells[3].Value.ToString();
            dateTimePicker1.Text = OrderGridViewer.Rows[IdRowsOrder].Cells[4].Value.ToString();
            comboBox1.SelectedIndex = comboBox1.FindString(OrderGridViewer.Rows[IdRowsOrder].Cells[6].Value.ToString());

        }

        public DataGridView OrderGridViewer;
        public int IdOrder;
        public int IdClient;
        public int IdRowsOrder;
        public SqlConnection connect;
        private void ChangeOrderButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && maskedTextBox1.MaskCompleted && comboBox1.Text != "")
            {
                string Day = dateTimePicker1.Text[0].ToString() + dateTimePicker1.Text[1].ToString();
                string Month = dateTimePicker1.Text[3].ToString() + dateTimePicker1.Text[4].ToString();
                string Year = dateTimePicker1.Text[6].ToString() + dateTimePicker1.Text[7].ToString() + dateTimePicker1.Text[8].ToString() + dateTimePicker1.Text[9].ToString();
                string Date = $"{Year}-{Month}-{Day}";
                string IsRedy = (comboBox1.Text == "Готов") ? "1" : "0";

                string UpdateQuery = $"UPDATE [dbo].[CLIENT] SET [name_client] = '{textBox1.Text}', [surname_client] = '{textBox2.Text}', [patronymic_client] = '{textBox3.Text}', [number_client] = '{maskedTextBox1.Text}' WHERE [id_client] = {IdClient}";
                SqlCommand command = new SqlCommand(UpdateQuery, connect);
                int Count = command.ExecuteNonQuery();

                UpdateQuery = $"UPDATE [dbo].[ORDER] SET [is_redy] = '{IsRedy}', [date] = '{Date}' WHERE [id_order] = {IdOrder}";
                command = new SqlCommand(UpdateQuery, connect);
                Count = command.ExecuteNonQuery();

                OrderGridViewer.Rows[IdRowsOrder].Cells[0].Value = textBox1.Text;
                OrderGridViewer.Rows[IdRowsOrder].Cells[1].Value = textBox2.Text;
                OrderGridViewer.Rows[IdRowsOrder].Cells[2].Value = textBox3.Text;
                OrderGridViewer.Rows[IdRowsOrder].Cells[3].Value = maskedTextBox1.Text;
                OrderGridViewer.Rows[IdRowsOrder].Cells[4].Value = Date;
                OrderGridViewer.Rows[IdRowsOrder].Cells[6].Value = comboBox1.Text;

                Close();
                OrderGridViewer.ClearSelection();
            }
            else
            {
                MessageBox.Show($"Заполните все поля");
            }
        }

        private void dateTimePicker1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
