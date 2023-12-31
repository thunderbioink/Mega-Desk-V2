﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MegaDesk_Tapia
{
    internal class DeskQuote
    {
        public Desk Desk = new Desk();
        public string RushDays;
        public string CustomerName;
        public DateTime QuoteDate;
        public decimal totalQuote;

        public List<DeskQuote> deskQuotesList;

        // Constructor to initialize the DeskQuote
        public DeskQuote() 
        {
            deskQuotesList = new List<DeskQuote>();
        }
        public DeskQuote(Desk desk, string rushDays, string customerName, decimal quote)
        {
            Desk = desk;
            RushDays = rushDays;
            CustomerName = customerName;
            QuoteDate = DateTime.Now;
            totalQuote = quote; 
        }

        public void AddQuoteList(DeskQuote addElement)
        {
            deskQuotesList.Add(addElement);
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
            int surfaceArea = CalculateSurfaceArea(Desk.Width, Desk.Depth);
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

        public int CalculateSurfaceArea(int width, int depth)
        {
            return width * depth;
        }

        private decimal CalculateRushOrderPrice(string typeRush)
        {
            decimal[,] rushOrderPrices = GetRushOrder();// Load the rush order prices
            decimal rushOrderPrice = 0;
            switch (typeRush)
            {
                case "3 Days":
                    rushOrderPrice = CalculateRushOrderPriceByArea(rushOrderPrices[0,0], rushOrderPrices[0, 1], rushOrderPrices[0, 2]);
                    break;
                case "5 Days":
                    rushOrderPrice = CalculateRushOrderPriceByArea(rushOrderPrices[1, 0], rushOrderPrices[1, 1], rushOrderPrices[1, 2]);
                    break;
                case "7 Days":
                    rushOrderPrice = CalculateRushOrderPriceByArea(rushOrderPrices[2, 0], rushOrderPrices[2, 1], rushOrderPrices[2, 2]);
                    break;
                case "Free":
                    break;
            }
            return rushOrderPrice;
        }

        private decimal CalculateRushOrderPriceByArea(decimal smallPrice, decimal mediumPrice, decimal largePrice)
        {
            int surfaceArea = CalculateSurfaceArea(Desk.Width, Desk.Depth);
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
            switch (material)
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


        // Create a method to load the rush order prices from the file.
        private decimal[,] GetRushOrder()
        {
            // Define an array to store the rush order prices.
            decimal[,] rushOrderPrices = new decimal[3,3];

            // Specify the path to the rush order prices file.
            string filePath = "rushOrderPrices.txt";
            // string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "rushOrderPrices.txt");

            try
            {
                string[] lines = File.ReadAllLines(filePath);
                int counter = 0;
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        rushOrderPrices[i,j] = decimal.Parse(lines[counter]);
                        counter++;
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed.
                Console.WriteLine("Error: " + ex.Message);
            }

            return rushOrderPrices;
        }

        private void PrintRushOrderPrices(decimal[] rushOrderPrices)
        {
            for (int i = 0; i < rushOrderPrices.Length; i++)
            {
                Console.WriteLine($"Rush Order Price {i + 1}: ${rushOrderPrices[i]}");
            }
        }


        // Method to save DeskQuote objects to a JSON file
        public void SaveDeskQuotes(List<DeskQuote> deskQuotes)
        {
            string jsonData = JsonConvert.SerializeObject(deskQuotes, Formatting.Indented);

            // Specify the path to the JSON file where you want to save the data.
            string filePath = "quotes.json";

            try
            {
                File.WriteAllText(filePath, jsonData);
                Console.WriteLine("Desk quotes saved to quotes.json.");
            }
            catch (Exception ex)
            {
                // Handle exceptions as needed.
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // Method to load DeskQuote objects from a JSON file
        public List<DeskQuote> LoadDeskQuotes()
        {
            if (File.Exists("quotes.json"))
            {
                string jsonData = File.ReadAllText("quotes.json");
                return JsonConvert.DeserializeObject<List<DeskQuote>>(jsonData);
            }
            return new List<DeskQuote>();
        }

    }
}