using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCRM.Models
{
    public class Registration
    {
        private int registrationID;
        private int studentID;
        private int productID;
        private DateTime registrationDate;
        private double actualPaid;

        public int RegistrationID { get => registrationID; set => registrationID = value; }
        public int StudentID { get => studentID; set => studentID = value; }
        public int ProductID { get => productID; set => productID = value; }
        public DateTime RegistrationDate { get => registrationDate; set => registrationDate = value; }
        public double ActualPaid { get => actualPaid; set => actualPaid = value; }
    }
}
