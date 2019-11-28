using System;

namespace Data
{
    /// <summary>
    /// Order doesnt matter in XOR.
    /// Hashset<T>.Add puts 2 items in same bucket because they both have same HashCode, even though they have different data.
    /// This is inefficient because you can have small amount of buckets with long "lists".
    /// </summary>
    public class MyObject3 : IEquatable<MyObject3>
    {
        public int Id { get; }
        public int Val { get; }

        public MyObject3(int id, int val)
        {
            Id = id;
            Val = val;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyObject3);
        }

        public bool Equals(MyObject3 other)
        {
            if (other == null)
                return false;

            return Id == other.Id && Val == other.Val;
        }

        public override int GetHashCode()
        {
            return Id ^ Val;
        }
    }
}
