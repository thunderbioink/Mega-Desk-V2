using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Tapia
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void BtnAddQuote(object sender, EventArgs e)
        {
           
            AddQuote addQuoteForm = new AddQuote();
            addQuoteForm.Show();
        }

        private void BtnViewQuotes(object sender, EventArgs e)
        {
          
            ViewAllQuotes viewAllQuotesForm = new ViewAllQuotes();
            viewAllQuotesForm.Show();
        }

        private void BtnSearchQuotes(object sender, EventArgs e)
        {

            SearchQuotes searchQuotesForm = new SearchQuotes();
            searchQuotesForm.Show();
        }

        private void BtnExit(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
