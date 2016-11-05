using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dojo2
{
    class TestObject
    {
        public string Track { get; set; }
        public int Length { get; set; }


        public TestObject(string track, int length)
        {
            this.Track = track;
            this.Length = length;
        }

        public override string ToString()
        {
            return String.Format("{0} : {1}", Track, Length);
        }
    }
}
