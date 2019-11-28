using System;

namespace Data
{
    /// <summary>
    /// Equals implemented incorrectly.
    /// Hashset<T>.Contains returns true because theyre "ïdentified" by Val instead of Id.
    /// This is incorrect because the ID's differ
    /// </summary>
    public class MyObject1 : IEquatable<MyObject1>
    {
        public int Id { get; }
        public int Val { get; }

        public MyObject1(int id, int val)
        {
            Id = id;
            Val = val;
        }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyObject1);
        }

        public bool Equals(MyObject1 other)
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
