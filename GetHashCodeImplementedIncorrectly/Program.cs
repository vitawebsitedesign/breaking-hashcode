using Data;
using System;
using System.Collections.Generic;

namespace GetHashCodeImplementedIncorrectly
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new MyObject2(1, 2);
            var table = new HashSet<MyObject2>();
            table.Add(a);

            var b = new MyObject2(3, 2);
            var contains = table.Contains(b);
        }
    }
}
