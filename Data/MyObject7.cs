using System;

namespace Data
{
    /// <summary>
    /// MyObject6, but with GetHashCode() multiplying by larger numbers.
    /// This is an improvement, but only because we "expanded" the range of possible hash codes we generate.
    /// This version is essentially equivalent to Jon Skeet's recommendation
    /// https://stackoverflow.com/questions/263400/what-is-the-best-algorithm-for-overriding-gethashcode
    /// </summary>
    public class MyObject7 : IEquatable<MyObject7>
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }
        public int D { get; }
        public int E { get; }

        public MyObject7(int a, int b, int c, int d, int e)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyObject7);
        }

        public bool Equals(MyObject7 other)
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
                const int prime = 10007;

                var hash = 17;
                hash = hash * prime + A;
                hash = hash * prime + B;
                hash = hash * prime + C;
                hash = hash * prime + D;
                hash = hash * prime + E;
                return hash;
            }
        }
    }
}
