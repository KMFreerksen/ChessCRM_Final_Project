using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCRM.Models
{
    public class Contact
    {
        private int contactID;
        private string fname;
        private string lname;
        private string type;
        private string phone;
        private string email;
        private string streetAddress;
        private string city;
        private string state;
        private int zip;
        private int familyID;
        private int schoolID;

        public int ContactID { get => contactID; set => contactID = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Type { get => type; set => type = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Email { get => email; set => email = value; }
        public string StreetAddress { get => streetAddress; set => streetAddress = value; }
        public string City { get => city; set => city = value; }
        public string State { get => state; set => state = value; }
        public int Zip { get => zip; set => zip = value; }
        public int FamilyID { get => familyID; set => familyID = value; }
        public int SchoolID { get => schoolID; set => schoolID = value; }
        public virtual ICollection<StudentContact> StudentContacts { get; set; }
    }
}
