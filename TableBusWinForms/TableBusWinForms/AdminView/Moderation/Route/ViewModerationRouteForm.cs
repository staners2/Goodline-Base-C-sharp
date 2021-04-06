using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TableBusWinForms.AdminView.Moderation.Route
{
    public partial class ViewModerationRouteForm : Form
    {
        public ViewModerationRouteForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddRouteForm Form = new AddRouteForm();
            Form.Closed += (s, ev) =>
            {
                Update();
            };
            Form.ShowDialog();

        }

        private void Update()
        {

        }
    }
}
