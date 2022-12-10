using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCRM.Models
{
    public class EnrollmentViewModel
    {
        public Product Product { get; set; }
        public List<Registration> Registrations { get; set; }

        public List<Student> Students { get; set; }

        public EnrollmentViewModel()
        {
            Registrations = new List<Registration>();
            Students = new List<Student>();
        }
    }
}
