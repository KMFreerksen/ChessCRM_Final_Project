using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCRM.Models
{
    public class School
    {
        private int schoolID;
        private string schoolName;
        private string district;
        private string type;
        private string streetAddress;
        private string city;
        private string state;
        private int zip;
        private string phone;

        public int SchoolID { get => schoolID; set => schoolID = value; }
        public string SchoolName { get => schoolName; set => schoolName = value; }
        public string District { get => district; set => district = value; }
        public string Type { get => type; set => type = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public int Zip { get => zip; set => zip = value; }
        public string Phone { get => phone; set => phone = value; }
    }
}
