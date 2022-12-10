using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCRM.Models
{
    public class StudentContact
    {
        public int FamilyID { get; set; }

        public int StudentID { get; set; }
        public virtual Student Student { get; set; }

        public int ContactID { get; set; }
      
        public virtual Contact Contact { get; set; }
    }
}
