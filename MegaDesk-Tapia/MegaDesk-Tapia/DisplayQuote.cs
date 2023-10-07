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

namespace MegaDesk_Tapia
{
    public partial class DisplayQuote : Form
    {
        public DisplayQuote(decimal totalQuote, string customerName, int width, int depth,
                            int numDrawers, string deskMaterial, string rushOrder, DateTime quoteDate)
        {
            InitializeComponent();

            // Display quote information
            lblCustomerName.Text = customerName;
            lblDeskWidth.Text = width.ToString();
            lblDeskDepth.Text = depth.ToString();
            lblDeskDrawers.Text = numDrawers.ToString();
            lblDeskMaterial.Text = deskMaterial;
            lblRushOrder.Text = rushOrder;
            lblQuoteDate.Text = quoteDate.ToShortDateString();
            lblQuotePrice.Text = totalQuote.ToString("C");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            // Close the DisplayQuote form
            this.Close();
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
