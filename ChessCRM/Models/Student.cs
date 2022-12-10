using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ChessCRM.Models
{
    public class Student
    {
        private int studentID;
        [Required(ErrorMessage = "A First Name is Required")]
        [StringLength(15)]
        private string fname;
        [Required(ErrorMessage ="A Last Name is Required")]
        [StringLength(25)]
        private string lname;
        [StringLength(2)]
        private string gender;
        [StringLength(50)]
        private string email;
        private DateTime dob;
        [StringLength(12)]
        private string phone;
        private string skill;
        private int uschessID;
        private int familyID;
        private int schoolID;
        private bool active = true;
        //private DateTime lastAct; 

        public int StudentID { get => studentID; set => studentID = value; }
        public string Fname { get => fname; set => fname = value; }
        public string Lname { get => lname; set => lname = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Dob { get => dob; set => dob = value; }
        public string Phone { get => phone; set => phone = value; }
        public string Skill { get => skill; set => skill = value; }
        public int UschessID { get => uschessID; set => uschessID = value; }
        public int FamilyID { get => familyID; set => familyID = value; }
        public int SchoolID { get => schoolID; set => schoolID = value; }
        public virtual ICollection<StudentContact> StudentContacts { get; set; }
        public bool Active { get => active; set => active = value; }
        //public DateTime LastAct { get => lastAct; set => lastAct = value; }

        //Constructor
        //Methods
            //Get Age
            //To String
            public string Print()
        {
            string s = "";
            s = Lname + ", " + Fname + " | US Chess ID: " + UschessID + " | Date of Birth: " + Dob + "\n";
            return s;       
        }
        
    }
}
