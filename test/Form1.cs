using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> List = new List<string>(){"", "", "", "", "", ""};
            var List2 = List.Select(x => x = new Random().Next(20).ToString());
            var List1 = from t in List
                select t;

            label1.Text = string.Join(Environment.NewLine, List1);
            label2.Text = string.Join(Environment.NewLine,List2);


        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}
