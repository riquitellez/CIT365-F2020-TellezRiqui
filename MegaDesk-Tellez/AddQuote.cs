using MegaDesk_Tellez.Classes;
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
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            Home viewHome = (Home)Tag;
            viewHome.Show();
            Close();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            customerNameBox.Text = "";
            numericWidth.Value = 0;
            numericDepth.Value = 0;
            numericDrawers.Value = 0;
            materialCombo.SelectedItem = null;
            rushDaysCombo.SelectedItem = null;
        }

        private void addQuoteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Desk desk = new Desk((int)numericWidth.Value, (int)numericDepth.Value, (int)numericDrawers.Value, materialCombo.Text);
                DeskQuote quote = new DeskQuote(desk, customerNameBox.Text, (int)rushDaysCombo.SelectedItem);
                quote.TotalPrice = quote.DeskTotalPrice();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
