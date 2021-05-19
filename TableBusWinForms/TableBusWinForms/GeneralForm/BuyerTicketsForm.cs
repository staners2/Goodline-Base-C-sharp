using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryController;
using TableBusWinForms.Presenter;

namespace TableBusWinForms.GeneralForm
{
    public partial class BuyerTicketsForm : Form
    {
        public BuyerTicketsForm(int IdTable, int IdAccount)
        {
            InitializeComponent();
            this.IdTable = IdTable;
            this.IdAccount = IdAccount;
            BuyerTicketsPresenter = new BuyerTicketsPresenter(this);
        }

        public BuyerTicketsPresenter BuyerTicketsPresenter { get; set; }
        public int IdTable { get; set; }
        public int IdAccount { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            BuyerTicketsPresenter.FormLoad();
        }
        
        private void BuyButtonClick(object sender, EventArgs e)
        {
            BuyerTicketsPresenter.BuyButtonClick();
        }
    }
}
