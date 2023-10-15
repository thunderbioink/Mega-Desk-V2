using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MegaDesk_Tapia.Desk;

namespace MegaDesk_Tapia
{
    public partial class AddQuote : Form
    {
        string customer;
        int widthBox;
        int numDrawersBox;
        int depthBox;

        DeskQuote DeskQuote = new DeskQuote();

        string[] rushDaysData = new string[4] { "Free", "3 Days", "5 Days", "7 Days" }; 

        public AddQuote()
        {
            InitializeComponent();

            // cmbMaterial.DataSource = Enum.GetValues(typeof(DesktopMaterial));
            List<DesktopMaterial> materials = Enum.GetValues(typeof(DesktopMaterial)).Cast<DesktopMaterial>().ToList();
            cmbMaterial.DataSource = materials;
            cmbRushOrder.DataSource = rushDaysData;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                customer = customerName.Text;
                widthBox = int.Parse(txtWidth.Text);
                numDrawersBox = int.Parse(txtNumDrawers.Text);
                depthBox = int.Parse(txtDepth.Text);

                DesktopMaterial material = (DesktopMaterial)cmbMaterial.SelectedItem;
                // SelectedIndex is another option

                // ExpectedDelivery rushDays = (ExpectedDelivery)cmbRushOrder.SelectedIndex; // Assuming rush order values are stored as strings in the ComboBox
                string rushDays = cmbRushOrder.Text;



                // Validate user input (you can add more validation as needed)

                decimal totalQuote = 0;

                Desk Desk = new Desk(widthBox, depthBox, numDrawersBox, material);
                DeskQuote DeskQuote = new DeskQuote(Desk, rushDays, customer, totalQuote);

                int surfaceArea = DeskQuote.CalculateSurfaceArea(widthBox, depthBox);
                Console.WriteLine(surfaceArea);

                // Calculate the quote total

                totalQuote = DeskQuote.CalculateQuoteTotal(material, rushDays);

                // Create and show the DisplayQuote form
                DisplayQuote displayQuoteForm = new DisplayQuote(totalQuote, customer, widthBox, depthBox, numDrawersBox, material.ToString(), cmbRushOrder.Text, DateTime.Now); ;
                displayQuoteForm.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred", "Error" ,MessageBoxButtons.OK , MessageBoxIcon.Error); 
                throw;
            }
            

        }

        private void Width_Validating(object sender, CancelEventArgs e)
        {
            if (!int.TryParse(txtWidth.Text, out int width) || width < Desk.MIN_WIDTH || width > Desk.MAX_WIDTH)
            {
                errorProvider.SetError(txtWidth, "Enter an integer between " + Desk.MIN_WIDTH + " and " + Desk.MAX_WIDTH + ".");
                e.Cancel = true; // Cancel the focus change
            }
            else
            {
                errorProvider.SetError(txtWidth, "");
            }
        }

        private void Depth_Validating(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                errorProvider.SetError(txtDepth, "It should be an integer.");
            }
            else
            {
                errorProvider.SetError(txtDepth, "");
            }
        }

        private void addQuotesButton_Click(object sender, EventArgs e)
        {
            DeskQuote.deskQuotesList = DeskQuote.LoadDeskQuotes();

            customer = customerName.Text;
            widthBox = int.Parse(txtWidth.Text);
            numDrawersBox = int.Parse(txtNumDrawers.Text);
            depthBox = int.Parse(txtDepth.Text);

            DesktopMaterial material = (DesktopMaterial)cmbMaterial.SelectedItem;
            // SelectedIndex is another option

            // ExpectedDelivery rushDays = (ExpectedDelivery)cmbRushOrder.SelectedIndex; // Assuming rush order values are stored as strings in the ComboBox
            string rushDays = cmbRushOrder.Text;

            // Calculate the quote total
            Desk Desk = new Desk(widthBox, depthBox, numDrawersBox, material);

            decimal totalQuote = DeskQuote.CalculateQuoteTotal(material, rushDays);
            
            DeskQuote deskQuote = new DeskQuote(Desk, rushDays, customer, totalQuote);


            DeskQuote.AddQuoteList(deskQuote);
            DeskQuote.SaveDeskQuotes(DeskQuote.deskQuotesList);




        }
    }
}
