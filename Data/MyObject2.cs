using System;

namespace Data
{
    /// <summary>
    /// GetHashCode implemented incorrectly.
    /// Hashset<T>.Contains returns false because theyre in different buckets.
    /// This is incorrect because an object of same value is in the HashSet.
    /// </summary>
    public class MyObject2 : IEquatable<MyObject2>
    {
        public int Id { get; }
        public int Val { get; }

        public MyObject2(int id, int val)
        {
            Id = id;
            Val = val;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyObject2);
        }

        public bool Equals(MyObject2 other)
        {
            if (other == null)
                return false;

            return Id == other.Id && Val == other.Val;
        }

        public override int GetHashCode()
        {
            return Id;
        }
    }
}
