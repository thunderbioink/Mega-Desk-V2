using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tapia
{
    internal class DeskQuote
    {
        public Desk Desk;
        public string RushDays;
        public string CustomerName;
        public DateTime QuoteDate;

        // Constructor to initialize the DeskQuote
        public DeskQuote() { }
        public DeskQuote(Desk desk, string rushDays, string customerName)
        {
            Desk = desk;
            RushDays = rushDays;
            CustomerName = customerName;
            QuoteDate = DateTime.Now;
        }

        // Method to calculate the desk quote total
        public decimal CalculateQuoteTotal(DesktopMaterial material, string rushDays)
        {
            decimal basePrice = 200; // Base desk price
            decimal surfaceAreaPrice = CalculateSurfaceAreaPrice();
            decimal drawersPrice = CalculateDrawersPrice();
            decimal rushOrderPrice = CalculateRushOrderPrice(rushDays);
            

            return basePrice + surfaceAreaPrice + drawersPrice + rushOrderPrice + CalculateMaterialPrice(material);
        }

        // Helper methods for calculating price components
        private decimal CalculateSurfaceAreaPrice()
        {
            int surfaceArea = Desk.Width * Desk.Depth;
            decimal pricePerSquareInch = 1; // Price per square inch
            if (surfaceArea > 1000)
            {
                return (surfaceArea - 1000) * pricePerSquareInch;
            }

            return 0;
        }

        private decimal CalculateDrawersPrice()
        {
            int drawersPrice = Desk.NumDrawers * 50; // $50 per drawer
            return drawersPrice;
        }

        private decimal CalculateRushOrderPrice(string typeRush)
        {
            decimal rushOrderPrice = 0;
            switch (typeRush)
            {
                case "3 Days":
                    rushOrderPrice = CalculateRushOrderPriceByArea(60, 70, 80);
                    break;
                case "5 Days":
                    rushOrderPrice = CalculateRushOrderPriceByArea(40, 50, 60);
                    break;
                case "7 Days":
                    rushOrderPrice = CalculateRushOrderPriceByArea(30, 35, 40);
                    break;
                case "Free":
                    break;
            }
            return rushOrderPrice;
        }

        private decimal CalculateRushOrderPriceByArea(decimal smallPrice, decimal mediumPrice, decimal largePrice)
        {
            int surfaceArea = Desk.Width * Desk.Depth;
            if (surfaceArea < 1000)
            {
                return smallPrice;
            }
            else if (surfaceArea >= 1000 && surfaceArea <= 2000)
            {
                return mediumPrice;
            }
            else
            {
                return largePrice;
            }
        }

        private decimal CalculateMaterialPrice(DesktopMaterial material)
        { 
            switch(material)
            {
                case DesktopMaterial.Oak: 
                    return 200;
                case DesktopMaterial.Laminate:
                    return 100;
                case DesktopMaterial.Pine:
                    return 50;
                case DesktopMaterial.Rosewood:
                    return 300;
                case DesktopMaterial.Veneer:
                    return 125;
                default: 
                    return 0;
            }
        }
    }
}
