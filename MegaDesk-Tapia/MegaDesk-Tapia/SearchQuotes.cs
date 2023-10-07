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

            // Create a list to store the search results
            List<DeskQuote> searchResults = new List<DeskQuote>();

            // Iterate through the deskQuotes and filter quotes that match the selected material
            // foreach (List<DeskQuote> quote in deskQuotes)
            {
                // if (quote.Desk.Material == selectedMaterial)
                {
                   //  searchResults.Add(quote);
                }
            }

            // Set the DataGridView's DataSource to display the search results
            dataGridView.DataSource = searchResults;
        }
    }
}
