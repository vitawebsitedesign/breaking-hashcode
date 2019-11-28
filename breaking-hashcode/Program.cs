using System;
using System.Collections;
using System.Collections.Generic;

namespace breaking_hashcode
{
    internal class Program
    {
        public static void Main(string[] args)
        {

        }

        private static void EqualsImplIncorrectly()
        {
            var a = new MyObject(1, 2);
            var table = new HashSet<MyObject>();
            table.Add(a);

            var b = new MyObject(2, 2);
            table.Add(b);

            var contains = table.Contains(b);
        }
    }
}
