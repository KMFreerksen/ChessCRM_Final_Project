using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCRM.Models
{
    public class Product
    {
        private int productID;
        private string productName;
        private string type;
        private DateTime startDateTime;
        private DateTime endDateTime;
        private string location;
        private string streetAddress;
        private string city;
        private string state;
        private int zip;
        private int maxCapacity;
        private double basePrice;

        public int ProductID { get => productID; set => productID = value; }
        public string ProductName { get => productName; set => productName = value; }
        public string Type { get => type; set => type = value; }
        public DateTime StartDateTime { get => startDateTime; set => startDateTime = value; }
        public DateTime EndDateTime { get => endDateTime; set => endDateTime = value; }
        public string Location { get => location; set => location = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public int Zip { get => zip; set => zip = value; }
        public int MaxCapacity { get => maxCapacity; set => maxCapacity = value; }
        public double BasePrice { get => basePrice; set => basePrice = value; }

        // Constructor

        // Get enrollment

        // Get revenue
    }
}
