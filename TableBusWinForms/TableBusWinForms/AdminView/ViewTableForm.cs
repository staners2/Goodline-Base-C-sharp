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
    }
}
