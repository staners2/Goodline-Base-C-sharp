using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TableBusWinForms.AdminView.Moderation.City;
using TableBusWinForms.AdminView.Moderation.Route;
using TableBusWinForms.AdminView.Moderation.TableRecords;

namespace TableBusWinForms.AdminView
{
    public partial class ViewTableForm : Form
    {
        public ViewTableForm(int IdAccount)
        {
            InitializeComponent();
            this.IdAccount = IdAccount;
        }

        private int IdAccount { get; set; }

        private void ViewTableForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form AuthorizeForm = Application.OpenForms[0];
            AuthorizeForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ViewModerationCityForm Form = new ViewModerationCityForm();
            Form.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ViewModerationRouteForm Form = new ViewModerationRouteForm();
            Form.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ViewModerationTableRecordsForm Form = new ViewModerationTableRecordsForm();
            Form.ShowDialog();
        }
    }
}
