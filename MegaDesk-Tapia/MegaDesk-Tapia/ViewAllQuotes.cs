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
    public partial class ViewAllQuotes : Form
    {
        DeskQuote deskQuote = new DeskQuote();

        public ViewAllQuotes()
        {
            InitializeComponent();

            

            LoadDataToView();
        }

        private void LoadDataToView()
        {

            deskQuote.deskQuotesList = deskQuote.LoadDeskQuotes();

            List<DeskQuote> quotes = deskQuote.deskQuotesList;

            foreach (DeskQuote quote in quotes)
            {
                int rowsIndex = dataGridView1.Rows.Add();

                dataGridView1.Rows[rowsIndex].Cells[0].Value = quote.CustomerName.ToString();
                dataGridView1.Rows[rowsIndex].Cells[1].Value = quote.QuoteDate.ToString("dd mm yyyy");
                dataGridView1.Rows[rowsIndex].Cells[2].Value = quote.Desk.Width.ToString();
                dataGridView1.Rows[rowsIndex].Cells[3].Value = quote.Desk.Depth.ToString();
                dataGridView1.Rows[rowsIndex].Cells[4].Value = quote.Desk.NumDrawers.ToString();
                dataGridView1.Rows[rowsIndex].Cells[5].Value = quote.Desk.Material.ToString();
                dataGridView1.Rows[rowsIndex].Cells[6].Value = quote.RushDays.ToString();
                dataGridView1.Rows[rowsIndex].Cells[7].Value = quote.totalQuote.ToString();

            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
