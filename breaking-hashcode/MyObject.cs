using System;

namespace breaking_hashcode
{
    internal class MyObject : IEquatable<MyObject>
    {
        public int Id { get; }
        public int Val { get; }

        public MyObject(int id, int val)
        {
            Id = id;
            Val = val;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyObject);
        }

        public bool Equals(MyObject other)
        {
            if (other == null)
                return false;

            return Val == other.Val;
        }

        public override int GetHashCode()
        {
            return Val;
        }
    }
}
