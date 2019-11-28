using System;

namespace Data
{
    /// <summary>
    /// MyObject4, but with GetHashCode() multiplying with prime numbers with XOR.
    /// This is an improvement, but only because we "expanded" the range of possible hash codes we generate, because of the multiplication.
    /// I.E.: The improvement is NOT because of the prime number.
    /// </summary>
    public class MyObject5 : IEquatable<MyObject5>
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }
        public int D { get; }
        public int E { get; }

        public MyObject5(int a, int b, int c, int d, int e)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyObject5);
        }

        public bool Equals(MyObject5 other)
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
                    ^ (B * prime)
                    ^ (C * prime)
                    ^ (D * prime)
                    ^ (E * prime);
                return 17 + hash;
            }
        }
    }
}
