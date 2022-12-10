using System.Collections.Generic;

namespace ChessCRM.Models
{
    public class StudentListViewModel
    {
        // Properties
        // public List<Student> Students { get; set; }
        public StudentLinkedList SortedAll { get; set; }
        public StudentLinkedList SortedActive { get; set; }

        // Constructors
        public StudentListViewModel()
        {
            // Students = new List<Student>();
            SortedAll = new StudentLinkedList();
            SortedActive = new StudentLinkedList();
        }

        // Methods
    }
}
