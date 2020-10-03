using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_Tellez.Classes
{
    public class DeskQuote
    {
        public int Id { get; set; }
        [Required]
        public Desk Desk { get; set; }
        [Required]
        public int RushDays { get; set; }
        [Required]
        public string ClientFullName { get; set; }
        public DateTime Date { get; set; }
        public int TotalPrice { get; set; }

        public DeskQuote(Desk desk, string clientName, int rushDays)
        {
            Date = DateTime.Today;
            RushDays = rushDays;
            ClientFullName = clientName;
            Desk = desk;
        }

        public void SetTotalPrice(int totalPrice)
        {
            TotalPrice = totalPrice;
        }

        public int DeskTotalPrice() 
        {
            int size;
            int total = 0;
            int basePrice = 200;
            int materialPrice = 0;
            int drawersPrice = 0;
            int areaPrice = 0;
            int rushPrice = 0;

            size = Desk.Width * Desk.Depth;

            switch (Desk.Material) 
            {
                case "Oak":
                    materialPrice = 200;
                    break;
                case "Laminate":
                    materialPrice = 100;
                    break;
                case "Pine":
                    materialPrice = 50;
                    break;
                case "Rosewood":
                    materialPrice = 300;
                    break;
                case "Veneer":
                    materialPrice = 125;
                    break;
            }

            drawersPrice = Desk.DrawersNumber * 50;
            areaPrice = size * 1;

            if (RushDays == 3)
            {
                if (size < 1000)
                {
                    rushPrice = 60;
                }

                else if (size <= 2000)
                {
                    rushPrice = 70;
                }

                else if (size > 2000)
                {
                    rushPrice = 80;
                }
            }

            else if (RushDays == 5)
            {
                if (size < 1000)
                {
                    rushPrice = 40;
                }

                else if (size <= 2000)
                {
                    rushPrice = 50;
                }

                else if (size > 2000)
                {
                    rushPrice = 60;
                }
            }

            else if (RushDays == 7)
            {
                if (size < 1000)
                {
                    rushPrice = 30;
                }

                else if (size <= 2000)
                {
                    rushPrice = 35;
                }

                else if (size > 2000)
                {
                    rushPrice = 40;
                }
            }

            total = basePrice + materialPrice + drawersPrice + areaPrice + rushPrice;

            return total;
        }
    }
}
