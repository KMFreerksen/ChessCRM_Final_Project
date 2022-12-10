using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCRM.Models
{
    public class StudentListFull : Exception
    {
        public override string Message { get { return "List is Full"; } }
    }
}
