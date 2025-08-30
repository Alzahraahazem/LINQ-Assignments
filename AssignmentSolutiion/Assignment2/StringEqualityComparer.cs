using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class StringEqualityComparer: IEqualityComparer<string>
    {
        public bool Equals(string x, string y)
        {
            return x == y;  
        }

        public int GetHashCode(string obj)
        {
            return obj.GetHashCode();
        }
    }
}
