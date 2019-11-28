using Data;
using System;
using System.Collections.Generic;

namespace InefficientBucketDistribution
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: copy-paste debug output, then count zeros to get % buckets filled
            Example3Simple();
            Example4AtScale();
            Example5AtScale();
            Example6AtScale();
            Example7AtScale();
            Example8AtScale();
        }

        private static void Example3Simple()
        {
            var a = new MyObject3(1, 2);
            var b = new MyObject3(2, 1);
            var table = new HashSet<MyObject3> { a, b };
        }

        private static void Example4AtScale()
        {
            var set = new HashSet<MyObject4>();
            var limit = 5;
            for (var a = 0; a < limit; a++)
            {
                for (var b = 0; b < limit; b++)
                {
                    for (var c = 0; c < limit; c++)
                    {
                        for (var d = 0; d < limit; d++)
                        {
                            for (var e = 0; e < limit; e++)
                            {
                                set.Add(new MyObject4(a, b, c, d, e));
                            }
                        }
                    }
                }
            }
        }

        private static void Example5AtScale()
        {
            var set = new HashSet<MyObject5>();
            var limit = 5;
            for (var a = 0; a < limit; a++)
            {
                for (var b = 0; b < limit; b++)
                {
                    for (var c = 0; c < limit; c++)
                    {
                        for (var d = 0; d < limit; d++)
                        {
                            for (var e = 0; e < limit; e++)
                            {
                                set.Add(new MyObject5(a, b, c, d, e));
                            }
                        }
                    }
                }
            }
        }

        private static void Example6AtScale()
        {
            var set = new HashSet<MyObject6>();
            var limit = 5;
            for (var a = 0; a < limit; a++)
            {
                for (var b = 0; b < limit; b++)
                {
                    for (var c = 0; c < limit; c++)
                    {
                        for (var d = 0; d < limit; d++)
                        {
                            for (var e = 0; e < limit; e++)
                            {
                                set.Add(new MyObject6(a, b, c, d, e));
                            }
                        }
                    }
                }
            }
        }

        private static void Example7AtScale()
        {
            var set = new HashSet<MyObject7>();
            var limit = 5;
            for (var a = 0; a < limit; a++)
            {
                for (var b = 0; b < limit; b++)
                {
                    for (var c = 0; c < limit; c++)
                    {
                        for (var d = 0; d < limit; d++)
                        {
                            for (var e = 0; e < limit; e++)
                            {
                                set.Add(new MyObject7(a, b, c, d, e));
                            }
                        }
                    }
                }
            }
        }

        private static void Example8AtScale()
        {
            var set = new HashSet<MyObject8>();
            var limit = 5;
            for (var a = 0; a < limit; a++)
            {
                for (var b = 0; b < limit; b++)
                {
                    for (var c = 0; c < limit; c++)
                    {
                        for (var d = 0; d < limit; d++)
                        {
                            for (var e = 0; e < limit; e++)
                            {
                                set.Add(new MyObject8(a, b, c, d, e));
                            }
                        }
                    }
                }
            }
        }
    }
}
