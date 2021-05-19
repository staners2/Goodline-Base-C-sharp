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
using LibraryController.Models;
using TableBusWinForms.Presenter;

namespace TableBusWinForms.GeneralForm
{
    public partial class PurchasedTicket : Form
    {
        public PurchasedTicket(int IdTable, int IdRecordFlight)
        {
            InitializeComponent();
            this.IdTable = IdTable;
            this.IdRecordFlight = IdRecordFlight;
            PurchasedTicketPresenter = new PurchasedTicketPresenter(this);
        }

        public PurchasedTicketPresenter PurchasedTicketPresenter;

        public int IdTable { get; set; }
        public int IdRecordFlight { get; set; }

        private void PurchasedTicket_Load(object sender, EventArgs e)
        {
            PurchasedTicketPresenter.LoadForm();
        }

        private void CancelButtonClick(object sender, EventArgs e)
        {
            PurchasedTicketPresenter.CancelButtonClick();
        }
    }
}
