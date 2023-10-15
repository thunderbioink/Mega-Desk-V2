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
    public partial class SearchQuotes : Form
    {

        DeskQuote deskQuote = new DeskQuote();

        private List<DeskQuote> deskQuotes; // This should be set with your list of quotes.

        public SearchQuotes()
        {
            InitializeComponent();

            List<DesktopMaterial> material = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            cmbMaterial.DataSource = material;
        }

        private void cmbMaterial_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Get the selected material from the ComboBox
            DesktopMaterial selectedMaterial = (DesktopMaterial)cmbMaterial.SelectedItem;

            deskQuote.deskQuotesList = deskQuote.LoadDeskQuotes();

            List<DeskQuote> quotes = deskQuote.deskQuotesList;

            var elementsFound = quotes.Where(quote => quote.Desk.Material == selectedMaterial).ToList();

            dataGridView.Rows.Clear();

            foreach ( DeskQuote element in elementsFound ) 
            {
                int rowsIndex = dataGridView.Rows.Add();

                dataGridView.Rows[rowsIndex].Cells[0].Value = element.CustomerName.ToString();
                dataGridView.Rows[rowsIndex].Cells[1].Value = element.QuoteDate.ToString("dd mm yyyy");
                dataGridView.Rows[rowsIndex].Cells[2].Value = element.Desk.Width.ToString();
                dataGridView.Rows[rowsIndex].Cells[3].Value = element.Desk.Depth.ToString();
                dataGridView.Rows[rowsIndex].Cells[4].Value = element.Desk.NumDrawers.ToString();
                dataGridView.Rows[rowsIndex].Cells[5].Value = element.Desk.Material.ToString();
                dataGridView.Rows[rowsIndex].Cells[6].Value = element.RushDays.ToString();
                dataGridView.Rows[rowsIndex].Cells[7].Value = element.totalQuote.ToString();

            }

        }
    }
}
