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
    public partial class OpenLogsForms : Form
    {
        public OpenLogsForms()
        {
            InitializeComponent();
        }

        public SqlConnection connect;
        private void OpenLogsForms_Load(object sender, EventArgs e)
        {
            string query = "SELECT description, date FROM [dbo].[HistroryActions]";

            SqlCommand command = new SqlCommand(query, connect);
            SqlDataReader reader = command.ExecuteReader();
            int i = 1;

            while (reader.Read())
            {
                LogsBox.Rows.Add(i, reader[0], Convert.ToDateTime(reader[1]).ToString("yyyy-MM-dd"));
                i++;
            }

            reader.Close();
        }
    }
}
