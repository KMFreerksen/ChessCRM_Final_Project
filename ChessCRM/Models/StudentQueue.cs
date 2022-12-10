using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCRM.Models
{
    public class StudentQueue
    {
        private LinkedList<Student> sQueue;

        public LinkedList<Student> SQueue { get => sQueue; set => sQueue = value; }
        
        public StudentQueue() { SQueue = new LinkedList<Student>(); }

        public bool isEmpty() { if(SQueue.Count == 0) { return true; } else { return false; } }
    
        public int Size() { if (!isEmpty()){ return SQueue.Count; } else { throw new queueEmptyException(); }}

        public Student Peek()
        {
            if (!isEmpty())
            { return SQueue.First.Value; }
            else { throw new queueEmptyException(); }
        }
        public virtual Student Dequeue()
        {
            if (!isEmpty())
            { 
                Student next = SQueue.First.Value;
                SQueue.RemoveFirst();
                return next;
            }
            else { throw new queueEmptyException(); }
        }

        public void Enqueue(Student s)
        {
            SQueue.AddLast(s);
        }

        public string Print()
        {
            if (!isEmpty())
            {
                string QString = "";
                foreach (var s in SQueue)
                {
                    QString += s.Print();
                }
                return QString;
            }
            else { throw new queueEmptyException(); }
        }

    }
}
