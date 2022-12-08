using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssetTracker_Entity
{
    internal class Asset
    {
        public int Id { get; set; }
        public string? Type { get; set; }
        public string? Brand { get; set; }
        public string? Model { get; set; }
        public string? Office { get; set; }
        public double Price { get; set; }
        public DateTime PurchaseDate { get; set; }

        // Matches list items office to a currency
        public string getCurrency()
        {
            if (Office == "Germany")
            {
                return "EUR";
            }
            else if (Office == "Sweden")
            {
                return "SEK";
            }
            else
            {
                return "USD";
            }
        }

        // Converts USD to Local currency
        public double covertCurrency()
        {
            double localCurrency;
            if (Office == "Germany")
            {
                localCurrency = Price * 1.02;
                return localCurrency;
            }
            else if (Office == "Sweden")
            {
                localCurrency = Price * 10.81;
                return localCurrency;
            }
            else
            {
                localCurrency = Price;
                return localCurrency;
            }
        }

    }
}

