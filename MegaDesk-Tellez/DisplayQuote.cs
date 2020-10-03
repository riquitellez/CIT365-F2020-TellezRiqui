using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Tellez
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void DisplayQuote_Load(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home viewHome = (Home)Tag;
            viewHome.Show();
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Home viewHome = (Home)Tag;
            viewHome.Show();
            Close();
        }
    }
}
