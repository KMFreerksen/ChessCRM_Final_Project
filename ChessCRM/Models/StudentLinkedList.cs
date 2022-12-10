namespace ChessCRM.Models
{
    public class StudentLinkedList
    {
        private int _size;
        private const int max_size = 500;
        private Student[] students;

        public int Size { get => _size; set => _size = value; }
        public static int Max_size => max_size;
        public Student[] Students { get => students; set => students = value; }

        // Constructors
        public StudentLinkedList() { Students = new Student[Max_size]; Size = 0; }

        public StudentLinkedList(Student[] arr)
        {
            Students = new Student[Max_size]; 
            Size = 0;
            foreach (var s in arr)
            {
                if (s != null)
                {
                    Students[Size] = s;
                    Size++;
                }
            }
        }

        // Methods
        public bool isEmpty() { if (Size == 0) { return true; } else { return false; } }

        public bool isFull() { if (Size == max_size) { return true; } else { return false; } }

        public int size() { if (!isEmpty()) { return Size; } else { throw new StudentListEmpty(); } }

        public void AddLast(Student s) { if (!isFull()) { Students[Size] = s; Size++; } else { throw new StudentListFull(); } }

        public void AddAt(Student s, int index)
        {
            if (!isFull())
            {
                if (index == Size) { AddLast(s); }
                else if (index < Size && index >= 0)
                {
                    for (int i = Size; i >= index; i--)
                    {
                        Students[i + 1] = Students[i];
                    }
                    Students[index] = s;
                    Size++;
                }
                else { throw new InvalidIndexEception(); }
            }
            else
            {
                throw new StudentListFull();
            }
        }

        public void AddFirst (Student s)
        {
            if (!isFull())
            {
                for (int i = Size; i > 0; i--)
                {
                    Students[i] = Students[i-1];
                }
                Students[0] = s;
                Size++;
            }
            else { throw new StudentListFull(); }
        }

        public Student RemoveLast()
        {
            if (!isEmpty())
            {
                Student s = new Student();
                s = Students[Size-1];
                Students[Size-1] = new Student();
                Size--;
                return s;
            }
            else { throw new StudentListEmpty(); }
        }

        public Student RemoveAt(int index)
        {
            if (!isEmpty())
            {
                if(index == Size) { return RemoveLast(); }
                else if (index < Size && index >= 0)
                {
                    Student s = new Student();
                    s = Students[index];
                    for (int i = index; i < Size; i++)
                    {
                        Students[i] = Students[i+1];
                    }
                    Size--;
                    return s;
                }
                else { throw new InvalidIndexEception(); }
            }
            else { throw new StudentListEmpty(); }
        }

        public bool Contains(Student s)
        {
            if (!isEmpty())
            {
                foreach (var student in Students)
                {
                    if (student == s)
                    {
                        return true;
                    }
                }
                return false;
            }
            else { throw new StudentListEmpty(); }
        }

        public int Find(Student s)
        {
            if (!isEmpty())
            {
                int index = 0;
                foreach (var student in Students)
                {
                    if (student == s)
                    {
                        return index;
                    }
                    else { index++; }
                }
                return -1;
            }
            else { throw new StudentListEmpty(); }
        }

        public void Remove(Student s)
        {
            if (!isEmpty())
            {
                int index;
                index = this.Find(s);
                if (index >= 0) { this.RemoveAt(index); }
                else
                {
                    throw new StudentNotFoundException();
                }
            }
            else { throw new StudentListEmpty(); }
        }

        public void AlphabetizeByLname()
        {
            if (!isEmpty())
            {
                for (int i = 1; i < Size; i++)
                {
                    var key = Students[i];
                    var flag = 0;
                    for (int j = i - 1; j >= 0 && flag != 1;)
                    {
                        
                        if (key.Lname.CompareTo(Students[j].Lname) < 0)
                        {
                            Students[j + 1] = Students[j];
                            j--;
                            Students[j + 1] = key;
                        }
                        else flag = 1;
                    }
                }
            }
            else { throw new StudentListEmpty(); }
        }

        public StudentLinkedList GetCurrent()
        {
            if (!isEmpty())
            {
                Student[] current = new Student[max_size];
                int index = 0;
                for(int i = 0; i < Size; i++)
                {
                    if (Students[i].Active) { 
                        current[index] = Students[i]; 
                        index++; 
                    }
                }
                StudentLinkedList active = new StudentLinkedList(current);
                return active;
            }
            else { throw new StudentListEmpty(); }
        }

        public string Print()
        {
            if (!isEmpty())
            {
                string List = "";
                for (int i = 0; i < Size; i++)
                {
                    List += this.Students[i].Lname + ", " + this.Students[i].Fname + "\n"; //+ " | US Chess ID: " + s.UschessID + " | Date of Birth: " + s.Dob + "\n";
                }
                return List;
            }
            else { throw new StudentListEmpty(); }
        }
    }
}
