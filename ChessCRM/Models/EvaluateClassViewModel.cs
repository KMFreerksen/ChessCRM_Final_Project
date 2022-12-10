using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCRM.Models
{
    public class EvaluateClassViewModel : StudentQueue
    {
        public Student Previous { get; set; }
        public Product Product { get; set; }

        public EvaluateClassViewModel() : base() { Previous = new Student(); Product = new Product();  }
        
        public override Student Dequeue()
        {
            if (!isEmpty())
            {
                Previous = Dequeue();
                return Previous;
            }
            else { throw new queueEmptyException(); }
        }

        public Student GetPrevious()
        {
            if (Previous != null)
            {
                return Previous;
            }
            else throw new queueEmptyException();
        }
    }
}
