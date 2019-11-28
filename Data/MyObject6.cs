using System;

namespace Data
{
    /// <summary>
    /// MyObject5, but with GetHashCode() no longer doing an XOR
    /// This is an improvement again, but only because XOR in out GetHashCode implementation cancels out
    /// </summary>
    public class MyObject6 : IEquatable<MyObject6>
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }
        public int D { get; }
        public int E { get; }

        public MyObject6(int a, int b, int c, int d, int e)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyObject6);
        }

        public bool Equals(MyObject6 other)
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
            unchecked
            {
                const int prime = 23;
                var hash = (A * prime)
                    + (B * prime)
                    + (C * prime)
                    + (D * prime)
                    + (E * prime);
                return 17 + hash;
            }
        }
    }
}
