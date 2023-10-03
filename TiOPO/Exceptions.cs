using System;
namespace TiOPO
{
    public class ArrayLength : Exception
    {
        public ArrayLength() { }
        public ArrayLength(string msg): base(msg) { }
        public ArrayLength(string msg, Exception inner) : base(msg, inner) { }
    }
    public class OutOfRange : Exception
    {
        public OutOfRange() { }
        public OutOfRange(string msg) : base(msg) { }
        public OutOfRange(string msg, Exception inner) : base(msg, inner) { }
    }
}

