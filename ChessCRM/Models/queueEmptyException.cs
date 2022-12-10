using System;
using System.Collections.Generic;
using System.Text;

namespace ChessCRM
{
    public class queueEmptyException : Exception
    { public override string Message { get { return "Queue is Empty"; } } }
}
