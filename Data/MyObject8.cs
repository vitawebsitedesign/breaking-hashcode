using System;

namespace Data
{
    /// <summary>
    /// MyObject7, but with a hand-crafted GetHashCode() for optimum bucket distribution
    /// </summary>
    public class MyObject8 : IEquatable<MyObject8>
    {
        public int A { get; }
        public int B { get; }
        public int C { get; }
        public int D { get; }
        public int E { get; }

        public MyObject8(int a, int b, int c, int d, int e)
        {
            A = a;
            B = b;
            C = c;
            D = d;
            E = e;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyObject8);
        }

        public bool Equals(MyObject8 other)
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
                var str = $"{A}{B}{C}{D}{E}";
                return int.Parse(str);
            }
        }
    }
}
