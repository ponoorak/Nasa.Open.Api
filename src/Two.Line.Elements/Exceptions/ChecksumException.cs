using System;
using System.Collections.Generic;
using System.Text;

namespace Two.Line.Elements.Exceptions
{

    public class ChecksumException : Exception
    {
        public int Expected { get; }
        public int Actual { get; }

        public ChecksumException(int expected, int actual)
        {
            Expected = expected;
            Actual = actual;
        }
    }
}
