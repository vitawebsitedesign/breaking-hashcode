using Data;
using System;
using System.Collections.Generic;

namespace EqualsImplementedIncorrectly
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var a = new MyObject1(1, 2);
            var table = new HashSet<MyObject1>();
            table.Add(a);

            var b = new MyObject1(2, 2);
            var contains = table.Contains(b);
        }
    }
}
