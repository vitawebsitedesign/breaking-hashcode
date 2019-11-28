using System;

namespace Data
{
    /// <summary>
    /// A more realistic demo of MyObject3
    /// </summary>
    public class MyObject4 : IEquatable<MyObject4>
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }
        public int D { get; }
        public int E { get; }

        public MyObject4(int a, int b, int c, int d, int e)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyObject4);
        }

        public bool Equals(MyObject4 other)
        {
            if (other == null)
                return false;

            return A == other.A
                && B == other.B
                && C == other.C
                && D == other.D
                && E == other.E;
        }

        public override int GetHashCode()
        {
            return A ^ B ^ C ^ D ^ E;
        }
    }
}
